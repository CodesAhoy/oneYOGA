Public Class mainEnrolmentForm

    Public studID As Integer, studName As String
 
    Private Sub mainEnrolmentForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        selectStudentToEnrollMenuForm.Enabled = True
        selectStudentToEnrollMenuForm.Focus()
    End Sub

    Private Sub mainEnrolmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.memberClass' table. You can move, or remove it, as needed.
        

    End Sub

    Private Sub mainEnrolmentForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.studNameTextBox.Text = studName
        Me.MemberClassBindingSource.Filter = "studID = " & studID
        Me.MemberClassTableAdapter.Fill(Me.OYmembers.memberClass)
    End Sub

    Private Sub enrolToNewClassButton_Click(sender As Object, e As EventArgs) Handles enrolToNewClassButton.Click
        selectClassToEnrollForm.Show()
    End Sub
End Class