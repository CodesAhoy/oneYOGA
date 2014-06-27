Public Class addNewTeacherForm

    Private Sub addNewTeacherForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        teachersMenuForm.Enabled = True
        teachersMenuForm.Focus()
    End Sub

    Private Sub addNewTeacherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.teachers' table. You can move, or remove it, as needed.
        'Me.TeachersTableAdapter.Fill(Me.OYmembers.teachers)

    End Sub

    Private Sub addNewTeacherForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.TeachersBindingSource.AddNew()
        Me.surnameTextBox.Focus()
    End Sub

    Private Sub saveNewTeacherButton_Click(sender As Object, e As EventArgs) Handles saveNewTeacherButton.Click
        Try
            Me.Validate()
            Me.TeachersBindingSource.EndEdit()
            Me.TeachersTableAdapter.Update(Me.OYmembers.teachers)
            MsgBox("Added new teacher", 0, "One Yoga")
            teachersMenuForm.TeachersTableAdapter.Fill(teachersMenuForm.OYmembers.teachers)
            teachersMenuForm.TeachersBindingSource.Sort = "surname, firstname ASC"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub cancelAddNewTeacherButton_Click(sender As Object, e As EventArgs) Handles cancelAddNewTeacherButton.Click
        Me.Close()
    End Sub
End Class