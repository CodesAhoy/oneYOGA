Public Class Classes

    Private Sub AddClassScheduleButton_Click(sender As Object, e As EventArgs) Handles AddClassScheduleButton.Click
        Me.Enabled = False
        classSchedule.Show()
    End Sub

    Private Sub Classes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mainMenu.Enabled = True
    End Sub

    Private Sub AddSubjectButton_Click(sender As Object, e As EventArgs) Handles AddSubjectButton.Click
        Me.Enabled = False
        AddSubjectForm.Show()
    End Sub
End Class