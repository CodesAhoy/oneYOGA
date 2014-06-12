Public Class login_Form

    Sub TestEncoding()
        Dim plainText As String = InputBox("Enter the plain text:")
        Dim password As String = InputBox("Enter the password:")

        Dim wrapper As New Simple3Des(password)
        Dim cipherText As String = wrapper.EncryptData(plainText)

        MsgBox("The cipher text is: " & cipherText)
        My.Computer.FileSystem.WriteAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
            "\cipherText.txt", cipherText, False)
    End Sub

    Sub TestDecoding()
        Dim cipherText As String = My.Computer.FileSystem.ReadAllText(
            My.Computer.FileSystem.SpecialDirectories.MyDocuments &
                "\cipherText.txt")
        Dim password As String = InputBox("Enter the password:")
        Dim wrapper As New Simple3Des(password)

        ' DecryptData throws if the wrong password is used. 
        Try
            Dim plainText As String = wrapper.DecryptData(cipherText)
            MsgBox("The plain text is: " & plainText)
        Catch ex As System.Security.Cryptography.CryptographicException
            MsgBox("The data could not be decrypted with the password.")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TestEncoding()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TestDecoding()
    End Sub
End Class