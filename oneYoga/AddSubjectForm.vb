Public Class AddSubjectForm

    Private Sub SubjectsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SubjectsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OYmembers)

    End Sub

    Private Sub AddSubjectForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Classes.Enabled = True
    End Sub

    Private Sub AddSubjectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.OYmembers.subjects)

    End Sub

    Private Sub AddNewSubButton_Click(sender As Object, e As EventArgs) Handles AddNewSubButton.Click
        Try
            Me.Validate()
            Me.SubjectsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OYmembers)
            MsgBox("Added new Subject")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Classes.Enabled = True
        Me.Close()

    End Sub

    Private Sub AddSubjectForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.SubjectsBindingSource.AddNew()
        Me.SubjectTextBox.Focus()
    End Sub

    Private Sub CancelSubjButton_Click(sender As Object, e As EventArgs) Handles CancelSubjButton.Click
        Classes.Enabled = True
        Me.Close()
    End Sub
End Class