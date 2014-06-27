Public Class addNewRateSessionForm

    Private Sub addNewRateForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        rates.Enabled = True

    End Sub

    Private Sub addNewRateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.rates' table. You can move, or remove it, as needed.
        'Me.RatesTableAdapter.Fill(Me.OYmembers.rates)
        'TODO: This line of code loads data into the 'OYmembers.subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.OYmembers.subjects)

    End Sub

    Private Sub saveRateButton_Click(sender As Object, e As EventArgs) Handles saveRateButton.Click
        Try
            Me.Validate()
            Me.RatesBindingSource.EndEdit()
            Me.RatesTableAdapter.Update(Me.OYmembers)
            rates.RatesTableAdapter.Fill(rates.OYmembers.rates)
            rates.RatesTableAdapter.Update(rates.OYmembers)
            MsgBox("New rate added!", 0, "One Yoga")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'rates.Close()
        'rates.Show()
        rates.Enabled = True
        Me.Close()
    End Sub

    Private Sub CancelRateButton_Click(sender As Object, e As EventArgs) Handles CancelRateButton.Click

        rates.Enabled = True
        Me.Close()
    End Sub

    Private Sub addNewRateForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.RatesBindingSource.AddNew()
        Me.SubjectsBindingSource.Sort = "subject ASC"
        Me.sessionsComboBox.SelectedIndex = 0
    End Sub

End Class