<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectTeacherForm
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
        Me.teacherDataGridView = New System.Windows.Forms.DataGridView()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeachersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OYmembers = New oneYoga.OYmembers()
        Me.TeachersTableAdapter = New oneYoga.OYmembersTableAdapters.teachersTableAdapter()
        Me.selectTeacherButton = New System.Windows.Forms.Button()
        Me.cancelSelectteacherButton = New System.Windows.Forms.Button()
        CType(Me.teacherDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeachersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teacherDataGridView
        '
        Me.teacherDataGridView.AllowUserToAddRows = False
        Me.teacherDataGridView.AllowUserToDeleteRows = False
        Me.teacherDataGridView.AllowUserToOrderColumns = True
        Me.teacherDataGridView.AutoGenerateColumns = False
        Me.teacherDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.teacherDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SurnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.MIDataGridViewTextBoxColumn, Me.IdDataGridViewTextBoxColumn})
        Me.teacherDataGridView.DataSource = Me.TeachersBindingSource
        Me.teacherDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.teacherDataGridView.MultiSelect = False
        Me.teacherDataGridView.Name = "teacherDataGridView"
        Me.teacherDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.teacherDataGridView.Size = New System.Drawing.Size(488, 200)
        Me.teacherDataGridView.TabIndex = 0
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        Me.SurnameDataGridViewTextBoxColumn.Width = 200
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.Width = 200
        '
        'MIDataGridViewTextBoxColumn
        '
        Me.MIDataGridViewTextBoxColumn.DataPropertyName = "MI"
        Me.MIDataGridViewTextBoxColumn.HeaderText = "MI"
        Me.MIDataGridViewTextBoxColumn.Name = "MIDataGridViewTextBoxColumn"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TeachersBindingSource
        '
        Me.TeachersBindingSource.DataMember = "teachers"
        Me.TeachersBindingSource.DataSource = Me.OYmembers
        '
        'OYmembers
        '
        Me.OYmembers.DataSetName = "OYmembers"
        Me.OYmembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeachersTableAdapter
        '
        Me.TeachersTableAdapter.ClearBeforeFill = True
        '
        'selectTeacherButton
        '
        Me.selectTeacherButton.Location = New System.Drawing.Point(156, 227)
        Me.selectTeacherButton.Name = "selectTeacherButton"
        Me.selectTeacherButton.Size = New System.Drawing.Size(102, 33)
        Me.selectTeacherButton.TabIndex = 1
        Me.selectTeacherButton.Text = "Select"
        Me.selectTeacherButton.UseVisualStyleBackColor = True
        '
        'cancelSelectteacherButton
        '
        Me.cancelSelectteacherButton.Location = New System.Drawing.Point(264, 227)
        Me.cancelSelectteacherButton.Name = "cancelSelectteacherButton"
        Me.cancelSelectteacherButton.Size = New System.Drawing.Size(102, 33)
        Me.cancelSelectteacherButton.TabIndex = 2
        Me.cancelSelectteacherButton.Text = "Cancel"
        Me.cancelSelectteacherButton.UseVisualStyleBackColor = True
        '
        'selectTeacherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 272)
        Me.Controls.Add(Me.cancelSelectteacherButton)
        Me.Controls.Add(Me.selectTeacherButton)
        Me.Controls.Add(Me.teacherDataGridView)
        Me.Name = "selectTeacherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Yoga - Select Teacher"
        CType(Me.teacherDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeachersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents teacherDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents TeachersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeachersTableAdapter As oneYoga.OYmembersTableAdapters.teachersTableAdapter
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MIDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selectTeacherButton As System.Windows.Forms.Button
    Friend WithEvents cancelSelectteacherButton As System.Windows.Forms.Button
End Class
