<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InquiryForm
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
        Dim DateLabel As System.Windows.Forms.Label
        Dim TimeLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirsNameLabel As System.Windows.Forms.Label
        Dim MiddleInitialLabel As System.Windows.Forms.Label
        Dim InquiryOnLabel As System.Windows.Forms.Label
        Dim SourceofInformationLabel As System.Windows.Forms.Label
        Dim ContactNumberLabel As System.Windows.Forms.Label
        Dim EmailAddressLabel As System.Windows.Forms.Label
        Dim ReceivedByLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InquiryForm))
        Me.OYinquiry = New oneYoga.OYinquiry()
        Me.InquiryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InquiryTableAdapter = New oneYoga.OYinquiryTableAdapters.inquiryTableAdapter()
        Me.TableAdapterManager = New oneYoga.OYinquiryTableAdapters.TableAdapterManager()
        Me.InquiryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InquiryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EditButton = New System.Windows.Forms.ToolStripButton()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TimeTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirsNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleInitialTextBox = New System.Windows.Forms.TextBox()
        Me.InquiryOnTextBox = New System.Windows.Forms.TextBox()
        Me.SourceofInformationTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailAddressTextBox = New System.Windows.Forms.TextBox()
        Me.ReceivedByComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        TimeLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirsNameLabel = New System.Windows.Forms.Label()
        MiddleInitialLabel = New System.Windows.Forms.Label()
        InquiryOnLabel = New System.Windows.Forms.Label()
        SourceofInformationLabel = New System.Windows.Forms.Label()
        ContactNumberLabel = New System.Windows.Forms.Label()
        EmailAddressLabel = New System.Windows.Forms.Label()
        ReceivedByLabel = New System.Windows.Forms.Label()
        CType(Me.OYinquiry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InquiryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InquiryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InquiryBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(467, 202)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 23
        DateLabel.Text = "Date:"
        '
        'TimeLabel
        '
        TimeLabel.AutoSize = True
        TimeLabel.Location = New System.Drawing.Point(467, 293)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New System.Drawing.Size(33, 13)
        TimeLabel.TabIndex = 25
        TimeLabel.Text = "Time:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(25, 169)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 27
        LastNameLabel.Text = "Last Name:"
        '
        'FirsNameLabel
        '
        FirsNameLabel.AutoSize = True
        FirsNameLabel.Location = New System.Drawing.Point(301, 169)
        FirsNameLabel.Name = "FirsNameLabel"
        FirsNameLabel.Size = New System.Drawing.Size(60, 13)
        FirsNameLabel.TabIndex = 29
        FirsNameLabel.Text = "First Name:"
        '
        'MiddleInitialLabel
        '
        MiddleInitialLabel.AutoSize = True
        MiddleInitialLabel.Location = New System.Drawing.Point(579, 169)
        MiddleInitialLabel.Name = "MiddleInitialLabel"
        MiddleInitialLabel.Size = New System.Drawing.Size(68, 13)
        MiddleInitialLabel.TabIndex = 31
        MiddleInitialLabel.Text = "Middle Initial:"
        '
        'InquiryOnLabel
        '
        InquiryOnLabel.AutoSize = True
        InquiryOnLabel.Location = New System.Drawing.Point(25, 202)
        InquiryOnLabel.Name = "InquiryOnLabel"
        InquiryOnLabel.Size = New System.Drawing.Size(58, 13)
        InquiryOnLabel.TabIndex = 33
        InquiryOnLabel.Text = "Inquiry On:"
        '
        'SourceofInformationLabel
        '
        SourceofInformationLabel.AutoSize = True
        SourceofInformationLabel.Location = New System.Drawing.Point(25, 233)
        SourceofInformationLabel.Name = "SourceofInformationLabel"
        SourceofInformationLabel.Size = New System.Drawing.Size(111, 13)
        SourceofInformationLabel.TabIndex = 35
        SourceofInformationLabel.Text = "Source of Information:"
        '
        'ContactNumberLabel
        '
        ContactNumberLabel.AutoSize = True
        ContactNumberLabel.Location = New System.Drawing.Point(448, 263)
        ContactNumberLabel.Name = "ContactNumberLabel"
        ContactNumberLabel.Size = New System.Drawing.Size(87, 13)
        ContactNumberLabel.TabIndex = 37
        ContactNumberLabel.Text = "Contact Number:"
        '
        'EmailAddressLabel
        '
        EmailAddressLabel.AutoSize = True
        EmailAddressLabel.Location = New System.Drawing.Point(25, 263)
        EmailAddressLabel.Name = "EmailAddressLabel"
        EmailAddressLabel.Size = New System.Drawing.Size(76, 13)
        EmailAddressLabel.TabIndex = 39
        EmailAddressLabel.Text = "Email Address:"
        '
        'ReceivedByLabel
        '
        ReceivedByLabel.AutoSize = True
        ReceivedByLabel.Location = New System.Drawing.Point(25, 293)
        ReceivedByLabel.Name = "ReceivedByLabel"
        ReceivedByLabel.Size = New System.Drawing.Size(71, 13)
        ReceivedByLabel.TabIndex = 41
        ReceivedByLabel.Text = "Received By:"
        '
        'OYinquiry
        '
        Me.OYinquiry.DataSetName = "OYinquiry"
        Me.OYinquiry.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InquiryBindingSource
        '
        Me.InquiryBindingSource.DataMember = "inquiry"
        Me.InquiryBindingSource.DataSource = Me.OYinquiry
        '
        'InquiryTableAdapter
        '
        Me.InquiryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.inquiryTableAdapter = Me.InquiryTableAdapter
        Me.TableAdapterManager.UpdateOrder = oneYoga.OYinquiryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InquiryBindingNavigator
        '
        Me.InquiryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InquiryBindingNavigator.BindingSource = Me.InquiryBindingSource
        Me.InquiryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InquiryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InquiryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InquiryBindingNavigatorSaveItem, Me.EditButton})
        Me.InquiryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InquiryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InquiryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InquiryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InquiryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InquiryBindingNavigator.Name = "InquiryBindingNavigator"
        Me.InquiryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InquiryBindingNavigator.Size = New System.Drawing.Size(719, 25)
        Me.InquiryBindingNavigator.TabIndex = 0
        Me.InquiryBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'InquiryBindingNavigatorSaveItem
        '
        Me.InquiryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InquiryBindingNavigatorSaveItem.Image = CType(resources.GetObject("InquiryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InquiryBindingNavigatorSaveItem.Name = "InquiryBindingNavigatorSaveItem"
        Me.InquiryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InquiryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EditButton
        '
        Me.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditButton.Image = CType(resources.GetObject("EditButton.Image"), System.Drawing.Image)
        Me.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(31, 22)
        Me.EditButton.Text = "Edit"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InquiryBindingSource, "Date", True))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(506, 196)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 24
        '
        'TimeTextBox
        '
        Me.TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InquiryBindingSource, "Time", True))
        Me.TimeTextBox.Location = New System.Drawing.Point(506, 290)
        Me.TimeTextBox.Name = "TimeTextBox"
        Me.TimeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TimeTextBox.TabIndex = 26
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InquiryBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(92, 166)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LastNameTextBox.TabIndex = 28
        '
        'FirsNameTextBox
        '
        Me.FirsNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InquiryBindingSource, "FirsName", True))
        Me.FirsNameTextBox.Location = New System.Drawing.Point(364, 166)
        Me.FirsNameTextBox.Name = "FirsNameTextBox"
        Me.FirsNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirsNameTextBox.TabIndex = 30
        '
        'MiddleInitialTextBox
        '
        Me.MiddleInitialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InquiryBindingSource, "MiddleInitial", True))
        Me.MiddleInitialTextBox.Location = New System.Drawing.Point(653, 166)
        Me.MiddleInitialTextBox.Name = "MiddleInitialTextBox"
        Me.MiddleInitialTextBox.Size = New System.Drawing.Size(53, 20)
        Me.MiddleInitialTextBox.TabIndex = 32
        '
        'InquiryOnTextBox
        '
        Me.InquiryOnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InquiryBindingSource, "InquiryOn", True))
        Me.InquiryOnTextBox.Location = New System.Drawing.Point(92, 199)
        Me.InquiryOnTextBox.Name = "InquiryOnTextBox"
        Me.InquiryOnTextBox.Size = New System.Drawing.Size(369, 20)
        Me.InquiryOnTextBox.TabIndex = 34
        '
        'SourceofInformationTextBox
        '
        Me.SourceofInformationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InquiryBindingSource, "SourceofInformation", True))
        Me.SourceofInformationTextBox.Location = New System.Drawing.Point(139, 230)
        Me.SourceofInformationTextBox.Name = "SourceofInformationTextBox"
        Me.SourceofInformationTextBox.Size = New System.Drawing.Size(567, 20)
        Me.SourceofInformationTextBox.TabIndex = 36
        '
        'ContactNumberTextBox
        '
        Me.ContactNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InquiryBindingSource, "ContactNumber", True))
        Me.ContactNumberTextBox.Location = New System.Drawing.Point(541, 260)
        Me.ContactNumberTextBox.Name = "ContactNumberTextBox"
        Me.ContactNumberTextBox.Size = New System.Drawing.Size(165, 20)
        Me.ContactNumberTextBox.TabIndex = 38
        '
        'EmailAddressTextBox
        '
        Me.EmailAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InquiryBindingSource, "EmailAddress", True))
        Me.EmailAddressTextBox.Location = New System.Drawing.Point(107, 260)
        Me.EmailAddressTextBox.Name = "EmailAddressTextBox"
        Me.EmailAddressTextBox.Size = New System.Drawing.Size(335, 20)
        Me.EmailAddressTextBox.TabIndex = 40
        '
        'ReceivedByComboBox
        '
        Me.ReceivedByComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InquiryBindingSource, "ReceivedBy", True))
        Me.ReceivedByComboBox.FormattingEnabled = True
        Me.ReceivedByComboBox.Location = New System.Drawing.Point(107, 290)
        Me.ReceivedByComboBox.Name = "ReceivedByComboBox"
        Me.ReceivedByComboBox.Size = New System.Drawing.Size(354, 21)
        Me.ReceivedByComboBox.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(275, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 25)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "INQUIRY FORM"
        '
        'InquiryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 376)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(TimeLabel)
        Me.Controls.Add(Me.TimeTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirsNameLabel)
        Me.Controls.Add(Me.FirsNameTextBox)
        Me.Controls.Add(MiddleInitialLabel)
        Me.Controls.Add(Me.MiddleInitialTextBox)
        Me.Controls.Add(InquiryOnLabel)
        Me.Controls.Add(Me.InquiryOnTextBox)
        Me.Controls.Add(SourceofInformationLabel)
        Me.Controls.Add(Me.SourceofInformationTextBox)
        Me.Controls.Add(ContactNumberLabel)
        Me.Controls.Add(Me.ContactNumberTextBox)
        Me.Controls.Add(EmailAddressLabel)
        Me.Controls.Add(Me.EmailAddressTextBox)
        Me.Controls.Add(ReceivedByLabel)
        Me.Controls.Add(Me.ReceivedByComboBox)
        Me.Controls.Add(Me.InquiryBindingNavigator)
        Me.Name = "InquiryForm"
        Me.Text = "InquiryForm"
        CType(Me.OYinquiry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InquiryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InquiryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InquiryBindingNavigator.ResumeLayout(False)
        Me.InquiryBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OYinquiry As oneYoga.OYinquiry
    Friend WithEvents InquiryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InquiryTableAdapter As oneYoga.OYinquiryTableAdapters.inquiryTableAdapter
    Friend WithEvents TableAdapterManager As oneYoga.OYinquiryTableAdapters.TableAdapterManager
    Friend WithEvents InquiryBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InquiryBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents TimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirsNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MiddleInitialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents InquiryOnTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SourceofInformationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ReceivedByComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
