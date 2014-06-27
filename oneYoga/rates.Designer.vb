<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rates
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
        Me.ratesDataGridView = New System.Windows.Forms.DataGridView()
        Me.RatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OYmembers = New oneYoga.OYmembers()
        Me.addNewRateButton = New System.Windows.Forms.Button()
        Me.editRateButton = New System.Windows.Forms.Button()
        Me.closeRatesButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RatesTableAdapter = New oneYoga.OYmembersTableAdapters.ratesTableAdapter()
        Me.addSingleSessionButton = New System.Windows.Forms.Button()
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfSessionsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.validity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ratesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ratesDataGridView
        '
        Me.ratesDataGridView.AllowUserToAddRows = False
        Me.ratesDataGridView.AllowUserToDeleteRows = False
        Me.ratesDataGridView.AllowUserToOrderColumns = True
        Me.ratesDataGridView.AutoGenerateColumns = False
        Me.ratesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ratesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubjectDataGridViewTextBoxColumn, Me.NumberOfSessionsDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn, Me.validity, Me.IdDataGridViewTextBoxColumn})
        Me.ratesDataGridView.DataSource = Me.RatesBindingSource
        Me.ratesDataGridView.Location = New System.Drawing.Point(135, 12)
        Me.ratesDataGridView.Name = "ratesDataGridView"
        Me.ratesDataGridView.ReadOnly = True
        Me.ratesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ratesDataGridView.Size = New System.Drawing.Size(527, 299)
        Me.ratesDataGridView.TabIndex = 0
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
        'addNewRateButton
        '
        Me.addNewRateButton.Location = New System.Drawing.Point(12, 12)
        Me.addNewRateButton.Name = "addNewRateButton"
        Me.addNewRateButton.Size = New System.Drawing.Size(117, 32)
        Me.addNewRateButton.TabIndex = 1
        Me.addNewRateButton.Text = "Add Multi Sessions"
        Me.addNewRateButton.UseVisualStyleBackColor = True
        '
        'editRateButton
        '
        Me.editRateButton.Location = New System.Drawing.Point(12, 88)
        Me.editRateButton.Name = "editRateButton"
        Me.editRateButton.Size = New System.Drawing.Size(117, 32)
        Me.editRateButton.TabIndex = 2
        Me.editRateButton.Text = "Edit Rate"
        Me.editRateButton.UseVisualStyleBackColor = True
        '
        'closeRatesButton
        '
        Me.closeRatesButton.Location = New System.Drawing.Point(12, 164)
        Me.closeRatesButton.Name = "closeRatesButton"
        Me.closeRatesButton.Size = New System.Drawing.Size(117, 32)
        Me.closeRatesButton.TabIndex = 3
        Me.closeRatesButton.Text = "Close"
        Me.closeRatesButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Delete Rate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RatesTableAdapter
        '
        Me.RatesTableAdapter.ClearBeforeFill = True
        '
        'addSingleSessionButton
        '
        Me.addSingleSessionButton.Location = New System.Drawing.Point(12, 50)
        Me.addSingleSessionButton.Name = "addSingleSessionButton"
        Me.addSingleSessionButton.Size = New System.Drawing.Size(117, 32)
        Me.addSingleSessionButton.TabIndex = 5
        Me.addSingleSessionButton.Text = "Add Single Session"
        Me.addSingleSessionButton.UseVisualStyleBackColor = True
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        Me.SubjectDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubjectDataGridViewTextBoxColumn.Width = 200
        '
        'NumberOfSessionsDataGridViewTextBoxColumn
        '
        Me.NumberOfSessionsDataGridViewTextBoxColumn.DataPropertyName = "numberOfSessions"
        Me.NumberOfSessionsDataGridViewTextBoxColumn.HeaderText = "Number Of Sessions"
        Me.NumberOfSessionsDataGridViewTextBoxColumn.Name = "NumberOfSessionsDataGridViewTextBoxColumn"
        Me.NumberOfSessionsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        Me.RateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'validity
        '
        Me.validity.DataPropertyName = "validity"
        Me.validity.HeaderText = "Validity (Days)"
        Me.validity.Name = "validity"
        Me.validity.ReadOnly = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'rates
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 323)
        Me.Controls.Add(Me.addSingleSessionButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.closeRatesButton)
        Me.Controls.Add(Me.editRateButton)
        Me.Controls.Add(Me.addNewRateButton)
        Me.Controls.Add(Me.ratesDataGridView)
        Me.Name = "rates"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Yoga - Rates"
        CType(Me.ratesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ratesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents addNewRateButton As System.Windows.Forms.Button
    Friend WithEvents editRateButton As System.Windows.Forms.Button
    Friend WithEvents closeRatesButton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents RatesTableAdapter As oneYoga.OYmembersTableAdapters.ratesTableAdapter
    Friend WithEvents addSingleSessionButton As System.Windows.Forms.Button
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberOfSessionsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents validity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
