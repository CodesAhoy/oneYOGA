<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchMembers
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.membersDataGrid = New System.Windows.Forms.DataGridView()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.memberID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.membersContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OYmembers = New oneYoga.OYmembers()
        Me.MembersTableAdapter = New oneYoga.OYmembersTableAdapters.membersTableAdapter()
        Me.openMemberDataButton = New System.Windows.Forms.Button()
        Me.CloseSearchMembersButton = New System.Windows.Forms.Button()
        CType(Me.membersDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.membersContextMenuStrip.SuspendLayout()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'membersDataGrid
        '
        Me.membersDataGrid.AllowUserToAddRows = False
        Me.membersDataGrid.AllowUserToDeleteRows = False
        Me.membersDataGrid.AllowUserToOrderColumns = True
        Me.membersDataGrid.AllowUserToResizeRows = False
        Me.membersDataGrid.AutoGenerateColumns = False
        Me.membersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.membersDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SurnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.MIDataGridViewTextBoxColumn, Me.memberID})
        Me.membersDataGrid.DataSource = Me.MembersBindingSource
        Me.membersDataGrid.Location = New System.Drawing.Point(120, 25)
        Me.membersDataGrid.MultiSelect = False
        Me.membersDataGrid.Name = "membersDataGrid"
        Me.membersDataGrid.ReadOnly = True
        Me.membersDataGrid.RowTemplate.ReadOnly = True
        Me.membersDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.membersDataGrid.Size = New System.Drawing.Size(486, 276)
        Me.membersDataGrid.TabIndex = 0
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SurnameDataGridViewTextBoxColumn.Width = 200
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FirstnameDataGridViewTextBoxColumn.Width = 200
        '
        'MIDataGridViewTextBoxColumn
        '
        Me.MIDataGridViewTextBoxColumn.DataPropertyName = "MI"
        Me.MIDataGridViewTextBoxColumn.HeaderText = "MI"
        Me.MIDataGridViewTextBoxColumn.Name = "MIDataGridViewTextBoxColumn"
        Me.MIDataGridViewTextBoxColumn.ReadOnly = True
        Me.MIDataGridViewTextBoxColumn.Width = 40
        '
        'memberID
        '
        Me.memberID.DataPropertyName = "memberID"
        Me.memberID.HeaderText = "memberID"
        Me.memberID.Name = "memberID"
        Me.memberID.ReadOnly = True
        '
        'membersContextMenuStrip
        '
        Me.membersContextMenuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.Cell
        Me.membersContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.membersContextMenuStrip.Name = "membersContextMenuStrip"
        Me.membersContextMenuStrip.Size = New System.Drawing.Size(108, 48)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "members"
        Me.MembersBindingSource.DataSource = Me.OYmembers
        '
        'OYmembers
        '
        Me.OYmembers.DataSetName = "OYmembers"
        Me.OYmembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'openMemberDataButton
        '
        Me.openMemberDataButton.Location = New System.Drawing.Point(22, 52)
        Me.openMemberDataButton.Name = "openMemberDataButton"
        Me.openMemberDataButton.Size = New System.Drawing.Size(75, 23)
        Me.openMemberDataButton.TabIndex = 1
        Me.openMemberDataButton.Text = "View"
        Me.openMemberDataButton.UseVisualStyleBackColor = True
        '
        'CloseSearchMembersButton
        '
        Me.CloseSearchMembersButton.Location = New System.Drawing.Point(22, 81)
        Me.CloseSearchMembersButton.Name = "CloseSearchMembersButton"
        Me.CloseSearchMembersButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseSearchMembersButton.TabIndex = 3
        Me.CloseSearchMembersButton.Text = "Close"
        Me.CloseSearchMembersButton.UseVisualStyleBackColor = True
        '
        'searchMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 313)
        Me.Controls.Add(Me.CloseSearchMembersButton)
        Me.Controls.Add(Me.openMemberDataButton)
        Me.Controls.Add(Me.membersDataGrid)
        Me.Name = "searchMembers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Yoga - Search Members"
        CType(Me.membersDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.membersContextMenuStrip.ResumeLayout(False)
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents membersDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersTableAdapter As oneYoga.OYmembersTableAdapters.membersTableAdapter
    Friend WithEvents membersContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents openMemberDataButton As System.Windows.Forms.Button
    Friend WithEvents CloseSearchMembersButton As System.Windows.Forms.Button
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents memberID As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
