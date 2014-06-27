Public Class teachersMenuForm

    Private Sub teachersMenuForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mainMenu.Enabled = True
        mainMenu.Focus()
    End Sub

    Private Sub teachersMenuForm_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.TeachersBindingSource.Sort = "surname, firstname ASC"
    End Sub

    Private Sub teachersMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.teachers' table. You can move, or remove it, as needed.
        Me.TeachersBindingSource.Sort = "surname, firstname ASC"
        Me.TeachersTableAdapter.Fill(Me.OYmembers.teachers)
    End Sub

    Private Sub addTeacherButton_Click(sender As Object, e As EventArgs) Handles addTeacherButton.Click
        Me.Enabled = False
        addNewTeacherForm.Show()
        addNewTeacherForm.Focus()
    End Sub
End Class