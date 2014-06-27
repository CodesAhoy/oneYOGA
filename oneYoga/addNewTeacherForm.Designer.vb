<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addNewTeacherForm
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
        Me.TeachersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OYmembers = New oneYoga.OYmembers()
        Me.surnameTextBox = New System.Windows.Forms.TextBox()
        Me.firstnameTextBox = New System.Windows.Forms.TextBox()
        Me.MITextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.saveNewTeacherButton = New System.Windows.Forms.Button()
        Me.cancelAddNewTeacherButton = New System.Windows.Forms.Button()
        Me.TeachersTableAdapter = New oneYoga.OYmembersTableAdapters.teachersTableAdapter()
        CType(Me.TeachersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeachersBindingSource, "Id", True))
        Me.IDTextBox.Location = New System.Drawing.Point(89, 66)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(62, 20)
        Me.IDTextBox.TabIndex = 0
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
        'surnameTextBox
        '
        Me.surnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeachersBindingSource, "surname", True))
        Me.surnameTextBox.Location = New System.Drawing.Point(89, 92)
        Me.surnameTextBox.Name = "surnameTextBox"
        Me.surnameTextBox.Size = New System.Drawing.Size(241, 20)
        Me.surnameTextBox.TabIndex = 1
        '
        'firstnameTextBox
        '
        Me.firstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeachersBindingSource, "firstname", True))
        Me.firstnameTextBox.Location = New System.Drawing.Point(89, 119)
        Me.firstnameTextBox.Name = "firstnameTextBox"
        Me.firstnameTextBox.Size = New System.Drawing.Size(241, 20)
        Me.firstnameTextBox.TabIndex = 2
        '
        'MITextBox
        '
        Me.MITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeachersBindingSource, "MI", True))
        Me.MITextBox.Location = New System.Drawing.Point(89, 146)
        Me.MITextBox.Name = "MITextBox"
        Me.MITextBox.Size = New System.Drawing.Size(111, 20)
        Me.MITextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please provide the necessary information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Firstname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "MI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID"
        '
        'saveNewTeacherButton
        '
        Me.saveNewTeacherButton.Location = New System.Drawing.Point(100, 182)
        Me.saveNewTeacherButton.Name = "saveNewTeacherButton"
        Me.saveNewTeacherButton.Size = New System.Drawing.Size(75, 23)
        Me.saveNewTeacherButton.TabIndex = 9
        Me.saveNewTeacherButton.Text = "Save"
        Me.saveNewTeacherButton.UseVisualStyleBackColor = True
        '
        'cancelAddNewTeacherButton
        '
        Me.cancelAddNewTeacherButton.Location = New System.Drawing.Point(181, 182)
        Me.cancelAddNewTeacherButton.Name = "cancelAddNewTeacherButton"
        Me.cancelAddNewTeacherButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelAddNewTeacherButton.TabIndex = 10
        Me.cancelAddNewTeacherButton.Text = "Cancel"
        Me.cancelAddNewTeacherButton.UseVisualStyleBackColor = True
        '
        'TeachersTableAdapter
        '
        Me.TeachersTableAdapter.ClearBeforeFill = True
        '
        'addNewTeacherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 226)
        Me.Controls.Add(Me.cancelAddNewTeacherButton)
        Me.Controls.Add(Me.saveNewTeacherButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MITextBox)
        Me.Controls.Add(Me.firstnameTextBox)
        Me.Controls.Add(Me.surnameTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Name = "addNewTeacherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Teacher Form"
        CType(Me.TeachersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents surnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents firstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents saveNewTeacherButton As System.Windows.Forms.Button
    Friend WithEvents cancelAddNewTeacherButton As System.Windows.Forms.Button
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents TeachersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeachersTableAdapter As oneYoga.OYmembersTableAdapters.teachersTableAdapter
End Class
