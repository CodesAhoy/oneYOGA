Public Class mainMenu
    Public userName As String

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        loginForm.Show()
        loginForm.UsernameTextBox.Focus()
        Me.Close()
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Me.Enabled = False
        membersRegistration.Show()
    End Sub

    Private Sub ViewMembersButton_Click(sender As Object, e As EventArgs) Handles ViewMembersButton.Click
        searchMembers.Show()
        Me.Enabled = False
        'results.Show()

    End Sub

    Private Sub ClassScheduleButton_Click(sender As Object, e As EventArgs) Handles ClassScheduleButton.Click
        'MsgBox("Feature Coming Soon!", 0, "One Yoga")
        Me.Enabled = False
        Classes.Show()
    End Sub

    Private Sub SalesButton_Click(sender As Object, e As EventArgs) Handles SalesButton.Click
        MsgBox("Feature Coming Soon!", 0, "One Yoga")
    End Sub

    Private Sub TeachersButton_Click(sender As Object, e As EventArgs) Handles TeachersButton.Click
        'MsgBox("Feature Coming Soon!", 0, "One Yoga")
        Me.Enabled = False
        teachersMenuForm.Show()
    End Sub

    Private Sub PaymentButton_Click(sender As Object, e As EventArgs) Handles PaymentButton.Click
        MsgBox("Feature Coming Soon!", 0, "One Yoga")
    End Sub

    Private Sub UsersButton_Click(sender As Object, e As EventArgs) Handles UsersButton.Click
        MsgBox("Feature Coming Soon!", 0, "One Yoga")
    End Sub

    Private Sub mainMenu_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.nameLabel.Text = "Welcome, " & userName
    End Sub



    Private Sub mainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        loginForm.Show()
        loginForm.UsernameTextBox.Focus()
    End Sub

    Private Sub EnrollMenuButton_Click(sender As Object, e As EventArgs) Handles EnrollMenuButton.Click
        MsgBox("Feature Coming Soon!", 0, "One Yoga")
    End Sub

    Private Sub RatesButton_Click(sender As Object, e As EventArgs) Handles RatesButton.Click
        Me.Enabled = False
        rates.Show()

    End Sub
End Class