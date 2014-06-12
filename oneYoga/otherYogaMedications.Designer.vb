<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class otherYogaMedications
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
        Dim MemberIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(otherYogaMedications))
        Me.OYmembers = New oneYoga.OYmembers()
        Me.OtherYogaMedicationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtherYogaMedicationTableAdapter = New oneYoga.OYmembersTableAdapters.otherYogaMedicationTableAdapter()
        Me.TableAdapterManager = New oneYoga.OYmembersTableAdapters.TableAdapterManager()
        Me.MembersTableAdapter = New oneYoga.OYmembersTableAdapters.membersTableAdapter()
        Me.UsersTableAdapter = New oneYoga.OYmembersTableAdapters.usersTableAdapter()
        Me.OtherYogaMedicationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.OtherYogaMedicationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKotherYogaMedicationToTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        IdLabel = New System.Windows.Forms.Label()
        MemberIDLabel = New System.Windows.Forms.Label()
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherYogaMedicationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtherYogaMedicationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OtherYogaMedicationBindingNavigator.SuspendLayout()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKotherYogaMedicationToTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(219, 120)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'MemberIDLabel
        '
        MemberIDLabel.AutoSize = True
        MemberIDLabel.Location = New System.Drawing.Point(219, 146)
        MemberIDLabel.Name = "MemberIDLabel"
        MemberIDLabel.Size = New System.Drawing.Size(61, 13)
        MemberIDLabel.TabIndex = 3
        MemberIDLabel.Text = "member ID:"
        '
        'OYmembers
        '
        Me.OYmembers.DataSetName = "OYmembers"
        Me.OYmembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OtherYogaMedicationBindingSource
        '
        Me.OtherYogaMedicationBindingSource.DataMember = "otherYogaMedication"
        Me.OtherYogaMedicationBindingSource.DataSource = Me.OYmembers
        '
        'OtherYogaMedicationTableAdapter
        '
        Me.OtherYogaMedicationTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.membersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.otherYogaMedicationTableAdapter = Me.OtherYogaMedicationTableAdapter
        Me.TableAdapterManager.UpdateOrder = oneYoga.OYmembersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Me.UsersTableAdapter
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'OtherYogaMedicationBindingNavigator
        '
        Me.OtherYogaMedicationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.OtherYogaMedicationBindingNavigator.BindingSource = Me.OtherYogaMedicationBindingSource
        Me.OtherYogaMedicationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.OtherYogaMedicationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.OtherYogaMedicationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.OtherYogaMedicationBindingNavigatorSaveItem})
        Me.OtherYogaMedicationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.OtherYogaMedicationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.OtherYogaMedicationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.OtherYogaMedicationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.OtherYogaMedicationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.OtherYogaMedicationBindingNavigator.Name = "OtherYogaMedicationBindingNavigator"
        Me.OtherYogaMedicationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.OtherYogaMedicationBindingNavigator.Size = New System.Drawing.Size(619, 25)
        Me.OtherYogaMedicationBindingNavigator.TabIndex = 0
        Me.OtherYogaMedicationBindingNavigator.Text = "BindingNavigator1"
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
        'OtherYogaMedicationBindingNavigatorSaveItem
        '
        Me.OtherYogaMedicationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OtherYogaMedicationBindingNavigatorSaveItem.Image = CType(resources.GetObject("OtherYogaMedicationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.OtherYogaMedicationBindingNavigatorSaveItem.Name = "OtherYogaMedicationBindingNavigatorSaveItem"
        Me.OtherYogaMedicationBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.OtherYogaMedicationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OtherYogaMedicationBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(286, 117)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.OtherYogaMedicationBindingSource, "memberID", True))
        Me.ComboBox1.DataSource = Me.MembersBindingSource
        Me.ComboBox1.DisplayMember = "surname"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(286, 143)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "memberID"
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "members"
        Me.MembersBindingSource.DataSource = Me.OYmembers
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.OYmembers
        '
        'FKotherYogaMedicationToTableBindingSource
        '
        Me.FKotherYogaMedicationToTableBindingSource.DataMember = "FK_otherYogaMedication_ToTable"
        Me.FKotherYogaMedicationToTableBindingSource.DataSource = Me.MembersBindingSource
        '
        'otherYogaMedications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 341)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(MemberIDLabel)
        Me.Controls.Add(Me.OtherYogaMedicationBindingNavigator)
        Me.Name = "otherYogaMedications"
        Me.Text = "otherYogaMedications"
        CType(Me.OYmembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherYogaMedicationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtherYogaMedicationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OtherYogaMedicationBindingNavigator.ResumeLayout(False)
        Me.OtherYogaMedicationBindingNavigator.PerformLayout()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKotherYogaMedicationToTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OYmembers As oneYoga.OYmembers
    Friend WithEvents OtherYogaMedicationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OtherYogaMedicationTableAdapter As oneYoga.OYmembersTableAdapters.otherYogaMedicationTableAdapter
    Friend WithEvents TableAdapterManager As oneYoga.OYmembersTableAdapters.TableAdapterManager
    Friend WithEvents OtherYogaMedicationBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents OtherYogaMedicationBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents UsersTableAdapter As oneYoga.OYmembersTableAdapters.usersTableAdapter
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MembersTableAdapter As oneYoga.OYmembersTableAdapters.membersTableAdapter
    Friend WithEvents MembersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FKotherYogaMedicationToTableBindingSource As System.Windows.Forms.BindingSource
End Class
