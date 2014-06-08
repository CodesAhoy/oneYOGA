Public Class Layout

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OYmembers)

    End Sub


    Private Sub UsersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OYmembers)

    End Sub

    Private Sub Layout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.OYmembers.users)

    End Sub
End Class