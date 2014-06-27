<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectStudentToEnrollMenuForm
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
        Me.studentDataGridView = New System.Windows.Forms.DataGridView()
        Me.OYmembers = New oneYoga.OYmembers()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter = New oneYoga.OYmembersTableAdapters.membersTableAdapter()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NicknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MemberIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selectStudentButton = New System.Windows.Forms.Button()
        Me.closeEnrolMenuButton = New System.Windows.Forms.Button()
        CType(Me.studentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'studentDataGridView
        '
        Me.studentDataGridView.AllowUserToAddRows = False
        Me.studentDataGridView.AllowUserToDeleteRows = False
        Me.studentDataGridView.AutoGenerateColumns = False
        Me.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.studentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SurnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.MIDataGridViewTextBoxColumn, Me.NicknameDataGridViewTextBoxColumn, Me.MemberIDDataGridViewTextBoxColumn})
        Me.studentDataGridView.DataSource = Me.MembersBindingSource
        Me.studentDataGridView.Location = New System.Drawing.Point(46, 35)
        Me.studentDataGridView.MultiSelect = False
        Me.studentDataGridView.Name = "studentDataGridView"
        Me.studentDataGridView.ReadOnly = True
        Me.studentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.studentDataGridView.Size = New System.Drawing.Size(544, 254)
        Me.studentDataGridView.TabIndex = 0
        '
        'OYmembers
        '
        Me.OYmembers.DataSetName = "OYmembers"
        Me.OYmembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "members"
        Me.MembersBindingSource.DataSource = Me.OYmembers
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MIDataGridViewTextBoxColumn
        '
        Me.MIDataGridViewTextBoxColumn.DataPropertyName = "MI"
        Me.MIDataGridViewTextBoxColumn.HeaderText = "MI"
        Me.MIDataGridViewTextBoxColumn.Name = "MIDataGridViewTextBoxColumn"
        Me.MIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NicknameDataGridViewTextBoxColumn
        '
        Me.NicknameDataGridViewTextBoxColumn.DataPropertyName = "nickname"
        Me.NicknameDataGridViewTextBoxColumn.HeaderText = "Nickname"
        Me.NicknameDataGridViewTextBoxColumn.Name = "NicknameDataGridViewTextBoxColumn"
        Me.NicknameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MemberIDDataGridViewTextBoxColumn
        '
        Me.MemberIDDataGridViewTextBoxColumn.DataPropertyName = "memberID"
        Me.MemberIDDataGridViewTextBoxColumn.HeaderText = "memberID"
        Me.MemberIDDataGridViewTextBoxColumn.Name = "MemberIDDataGridViewTextBoxColumn"
        Me.MemberIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select a student to enrol"
        '
        'selectStudentButton
        '
        Me.selectStudentButton.Location = New System.Drawing.Point(434, 300)
        Me.selectStudentButton.Name = "selectStudentButton"
        Me.selectStudentButton.Size = New System.Drawing.Size(75, 23)
        Me.selectStudentButton.TabIndex = 2
        Me.selectStudentButton.Text = "OK"
        Me.selectStudentButton.UseVisualStyleBackColor = True
        '
        'closeEnrolMenuButton
        '
        Me.closeEnrolMenuButton.Location = New System.Drawing.Point(515, 300)
        Me.closeEnrolMenuButton.Name = "closeEnrolMenuButton"
        Me.closeEnrolMenuButton.Size = New System.Drawing.Size(75, 23)
        Me.closeEnrolMenuButton.TabIndex = 3
        Me.closeEnrolMenuButton.Text = "Cancel"
        Me.closeEnrolMenuButton.UseVisualStyleBackColor = True
        '
        'selectStudentToEnrollMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 340)
        Me.Controls.Add(Me.closeEnrolMenuButton)
        Me.Controls.Add(Me.selectStudentButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.studentDataGridView)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "selectStudentToEnrollMenuForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Yoga - Enrolment"
        CType(Me.studentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents studentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersTableAdapter As oneYoga.OYmembersTableAdapters.membersTableAdapter
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NicknameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MemberIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents selectStudentButton As System.Windows.Forms.Button
    Friend WithEvents closeEnrolMenuButton As System.Windows.Forms.Button
End Class
