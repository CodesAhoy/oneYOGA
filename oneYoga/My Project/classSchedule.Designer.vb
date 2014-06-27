<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class classSchedule
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim ClassLabel As System.Windows.Forms.Label
        Dim TimeEndLabel As System.Windows.Forms.Label
        Dim TimeStartLabel1 As System.Windows.Forms.Label
        Dim TeacherLabel As System.Windows.Forms.Label
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ClassScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OYmembers = New oneYoga.OYmembers()
        Me.TimeEndTextBox = New System.Windows.Forms.TextBox()
        Me.TimeStartTextBox = New System.Windows.Forms.TextBox()
        Me.TimeEndDisplayTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TimeStartDisplayTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TeacherTextBox = New System.Windows.Forms.TextBox()
        Me.DaysGroupBox = New System.Windows.Forms.GroupBox()
        Me.SaturdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.FridayCheckBox = New System.Windows.Forms.CheckBox()
        Me.ThursdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.WednesdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.TuesdayCheckBox = New System.Windows.Forms.CheckBox()
        Me.MondayCheckBox = New System.Windows.Forms.CheckBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButtonAddNewClass = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClassScheduleTableAdapter = New oneYoga.OYmembersTableAdapters.classScheduleTableAdapter()
        Me.TableAdapterManager = New oneYoga.OYmembersTableAdapters.TableAdapterManager()
        Me.classComboBox = New System.Windows.Forms.ComboBox()
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectsTableAdapter = New oneYoga.OYmembersTableAdapters.subjectsTableAdapter()
        Me.teacherNameTextBox = New System.Windows.Forms.TextBox()
        Me.setTeacherButton = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        ClassLabel = New System.Windows.Forms.Label()
        TimeEndLabel = New System.Windows.Forms.Label()
        TimeStartLabel1 = New System.Windows.Forms.Label()
        TeacherLabel = New System.Windows.Forms.Label()
        CType(Me.ClassScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DaysGroupBox.SuspendLayout()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(31, 81)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(49, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Class ID:"
        '
        'ClassLabel
        '
        ClassLabel.AutoSize = True
        ClassLabel.Location = New System.Drawing.Point(31, 107)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New System.Drawing.Size(66, 13)
        ClassLabel.TabIndex = 3
        ClassLabel.Text = "Class Name:"
        '
        'TimeEndLabel
        '
        TimeEndLabel.AutoSize = True
        TimeEndLabel.Location = New System.Drawing.Point(321, 135)
        TimeEndLabel.Name = "TimeEndLabel"
        TimeEndLabel.Size = New System.Drawing.Size(55, 13)
        TimeEndLabel.TabIndex = 7
        TimeEndLabel.Text = "Time End:"
        '
        'TimeStartLabel1
        '
        TimeStartLabel1.AutoSize = True
        TimeStartLabel1.Location = New System.Drawing.Point(31, 136)
        TimeStartLabel1.Name = "TimeStartLabel1"
        TimeStartLabel1.Size = New System.Drawing.Size(58, 13)
        TimeStartLabel1.TabIndex = 8
        TimeStartLabel1.Text = "Time Start:"
        '
        'TeacherLabel
        '
        TeacherLabel.AutoSize = True
        TeacherLabel.Location = New System.Drawing.Point(321, 107)
        TeacherLabel.Name = "TeacherLabel"
        TeacherLabel.Size = New System.Drawing.Size(50, 13)
        TeacherLabel.TabIndex = 15
        TeacherLabel.Text = "Teacher:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassScheduleBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(91, 78)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'ClassScheduleBindingSource
        '
        Me.ClassScheduleBindingSource.DataMember = "classSchedule"
        Me.ClassScheduleBindingSource.DataSource = Me.OYmembers
        '
        'OYmembers
        '
        Me.OYmembers.DataSetName = "OYmembers"
        Me.OYmembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TimeEndTextBox
        '
        Me.TimeEndTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassScheduleBindingSource, "timeEnd", True))
        Me.TimeEndTextBox.Location = New System.Drawing.Point(381, 133)
        Me.TimeEndTextBox.Name = "TimeEndTextBox"
        Me.TimeEndTextBox.ReadOnly = True
        Me.TimeEndTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TimeEndTextBox.TabIndex = 8
        '
        'TimeStartTextBox
        '
        Me.TimeStartTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassScheduleBindingSource, "timeStart", True))
        Me.TimeStartTextBox.Location = New System.Drawing.Point(91, 133)
        Me.TimeStartTextBox.Name = "TimeStartTextBox"
        Me.TimeStartTextBox.ReadOnly = True
        Me.TimeStartTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TimeStartTextBox.TabIndex = 9
        '
        'TimeEndDisplayTextBox
        '
        Me.TimeEndDisplayTextBox.Location = New System.Drawing.Point(381, 132)
        Me.TimeEndDisplayTextBox.Name = "TimeEndDisplayTextBox"
        Me.TimeEndDisplayTextBox.ReadOnly = True
        Me.TimeEndDisplayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TimeEndDisplayTextBox.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(488, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Set"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TimeStartDisplayTextBox
        '
        Me.TimeStartDisplayTextBox.Location = New System.Drawing.Point(91, 133)
        Me.TimeStartDisplayTextBox.Name = "TimeStartDisplayTextBox"
        Me.TimeStartDisplayTextBox.ReadOnly = True
        Me.TimeStartDisplayTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TimeStartDisplayTextBox.TabIndex = 14
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(198, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Set"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TeacherTextBox
        '
        Me.TeacherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassScheduleBindingSource, "teacher", True))
        Me.TeacherTextBox.Enabled = False
        Me.TeacherTextBox.Location = New System.Drawing.Point(381, 103)
        Me.TeacherTextBox.Name = "TeacherTextBox"
        Me.TeacherTextBox.ReadOnly = True
        Me.TeacherTextBox.Size = New System.Drawing.Size(30, 20)
        Me.TeacherTextBox.TabIndex = 16
        '
        'DaysGroupBox
        '
        Me.DaysGroupBox.Controls.Add(Me.SaturdayCheckBox)
        Me.DaysGroupBox.Controls.Add(Me.FridayCheckBox)
        Me.DaysGroupBox.Controls.Add(Me.ThursdayCheckBox)
        Me.DaysGroupBox.Controls.Add(Me.WednesdayCheckBox)
        Me.DaysGroupBox.Controls.Add(Me.TuesdayCheckBox)
        Me.DaysGroupBox.Controls.Add(Me.MondayCheckBox)
        Me.DaysGroupBox.Location = New System.Drawing.Point(34, 159)
        Me.DaysGroupBox.Name = "DaysGroupBox"
        Me.DaysGroupBox.Size = New System.Drawing.Size(281, 192)
        Me.DaysGroupBox.TabIndex = 17
        Me.DaysGroupBox.TabStop = False
        Me.DaysGroupBox.Text = "Days"
        '
        'SaturdayCheckBox
        '
        Me.SaturdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClassScheduleBindingSource, "saturday", True))
        Me.SaturdayCheckBox.Location = New System.Drawing.Point(46, 124)
        Me.SaturdayCheckBox.Name = "SaturdayCheckBox"
        Me.SaturdayCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SaturdayCheckBox.TabIndex = 6
        Me.SaturdayCheckBox.Text = "Saturday"
        Me.SaturdayCheckBox.UseVisualStyleBackColor = True
        '
        'FridayCheckBox
        '
        Me.FridayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClassScheduleBindingSource, "friday", True))
        Me.FridayCheckBox.Location = New System.Drawing.Point(46, 104)
        Me.FridayCheckBox.Name = "FridayCheckBox"
        Me.FridayCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.FridayCheckBox.TabIndex = 5
        Me.FridayCheckBox.Text = "Friday"
        Me.FridayCheckBox.UseVisualStyleBackColor = True
        '
        'ThursdayCheckBox
        '
        Me.ThursdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClassScheduleBindingSource, "thursday", True))
        Me.ThursdayCheckBox.Location = New System.Drawing.Point(46, 83)
        Me.ThursdayCheckBox.Name = "ThursdayCheckBox"
        Me.ThursdayCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ThursdayCheckBox.TabIndex = 4
        Me.ThursdayCheckBox.Text = "Thursday"
        Me.ThursdayCheckBox.UseVisualStyleBackColor = True
        '
        'WednesdayCheckBox
        '
        Me.WednesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClassScheduleBindingSource, "wednesday", True))
        Me.WednesdayCheckBox.Location = New System.Drawing.Point(46, 61)
        Me.WednesdayCheckBox.Name = "WednesdayCheckBox"
        Me.WednesdayCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.WednesdayCheckBox.TabIndex = 3
        Me.WednesdayCheckBox.Text = "Wednesday"
        Me.WednesdayCheckBox.UseVisualStyleBackColor = True
        '
        'TuesdayCheckBox
        '
        Me.TuesdayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClassScheduleBindingSource, "tuesday", True))
        Me.TuesdayCheckBox.Location = New System.Drawing.Point(46, 40)
        Me.TuesdayCheckBox.Name = "TuesdayCheckBox"
        Me.TuesdayCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.TuesdayCheckBox.TabIndex = 2
        Me.TuesdayCheckBox.Text = "Tuesday"
        Me.TuesdayCheckBox.UseVisualStyleBackColor = True
        '
        'MondayCheckBox
        '
        Me.MondayCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ClassScheduleBindingSource, "monday", True))
        Me.MondayCheckBox.Location = New System.Drawing.Point(46, 19)
        Me.MondayCheckBox.Name = "MondayCheckBox"
        Me.MondayCheckBox.Size = New System.Drawing.Size(75, 24)
        Me.MondayCheckBox.TabIndex = 1
        Me.MondayCheckBox.Text = "Monday"
        Me.MondayCheckBox.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(407, 189)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(235, 45)
        Me.SaveButton.TabIndex = 18
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CancelButtonAddNewClass
        '
        Me.CancelButtonAddNewClass.Location = New System.Drawing.Point(407, 242)
        Me.CancelButtonAddNewClass.Name = "CancelButtonAddNewClass"
        Me.CancelButtonAddNewClass.Size = New System.Drawing.Size(235, 45)
        Me.CancelButtonAddNewClass.TabIndex = 19
        Me.CancelButtonAddNewClass.Text = "Cancel"
        Me.CancelButtonAddNewClass.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(238, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Add New Class Schedule"
        '
        'ClassScheduleTableAdapter
        '
        Me.ClassScheduleTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.classScheduleTableAdapter = Me.ClassScheduleTableAdapter
        Me.TableAdapterManager.gendersTableAdapter = Nothing
        Me.TableAdapterManager.membersTableAdapter = Nothing
        Me.TableAdapterManager.otherYogaMedicationTableAdapter = Nothing
        Me.TableAdapterManager.ratesTableAdapter = Nothing
        Me.TableAdapterManager.subjectsTableAdapter = Nothing
        Me.TableAdapterManager.teachersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = oneYoga.OYmembersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'classComboBox
        '
        Me.classComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClassScheduleBindingSource, "class", True))
        Me.classComboBox.DataSource = Me.SubjectsBindingSource
        Me.classComboBox.DisplayMember = "subject"
        Me.classComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.classComboBox.FormattingEnabled = True
        Me.classComboBox.Location = New System.Drawing.Point(103, 103)
        Me.classComboBox.Name = "classComboBox"
        Me.classComboBox.Size = New System.Drawing.Size(212, 21)
        Me.classComboBox.TabIndex = 21
        '
        'SubjectsBindingSource
        '
        Me.SubjectsBindingSource.DataMember = "subjects"
        Me.SubjectsBindingSource.DataSource = Me.OYmembers
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
        '
        'teacherNameTextBox
        '
        Me.teacherNameTextBox.Location = New System.Drawing.Point(418, 102)
        Me.teacherNameTextBox.Name = "teacherNameTextBox"
        Me.teacherNameTextBox.ReadOnly = True
        Me.teacherNameTextBox.Size = New System.Drawing.Size(165, 20)
        Me.teacherNameTextBox.TabIndex = 22
        '
        'setTeacherButton
        '
        Me.setTeacherButton.Location = New System.Drawing.Point(589, 100)
        Me.setTeacherButton.Name = "setTeacherButton"
        Me.setTeacherButton.Size = New System.Drawing.Size(75, 23)
        Me.setTeacherButton.TabIndex = 23
        Me.setTeacherButton.Text = "Set"
        Me.setTeacherButton.UseVisualStyleBackColor = True
        '
        'classSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 474)
        Me.Controls.Add(Me.setTeacherButton)
        Me.Controls.Add(Me.teacherNameTextBox)
        Me.Controls.Add(Me.classComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelButtonAddNewClass)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DaysGroupBox)
        Me.Controls.Add(TeacherLabel)
        Me.Controls.Add(Me.TeacherTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TimeStartDisplayTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TimeEndDisplayTextBox)
        Me.Controls.Add(TimeStartLabel1)
        Me.Controls.Add(Me.TimeStartTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(ClassLabel)
        Me.Controls.Add(TimeEndLabel)
        Me.Controls.Add(Me.TimeEndTextBox)
        Me.Name = "classSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Yoga - Add New Class Schedule"
        CType(Me.ClassScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DaysGroupBox.ResumeLayout(False)
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents ClassScheduleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassScheduleTableAdapter As oneYoga.OYmembersTableAdapters.classScheduleTableAdapter
    Friend WithEvents TableAdapterManager As oneYoga.OYmembersTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimeEndTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimeStartTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TimeEndDisplayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TimeStartDisplayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TeacherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DaysGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents WednesdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents TuesdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MondayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SaturdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FridayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ThursdayCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents CancelButtonAddNewClass As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents classComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As oneYoga.OYmembersTableAdapters.subjectsTableAdapter
    Friend WithEvents teacherNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents setTeacherButton As System.Windows.Forms.Button
End Class
