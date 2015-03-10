<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Time_Registration
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
        Me.mcStartRegister = New System.Windows.Forms.MonthCalendar()
        Me.mcFinishRegister = New System.Windows.Forms.MonthCalendar()
        Me.lblStartEntryHours = New System.Windows.Forms.Label()
        Me.lblFinishEntryHours = New System.Windows.Forms.Label()
        Me.lblWorkedHours = New System.Windows.Forms.Label()
        Me.txtWorkedHours = New System.Windows.Forms.TextBox()
        Me.cbMultipleEntry = New System.Windows.Forms.CheckBox()
        Me.cbAllowedWeekends = New System.Windows.Forms.CheckBox()
        Me.btnRegisterHours = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mcStartRegister
        '
        Me.mcStartRegister.Location = New System.Drawing.Point(49, 103)
        Me.mcStartRegister.Name = "mcStartRegister"
        Me.mcStartRegister.TabIndex = 2
        '
        'mcFinishRegister
        '
        Me.mcFinishRegister.Location = New System.Drawing.Point(330, 103)
        Me.mcFinishRegister.Name = "mcFinishRegister"
        Me.mcFinishRegister.TabIndex = 3
        '
        'lblStartEntryHours
        '
        Me.lblStartEntryHours.AutoSize = True
        Me.lblStartEntryHours.Location = New System.Drawing.Point(46, 64)
        Me.lblStartEntryHours.Name = "lblStartEntryHours"
        Me.lblStartEntryHours.Size = New System.Drawing.Size(29, 13)
        Me.lblStartEntryHours.TabIndex = 4
        Me.lblStartEntryHours.Text = "Start"
        '
        'lblFinishEntryHours
        '
        Me.lblFinishEntryHours.AutoSize = True
        Me.lblFinishEntryHours.Location = New System.Drawing.Point(330, 64)
        Me.lblFinishEntryHours.Name = "lblFinishEntryHours"
        Me.lblFinishEntryHours.Size = New System.Drawing.Size(34, 13)
        Me.lblFinishEntryHours.TabIndex = 5
        Me.lblFinishEntryHours.Text = "Finish"
        '
        'lblWorkedHours
        '
        Me.lblWorkedHours.AutoSize = True
        Me.lblWorkedHours.Location = New System.Drawing.Point(49, 291)
        Me.lblWorkedHours.Name = "lblWorkedHours"
        Me.lblWorkedHours.Size = New System.Drawing.Size(79, 13)
        Me.lblWorkedHours.TabIndex = 6
        Me.lblWorkedHours.Text = "Worked Hours:"
        '
        'txtWorkedHours
        '
        Me.txtWorkedHours.Location = New System.Drawing.Point(131, 288)
        Me.txtWorkedHours.Name = "txtWorkedHours"
        Me.txtWorkedHours.Size = New System.Drawing.Size(145, 20)
        Me.txtWorkedHours.TabIndex = 7
        '
        'cbMultipleEntry
        '
        Me.cbMultipleEntry.AutoSize = True
        Me.cbMultipleEntry.Location = New System.Drawing.Point(333, 291)
        Me.cbMultipleEntry.Name = "cbMultipleEntry"
        Me.cbMultipleEntry.Size = New System.Drawing.Size(89, 17)
        Me.cbMultipleEntry.TabIndex = 8
        Me.cbMultipleEntry.Text = "Multiple-Entry"
        Me.cbMultipleEntry.UseVisualStyleBackColor = True
        '
        'cbAllowedWeekends
        '
        Me.cbAllowedWeekends.AutoSize = True
        Me.cbAllowedWeekends.Location = New System.Drawing.Point(439, 291)
        Me.cbAllowedWeekends.Name = "cbAllowedWeekends"
        Me.cbAllowedWeekends.Size = New System.Drawing.Size(118, 17)
        Me.cbAllowedWeekends.TabIndex = 9
        Me.cbAllowedWeekends.Text = "Allowed Weekends"
        Me.cbAllowedWeekends.UseVisualStyleBackColor = True
        '
        'btnRegisterHours
        '
        Me.btnRegisterHours.Location = New System.Drawing.Point(52, 349)
        Me.btnRegisterHours.Name = "btnRegisterHours"
        Me.btnRegisterHours.Size = New System.Drawing.Size(109, 39)
        Me.btnRegisterHours.TabIndex = 10
        Me.btnRegisterHours.Text = "Register Hours"
        Me.btnRegisterHours.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToMainMenuToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ReturnToMainMenuToolStripMenuItem
        '
        Me.ReturnToMainMenuToolStripMenuItem.Name = "ReturnToMainMenuToolStripMenuItem"
        Me.ReturnToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ReturnToMainMenuToolStripMenuItem.Text = "Return to Main Menu"
        '
        'Time_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(624, 419)
        Me.Controls.Add(Me.btnRegisterHours)
        Me.Controls.Add(Me.cbAllowedWeekends)
        Me.Controls.Add(Me.cbMultipleEntry)
        Me.Controls.Add(Me.txtWorkedHours)
        Me.Controls.Add(Me.lblWorkedHours)
        Me.Controls.Add(Me.lblFinishEntryHours)
        Me.Controls.Add(Me.lblStartEntryHours)
        Me.Controls.Add(Me.mcFinishRegister)
        Me.Controls.Add(Me.mcStartRegister)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Time_Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time_Registration"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mcStartRegister As System.Windows.Forms.MonthCalendar
    Friend WithEvents mcFinishRegister As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblStartEntryHours As System.Windows.Forms.Label
    Friend WithEvents lblFinishEntryHours As System.Windows.Forms.Label
    Friend WithEvents lblWorkedHours As System.Windows.Forms.Label
    Friend WithEvents txtWorkedHours As System.Windows.Forms.TextBox
    Friend WithEvents cbMultipleEntry As System.Windows.Forms.CheckBox
    Friend WithEvents cbAllowedWeekends As System.Windows.Forms.CheckBox
    Friend WithEvents btnRegisterHours As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
