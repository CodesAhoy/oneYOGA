<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selectClassToEnrollForm
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
        Me.RatesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numberOfSessions = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.validity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OYmembers = New oneYoga.OYmembers()
        Me.ClassScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassScheduleTableAdapter = New oneYoga.OYmembersTableAdapters.classScheduleTableAdapter()
        Me.addClassButton = New System.Windows.Forms.Button()
        Me.cancelSelectClassButton = New System.Windows.Forms.Button()
        Me.RatesTableAdapter = New oneYoga.OYmembersTableAdapters.ratesTableAdapter()
        CType(Me.RatesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RatesDataGridView
        '
        Me.RatesDataGridView.AllowUserToAddRows = False
        Me.RatesDataGridView.AllowUserToDeleteRows = False
        Me.RatesDataGridView.AllowUserToOrderColumns = True
        Me.RatesDataGridView.AutoGenerateColumns = False
        Me.RatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RatesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.subject, Me.numberOfSessions, Me.rate, Me.validity})
        Me.RatesDataGridView.DataSource = Me.RatesBindingSource
        Me.RatesDataGridView.Location = New System.Drawing.Point(46, 19)
        Me.RatesDataGridView.MultiSelect = False
        Me.RatesDataGridView.Name = "RatesDataGridView"
        Me.RatesDataGridView.ReadOnly = True
        Me.RatesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RatesDataGridView.Size = New System.Drawing.Size(489, 227)
        Me.RatesDataGridView.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 35
        '
        'subject
        '
        Me.subject.DataPropertyName = "subject"
        Me.subject.HeaderText = "Class"
        Me.subject.Name = "subject"
        Me.subject.ReadOnly = True
        Me.subject.Width = 210
        '
        'numberOfSessions
        '
        Me.numberOfSessions.DataPropertyName = "numberOfSessions"
        Me.numberOfSessions.HeaderText = "numberOfSessions"
        Me.numberOfSessions.Name = "numberOfSessions"
        Me.numberOfSessions.ReadOnly = True
        '
        'rate
        '
        Me.rate.DataPropertyName = "rate"
        Me.rate.HeaderText = "rate"
        Me.rate.Name = "rate"
        Me.rate.ReadOnly = True
        '
        'validity
        '
        Me.validity.DataPropertyName = "validity"
        Me.validity.HeaderText = "validity"
        Me.validity.Name = "validity"
        Me.validity.ReadOnly = True
        '
        'RatesBindingSource
        '
        Me.RatesBindingSource.DataMember = "rates"
        Me.RatesBindingSource.DataSource = Me.OYmembers
        '
        'OYmembers
        '
        Me.OYmembers.DataSetName = "OYmembers"
        Me.OYmembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClassScheduleBindingSource
        '
        Me.ClassScheduleBindingSource.DataMember = "classSchedule"
        Me.ClassScheduleBindingSource.DataSource = Me.OYmembers
        '
        'ClassScheduleTableAdapter
        '
        Me.ClassScheduleTableAdapter.ClearBeforeFill = True
        '
        'addClassButton
        '
        Me.addClassButton.Location = New System.Drawing.Point(379, 252)
        Me.addClassButton.Name = "addClassButton"
        Me.addClassButton.Size = New System.Drawing.Size(75, 23)
        Me.addClassButton.TabIndex = 1
        Me.addClassButton.Text = "Add"
        Me.addClassButton.UseVisualStyleBackColor = True
        '
        'cancelSelectClassButton
        '
        Me.cancelSelectClassButton.Location = New System.Drawing.Point(460, 252)
        Me.cancelSelectClassButton.Name = "cancelSelectClassButton"
        Me.cancelSelectClassButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelSelectClassButton.TabIndex = 2
        Me.cancelSelectClassButton.Text = "Cancel"
        Me.cancelSelectClassButton.UseVisualStyleBackColor = True
        '
        'RatesTableAdapter
        '
        Me.RatesTableAdapter.ClearBeforeFill = True
        '
        'selectClassToEnrollForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 293)
        Me.Controls.Add(Me.cancelSelectClassButton)
        Me.Controls.Add(Me.addClassButton)
        Me.Controls.Add(Me.RatesDataGridView)
        Me.Name = "selectClassToEnrollForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Class To Enroll"
        CType(Me.RatesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RatesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents ClassScheduleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassScheduleTableAdapter As oneYoga.OYmembersTableAdapters.classScheduleTableAdapter
    Friend WithEvents addClassButton As System.Windows.Forms.Button
    Friend WithEvents cancelSelectClassButton As System.Windows.Forms.Button
    Friend WithEvents RatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RatesTableAdapter As oneYoga.OYmembersTableAdapters.ratesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numberOfSessions As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents validity As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
