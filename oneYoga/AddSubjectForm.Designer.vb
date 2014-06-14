<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSubjectForm
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
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.OYmembers = New oneYoga.OYmembers()
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectsTableAdapter = New oneYoga.OYmembersTableAdapters.subjectsTableAdapter()
        Me.TableAdapterManager = New oneYoga.OYmembersTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddNewSubButton = New System.Windows.Forms.Button()
        Me.CancelSubjButton = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        SubjectLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(26, 66)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(60, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Subject ID:"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Location = New System.Drawing.Point(27, 92)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(46, 13)
        SubjectLabel.TabIndex = 3
        SubjectLabel.Text = "Subject:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(27, 117)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'OYmembers
        '
        Me.OYmembers.DataSetName = "OYmembers"
        Me.OYmembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.classScheduleTableAdapter = Nothing
        Me.TableAdapterManager.membersTableAdapter = Nothing
        Me.TableAdapterManager.otherYogaMedicationTableAdapter = Nothing
        Me.TableAdapterManager.subjectsTableAdapter = Me.SubjectsTableAdapter
        Me.TableAdapterManager.UpdateOrder = oneYoga.OYmembersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(96, 62)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "subject", True))
        Me.SubjectTextBox.Location = New System.Drawing.Point(96, 88)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(291, 20)
        Me.SubjectTextBox.TabIndex = 4
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(96, 117)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(291, 98)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Add New Subject"
        '
        'AddNewSubButton
        '
        Me.AddNewSubButton.Location = New System.Drawing.Point(128, 235)
        Me.AddNewSubButton.Name = "AddNewSubButton"
        Me.AddNewSubButton.Size = New System.Drawing.Size(75, 23)
        Me.AddNewSubButton.TabIndex = 8
        Me.AddNewSubButton.Text = "Add"
        Me.AddNewSubButton.UseVisualStyleBackColor = True
        '
        'CancelSubjButton
        '
        Me.CancelSubjButton.Location = New System.Drawing.Point(217, 235)
        Me.CancelSubjButton.Name = "CancelSubjButton"
        Me.CancelSubjButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelSubjButton.TabIndex = 9
        Me.CancelSubjButton.Text = "Cancel"
        Me.CancelSubjButton.UseVisualStyleBackColor = True
        '
        'AddSubjectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 310)
        Me.Controls.Add(Me.CancelSubjButton)
        Me.Controls.Add(Me.AddNewSubButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(SubjectLabel)
        Me.Controls.Add(Me.SubjectTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Name = "AddSubjectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Yoga - Add Subject Form"
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents SubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As oneYoga.OYmembersTableAdapters.subjectsTableAdapter
    Friend WithEvents TableAdapterManager As oneYoga.OYmembersTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AddNewSubButton As System.Windows.Forms.Button
    Friend WithEvents CancelSubjButton As System.Windows.Forms.Button
End Class
