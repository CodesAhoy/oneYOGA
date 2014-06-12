Public Class results

  


    Private Sub results_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed



    End Sub



    Private Sub MembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MembersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OYmembers)

    End Sub

    Private Sub results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.OYmembers.members)

    End Sub

    Private Sub Close_button_Click(sender As Object, e As EventArgs) Handles Close_button.Click


        Me.Close()
    End Sub
End Class

