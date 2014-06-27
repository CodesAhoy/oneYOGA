<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainEnrolmentForm
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
        Me.studNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.memberClassDataGridView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionsAttendedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionsRemainingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValidUntilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberClassBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OYmembers = New oneYoga.OYmembers()
        Me.MemberClassTableAdapter = New oneYoga.OYmembersTableAdapters.memberClassTableAdapter()
        Me.enrolToNewClassButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.memberClassDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemberClassBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studNameTextBox
        '
        Me.studNameTextBox.Location = New System.Drawing.Point(32, 38)
        Me.studNameTextBox.Name = "studNameTextBox"
        Me.studNameTextBox.ReadOnly = True
        Me.studNameTextBox.Size = New System.Drawing.Size(516, 20)
        Me.studNameTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Member Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Classes enrolled:"
        '
        'memberClassDataGridView
        '
        Me.memberClassDataGridView.AllowUserToAddRows = False
        Me.memberClassDataGridView.AllowUserToDeleteRows = False
        Me.memberClassDataGridView.AllowUserToOrderColumns = True
        Me.memberClassDataGridView.AutoGenerateColumns = False
        Me.memberClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.memberClassDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SubjectDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn, Me.PaidDataGridViewTextBoxColumn, Me.BalanceDataGridViewTextBoxColumn, Me.SessionsDataGridViewTextBoxColumn, Me.SessionsAttendedDataGridViewTextBoxColumn, Me.SessionsRemainingDataGridViewTextBoxColumn, Me.ValidUntilDataGridViewTextBoxColumn})
        Me.memberClassDataGridView.DataSource = Me.MemberClassBindingSource
        Me.memberClassDataGridView.Location = New System.Drawing.Point(32, 90)
        Me.memberClassDataGridView.MultiSelect = False
        Me.memberClassDataGridView.Name = "memberClassDataGridView"
        Me.memberClassDataGridView.ReadOnly = True
        Me.memberClassDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.memberClassDataGridView.Size = New System.Drawing.Size(516, 150)
        Me.memberClassDataGridView.TabIndex = 3
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 30
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        Me.SubjectDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "totalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "totalAmount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaidDataGridViewTextBoxColumn
        '
        Me.PaidDataGridViewTextBoxColumn.DataPropertyName = "paid"
        Me.PaidDataGridViewTextBoxColumn.HeaderText = "paid"
        Me.PaidDataGridViewTextBoxColumn.Name = "PaidDataGridViewTextBoxColumn"
        Me.PaidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BalanceDataGridViewTextBoxColumn
        '
        Me.BalanceDataGridViewTextBoxColumn.DataPropertyName = "balance"
        Me.BalanceDataGridViewTextBoxColumn.HeaderText = "balance"
        Me.BalanceDataGridViewTextBoxColumn.Name = "BalanceDataGridViewTextBoxColumn"
        Me.BalanceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SessionsDataGridViewTextBoxColumn
        '
        Me.SessionsDataGridViewTextBoxColumn.DataPropertyName = "sessions"
        Me.SessionsDataGridViewTextBoxColumn.HeaderText = "sessions"
        Me.SessionsDataGridViewTextBoxColumn.Name = "SessionsDataGridViewTextBoxColumn"
        Me.SessionsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SessionsAttendedDataGridViewTextBoxColumn
        '
        Me.SessionsAttendedDataGridViewTextBoxColumn.DataPropertyName = "sessionsAttended"
        Me.SessionsAttendedDataGridViewTextBoxColumn.HeaderText = "sessionsAttended"
        Me.SessionsAttendedDataGridViewTextBoxColumn.Name = "SessionsAttendedDataGridViewTextBoxColumn"
        Me.SessionsAttendedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SessionsRemainingDataGridViewTextBoxColumn
        '
        Me.SessionsRemainingDataGridViewTextBoxColumn.DataPropertyName = "sessionsRemaining"
        Me.SessionsRemainingDataGridViewTextBoxColumn.HeaderText = "sessionsRemaining"
        Me.SessionsRemainingDataGridViewTextBoxColumn.Name = "SessionsRemainingDataGridViewTextBoxColumn"
        Me.SessionsRemainingDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValidUntilDataGridViewTextBoxColumn
        '
        Me.ValidUntilDataGridViewTextBoxColumn.DataPropertyName = "validUntil"
        Me.ValidUntilDataGridViewTextBoxColumn.HeaderText = "validUntil"
        Me.ValidUntilDataGridViewTextBoxColumn.Name = "ValidUntilDataGridViewTextBoxColumn"
        Me.ValidUntilDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberClassBindingSource
        '
        Me.MemberClassBindingSource.DataMember = "memberClass"
        Me.MemberClassBindingSource.DataSource = Me.OYmembers
        '
        'OYmembers
        '
        Me.OYmembers.DataSetName = "OYmembers"
        Me.OYmembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MemberClassTableAdapter
        '
        Me.MemberClassTableAdapter.ClearBeforeFill = True
        '
        'enrolToNewClassButton
        '
        Me.enrolToNewClassButton.Location = New System.Drawing.Point(392, 246)
        Me.enrolToNewClassButton.Name = "enrolToNewClassButton"
        Me.enrolToNewClassButton.Size = New System.Drawing.Size(75, 23)
        Me.enrolToNewClassButton.TabIndex = 4
        Me.enrolToNewClassButton.Text = "Enroll"
        Me.enrolToNewClassButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(473, 246)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Unenroll"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'mainEnrolmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 525)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.enrolToNewClassButton)
        Me.Controls.Add(Me.memberClassDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.studNameTextBox)
        Me.Name = "mainEnrolmentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Yoga - Enrol to classes"
        CType(Me.memberClassDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemberClassBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents studNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents memberClassDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents MemberClassBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MemberClassTableAdapter As oneYoga.OYmembersTableAdapters.memberClassTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BalanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SessionsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SessionsAttendedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SessionsRemainingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValidUntilDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents enrolToNewClassButton As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
