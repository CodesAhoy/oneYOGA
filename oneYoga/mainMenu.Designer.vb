<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.ViewMembersButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SalesButton = New System.Windows.Forms.Button()
        Me.TeachersButton = New System.Windows.Forms.Button()
        Me.ClassScheduleButton = New System.Windows.Forms.Button()
        Me.PaymentButton = New System.Windows.Forms.Button()
        Me.UsersButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.UsersButton, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.PaymentButton, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TeachersButton, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SalesButton, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ViewMembersButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RegisterButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ClassScheduleButton, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LogoutButton, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(314, 33)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(411, 302)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'RegisterButton
        '
        Me.RegisterButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RegisterButton.Location = New System.Drawing.Point(3, 3)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(199, 44)
        Me.RegisterButton.TabIndex = 0
        Me.RegisterButton.Text = "&Register Member"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'ViewMembersButton
        '
        Me.ViewMembersButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewMembersButton.Location = New System.Drawing.Point(208, 3)
        Me.ViewMembersButton.Name = "ViewMembersButton"
        Me.ViewMembersButton.Size = New System.Drawing.Size(200, 44)
        Me.ViewMembersButton.TabIndex = 1
        Me.ViewMembersButton.Text = "View Member"
        Me.ViewMembersButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogoutButton.Location = New System.Drawing.Point(208, 153)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(200, 44)
        Me.LogoutButton.TabIndex = 2
        Me.LogoutButton.Text = "&Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'SalesButton
        '
        Me.SalesButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SalesButton.Location = New System.Drawing.Point(208, 53)
        Me.SalesButton.Name = "SalesButton"
        Me.SalesButton.Size = New System.Drawing.Size(200, 44)
        Me.SalesButton.TabIndex = 3
        Me.SalesButton.Text = "&Sales"
        Me.SalesButton.UseVisualStyleBackColor = True
        '
        'TeachersButton
        '
        Me.TeachersButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TeachersButton.Location = New System.Drawing.Point(3, 103)
        Me.TeachersButton.Name = "TeachersButton"
        Me.TeachersButton.Size = New System.Drawing.Size(199, 44)
        Me.TeachersButton.TabIndex = 4
        Me.TeachersButton.Text = "&Teachers"
        Me.TeachersButton.UseVisualStyleBackColor = True
        '
        'ClassScheduleButton
        '
        Me.ClassScheduleButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClassScheduleButton.Location = New System.Drawing.Point(3, 53)
        Me.ClassScheduleButton.Name = "ClassScheduleButton"
        Me.ClassScheduleButton.Size = New System.Drawing.Size(199, 44)
        Me.ClassScheduleButton.TabIndex = 5
        Me.ClassScheduleButton.Text = "&Class Schedule"
        Me.ClassScheduleButton.UseVisualStyleBackColor = True
        '
        'PaymentButton
        '
        Me.PaymentButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PaymentButton.Location = New System.Drawing.Point(208, 103)
        Me.PaymentButton.Name = "PaymentButton"
        Me.PaymentButton.Size = New System.Drawing.Size(200, 44)
        Me.PaymentButton.TabIndex = 6
        Me.PaymentButton.Text = "&Payments"
        Me.PaymentButton.UseVisualStyleBackColor = True
        '
        'UsersButton
        '
        Me.UsersButton.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsersButton.Location = New System.Drawing.Point(3, 153)
        Me.UsersButton.Name = "UsersButton"
        Me.UsersButton.Size = New System.Drawing.Size(199, 44)
        Me.UsersButton.TabIndex = 7
        Me.UsersButton.Text = "&Users"
        Me.UsersButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.oneYoga.My.Resources.Resources.one_yoga_new_logo
        Me.PictureBox1.Location = New System.Drawing.Point(32, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(256, 302)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(32, 14)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(0, 13)
        Me.nameLabel.TabIndex = 2
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 372)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "mainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Yoga - Main Menu"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ClassScheduleButton As System.Windows.Forms.Button
    Friend WithEvents TeachersButton As System.Windows.Forms.Button
    Friend WithEvents SalesButton As System.Windows.Forms.Button
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
    Friend WithEvents ViewMembersButton As System.Windows.Forms.Button
    Friend WithEvents RegisterButton As System.Windows.Forms.Button
    Friend WithEvents PaymentButton As System.Windows.Forms.Button
    Friend WithEvents UsersButton As System.Windows.Forms.Button
    Friend WithEvents nameLabel As System.Windows.Forms.Label
End Class
