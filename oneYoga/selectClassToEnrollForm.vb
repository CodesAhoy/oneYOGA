Imports System.Data.SqlClient
Public Class selectClassToEnrollForm

    Public studID As Integer

    Private Sub selectClassToEnrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.rates' table. You can move, or remove it, as needed.
        Me.RatesTableAdapter.Fill(Me.OYmembers.rates)

    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelSelectClassButton.Click
        Me.Close()
    End Sub

    Private Sub addClassButton_Click(sender As Object, e As EventArgs) Handles addClassButton.Click
        Dim classToAdd As String, numberOfSessions As Integer, rate As Decimal, validity As Integer
        classToAdd = Me.RatesDataGridView.SelectedRows.Item(0).Cells(1).Value
        numberOfSessions = Me.RatesDataGridView.SelectedRows.Item(0).Cells(2).Value
        rate = Me.RatesDataGridView.SelectedRows.Item(0).Cells(3).Value
        validity = Me.RatesDataGridView.SelectedRows.Item(0).Cells(4).Value

        Dim cmd As SqlCommand
        Dim con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;Connect Timeout=30")
        If con.State = ConnectionState.Closed Then con.Open()
        cmd = New SqlCommand("INSERT INTO memberClass (studID, subject,totalAmount,paid,balance,sessions, sessionsAttended, sessionsRemaining, validUntil) VALUES (" & studID & ",'" & classToAdd & "'," & rate & ",0, 0," & numberOfSessions & ", 0, 0,'" & Today.AddDays(validity).ToShortDateString & "')", con)
        Try
            Dim sdr As SqlDataReader = cmd.ExecuteReader()
            mainEnrolmentForm.MemberClassTableAdapter.Fill(mainEnrolmentForm.OYmembers.memberClass)
            MsgBox("Enrolled!", 0, "One Yoga")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        
        con.Close()
        Me.Close()

    End Sub
End Class