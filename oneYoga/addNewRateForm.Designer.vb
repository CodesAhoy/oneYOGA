<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addNewRateSessionForm
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
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.RatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OYmembers = New oneYoga.OYmembers()
        Me.ratesTextBox = New System.Windows.Forms.TextBox()
        Me.subjectComboBox = New System.Windows.Forms.ComboBox()
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sessionsComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SubjectsTableAdapter = New oneYoga.OYmembersTableAdapters.subjectsTableAdapter()
        Me.rateLabel = New System.Windows.Forms.Label()
        Me.saveRateButton = New System.Windows.Forms.Button()
        Me.CancelRateButton = New System.Windows.Forms.Button()
        Me.RatesTableAdapter = New oneYoga.OYmembersTableAdapters.ratesTableAdapter()
        Me.validityComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.RatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RatesBindingSource, "Id", True))
        Me.IDTextBox.Location = New System.Drawing.Point(97, 31)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 0
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
        'ratesTextBox
        '
        Me.ratesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RatesBindingSource, "rate", True))
        Me.ratesTextBox.Location = New System.Drawing.Point(97, 111)
        Me.ratesTextBox.Name = "ratesTextBox"
        Me.ratesTextBox.Size = New System.Drawing.Size(177, 20)
        Me.ratesTextBox.TabIndex = 1
        '
        'subjectComboBox
        '
        Me.subjectComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.subjectComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.subjectComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RatesBindingSource, "subject", True))
        Me.subjectComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RatesBindingSource, "subject", True))
        Me.subjectComboBox.DataSource = Me.SubjectsBindingSource
        Me.subjectComboBox.DisplayMember = "subject"
        Me.subjectComboBox.FormattingEnabled = True
        Me.subjectComboBox.Location = New System.Drawing.Point(97, 57)
        Me.subjectComboBox.Name = "subjectComboBox"
        Me.subjectComboBox.Size = New System.Drawing.Size(177, 21)
        Me.subjectComboBox.TabIndex = 2
        Me.subjectComboBox.ValueMember = "subject"
        '
        'SubjectsBindingSource
        '
        Me.SubjectsBindingSource.DataMember = "subjects"
        Me.SubjectsBindingSource.DataSource = Me.OYmembers
        '
        'sessionsComboBox
        '
        Me.sessionsComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RatesBindingSource, "numberOfSessions", True))
        Me.sessionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sessionsComboBox.FormattingEnabled = True
        Me.sessionsComboBox.Items.AddRange(New Object() {"10", "20", "30"})
        Me.sessionsComboBox.Location = New System.Drawing.Point(97, 84)
        Me.sessionsComboBox.Name = "sessionsComboBox"
        Me.sessionsComboBox.Size = New System.Drawing.Size(177, 21)
        Me.sessionsComboBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Sessions"
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'rateLabel
        '
        Me.rateLabel.AutoSize = True
        Me.rateLabel.Location = New System.Drawing.Point(58, 115)
        Me.rateLabel.Name = "rateLabel"
        Me.rateLabel.Size = New System.Drawing.Size(30, 13)
        Me.rateLabel.TabIndex = 7
        Me.rateLabel.Text = "Rate"
        '
        'saveRateButton
        '
        Me.saveRateButton.Location = New System.Drawing.Point(86, 175)
        Me.saveRateButton.Name = "saveRateButton"
        Me.saveRateButton.Size = New System.Drawing.Size(75, 23)
        Me.saveRateButton.TabIndex = 8
        Me.saveRateButton.Text = "Save"
        Me.saveRateButton.UseVisualStyleBackColor = True
        '
        'CancelRateButton
        '
        Me.CancelRateButton.Location = New System.Drawing.Point(167, 175)
        Me.CancelRateButton.Name = "CancelRateButton"
        Me.CancelRateButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelRateButton.TabIndex = 9
        Me.CancelRateButton.Text = "Cancel"
        Me.CancelRateButton.UseVisualStyleBackColor = True
        '
        'RatesTableAdapter
        '
        Me.RatesTableAdapter.ClearBeforeFill = True
        '
        'validityComboBox
        '
        Me.validityComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RatesBindingSource, "validity", True))
        Me.validityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.validityComboBox.FormattingEnabled = True
        Me.validityComboBox.Items.AddRange(New Object() {"1", "30", "60"})
        Me.validityComboBox.Location = New System.Drawing.Point(97, 138)
        Me.validityComboBox.Name = "validityComboBox"
        Me.validityComboBox.Size = New System.Drawing.Size(177, 21)
        Me.validityComboBox.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Validity"
        '
        'addNewRateSessionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 224)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.validityComboBox)
        Me.Controls.Add(Me.CancelRateButton)
        Me.Controls.Add(Me.saveRateButton)
        Me.Controls.Add(Me.rateLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sessionsComboBox)
        Me.Controls.Add(Me.subjectComboBox)
        Me.Controls.Add(Me.ratesTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Name = "addNewRateSessionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Yoga - Add New Rate"
        CType(Me.RatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ratesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents subjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents sessionsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents SubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As oneYoga.OYmembersTableAdapters.subjectsTableAdapter
    Friend WithEvents rateLabel As System.Windows.Forms.Label
    Friend WithEvents saveRateButton As System.Windows.Forms.Button
    Friend WithEvents CancelRateButton As System.Windows.Forms.Button
    Friend WithEvents RatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RatesTableAdapter As oneYoga.OYmembersTableAdapters.ratesTableAdapter
    Friend WithEvents validityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
