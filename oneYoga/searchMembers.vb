Public Class searchMembers

    Private Sub searchMembers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mainMenu.Enabled = True
    End Sub




    Private Sub searchMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OYmembers.members' table. You can move, or remove it, as needed.

        Me.MembersTableAdapter.Fill(Me.OYmembers.members)
        Me.MembersBindingSource.Sort = "surname, firstname ASC"
    End Sub



    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        showResult()
    End Sub

    Private Sub openMemberDataButton_Click(sender As Object, e As EventArgs) Handles openMemberDataButton.Click
        showResult()
    End Sub

    Private Sub membersDataGrid_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles membersDataGrid.CellDoubleClick
        showResult()
    End Sub

    Private Sub showResult()
        Dim id As Integer
        id = Me.membersDataGrid.SelectedRows.Item(0).Cells(3).Value
        results.selectedID = id
        results.Show()
    End Sub

    Private Sub CloseSearchMembersButton_Click(sender As Object, e As EventArgs) Handles CloseSearchMembersButton.Click
        mainMenu.Enabled = True
        Me.Close()

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Delete member record?", "Delete Member Record", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Try
                Me.MembersBindingSource.Remove(Me.MembersBindingSource.Current)
                Me.MembersBindingSource.EndEdit()
                Me.MembersTableAdapter.Update(Me.OYmembers)
                MsgBox("Member deleted!")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

  
    Private Sub membersDataGrid_MouseDown(sender As Object, e As MouseEventArgs) Handles membersDataGrid.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim hit As DataGridView.HitTestInfo = _
                membersDataGrid.HitTest(e.X, e.Y)
            membersDataGrid.ClearSelection()
            If hit.RowIndex > -1 Then
                membersDataGrid.Rows(hit.RowIndex).Selected = True
                membersContextMenuStrip.Show(membersDataGrid, e.Location)
            End If
        End If
    End Sub
End Class