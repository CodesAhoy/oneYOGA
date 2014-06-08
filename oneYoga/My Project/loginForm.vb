Imports System.Data.SqlClient
Public Class loginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim cmd As SqlCommand
    Dim myDA As SqlDataAdapter
    Dim myDataSet As DataSet
    Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\user\Source\Repos\oneYOGA\oneYoga\bin\Debug\Database1.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        cmd = New SqlCommand("SELECT * FROM users Where username='" & UsernameTextBox.Text & "'" & " AND password = '" & PasswordTextBox.Text & "'", con)
        If con.State = ConnectionState.Closed Then con.Open()
        Dim sdr As SqlDataReader = cmd.ExecuteReader()
        If sdr.Read = True Then
            sdr.Close()
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            results.Show()
            Me.Hide()
        Else
            MsgBox("Invalid username or password!")
            sdr.Close()
        End If
        'While sdr.Read = True
        '   MsgBox(sdr.Item("name") & " " & sdr.Item("password") & sdr.Item("name"))
        'End While

        'MsgBox(UsernameTextBox.Text)

        




    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub



End Class
