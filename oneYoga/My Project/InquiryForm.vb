Public Class InquiryForm
   

    Private Sub InquiryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InquiryBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.InquiryBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OYinquiry)

            MsgBox("Successfully saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        




    End Sub
  
    Private Sub InquiryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYinquiry.inquiry' table. You can move, or remove it, as needed.
        Me.InquiryTableAdapter.Fill(Me.OYinquiry.inquiry)

    End Sub
End Class