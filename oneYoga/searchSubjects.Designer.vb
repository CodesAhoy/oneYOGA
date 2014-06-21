<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchSubjects
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
        Me.searchSubjectTextBox = New System.Windows.Forms.TextBox()
        Me.SearchSubjectButton = New System.Windows.Forms.Button()
        Me.CloseSearchSubjButton = New System.Windows.Forms.Button()
        Me.EditSubjButton = New System.Windows.Forms.Button()
        Me.SaveSubjButton = New System.Windows.Forms.Button()
        Me.DeleteSubjButton = New System.Windows.Forms.Button()
        Me.prevSubjButton = New System.Windows.Forms.Button()
        Me.nextSubjButton = New System.Windows.Forms.Button()
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
        IdLabel.Location = New System.Drawing.Point(58, 60)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(21, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "ID:"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Location = New System.Drawing.Point(58, 86)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(46, 13)
        SubjectLabel.TabIndex = 3
        SubjectLabel.Text = "Subject:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(58, 112)
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
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(125, 57)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "subject", True))
        Me.SubjectTextBox.Location = New System.Drawing.Point(125, 83)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(446, 20)
        Me.SubjectTextBox.TabIndex = 4
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(125, 109)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(446, 139)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search Subject:"
        '
        'searchSubjectTextBox
        '
        Me.searchSubjectTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.searchSubjectTextBox.Location = New System.Drawing.Point(125, 22)
        Me.searchSubjectTextBox.Name = "searchSubjectTextBox"
        Me.searchSubjectTextBox.Size = New System.Drawing.Size(349, 20)
        Me.searchSubjectTextBox.TabIndex = 8
        '
        'SearchSubjectButton
        '
        Me.SearchSubjectButton.Location = New System.Drawing.Point(481, 18)
        Me.SearchSubjectButton.Name = "SearchSubjectButton"
        Me.SearchSubjectButton.Size = New System.Drawing.Size(90, 23)
        Me.SearchSubjectButton.TabIndex = 9
        Me.SearchSubjectButton.Text = "Search"
        Me.SearchSubjectButton.UseVisualStyleBackColor = True
        '
        'CloseSearchSubjButton
        '
        Me.CloseSearchSubjButton.Location = New System.Drawing.Point(496, 257)
        Me.CloseSearchSubjButton.Name = "CloseSearchSubjButton"
        Me.CloseSearchSubjButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseSearchSubjButton.TabIndex = 10
        Me.CloseSearchSubjButton.Text = "Close"
        Me.CloseSearchSubjButton.UseVisualStyleBackColor = True
        '
        'EditSubjButton
        '
        Me.EditSubjButton.Location = New System.Drawing.Point(414, 257)
        Me.EditSubjButton.Name = "EditSubjButton"
        Me.EditSubjButton.Size = New System.Drawing.Size(75, 23)
        Me.EditSubjButton.TabIndex = 11
        Me.EditSubjButton.Text = "Edit"
        Me.EditSubjButton.UseVisualStyleBackColor = True
        '
        'SaveSubjButton
        '
        Me.SaveSubjButton.Location = New System.Drawing.Point(333, 257)
        Me.SaveSubjButton.Name = "SaveSubjButton"
        Me.SaveSubjButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveSubjButton.TabIndex = 12
        Me.SaveSubjButton.Text = "Save"
        Me.SaveSubjButton.UseVisualStyleBackColor = True
        '
        'DeleteSubjButton
        '
        Me.DeleteSubjButton.Location = New System.Drawing.Point(125, 257)
        Me.DeleteSubjButton.Name = "DeleteSubjButton"
        Me.DeleteSubjButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteSubjButton.TabIndex = 13
        Me.DeleteSubjButton.Text = "Delete"
        Me.DeleteSubjButton.UseVisualStyleBackColor = True
        '
        'prevSubjButton
        '
        Me.prevSubjButton.Location = New System.Drawing.Point(222, 257)
        Me.prevSubjButton.Name = "prevSubjButton"
        Me.prevSubjButton.Size = New System.Drawing.Size(38, 23)
        Me.prevSubjButton.TabIndex = 14
        Me.prevSubjButton.Text = "<"
        Me.prevSubjButton.UseVisualStyleBackColor = True
        '
        'nextSubjButton
        '
        Me.nextSubjButton.Location = New System.Drawing.Point(266, 257)
        Me.nextSubjButton.Name = "nextSubjButton"
        Me.nextSubjButton.Size = New System.Drawing.Size(38, 23)
        Me.nextSubjButton.TabIndex = 15
        Me.nextSubjButton.Text = ">"
        Me.nextSubjButton.UseVisualStyleBackColor = True
        '
        'searchSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 292)
        Me.Controls.Add(Me.nextSubjButton)
        Me.Controls.Add(Me.prevSubjButton)
        Me.Controls.Add(Me.DeleteSubjButton)
        Me.Controls.Add(Me.SaveSubjButton)
        Me.Controls.Add(Me.EditSubjButton)
        Me.Controls.Add(Me.CloseSearchSubjButton)
        Me.Controls.Add(Me.SearchSubjectButton)
        Me.Controls.Add(Me.searchSubjectTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(SubjectLabel)
        Me.Controls.Add(Me.SubjectTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Name = "searchSubjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "searchSubjects"
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
    Friend WithEvents searchSubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SearchSubjectButton As System.Windows.Forms.Button
    Friend WithEvents CloseSearchSubjButton As System.Windows.Forms.Button
    Friend WithEvents EditSubjButton As System.Windows.Forms.Button
    Friend WithEvents SaveSubjButton As System.Windows.Forms.Button
    Friend WithEvents DeleteSubjButton As System.Windows.Forms.Button
    Friend WithEvents prevSubjButton As System.Windows.Forms.Button
    Friend WithEvents nextSubjButton As System.Windows.Forms.Button
End Class
