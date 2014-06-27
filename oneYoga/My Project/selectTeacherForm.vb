Public Class selectTeacherForm

    Private Sub selectTeacherForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        classSchedule.Enabled = True
        classSchedule.Focus()
    End Sub

    Private Sub selectTeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.teachers' table. You can move, or remove it, as needed.
        Me.TeachersTableAdapter.Fill(Me.OYmembers.teachers)

    End Sub

    Private Sub selectTeacherButton_Click(sender As Object, e As EventArgs) Handles selectTeacherButton.Click
        Dim id As Integer
        Dim name As String
        id = Me.teacherDataGridView.SelectedRows.Item(0).Cells(3).Value
        name = Me.teacherDataGridView.SelectedRows.Item(0).Cells(0).Value & ", " & Me.teacherDataGridView.SelectedRows.Item(0).Cells(1).Value & " " & Me.teacherDataGridView.SelectedRows.Item(0).Cells(2).Value
        classSchedule.setTeacher(id, name)
        Me.Close()
    End Sub


    Private Sub cancelSelectteacherButton_Click(sender As Object, e As EventArgs) Handles cancelSelectteacherButton.Click
        Me.Close()
    End Sub
End Class