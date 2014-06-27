Public Class selectStudentToEnrollMenuForm


    Private Sub enrollMenuForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mainMenu.Enabled = True
        mainMenu.Focus()
    End Sub

    Private Sub enrollMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.OYmembers.members)

    End Sub

    Private Sub closeEnrolMenuButton_Click(sender As Object, e As EventArgs) Handles closeEnrolMenuButton.Click
        Me.Close()
    End Sub

    Private Sub selectStudentButton_Click(sender As Object, e As EventArgs) Handles selectStudentButton.Click
        Dim studID As Integer
        studID = Me.studentDataGridView.SelectedRows.Item(0).Cells(4).Value
        mainEnrolmentForm.studID = studID
        selectClassToEnrollForm.studID = studID
        mainEnrolmentForm.studName = Me.studentDataGridView.SelectedRows.Item(0).Cells(0).Value & ", " & Me.studentDataGridView.SelectedRows.Item(0).Cells(1).Value
        mainEnrolmentForm.Show()

    End Sub
End Class