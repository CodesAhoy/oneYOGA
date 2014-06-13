Public Class membersRegistration

    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OYmembers)

    End Sub

    Private Sub membersRegistration_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mainMenu.Enabled = True
    End Sub

    Private Sub membersRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.members' table. You can move, or remove it, as needed.
        'Me.MembersTableAdapter.Fill(Me.OYmembers.members)

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
        mainMenu.Enabled = True
    End Sub

    Private Sub membersRegistration_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.MembersBindingSource.AddNew()
        preliminaries()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Me.Validate()
            Me.MembersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OYmembers)
            MsgBox("New member saved!")
            mainMenu.Enabled = True
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            mainMenu.Enabled = True
            Me.Close()
        End Try

    End Sub

    'Setting uncheck checkboxes and preselected values for comboboxes
    Private Function preliminaries()
        Me.StatusComboBox.SelectedIndex = 0
        Me.SexComboBox.SelectedIndex = 0

        Me.AsthmaCheckBox.CheckState = CheckState.Unchecked
        Me.EpilepsyCheckBox.CheckState = CheckState.Unchecked
        Me.HighBloodCheckBox.CheckState = CheckState.Unchecked
        Me.HeartProblemCheckBox.CheckState = CheckState.Unchecked
        Me.BackpainCheckBox.CheckState = CheckState.Unchecked
        Me.PregnancyCheckBox.CheckState = CheckState.Unchecked
        Me.PrescribedMedicationCheckBox.CheckState = CheckState.Unchecked
        Me.PrescribedMedicationExplainTextBox.Enabled = False
        Me.SurgeryCheckBox.CheckState = CheckState.Unchecked
        Me.SurgeryExplainTextBox.Enabled = False

        Me.OYBrochureCheckBox.CheckState = CheckState.Unchecked
        Me.OYFlyerCheckBox.CheckState = CheckState.Unchecked
        Me.OYFriendCheckBox.CheckState = CheckState.Unchecked
        Me.OYinternetCheckBox.CheckState = CheckState.Unchecked
        Me.OYNewspaperCheckBox.CheckState = CheckState.Unchecked

        Me.FriendExplainTextBox.Enabled = False
        Me.NewspaperExplainTextBox.Enabled = False

        Me.DateRegisteredDateTimePicker.Value = Today
        Me.BirthdateDateTimePicker.Value = Today

        Me.SurnameTextBox.Focus()
        Me.ScrollControlIntoView(Panel2)

        Return 0
    End Function

    Private Sub PrescribedMedicationCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles PrescribedMedicationCheckBox.CheckStateChanged
        If (Me.PrescribedMedicationCheckBox.Checked) Then
            Me.PrescribedMedicationExplainTextBox.Clear()
            Me.PrescribedMedicationExplainTextBox.Enabled = True
        Else
            Me.PrescribedMedicationExplainTextBox.Clear()
            Me.PrescribedMedicationExplainTextBox.Enabled = False
        End If
    End Sub

    Private Sub SurgeryCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles SurgeryCheckBox.CheckStateChanged
        If (Me.SurgeryCheckBox.Checked) Then
            Me.SurgeryExplainTextBox.Clear()
            Me.SurgeryExplainTextBox.Enabled = True
        Else
            Me.SurgeryExplainTextBox.Clear()
            Me.SurgeryExplainTextBox.Enabled = False
        End If
    End Sub

    Private Sub OYNewspaperCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles OYNewspaperCheckBox.CheckStateChanged
        If (Me.OYNewspaperCheckBox.Checked) Then
            Me.NewspaperExplainTextBox.Clear()
            Me.NewspaperExplainTextBox.Enabled = True
        Else
            Me.NewspaperExplainTextBox.Clear()
            Me.NewspaperExplainTextBox.Enabled = False
        End If
    End Sub

    Private Sub OYFriendCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles OYFriendCheckBox.CheckStateChanged
        If (Me.OYFriendCheckBox.Checked) Then
            Me.FriendExplainTextBox.Clear()
            Me.FriendExplainTextBox.Enabled = True
        Else
            Me.FriendExplainTextBox.Clear()
            Me.FriendExplainTextBox.Enabled = False
        End If
    End Sub
End Class