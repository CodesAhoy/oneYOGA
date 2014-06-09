Public Class Form1

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OYdataset)

    End Sub


    Private Sub TableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.OYdataset)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYdataset.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.OYdataset.Table)

    End Sub
End Class