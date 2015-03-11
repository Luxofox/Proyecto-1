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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblProyect = New System.Windows.Forms.Label()
        Me.cbSelectionProyectRegisterHours = New System.Windows.Forms.ComboBox()
        Me.lblWorkCategory = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mcStartRegister
        '
        Me.mcStartRegister.Location = New System.Drawing.Point(52, 137)
        Me.mcStartRegister.Name = "mcStartRegister"
        Me.mcStartRegister.TabIndex = 2
        '
        'mcFinishRegister
        '
        Me.mcFinishRegister.Location = New System.Drawing.Point(340, 137)
        Me.mcFinishRegister.Name = "mcFinishRegister"
        Me.mcFinishRegister.TabIndex = 3
        '
        'lblStartEntryHours
        '
        Me.lblStartEntryHours.AutoSize = True
        Me.lblStartEntryHours.Location = New System.Drawing.Point(49, 115)
        Me.lblStartEntryHours.Name = "lblStartEntryHours"
        Me.lblStartEntryHours.Size = New System.Drawing.Size(29, 13)
        Me.lblStartEntryHours.TabIndex = 4
        Me.lblStartEntryHours.Text = "Start"
        '
        'lblFinishEntryHours
        '
        Me.lblFinishEntryHours.AutoSize = True
        Me.lblFinishEntryHours.Location = New System.Drawing.Point(337, 115)
        Me.lblFinishEntryHours.Name = "lblFinishEntryHours"
        Me.lblFinishEntryHours.Size = New System.Drawing.Size(34, 13)
        Me.lblFinishEntryHours.TabIndex = 5
        Me.lblFinishEntryHours.Text = "Finish"
        '
        'lblWorkedHours
        '
        Me.lblWorkedHours.AutoSize = True
        Me.lblWorkedHours.Location = New System.Drawing.Point(49, 325)
        Me.lblWorkedHours.Name = "lblWorkedHours"
        Me.lblWorkedHours.Size = New System.Drawing.Size(79, 13)
        Me.lblWorkedHours.TabIndex = 6
        Me.lblWorkedHours.Text = "Worked Hours:"
        '
        'txtWorkedHours
        '
        Me.txtWorkedHours.Location = New System.Drawing.Point(134, 322)
        Me.txtWorkedHours.Name = "txtWorkedHours"
        Me.txtWorkedHours.Size = New System.Drawing.Size(145, 20)
        Me.txtWorkedHours.TabIndex = 7
        '
        'cbMultipleEntry
        '
        Me.cbMultipleEntry.AutoSize = True
        Me.cbMultipleEntry.Location = New System.Drawing.Point(297, 325)
        Me.cbMultipleEntry.Name = "cbMultipleEntry"
        Me.cbMultipleEntry.Size = New System.Drawing.Size(89, 17)
        Me.cbMultipleEntry.TabIndex = 8
        Me.cbMultipleEntry.Text = "Multiple-Entry"
        Me.cbMultipleEntry.UseVisualStyleBackColor = True
        '
        'cbAllowedWeekends
        '
        Me.cbAllowedWeekends.AutoSize = True
        Me.cbAllowedWeekends.Location = New System.Drawing.Point(392, 324)
        Me.cbAllowedWeekends.Name = "cbAllowedWeekends"
        Me.cbAllowedWeekends.Size = New System.Drawing.Size(118, 17)
        Me.cbAllowedWeekends.TabIndex = 9
        Me.cbAllowedWeekends.Text = "Allowed Weekends"
        Me.cbAllowedWeekends.UseVisualStyleBackColor = True
        '
        'btnRegisterHours
        '
        Me.btnRegisterHours.Location = New System.Drawing.Point(52, 422)
        Me.btnRegisterHours.Name = "btnRegisterHours"
        Me.btnRegisterHours.Size = New System.Drawing.Size(109, 39)
        Me.btnRegisterHours.TabIndex = 10
        Me.btnRegisterHours.Text = "Register Hours"
        Me.btnRegisterHours.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(134, 370)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(433, 28)
        Me.txtDescription.TabIndex = 13
        '
        'lblProyect
        '
        Me.lblProyect.AutoSize = True
        Me.lblProyect.Location = New System.Drawing.Point(49, 51)
        Me.lblProyect.Name = "lblProyect"
        Me.lblProyect.Size = New System.Drawing.Size(46, 13)
        Me.lblProyect.TabIndex = 14
        Me.lblProyect.Text = "Proyect:"
        '
        'cbSelectionProyectRegisterHours
        '
        Me.cbSelectionProyectRegisterHours.FormattingEnabled = True
        Me.cbSelectionProyectRegisterHours.Location = New System.Drawing.Point(101, 48)
        Me.cbSelectionProyectRegisterHours.Name = "cbSelectionProyectRegisterHours"
        Me.cbSelectionProyectRegisterHours.Size = New System.Drawing.Size(253, 21)
        Me.cbSelectionProyectRegisterHours.TabIndex = 15
        '
        'lblWorkCategory
        '
        Me.lblWorkCategory.AutoSize = True
        Me.lblWorkCategory.Location = New System.Drawing.Point(52, 87)
        Me.lblWorkCategory.Name = "lblWorkCategory"
        Me.lblWorkCategory.Size = New System.Drawing.Size(81, 13)
        Me.lblWorkCategory.TabIndex = 16
        Me.lblWorkCategory.Text = "Work Category:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(139, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(178, 21)
        Me.ComboBox1.TabIndex = 17
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Time_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(646, 486)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblWorkCategory)
        Me.Controls.Add(Me.cbSelectionProyectRegisterHours)
        Me.Controls.Add(Me.lblProyect)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblProyect As System.Windows.Forms.Label
    Friend WithEvents cbSelectionProyectRegisterHours As System.Windows.Forms.ComboBox
    Friend WithEvents lblWorkCategory As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
End Class
