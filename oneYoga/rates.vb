Public Class rates

    Private Sub addNewRateButton_Click(sender As Object, e As EventArgs) Handles addNewRateButton.Click
        Me.Enabled = False
        addNewRateSessionForm.Show()
    End Sub

    Private Sub closeRatesButton_Click(sender As Object, e As EventArgs) Handles closeRatesButton.Click

        mainMenu.Enabled = True
        Me.Close()
    End Sub

    Private Sub rates_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mainMenu.Enabled = True
        mainMenu.Focus()
    End Sub

    Private Sub rates_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.RatesTableAdapter.Fill(Me.OYmembers.rates)
        Me.RatesBindingSource.Sort = "subject ASC"

    End Sub
End Class