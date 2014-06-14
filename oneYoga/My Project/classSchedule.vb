Imports System.Globalization

Public Class classSchedule
    Dim provider As CultureInfo = CultureInfo.InvariantCulture

    Private Sub ClassScheduleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClassScheduleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OYmembers)

    End Sub

    Private Sub classSchedule_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Classes.Enabled = True
    End Sub

    Private Sub classSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.OYmembers.subjects)
        'TODO: This line of code loads data into the 'OYmembers.subjects' table. You can move, or remove it, as needed.
        'Me.SubjectsTableAdapter.Fill(Me.OYmembers.subjects)
        'TODO: This line of code loads data into the 'OYmembers.classSchedule' table. You can move, or remove it, as needed.
        Me.ClassScheduleTableAdapter.Fill(Me.OYmembers.classSchedule)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        timePickerDialog.Show()
    End Sub

    Private Sub TimeEndTextBox_TextChanged(sender As Object, e As EventArgs) Handles TimeEndTextBox.TextChanged

        If (Me.TimeEndTextBox.Text <> "") Then
            Me.TimeEndDisplayTextBox.Text = Format(DateTime.ParseExact(Me.TimeEndTextBox.Text.ToString, "H:m:s", provider), "hh:mm tt")
        Else
            Me.TimeEndDisplayTextBox.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TimePickerStartDialog.Show()
    End Sub

    Private Sub TimeStartTextBox_TextChanged(sender As Object, e As EventArgs) Handles TimeStartTextBox.TextChanged
        If (Me.TimeStartTextBox.Text <> "") Then
            Me.TimeStartDisplayTextBox.Text = Format(DateTime.ParseExact(Me.TimeStartTextBox.Text.ToString, "H:m:s", provider), "hh:mm tt")
        Else
            Me.TimeStartDisplayTextBox.Clear()
        End If
    End Sub


    Private Sub classSchedule_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.SubjectsBindingSource.Sort = "subject ASC"
        Me.ClassScheduleBindingSource.AddNew()

        Me.classComboBox.SelectedIndex = 0
        preliminaries()
    End Sub

    Private Function preliminaries()
        Me.MondayCheckBox.CheckState = CheckState.Unchecked
        Me.TuesdayCheckBox.CheckState = CheckState.Unchecked
        Me.WednesdayCheckBox.CheckState = CheckState.Unchecked
        Me.ThursdayCheckBox.CheckState = CheckState.Unchecked
        Me.FridayCheckBox.CheckState = CheckState.Unchecked
        Me.SaturdayCheckBox.CheckState = CheckState.Unchecked
        Return 0
    End Function


    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Me.Validate()
            Me.ClassScheduleBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OYmembers)
            MsgBox("New class schedule added")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        mainMenu.Enabled = True
        Me.Close()

    End Sub

    Private Sub CancelButtonAddNewClass_Click(sender As Object, e As EventArgs) Handles CancelButtonAddNewClass.Click
        Classes.Enabled = True
        Me.Close()
    End Sub
End Class