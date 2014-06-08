<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class results
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
        Dim MemberIDLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim MILabel As System.Windows.Forms.Label
        Dim NicknameLabel As System.Windows.Forms.Label
        Dim HomeAddrLabel As System.Windows.Forms.Label
        Dim ZipcodeLabel As System.Windows.Forms.Label
        Dim OfficeAddrLabel As System.Windows.Forms.Label
        Dim BirthdateLabel As System.Windows.Forms.Label
        Dim CivilStatusLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim MobileNoLabel As System.Windows.Forms.Label
        Dim OtherContactLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim ContactPersonLabel As System.Windows.Forms.Label
        Dim ContactPersonNoLabel As System.Windows.Forms.Label
        Dim ContactPersonRelationshipLabel As System.Windows.Forms.Label
        Dim ContactPersonAddrLabel As System.Windows.Forms.Label
        Dim AsthmaLabel As System.Windows.Forms.Label
        Dim EpilepsyLabel As System.Windows.Forms.Label
        Dim HighBloodLabel As System.Windows.Forms.Label
        Dim HeartProblemLabel As System.Windows.Forms.Label
        Dim BackpainLabel As System.Windows.Forms.Label
        Dim PregnancyLabel As System.Windows.Forms.Label
        Dim OtherHealthConditionLabel As System.Windows.Forms.Label
        Dim PrescribedMedicationExplainLabel As System.Windows.Forms.Label
        Dim PhysicianOrHospitalCareLabel As System.Windows.Forms.Label
        Dim SurgeryLabel As System.Windows.Forms.Label
        Dim SurgeryExplainLabel As System.Windows.Forms.Label
        Dim OYOthersLabel As System.Windows.Forms.Label
        Dim FriendExplainLabel As System.Windows.Forms.Label
        Dim DateRegisteredLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(results))
        Me.OYmembers = New oneYoga.OYmembers()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter = New oneYoga.OYmembersTableAdapters.membersTableAdapter()
        Me.TableAdapterManager = New oneYoga.OYmembersTableAdapters.TableAdapterManager()
        Me.MembersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.EditButton = New System.Windows.Forms.ToolStripButton()
        Me.MembersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.MemberIDTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.MITextBox = New System.Windows.Forms.TextBox()
        Me.NicknameTextBox = New System.Windows.Forms.TextBox()
        Me.HomeAddrTextBox = New System.Windows.Forms.TextBox()
        Me.ZipcodeTextBox = New System.Windows.Forms.TextBox()
        Me.OfficeAddrTextBox = New System.Windows.Forms.TextBox()
        Me.BirthdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MobileNoTextBox = New System.Windows.Forms.TextBox()
        Me.OtherContactTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ContactPersonTextBox = New System.Windows.Forms.TextBox()
        Me.ContactPersonNoTextBox = New System.Windows.Forms.TextBox()
        Me.ContactPersonRelationshipTextBox = New System.Windows.Forms.TextBox()
        Me.ContactPersonAddrTextBox = New System.Windows.Forms.TextBox()
        Me.AsthmaCheckBox = New System.Windows.Forms.CheckBox()
        Me.EpilepsyCheckBox = New System.Windows.Forms.CheckBox()
        Me.HighBloodCheckBox = New System.Windows.Forms.CheckBox()
        Me.HeartProblemCheckBox = New System.Windows.Forms.CheckBox()
        Me.BackpainCheckBox = New System.Windows.Forms.CheckBox()
        Me.PregnancyCheckBox = New System.Windows.Forms.CheckBox()
        Me.OtherHealthConditionTextBox = New System.Windows.Forms.TextBox()
        Me.PrescribedMedicationCheckBox = New System.Windows.Forms.CheckBox()
        Me.PrescribedMedicationExplainTextBox = New System.Windows.Forms.TextBox()
        Me.PhysicianOrHospitalCareTextBox = New System.Windows.Forms.TextBox()
        Me.SurgeryCheckBox = New System.Windows.Forms.CheckBox()
        Me.SurgeryExplainTextBox = New System.Windows.Forms.TextBox()
        Me.OYinternetCheckBox = New System.Windows.Forms.CheckBox()
        Me.OYFlyerCheckBox = New System.Windows.Forms.CheckBox()
        Me.OYNewspaperCheckBox = New System.Windows.Forms.CheckBox()
        Me.OYFriendCheckBox = New System.Windows.Forms.CheckBox()
        Me.OYBrochureCheckBox = New System.Windows.Forms.CheckBox()
        Me.OYOthersTextBox = New System.Windows.Forms.TextBox()
        Me.NewspaperExplainTextBox = New System.Windows.Forms.TextBox()
        Me.FriendExplainTextBox = New System.Windows.Forms.TextBox()
        Me.DateRegisteredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Status_ComboBox = New System.Windows.Forms.ComboBox()
        Me.Sex_ComboBox = New System.Windows.Forms.ComboBox()
        Me.PersonalLabel = New System.Windows.Forms.Label()
        Me.emergency_Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.healthLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.newspaperExplain_Label = New System.Windows.Forms.Label()
        Me.Close_button = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        MemberIDLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        MILabel = New System.Windows.Forms.Label()
        NicknameLabel = New System.Windows.Forms.Label()
        HomeAddrLabel = New System.Windows.Forms.Label()
        ZipcodeLabel = New System.Windows.Forms.Label()
        OfficeAddrLabel = New System.Windows.Forms.Label()
        BirthdateLabel = New System.Windows.Forms.Label()
        CivilStatusLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        MobileNoLabel = New System.Windows.Forms.Label()
        OtherContactLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        ContactPersonLabel = New System.Windows.Forms.Label()
        ContactPersonNoLabel = New System.Windows.Forms.Label()
        ContactPersonRelationshipLabel = New System.Windows.Forms.Label()
        ContactPersonAddrLabel = New System.Windows.Forms.Label()
        AsthmaLabel = New System.Windows.Forms.Label()
        EpilepsyLabel = New System.Windows.Forms.Label()
        HighBloodLabel = New System.Windows.Forms.Label()
        HeartProblemLabel = New System.Windows.Forms.Label()
        BackpainLabel = New System.Windows.Forms.Label()
        PregnancyLabel = New System.Windows.Forms.Label()
        OtherHealthConditionLabel = New System.Windows.Forms.Label()
        PrescribedMedicationExplainLabel = New System.Windows.Forms.Label()
        PhysicianOrHospitalCareLabel = New System.Windows.Forms.Label()
        SurgeryLabel = New System.Windows.Forms.Label()
        SurgeryExplainLabel = New System.Windows.Forms.Label()
        OYOthersLabel = New System.Windows.Forms.Label()
        FriendExplainLabel = New System.Windows.Forms.Label()
        DateRegisteredLabel = New System.Windows.Forms.Label()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MembersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'MemberIDLabel
        '
        MemberIDLabel.AutoSize = True
        MemberIDLabel.Location = New System.Drawing.Point(31, 116)
        MemberIDLabel.Name = "MemberIDLabel"
        MemberIDLabel.Size = New System.Drawing.Size(62, 13)
        MemberIDLabel.TabIndex = 3
        MemberIDLabel.Text = "Member ID:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(31, 139)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(61, 13)
        SurnameLabel.TabIndex = 5
        SurnameLabel.Text = "Last Name:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(304, 140)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(60, 13)
        FirstnameLabel.TabIndex = 7
        FirstnameLabel.Text = "First Name:"
        '
        'MILabel
        '
        MILabel.AutoSize = True
        MILabel.Location = New System.Drawing.Point(574, 139)
        MILabel.Name = "MILabel"
        MILabel.Size = New System.Drawing.Size(22, 13)
        MILabel.TabIndex = 9
        MILabel.Text = "MI:"
        '
        'NicknameLabel
        '
        NicknameLabel.AutoSize = True
        NicknameLabel.Location = New System.Drawing.Point(689, 138)
        NicknameLabel.Name = "NicknameLabel"
        NicknameLabel.Size = New System.Drawing.Size(58, 13)
        NicknameLabel.TabIndex = 11
        NicknameLabel.Text = "Nickname:"
        '
        'HomeAddrLabel
        '
        HomeAddrLabel.AutoSize = True
        HomeAddrLabel.Location = New System.Drawing.Point(31, 163)
        HomeAddrLabel.Name = "HomeAddrLabel"
        HomeAddrLabel.Size = New System.Drawing.Size(79, 13)
        HomeAddrLabel.TabIndex = 13
        HomeAddrLabel.Text = "Home Address:"
        '
        'ZipcodeLabel
        '
        ZipcodeLabel.AutoSize = True
        ZipcodeLabel.Location = New System.Drawing.Point(696, 160)
        ZipcodeLabel.Name = "ZipcodeLabel"
        ZipcodeLabel.Size = New System.Drawing.Size(49, 13)
        ZipcodeLabel.TabIndex = 15
        ZipcodeLabel.Text = "Zipcode:"
        '
        'OfficeAddrLabel
        '
        OfficeAddrLabel.AutoSize = True
        OfficeAddrLabel.Location = New System.Drawing.Point(31, 186)
        OfficeAddrLabel.Name = "OfficeAddrLabel"
        OfficeAddrLabel.Size = New System.Drawing.Size(79, 13)
        OfficeAddrLabel.TabIndex = 17
        OfficeAddrLabel.Text = "Office Address:"
        '
        'BirthdateLabel
        '
        BirthdateLabel.AutoSize = True
        BirthdateLabel.Location = New System.Drawing.Point(31, 210)
        BirthdateLabel.Name = "BirthdateLabel"
        BirthdateLabel.Size = New System.Drawing.Size(52, 13)
        BirthdateLabel.TabIndex = 19
        BirthdateLabel.Text = "Birthdate:"
        '
        'CivilStatusLabel
        '
        CivilStatusLabel.AutoSize = True
        CivilStatusLabel.Location = New System.Drawing.Point(284, 210)
        CivilStatusLabel.Name = "CivilStatusLabel"
        CivilStatusLabel.Size = New System.Drawing.Size(40, 13)
        CivilStatusLabel.TabIndex = 21
        CivilStatusLabel.Text = "Status:"
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(443, 211)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(28, 13)
        SexLabel.TabIndex = 23
        SexLabel.Text = "Sex:"
        '
        'MobileNoLabel
        '
        MobileNoLabel.AutoSize = True
        MobileNoLabel.Location = New System.Drawing.Point(598, 211)
        MobileNoLabel.Name = "MobileNoLabel"
        MobileNoLabel.Size = New System.Drawing.Size(81, 13)
        MobileNoLabel.TabIndex = 25
        MobileNoLabel.Text = "Mobile Number:"
        '
        'OtherContactLabel
        '
        OtherContactLabel.AutoSize = True
        OtherContactLabel.Location = New System.Drawing.Point(31, 236)
        OtherContactLabel.Name = "OtherContactLabel"
        OtherContactLabel.Size = New System.Drawing.Size(86, 13)
        OtherContactLabel.TabIndex = 27
        OtherContactLabel.Text = "Other Contact #:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(314, 236)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(76, 13)
        EmailLabel.TabIndex = 29
        EmailLabel.Text = "Email Address:"
        '
        'ContactPersonLabel
        '
        ContactPersonLabel.AutoSize = True
        ContactPersonLabel.Location = New System.Drawing.Point(31, 294)
        ContactPersonLabel.Name = "ContactPersonLabel"
        ContactPersonLabel.Size = New System.Drawing.Size(83, 13)
        ContactPersonLabel.TabIndex = 31
        ContactPersonLabel.Text = "Contact Person:"
        '
        'ContactPersonNoLabel
        '
        ContactPersonNoLabel.AutoSize = True
        ContactPersonNoLabel.Location = New System.Drawing.Point(30, 315)
        ContactPersonNoLabel.Name = "ContactPersonNoLabel"
        ContactPersonNoLabel.Size = New System.Drawing.Size(87, 13)
        ContactPersonNoLabel.TabIndex = 33
        ContactPersonNoLabel.Text = "Contact Number:"
        '
        'ContactPersonRelationshipLabel
        '
        ContactPersonRelationshipLabel.AutoSize = True
        ContactPersonRelationshipLabel.Location = New System.Drawing.Point(611, 293)
        ContactPersonRelationshipLabel.Name = "ContactPersonRelationshipLabel"
        ContactPersonRelationshipLabel.Size = New System.Drawing.Size(68, 13)
        ContactPersonRelationshipLabel.TabIndex = 35
        ContactPersonRelationshipLabel.Text = "Relationship:"
        '
        'ContactPersonAddrLabel
        '
        ContactPersonAddrLabel.AutoSize = True
        ContactPersonAddrLabel.Location = New System.Drawing.Point(323, 318)
        ContactPersonAddrLabel.Name = "ContactPersonAddrLabel"
        ContactPersonAddrLabel.Size = New System.Drawing.Size(48, 13)
        ContactPersonAddrLabel.TabIndex = 37
        ContactPersonAddrLabel.Text = "Address:"
        '
        'AsthmaLabel
        '
        AsthmaLabel.AutoSize = True
        AsthmaLabel.Location = New System.Drawing.Point(60, 388)
        AsthmaLabel.Name = "AsthmaLabel"
        AsthmaLabel.Size = New System.Drawing.Size(42, 13)
        AsthmaLabel.TabIndex = 39
        AsthmaLabel.Text = "Asthma"
        '
        'EpilepsyLabel
        '
        EpilepsyLabel.AutoSize = True
        EpilepsyLabel.Location = New System.Drawing.Point(132, 389)
        EpilepsyLabel.Name = "EpilepsyLabel"
        EpilepsyLabel.Size = New System.Drawing.Size(46, 13)
        EpilepsyLabel.TabIndex = 41
        EpilepsyLabel.Text = "Epilepsy"
        '
        'HighBloodLabel
        '
        HighBloodLabel.AutoSize = True
        HighBloodLabel.Location = New System.Drawing.Point(207, 389)
        HighBloodLabel.Name = "HighBloodLabel"
        HighBloodLabel.Size = New System.Drawing.Size(103, 13)
        HighBloodLabel.TabIndex = 43
        HighBloodLabel.Text = "High Blood Pressure"
        '
        'HeartProblemLabel
        '
        HeartProblemLabel.AutoSize = True
        HeartProblemLabel.Location = New System.Drawing.Point(339, 390)
        HeartProblemLabel.Name = "HeartProblemLabel"
        HeartProblemLabel.Size = New System.Drawing.Size(74, 13)
        HeartProblemLabel.TabIndex = 45
        HeartProblemLabel.Text = "Heart Problem"
        '
        'BackpainLabel
        '
        BackpainLabel.AutoSize = True
        BackpainLabel.Location = New System.Drawing.Point(441, 390)
        BackpainLabel.Name = "BackpainLabel"
        BackpainLabel.Size = New System.Drawing.Size(52, 13)
        BackpainLabel.TabIndex = 47
        BackpainLabel.Text = "Backpain"
        '
        'PregnancyLabel
        '
        PregnancyLabel.AutoSize = True
        PregnancyLabel.Location = New System.Drawing.Point(520, 390)
        PregnancyLabel.Name = "PregnancyLabel"
        PregnancyLabel.Size = New System.Drawing.Size(58, 13)
        PregnancyLabel.TabIndex = 49
        PregnancyLabel.Text = "Pregnancy"
        '
        'OtherHealthConditionLabel
        '
        OtherHealthConditionLabel.AutoSize = True
        OtherHealthConditionLabel.Location = New System.Drawing.Point(44, 414)
        OtherHealthConditionLabel.Name = "OtherHealthConditionLabel"
        OtherHealthConditionLabel.Size = New System.Drawing.Size(115, 13)
        OtherHealthConditionLabel.TabIndex = 51
        OtherHealthConditionLabel.Text = "Others (Please specify)"
        '
        'PrescribedMedicationExplainLabel
        '
        PrescribedMedicationExplainLabel.AutoSize = True
        PrescribedMedicationExplainLabel.Location = New System.Drawing.Point(45, 462)
        PrescribedMedicationExplainLabel.Name = "PrescribedMedicationExplainLabel"
        PrescribedMedicationExplainLabel.Size = New System.Drawing.Size(108, 13)
        PrescribedMedicationExplainLabel.TabIndex = 55
        PrescribedMedicationExplainLabel.Text = "If yes, please explain:"
        '
        'PhysicianOrHospitalCareLabel
        '
        PhysicianOrHospitalCareLabel.AutoSize = True
        PhysicianOrHospitalCareLabel.Location = New System.Drawing.Point(34, 486)
        PhysicianOrHospitalCareLabel.Name = "PhysicianOrHospitalCareLabel"
        PhysicianOrHospitalCareLabel.Size = New System.Drawing.Size(449, 13)
        PhysicianOrHospitalCareLabel.TabIndex = 57
        PhysicianOrHospitalCareLabel.Text = "3. If you are presently under the care of physician, or have been hospitalized, p" & _
    "lease describe."
        '
        'SurgeryLabel
        '
        SurgeryLabel.AutoSize = True
        SurgeryLabel.Location = New System.Drawing.Point(35, 526)
        SurgeryLabel.Name = "SurgeryLabel"
        SurgeryLabel.Size = New System.Drawing.Size(234, 13)
        SurgeryLabel.TabIndex = 59
        SurgeryLabel.Text = "4. Have you undergone any surgery in the past?"
        '
        'SurgeryExplainLabel
        '
        SurgeryExplainLabel.AutoSize = True
        SurgeryExplainLabel.Location = New System.Drawing.Point(49, 548)
        SurgeryExplainLabel.Name = "SurgeryExplainLabel"
        SurgeryExplainLabel.Size = New System.Drawing.Size(108, 13)
        SurgeryExplainLabel.TabIndex = 61
        SurgeryExplainLabel.Text = "If yes, please explain:"
        '
        'OYOthersLabel
        '
        OYOthersLabel.AutoSize = True
        OYOthersLabel.Location = New System.Drawing.Point(191, 672)
        OYOthersLabel.Name = "OYOthersLabel"
        OYOthersLabel.Size = New System.Drawing.Size(41, 13)
        OYOthersLabel.TabIndex = 73
        OYOthersLabel.Text = "Others:"
        '
        'FriendExplainLabel
        '
        FriendExplainLabel.AutoSize = True
        FriendExplainLabel.Location = New System.Drawing.Point(363, 653)
        FriendExplainLabel.Name = "FriendExplainLabel"
        FriendExplainLabel.Size = New System.Drawing.Size(74, 13)
        FriendExplainLabel.TabIndex = 77
        FriendExplainLabel.Text = "If friend, who?"
        '
        'DateRegisteredLabel
        '
        DateRegisteredLabel.AutoSize = True
        DateRegisteredLabel.Location = New System.Drawing.Point(45, 704)
        DateRegisteredLabel.Name = "DateRegisteredLabel"
        DateRegisteredLabel.Size = New System.Drawing.Size(87, 13)
        DateRegisteredLabel.TabIndex = 79
        DateRegisteredLabel.Text = "Date Registered:"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.membersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.UpdateOrder = oneYoga.OYmembersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'MembersBindingNavigator
        '
        Me.MembersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MembersBindingNavigator.BindingSource = Me.MembersBindingSource
        Me.MembersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MembersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MembersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.EditButton, Me.BindingNavigatorDeleteItem, Me.MembersBindingNavigatorSaveItem})
        Me.MembersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MembersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MembersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MembersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MembersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MembersBindingNavigator.Name = "MembersBindingNavigator"
        Me.MembersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MembersBindingNavigator.Size = New System.Drawing.Size(925, 25)
        Me.MembersBindingNavigator.TabIndex = 3
        Me.MembersBindingNavigator.Text = "BindingNavigator1"
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
        'EditButton
        '
        Me.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditButton.Image = CType(resources.GetObject("EditButton.Image"), System.Drawing.Image)
        Me.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(31, 22)
        Me.EditButton.Text = "Edit"
        '
        'MembersBindingNavigatorSaveItem
        '
        Me.MembersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MembersBindingNavigatorSaveItem.Image = CType(resources.GetObject("MembersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MembersBindingNavigatorSaveItem.Name = "MembersBindingNavigatorSaveItem"
        Me.MembersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MembersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'MemberIDTextBox
        '
        Me.MemberIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "memberID", True))
        Me.MemberIDTextBox.Enabled = False
        Me.MemberIDTextBox.Location = New System.Drawing.Point(98, 113)
        Me.MemberIDTextBox.Name = "MemberIDTextBox"
        Me.MemberIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MemberIDTextBox.TabIndex = 4
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(98, 136)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SurnameTextBox.TabIndex = 6
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "firstname", True))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(366, 136)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstnameTextBox.TabIndex = 8
        '
        'MITextBox
        '
        Me.MITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "MI", True))
        Me.MITextBox.Location = New System.Drawing.Point(599, 135)
        Me.MITextBox.Name = "MITextBox"
        Me.MITextBox.Size = New System.Drawing.Size(85, 20)
        Me.MITextBox.TabIndex = 10
        '
        'NicknameTextBox
        '
        Me.NicknameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "nickname", True))
        Me.NicknameTextBox.Location = New System.Drawing.Point(749, 134)
        Me.NicknameTextBox.Name = "NicknameTextBox"
        Me.NicknameTextBox.Size = New System.Drawing.Size(134, 20)
        Me.NicknameTextBox.TabIndex = 12
        '
        'HomeAddrTextBox
        '
        Me.HomeAddrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "homeAddr", True))
        Me.HomeAddrTextBox.Location = New System.Drawing.Point(111, 159)
        Me.HomeAddrTextBox.Name = "HomeAddrTextBox"
        Me.HomeAddrTextBox.Size = New System.Drawing.Size(573, 20)
        Me.HomeAddrTextBox.TabIndex = 14
        '
        'ZipcodeTextBox
        '
        Me.ZipcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "zipcode", True))
        Me.ZipcodeTextBox.Location = New System.Drawing.Point(749, 158)
        Me.ZipcodeTextBox.Name = "ZipcodeTextBox"
        Me.ZipcodeTextBox.Size = New System.Drawing.Size(134, 20)
        Me.ZipcodeTextBox.TabIndex = 16
        '
        'OfficeAddrTextBox
        '
        Me.OfficeAddrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "officeAddr", True))
        Me.OfficeAddrTextBox.Location = New System.Drawing.Point(111, 183)
        Me.OfficeAddrTextBox.Name = "OfficeAddrTextBox"
        Me.OfficeAddrTextBox.Size = New System.Drawing.Size(772, 20)
        Me.OfficeAddrTextBox.TabIndex = 18
        '
        'BirthdateDateTimePicker
        '
        Me.BirthdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MembersBindingSource, "birthdate", True))
        Me.BirthdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "birthdate", True))
        Me.BirthdateDateTimePicker.Location = New System.Drawing.Point(80, 207)
        Me.BirthdateDateTimePicker.Name = "BirthdateDateTimePicker"
        Me.BirthdateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.BirthdateDateTimePicker.TabIndex = 20
        '
        'MobileNoTextBox
        '
        Me.MobileNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "mobileNo", True))
        Me.MobileNoTextBox.Location = New System.Drawing.Point(679, 207)
        Me.MobileNoTextBox.Name = "MobileNoTextBox"
        Me.MobileNoTextBox.Size = New System.Drawing.Size(204, 20)
        Me.MobileNoTextBox.TabIndex = 26
        '
        'OtherContactTextBox
        '
        Me.OtherContactTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "otherContact", True))
        Me.OtherContactTextBox.Location = New System.Drawing.Point(120, 233)
        Me.OtherContactTextBox.Name = "OtherContactTextBox"
        Me.OtherContactTextBox.Size = New System.Drawing.Size(188, 20)
        Me.OtherContactTextBox.TabIndex = 28
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(393, 233)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(490, 20)
        Me.EmailTextBox.TabIndex = 30
        '
        'ContactPersonTextBox
        '
        Me.ContactPersonTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "contactPerson", True))
        Me.ContactPersonTextBox.Location = New System.Drawing.Point(113, 290)
        Me.ContactPersonTextBox.Name = "ContactPersonTextBox"
        Me.ContactPersonTextBox.Size = New System.Drawing.Size(492, 20)
        Me.ContactPersonTextBox.TabIndex = 32
        '
        'ContactPersonNoTextBox
        '
        Me.ContactPersonNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "contactPersonNo", True))
        Me.ContactPersonNoTextBox.Location = New System.Drawing.Point(116, 314)
        Me.ContactPersonNoTextBox.Name = "ContactPersonNoTextBox"
        Me.ContactPersonNoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ContactPersonNoTextBox.TabIndex = 34
        '
        'ContactPersonRelationshipTextBox
        '
        Me.ContactPersonRelationshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "contactPersonRelationship", True))
        Me.ContactPersonRelationshipTextBox.Location = New System.Drawing.Point(683, 289)
        Me.ContactPersonRelationshipTextBox.Name = "ContactPersonRelationshipTextBox"
        Me.ContactPersonRelationshipTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ContactPersonRelationshipTextBox.TabIndex = 36
        '
        'ContactPersonAddrTextBox
        '
        Me.ContactPersonAddrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "contactPersonAddr", True))
        Me.ContactPersonAddrTextBox.Location = New System.Drawing.Point(373, 314)
        Me.ContactPersonAddrTextBox.Name = "ContactPersonAddrTextBox"
        Me.ContactPersonAddrTextBox.Size = New System.Drawing.Size(510, 20)
        Me.ContactPersonAddrTextBox.TabIndex = 38
        '
        'AsthmaCheckBox
        '
        Me.AsthmaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "asthma", True))
        Me.AsthmaCheckBox.Location = New System.Drawing.Point(47, 384)
        Me.AsthmaCheckBox.Name = "AsthmaCheckBox"
        Me.AsthmaCheckBox.Size = New System.Drawing.Size(23, 24)
        Me.AsthmaCheckBox.TabIndex = 40
        Me.AsthmaCheckBox.UseVisualStyleBackColor = True
        '
        'EpilepsyCheckBox
        '
        Me.EpilepsyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "epilepsy", True))
        Me.EpilepsyCheckBox.Location = New System.Drawing.Point(118, 384)
        Me.EpilepsyCheckBox.Name = "EpilepsyCheckBox"
        Me.EpilepsyCheckBox.Size = New System.Drawing.Size(14, 24)
        Me.EpilepsyCheckBox.TabIndex = 42
        Me.EpilepsyCheckBox.UseVisualStyleBackColor = True
        '
        'HighBloodCheckBox
        '
        Me.HighBloodCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "highBlood", True))
        Me.HighBloodCheckBox.Location = New System.Drawing.Point(194, 384)
        Me.HighBloodCheckBox.Name = "HighBloodCheckBox"
        Me.HighBloodCheckBox.Size = New System.Drawing.Size(18, 24)
        Me.HighBloodCheckBox.TabIndex = 44
        Me.HighBloodCheckBox.UseVisualStyleBackColor = True
        '
        'HeartProblemCheckBox
        '
        Me.HeartProblemCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "heartProblem", True))
        Me.HeartProblemCheckBox.Location = New System.Drawing.Point(326, 385)
        Me.HeartProblemCheckBox.Name = "HeartProblemCheckBox"
        Me.HeartProblemCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.HeartProblemCheckBox.TabIndex = 46
        Me.HeartProblemCheckBox.UseVisualStyleBackColor = True
        '
        'BackpainCheckBox
        '
        Me.BackpainCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "backpain", True))
        Me.BackpainCheckBox.Location = New System.Drawing.Point(428, 385)
        Me.BackpainCheckBox.Name = "BackpainCheckBox"
        Me.BackpainCheckBox.Size = New System.Drawing.Size(14, 24)
        Me.BackpainCheckBox.TabIndex = 48
        Me.BackpainCheckBox.UseVisualStyleBackColor = True
        '
        'PregnancyCheckBox
        '
        Me.PregnancyCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "pregnancy", True))
        Me.PregnancyCheckBox.Location = New System.Drawing.Point(506, 385)
        Me.PregnancyCheckBox.Name = "PregnancyCheckBox"
        Me.PregnancyCheckBox.Size = New System.Drawing.Size(14, 24)
        Me.PregnancyCheckBox.TabIndex = 50
        Me.PregnancyCheckBox.UseVisualStyleBackColor = True
        '
        'OtherHealthConditionTextBox
        '
        Me.OtherHealthConditionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "otherHealthCondition", True))
        Me.OtherHealthConditionTextBox.Location = New System.Drawing.Point(160, 413)
        Me.OtherHealthConditionTextBox.Name = "OtherHealthConditionTextBox"
        Me.OtherHealthConditionTextBox.Size = New System.Drawing.Size(723, 20)
        Me.OtherHealthConditionTextBox.TabIndex = 52
        '
        'PrescribedMedicationCheckBox
        '
        Me.PrescribedMedicationCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "prescribedMedication", True))
        Me.PrescribedMedicationCheckBox.Location = New System.Drawing.Point(282, 434)
        Me.PrescribedMedicationCheckBox.Name = "PrescribedMedicationCheckBox"
        Me.PrescribedMedicationCheckBox.Size = New System.Drawing.Size(48, 24)
        Me.PrescribedMedicationCheckBox.TabIndex = 54
        Me.PrescribedMedicationCheckBox.Text = "Yes"
        Me.PrescribedMedicationCheckBox.UseVisualStyleBackColor = True
        '
        'PrescribedMedicationExplainTextBox
        '
        Me.PrescribedMedicationExplainTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "prescribedMedicationExplain", True))
        Me.PrescribedMedicationExplainTextBox.Location = New System.Drawing.Point(156, 460)
        Me.PrescribedMedicationExplainTextBox.Name = "PrescribedMedicationExplainTextBox"
        Me.PrescribedMedicationExplainTextBox.Size = New System.Drawing.Size(727, 20)
        Me.PrescribedMedicationExplainTextBox.TabIndex = 56
        '
        'PhysicianOrHospitalCareTextBox
        '
        Me.PhysicianOrHospitalCareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "physicianOrHospitalCare", True))
        Me.PhysicianOrHospitalCareTextBox.Location = New System.Drawing.Point(47, 503)
        Me.PhysicianOrHospitalCareTextBox.Name = "PhysicianOrHospitalCareTextBox"
        Me.PhysicianOrHospitalCareTextBox.Size = New System.Drawing.Size(836, 20)
        Me.PhysicianOrHospitalCareTextBox.TabIndex = 58
        '
        'SurgeryCheckBox
        '
        Me.SurgeryCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "surgery", True))
        Me.SurgeryCheckBox.Location = New System.Drawing.Point(271, 526)
        Me.SurgeryCheckBox.Name = "SurgeryCheckBox"
        Me.SurgeryCheckBox.Size = New System.Drawing.Size(84, 17)
        Me.SurgeryCheckBox.TabIndex = 60
        Me.SurgeryCheckBox.Text = "Yes"
        Me.SurgeryCheckBox.UseVisualStyleBackColor = True
        '
        'SurgeryExplainTextBox
        '
        Me.SurgeryExplainTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "surgeryExplain", True))
        Me.SurgeryExplainTextBox.Location = New System.Drawing.Point(160, 546)
        Me.SurgeryExplainTextBox.Name = "SurgeryExplainTextBox"
        Me.SurgeryExplainTextBox.Size = New System.Drawing.Size(723, 20)
        Me.SurgeryExplainTextBox.TabIndex = 62
        '
        'OYinternetCheckBox
        '
        Me.OYinternetCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "OYinternet", True))
        Me.OYinternetCheckBox.Location = New System.Drawing.Point(54, 625)
        Me.OYinternetCheckBox.Name = "OYinternetCheckBox"
        Me.OYinternetCheckBox.Size = New System.Drawing.Size(63, 24)
        Me.OYinternetCheckBox.TabIndex = 64
        Me.OYinternetCheckBox.Text = "Internet"
        Me.OYinternetCheckBox.UseVisualStyleBackColor = True
        '
        'OYFlyerCheckBox
        '
        Me.OYFlyerCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "OYFlyer", True))
        Me.OYFlyerCheckBox.Location = New System.Drawing.Point(192, 625)
        Me.OYFlyerCheckBox.Name = "OYFlyerCheckBox"
        Me.OYFlyerCheckBox.Size = New System.Drawing.Size(52, 24)
        Me.OYFlyerCheckBox.TabIndex = 66
        Me.OYFlyerCheckBox.Text = "Flyer"
        Me.OYFlyerCheckBox.UseVisualStyleBackColor = True
        '
        'OYNewspaperCheckBox
        '
        Me.OYNewspaperCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "OYNewspaper", True))
        Me.OYNewspaperCheckBox.Location = New System.Drawing.Point(54, 644)
        Me.OYNewspaperCheckBox.Name = "OYNewspaperCheckBox"
        Me.OYNewspaperCheckBox.Size = New System.Drawing.Size(138, 24)
        Me.OYNewspaperCheckBox.TabIndex = 68
        Me.OYNewspaperCheckBox.Text = "Newspaper/Magazine"
        Me.OYNewspaperCheckBox.UseVisualStyleBackColor = True
        '
        'OYFriendCheckBox
        '
        Me.OYFriendCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "OYFriend", True))
        Me.OYFriendCheckBox.Location = New System.Drawing.Point(54, 664)
        Me.OYFriendCheckBox.Name = "OYFriendCheckBox"
        Me.OYFriendCheckBox.Size = New System.Drawing.Size(65, 24)
        Me.OYFriendCheckBox.TabIndex = 70
        Me.OYFriendCheckBox.Text = "Friend"
        Me.OYFriendCheckBox.UseVisualStyleBackColor = True
        '
        'OYBrochureCheckBox
        '
        Me.OYBrochureCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MembersBindingSource, "OYBrochure", True))
        Me.OYBrochureCheckBox.Location = New System.Drawing.Point(192, 645)
        Me.OYBrochureCheckBox.Name = "OYBrochureCheckBox"
        Me.OYBrochureCheckBox.Size = New System.Drawing.Size(76, 24)
        Me.OYBrochureCheckBox.TabIndex = 72
        Me.OYBrochureCheckBox.Text = "Brochure"
        Me.OYBrochureCheckBox.UseVisualStyleBackColor = True
        '
        'OYOthersTextBox
        '
        Me.OYOthersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "OYOthers", True))
        Me.OYOthersTextBox.Location = New System.Drawing.Point(234, 669)
        Me.OYOthersTextBox.Name = "OYOthersTextBox"
        Me.OYOthersTextBox.Size = New System.Drawing.Size(121, 20)
        Me.OYOthersTextBox.TabIndex = 74
        '
        'NewspaperExplainTextBox
        '
        Me.NewspaperExplainTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "newspaperExplain", True))
        Me.NewspaperExplainTextBox.Location = New System.Drawing.Point(545, 626)
        Me.NewspaperExplainTextBox.Name = "NewspaperExplainTextBox"
        Me.NewspaperExplainTextBox.Size = New System.Drawing.Size(338, 20)
        Me.NewspaperExplainTextBox.TabIndex = 76
        '
        'FriendExplainTextBox
        '
        Me.FriendExplainTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "friendExplain", True))
        Me.FriendExplainTextBox.Location = New System.Drawing.Point(446, 650)
        Me.FriendExplainTextBox.Name = "FriendExplainTextBox"
        Me.FriendExplainTextBox.Size = New System.Drawing.Size(437, 20)
        Me.FriendExplainTextBox.TabIndex = 78
        '
        'DateRegisteredDateTimePicker
        '
        Me.DateRegisteredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MembersBindingSource, "dateRegistered", True))
        Me.DateRegisteredDateTimePicker.Location = New System.Drawing.Point(138, 698)
        Me.DateRegisteredDateTimePicker.Name = "DateRegisteredDateTimePicker"
        Me.DateRegisteredDateTimePicker.Size = New System.Drawing.Size(333, 20)
        Me.DateRegisteredDateTimePicker.TabIndex = 80
        '
        'Status_ComboBox
        '
        Me.Status_ComboBox.AutoCompleteCustomSource.AddRange(New String() {"Single", "Married", "Widow", "Divorced"})
        Me.Status_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.Status_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "civilStatus", True))
        Me.Status_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MembersBindingSource, "civilStatus", True))
        Me.Status_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.MembersBindingSource, "civilStatus", True))
        Me.Status_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status_ComboBox.FormattingEnabled = True
        Me.Status_ComboBox.Items.AddRange(New Object() {"Single", "Married", "Widow", "Divorced"})
        Me.Status_ComboBox.Location = New System.Drawing.Point(320, 206)
        Me.Status_ComboBox.Name = "Status_ComboBox"
        Me.Status_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Status_ComboBox.TabIndex = 81
        '
        'Sex_ComboBox
        '
        Me.Sex_ComboBox.AutoCompleteCustomSource.AddRange(New String() {"Male", "Female"})
        Me.Sex_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.MembersBindingSource, "sex", True))
        Me.Sex_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MembersBindingSource, "sex", True))
        Me.Sex_ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "sex", True))
        Me.Sex_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sex_ComboBox.FormattingEnabled = True
        Me.Sex_ComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.Sex_ComboBox.Location = New System.Drawing.Point(470, 206)
        Me.Sex_ComboBox.Name = "Sex_ComboBox"
        Me.Sex_ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Sex_ComboBox.TabIndex = 82
        '
        'PersonalLabel
        '
        Me.PersonalLabel.AutoSize = True
        Me.PersonalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersonalLabel.Location = New System.Drawing.Point(29, 77)
        Me.PersonalLabel.Name = "PersonalLabel"
        Me.PersonalLabel.Size = New System.Drawing.Size(148, 25)
        Me.PersonalLabel.TabIndex = 83
        Me.PersonalLabel.Text = "Personal Data"
        '
        'emergency_Label
        '
        Me.emergency_Label.AutoSize = True
        Me.emergency_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emergency_Label.Location = New System.Drawing.Point(29, 259)
        Me.emergency_Label.Name = "emergency_Label"
        Me.emergency_Label.Size = New System.Drawing.Size(218, 25)
        Me.emergency_Label.TabIndex = 84
        Me.emergency_Label.Text = "In case of emergency"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 25)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Health Issues"
        '
        'healthLabel1
        '
        Me.healthLabel1.AutoSize = True
        Me.healthLabel1.Location = New System.Drawing.Point(34, 367)
        Me.healthLabel1.Name = "healthLabel1"
        Me.healthLabel1.Size = New System.Drawing.Size(301, 13)
        Me.healthLabel1.TabIndex = 86
        Me.healthLabel1.Text = "1. Are you experiencing any of the following health conditions?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 439)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 13)
        Me.Label2.TabIndex = 87
        Me.Label2.Text = "2. Are you currently taking prescribed medication?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 575)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 25)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "One Yoga Wellness Studio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 606)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(325, 13)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "How did you hear about One Yoga Wellness Studio? Please select:"
        '
        'newspaperExplain_Label
        '
        Me.newspaperExplain_Label.AutoSize = True
        Me.newspaperExplain_Label.Location = New System.Drawing.Point(363, 630)
        Me.newspaperExplain_Label.Name = "newspaperExplain_Label"
        Me.newspaperExplain_Label.Size = New System.Drawing.Size(179, 13)
        Me.newspaperExplain_Label.TabIndex = 90
        Me.newspaperExplain_Label.Text = "If newspaper/magazine, which one?"
        '
        'Close_button
        '
        Me.Close_button.Location = New System.Drawing.Point(660, 699)
        Me.Close_button.Name = "Close_button"
        Me.Close_button.Size = New System.Drawing.Size(223, 23)
        Me.Close_button.TabIndex = 91
        Me.Close_button.Text = "Close"
        Me.Close_button.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(334, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(240, 25)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "REGISTRATION FORM"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 728)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(925, 22)
        Me.StatusStrip1.TabIndex = 93
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(925, 750)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Close_button)
        Me.Controls.Add(Me.newspaperExplain_Label)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.healthLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.emergency_Label)
        Me.Controls.Add(Me.PersonalLabel)
        Me.Controls.Add(Me.Sex_ComboBox)
        Me.Controls.Add(Me.Status_ComboBox)
        Me.Controls.Add(MemberIDLabel)
        Me.Controls.Add(Me.MemberIDTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(FirstnameLabel)
        Me.Controls.Add(Me.FirstnameTextBox)
        Me.Controls.Add(MILabel)
        Me.Controls.Add(Me.MITextBox)
        Me.Controls.Add(NicknameLabel)
        Me.Controls.Add(Me.NicknameTextBox)
        Me.Controls.Add(HomeAddrLabel)
        Me.Controls.Add(Me.HomeAddrTextBox)
        Me.Controls.Add(ZipcodeLabel)
        Me.Controls.Add(Me.ZipcodeTextBox)
        Me.Controls.Add(OfficeAddrLabel)
        Me.Controls.Add(Me.OfficeAddrTextBox)
        Me.Controls.Add(BirthdateLabel)
        Me.Controls.Add(Me.BirthdateDateTimePicker)
        Me.Controls.Add(CivilStatusLabel)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(MobileNoLabel)
        Me.Controls.Add(Me.MobileNoTextBox)
        Me.Controls.Add(OtherContactLabel)
        Me.Controls.Add(Me.OtherContactTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(ContactPersonLabel)
        Me.Controls.Add(Me.ContactPersonTextBox)
        Me.Controls.Add(ContactPersonNoLabel)
        Me.Controls.Add(Me.ContactPersonNoTextBox)
        Me.Controls.Add(ContactPersonRelationshipLabel)
        Me.Controls.Add(Me.ContactPersonRelationshipTextBox)
        Me.Controls.Add(ContactPersonAddrLabel)
        Me.Controls.Add(Me.ContactPersonAddrTextBox)
        Me.Controls.Add(AsthmaLabel)
        Me.Controls.Add(Me.AsthmaCheckBox)
        Me.Controls.Add(EpilepsyLabel)
        Me.Controls.Add(Me.EpilepsyCheckBox)
        Me.Controls.Add(HighBloodLabel)
        Me.Controls.Add(Me.HighBloodCheckBox)
        Me.Controls.Add(HeartProblemLabel)
        Me.Controls.Add(Me.HeartProblemCheckBox)
        Me.Controls.Add(BackpainLabel)
        Me.Controls.Add(Me.BackpainCheckBox)
        Me.Controls.Add(PregnancyLabel)
        Me.Controls.Add(Me.PregnancyCheckBox)
        Me.Controls.Add(OtherHealthConditionLabel)
        Me.Controls.Add(Me.OtherHealthConditionTextBox)
        Me.Controls.Add(Me.PrescribedMedicationCheckBox)
        Me.Controls.Add(PrescribedMedicationExplainLabel)
        Me.Controls.Add(Me.PrescribedMedicationExplainTextBox)
        Me.Controls.Add(PhysicianOrHospitalCareLabel)
        Me.Controls.Add(Me.PhysicianOrHospitalCareTextBox)
        Me.Controls.Add(SurgeryLabel)
        Me.Controls.Add(Me.SurgeryCheckBox)
        Me.Controls.Add(SurgeryExplainLabel)
        Me.Controls.Add(Me.SurgeryExplainTextBox)
        Me.Controls.Add(Me.OYinternetCheckBox)
        Me.Controls.Add(Me.OYFlyerCheckBox)
        Me.Controls.Add(Me.OYNewspaperCheckBox)
        Me.Controls.Add(Me.OYFriendCheckBox)
        Me.Controls.Add(Me.OYBrochureCheckBox)
        Me.Controls.Add(OYOthersLabel)
        Me.Controls.Add(Me.OYOthersTextBox)
        Me.Controls.Add(Me.NewspaperExplainTextBox)
        Me.Controls.Add(FriendExplainLabel)
        Me.Controls.Add(Me.FriendExplainTextBox)
        Me.Controls.Add(DateRegisteredLabel)
        Me.Controls.Add(Me.DateRegisteredDateTimePicker)
        Me.Controls.Add(Me.MembersBindingNavigator)
        Me.Name = "results"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration Testing"
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MembersBindingNavigator.ResumeLayout(False)
        Me.MembersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersTableAdapter As oneYoga.OYmembersTableAdapters.membersTableAdapter
    Friend WithEvents TableAdapterManager As oneYoga.OYmembersTableAdapters.TableAdapterManager
    Friend WithEvents MembersBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MembersBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents MemberIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MITextBox As System.Windows.Forms.TextBox
    Friend WithEvents NicknameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HomeAddrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZipcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OfficeAddrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BirthdateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MobileNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OtherContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactPersonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactPersonNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactPersonRelationshipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactPersonAddrTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AsthmaCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EpilepsyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HighBloodCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents HeartProblemCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BackpainCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PregnancyCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OtherHealthConditionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrescribedMedicationCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PrescribedMedicationExplainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhysicianOrHospitalCareTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurgeryCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SurgeryExplainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OYinternetCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OYFlyerCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OYNewspaperCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OYFriendCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OYBrochureCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OYOthersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewspaperExplainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FriendExplainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateRegisteredDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Status_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Sex_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PersonalLabel As System.Windows.Forms.Label
    Friend WithEvents emergency_Label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents healthLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents newspaperExplain_Label As System.Windows.Forms.Label
    Friend WithEvents Close_button As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents EditButton As System.Windows.Forms.ToolStripButton
End Class
