Imports System.Data.SqlClient
Public Class searchSubjects

    Dim cmd As SqlCommand
    Dim myDA As SqlDataAdapter
    Dim myDataSet As DataSet
    Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Source\Repos\oneYOGA\oneYoga\bin\Debug\Database1.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub searchSubjects_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Classes.Enabled = True
    End Sub

    Private Sub searchSubjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.OYmembers.subjects)
        Me.SubjectsBindingSource.Sort = "subject ASC"
        Dim myNames = From n In OYmembers.subjects Select n.subject
        Me.searchSubjectTextBox.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.searchSubjectTextBox.AutoCompleteCustomSource.AddRange(myNames.ToArray())

        disableComponents()
        If SubjectsBindingSource.Count = 0 Then
            DeleteSubjButton.Enabled = False
            EditSubjButton.Enabled = False
        Else
            DeleteSubjButton.Enabled = True
            EditSubjButton.Enabled = True
        End If
    End Sub

    Private Sub SearchSubjectButton_Click(sender As Object, e As EventArgs) Handles SearchSubjectButton.Click
        Dim subj As String
        subj = searchSubjectTextBox.Text
        cmd = New SqlCommand("SELECT * FROM subjects Where subject='" & subj & "'", con)
        If con.State = ConnectionState.Closed Then con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        If sdr.Read = True Then
            Me.SubjectsBindingSource.Sort = "subject ASC"
            Me.SubjectsBindingSource.Position = Me.SubjectsBindingSource.Find("subject", sdr.Item(1).ToString)
            EditSubjButton.Enabled = True
        Else
            MsgBox("No result")
            EditSubjButton.Enabled = False
        End If
        con.Close()
        sdr.Close()

    End Sub

    Private Sub disableComponents()
        IdTextBox.Enabled = False
        SubjectTextBox.ReadOnly = True
        SubjectTextBox.BackColor = Color.White
        DescriptionTextBox.BackColor = Color.White
        DescriptionTextBox.ReadOnly = True
        If SubjectsBindingSource.Count = 0 Then
            DeleteSubjButton.Enabled = False
            EditSubjButton.Enabled = False
        Else
            DeleteSubjButton.Enabled = True
            EditSubjButton.Enabled = True
        End If
        SaveSubjButton.Enabled = False
    End Sub

    Private Sub enableComponents()

        SubjectTextBox.ReadOnly = False
        DescriptionTextBox.ReadOnly = False
        SaveSubjButton.Enabled = True
    End Sub

    Private Sub CloseSearchSubjButton_Click(sender As Object, e As EventArgs) Handles CloseSearchSubjButton.Click
        Classes.Enabled = True
        Me.Close()


    End Sub

    Private Sub EditSubjButton_Click(sender As Object, e As EventArgs) Handles EditSubjButton.Click
        EditSubjButton.Enabled = False
        enableComponents()

    End Sub

    Private Sub SaveSubjButton_Click(sender As Object, e As EventArgs) Handles SaveSubjButton.Click
   
        Try
            Me.Validate()
            Me.SubjectsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OYmembers)
            RefreshList()
            MsgBox("Subject saved!")
            disableComponents()
        Catch ex As Exception
            MsgBox(ex.Message)
            disableComponents()
            EditSubjButton.Enabled = True
        End Try
    End Sub

    Private Sub DeleteSubjButton_Click(sender As Object, e As EventArgs) Handles DeleteSubjButton.Click
        Try
            Me.SubjectsBindingSource.Remove(Me.SubjectsBindingSource.Current)
            Me.SubjectsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OYmembers)
            RefreshList()
            MsgBox("Subject deleted!")
            disableComponents()
        Catch ex As Exception
            MsgBox(ex.Message)
            disableComponents()
            EditSubjButton.Enabled = False
        End Try
    End Sub

    Private Sub SubjectsBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles SubjectsBindingSource.PositionChanged
        If SubjectsBindingSource.Count = 0 Then
            DeleteSubjButton.Enabled = False
        Else
            DeleteSubjButton.Enabled = True
        End If
    End Sub

    Private Sub prevSubjButton_Click(sender As Object, e As EventArgs) Handles prevSubjButton.Click
        Me.SubjectsBindingSource.MovePrevious()

    End Sub

    Private Sub nextSubjButton_Click(sender As Object, e As EventArgs) Handles nextSubjButton.Click
        Me.SubjectsBindingSource.MoveNext()
    End Sub

    Private Sub RefreshList()
        Dim myNames = From n In OYmembers.subjects Select n.subject
        Me.searchSubjectTextBox.AutoCompleteMode = AutoCompleteMode.Suggest
        Me.searchSubjectTextBox.AutoCompleteCustomSource.Clear()
        Me.searchSubjectTextBox.AutoCompleteCustomSource.AddRange(myNames.ToArray())
    End Sub

End Class