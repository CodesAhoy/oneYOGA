Public Class results

  


    Private Sub results_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        loginForm.Show()

    End Sub


    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MembersBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.MembersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OYmembers)


            MsgBox("Successfully saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MembersBindingNavigatorSaveItem.Enabled = False
        If OYmembers.Tables(0).Rows.Count > 0 Then
            EditButton.Enabled = True
        Else
            EditButton.Enabled = False
        End If
        disableComponent()
        BindingNavigatorAddNewItem.Enabled = True
    End Sub

    Private Sub results_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.OYmembers.members)
        MembersBindingNavigatorSaveItem.Enabled = False
        disableComponent()
        If OYmembers.Tables(0).Rows.Count > 0 Then
            EditButton.Enabled = True
        Else
            EditButton.Enabled = False
        End If
    End Sub

 
    Private Sub Close_button_Click(sender As Object, e As EventArgs) Handles Close_button.Click
        loginForm.Show()
        Me.Close()
    End Sub

 

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        MembersBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
        enableComponent()
    End Sub

    Private Function disableComponent()
        SurnameTextBox.Enabled = False
        FirstnameTextBox.Enabled = False
        MITextBox.Enabled = False
        NicknameTextBox.Enabled = False
        HomeAddrTextBox.Enabled = False
        ZipcodeTextBox.Enabled = False
        OfficeAddrTextBox.Enabled = False
        BirthdateDateTimePicker.Enabled = False
        Status_ComboBox.Enabled = False
        Sex_ComboBox.Enabled = False
        MobileNoTextBox.Enabled = False
        OtherContactTextBox.Enabled = False
        EmailTextBox.Enabled = False
        ContactPersonTextBox.Enabled = False
        ContactPersonRelationshipTextBox.Enabled = False
        ContactPersonNoTextBox.Enabled = False
        ContactPersonAddrTextBox.Enabled = False
        AsthmaCheckBox.Enabled = False
        EpilepsyCheckBox.Enabled = False
        HighBloodCheckBox.Enabled = False
        HeartProblemCheckBox.Enabled = False
        BackpainCheckBox.Enabled = False
        PregnancyCheckBox.Enabled = False
        OtherHealthConditionTextBox.Enabled = False
        PrescribedMedicationCheckBox.Enabled = False
        PrescribedMedicationExplainTextBox.Enabled = False
        PhysicianOrHospitalCareTextBox.Enabled = False
        SurgeryCheckBox.Enabled = False
        SurgeryExplainTextBox.Enabled = False
        OYinternetCheckBox.Enabled = False
        OYFlyerCheckBox.Enabled = False
        OYNewspaperCheckBox.Enabled = False
        OYBrochureCheckBox.Enabled = False
        OYFriendCheckBox.Enabled = False
        OYOthersTextBox.Enabled = False
        NewspaperExplainTextBox.Enabled = False
        FriendExplainTextBox.Enabled = False
        DateRegisteredDateTimePicker.Enabled = False


        Return True

    End Function

    Private Function enableComponent()
        SurnameTextBox.Enabled = True
        FirstnameTextBox.Enabled = True
        MITextBox.Enabled = True
        NicknameTextBox.Enabled = True
        HomeAddrTextBox.Enabled = True
        ZipcodeTextBox.Enabled = True
        OfficeAddrTextBox.Enabled = True
        BirthdateDateTimePicker.Enabled = True
        Status_ComboBox.Enabled = True
        Sex_ComboBox.Enabled = True
        MobileNoTextBox.Enabled = True
        OtherContactTextBox.Enabled = True
        EmailTextBox.Enabled = True
        ContactPersonTextBox.Enabled = True
        ContactPersonRelationshipTextBox.Enabled = True
        ContactPersonNoTextBox.Enabled = True
        ContactPersonAddrTextBox.Enabled = True
        AsthmaCheckBox.Enabled = True
        EpilepsyCheckBox.Enabled = True
        HighBloodCheckBox.Enabled = True
        HeartProblemCheckBox.Enabled = True
        BackpainCheckBox.Enabled = True
        PregnancyCheckBox.Enabled = True
        OtherHealthConditionTextBox.Enabled = True
        PrescribedMedicationCheckBox.Enabled = True
        PrescribedMedicationExplainTextBox.Enabled = True
        PhysicianOrHospitalCareTextBox.Enabled = True
        SurgeryCheckBox.Enabled = True
        SurgeryExplainTextBox.Enabled = True
        OYinternetCheckBox.Enabled = True
        OYFlyerCheckBox.Enabled = True
        OYNewspaperCheckBox.Enabled = True
        OYBrochureCheckBox.Enabled = True
        OYFriendCheckBox.Enabled = True
        OYOthersTextBox.Enabled = True
        NewspaperExplainTextBox.Enabled = True
        FriendExplainTextBox.Enabled = True
        DateRegisteredDateTimePicker.Enabled = True


        Return True

    End Function


   
    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        enableComponent()
        EditButton.Enabled = False
        MembersBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = False
    End Sub
End Class

