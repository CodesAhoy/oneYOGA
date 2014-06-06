Public Class results

  
    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MembersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    Private Sub results_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        loginForm.Show()

    End Sub

    Private Sub results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.Database1DataSet.members)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loginForm.Show()
        Me.Close()

    End Sub
End Class