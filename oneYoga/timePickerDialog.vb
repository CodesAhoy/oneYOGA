Imports System.Windows.Forms

Public Class timePickerDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim s As String
        s = Me.DateTimePicker1.Value.Hour.ToString & ":" & Me.DateTimePicker1.Value.Minute & ":00"
        classSchedule.TimeEndTextBox.Text = s
        classSchedule.TimeEndDisplayTextBox.Text = Format(Me.DateTimePicker1.Value, "hh:mm tt")
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub timePickerDialog_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub
End Class
