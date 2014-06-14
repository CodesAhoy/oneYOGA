<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classes
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
        Me.AddSubjectButton = New System.Windows.Forms.Button()
        Me.ViewSubjectsButton = New System.Windows.Forms.Button()
        Me.AddClassScheduleButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddSubjectButton
        '
        Me.AddSubjectButton.Location = New System.Drawing.Point(73, 58)
        Me.AddSubjectButton.Name = "AddSubjectButton"
        Me.AddSubjectButton.Size = New System.Drawing.Size(135, 23)
        Me.AddSubjectButton.TabIndex = 0
        Me.AddSubjectButton.Text = "Add Subjects"
        Me.AddSubjectButton.UseVisualStyleBackColor = True
        '
        'ViewSubjectsButton
        '
        Me.ViewSubjectsButton.Location = New System.Drawing.Point(73, 87)
        Me.ViewSubjectsButton.Name = "ViewSubjectsButton"
        Me.ViewSubjectsButton.Size = New System.Drawing.Size(135, 23)
        Me.ViewSubjectsButton.TabIndex = 1
        Me.ViewSubjectsButton.Text = "View Subjects"
        Me.ViewSubjectsButton.UseVisualStyleBackColor = True
        '
        'AddClassScheduleButton
        '
        Me.AddClassScheduleButton.Location = New System.Drawing.Point(75, 115)
        Me.AddClassScheduleButton.Name = "AddClassScheduleButton"
        Me.AddClassScheduleButton.Size = New System.Drawing.Size(135, 23)
        Me.AddClassScheduleButton.TabIndex = 2
        Me.AddClassScheduleButton.Text = "Add Class Schedule"
        Me.AddClassScheduleButton.UseVisualStyleBackColor = True
        '
        'Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 208)
        Me.Controls.Add(Me.AddClassScheduleButton)
        Me.Controls.Add(Me.ViewSubjectsButton)
        Me.Controls.Add(Me.AddSubjectButton)
        Me.Name = "Classes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Yoga - Class Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddSubjectButton As System.Windows.Forms.Button
    Friend WithEvents ViewSubjectsButton As System.Windows.Forms.Button
    Friend WithEvents AddClassScheduleButton As System.Windows.Forms.Button
End Class
