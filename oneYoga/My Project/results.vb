Public Class results

  
    Public selectedID As Integer

    Private Sub results_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed



    End Sub



    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OYmembers)

    End Sub

    Private Sub results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.OYmembers.members)

    End Sub


    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        mainMenu.Enabled = True
        Me.Close()
    End Sub

    Private Sub results_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.ScrollControlIntoView(Panel2)
        Preliminaries()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Me.Validate()
            Me.MembersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OYmembers)
            MsgBox("Member record updated!", 0, "One Yoga")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DeleteMemberButton_Click(sender As Object, e As EventArgs) Handles DeleteMemberButton.Click

        Dim result As Integer = MessageBox.Show("Delete member record?", "Delete Member Record", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Try
                Me.MembersBindingSource.Remove(Me.MembersBindingSource.Current)
                Me.MembersBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.OYmembers)
                MsgBox("Member deleted!")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            searchMembers.Close()
            searchMembers.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PrescribedMedicationCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles PrescribedMedicationCheckBox.CheckStateChanged
        If Me.PrescribedMedicationCheckBox.Checked Then
            'Me.PrescribedMedicationExplainTextBox.Clear()
            Me.PrescribedMedicationExplainTextBox.Enabled = True
        Else
            Me.PrescribedMedicationExplainTextBox.Clear()
            Me.PrescribedMedicationExplainTextBox.Enabled = False
        End If
    End Sub

    Private Sub SurgeryCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles SurgeryCheckBox.CheckStateChanged
        If (Me.SurgeryCheckBox.Checked) Then
            'Me.SurgeryExplainTextBox.Clear()
            Me.SurgeryExplainTextBox.Enabled = True
        Else
            Me.SurgeryExplainTextBox.Clear()
            Me.SurgeryExplainTextBox.Enabled = False
        End If
    End Sub

    Private Sub OYNewspaperCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles OYNewspaperCheckBox.CheckStateChanged
        If (Me.OYNewspaperCheckBox.Checked) Then
            'Me.NewspaperExplainTextBox.Clear()
            Me.NewspaperExplainTextBox.Enabled = True
        Else
            Me.NewspaperExplainTextBox.Clear()
            Me.NewspaperExplainTextBox.Enabled = False
        End If
    End Sub

    Private Sub OYFriendCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles OYFriendCheckBox.CheckStateChanged
        If (Me.OYFriendCheckBox.Checked) Then
            'Me.FriendExplainTextBox.Clear()
            Me.FriendExplainTextBox.Enabled = True
        Else
            Me.FriendExplainTextBox.Clear()
            Me.FriendExplainTextBox.Enabled = False
        End If
    End Sub

    Private Sub Preliminaries()
        Me.MembersBindingSource.Position = Me.MembersBindingSource.Find("memberID", selectedID)
        Dim myRowView As DataRowView = MembersBindingSource.Current

        If myRowView.Item("sex").ToString.Trim = "Male" Then
            Me.SexComboBox.SelectedIndex = 0
        Else
            Me.SexComboBox.SelectedIndex = 1
        End If

        If myRowView.Item("civilStatus").ToString.Trim = "Single" Then
            Me.StatusComboBox.SelectedIndex = 0
        ElseIf myRowView.Item("civilStatus").ToString.Trim = "Married" Then
            Me.StatusComboBox.SelectedIndex = 1
        ElseIf myRowView.Item("civilStatus").ToString.Trim = "Widow" Then
            Me.StatusComboBox.SelectedIndex = 2
        Else
            Me.StatusComboBox.SelectedIndex = 3
        End If


        If myRowView.Item("prescribedMedication") Then
            Me.PrescribedMedicationExplainTextBox.Enabled = True
        Else
            Me.PrescribedMedicationExplainTextBox.Clear()
            Me.PrescribedMedicationExplainTextBox.Enabled = False
        End If

        If myRowView.Item("surgery") Then
            Me.SurgeryExplainTextBox.Enabled = True
        Else
            Me.SurgeryExplainTextBox.Clear()
            Me.SurgeryExplainTextBox.Enabled = False
        End If

        If myRowView.Item("OYNewspaper") Then
            Me.NewspaperExplainTextBox.Enabled = True
        Else
            Me.NewspaperExplainTextBox.Clear()
            Me.NewspaperExplainTextBox.Enabled = False
        End If

        If myRowView.Item("OYFriend") Then
            Me.FriendExplainTextBox.Enabled = True
        Else
            Me.FriendExplainTextBox.Clear()
            Me.FriendExplainTextBox.Enabled = False
        End If

    End Sub
End Class

