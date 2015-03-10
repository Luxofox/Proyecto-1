<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.btnTimeRegistration = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnUserAdministration = New System.Windows.Forms.Button()
        Me.btnHolidayRequest = New System.Windows.Forms.Button()
        Me.btnHolidayBank = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnTimeRegistration
        '
        Me.btnTimeRegistration.Location = New System.Drawing.Point(158, 90)
        Me.btnTimeRegistration.Name = "btnTimeRegistration"
        Me.btnTimeRegistration.Size = New System.Drawing.Size(134, 38)
        Me.btnTimeRegistration.TabIndex = 0
        Me.btnTimeRegistration.Text = "Time Registration"
        Me.btnTimeRegistration.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.Location = New System.Drawing.Point(158, 134)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(134, 38)
        Me.btnProfile.TabIndex = 1
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(158, 310)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(134, 38)
        Me.btnReports.TabIndex = 2
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnUserAdministration
        '
        Me.btnUserAdministration.Location = New System.Drawing.Point(158, 266)
        Me.btnUserAdministration.Name = "btnUserAdministration"
        Me.btnUserAdministration.Size = New System.Drawing.Size(134, 38)
        Me.btnUserAdministration.TabIndex = 3
        Me.btnUserAdministration.Text = "User Administration"
        Me.btnUserAdministration.UseVisualStyleBackColor = True
        '
        'btnHolidayRequest
        '
        Me.btnHolidayRequest.Location = New System.Drawing.Point(158, 178)
        Me.btnHolidayRequest.Name = "btnHolidayRequest"
        Me.btnHolidayRequest.Size = New System.Drawing.Size(134, 38)
        Me.btnHolidayRequest.TabIndex = 4
        Me.btnHolidayRequest.Text = "Request Holiday"
        Me.btnHolidayRequest.UseVisualStyleBackColor = True
        '
        'btnHolidayBank
        '
        Me.btnHolidayBank.Location = New System.Drawing.Point(158, 222)
        Me.btnHolidayBank.Name = "btnHolidayBank"
        Me.btnHolidayBank.Size = New System.Drawing.Size(134, 38)
        Me.btnHolidayBank.TabIndex = 5
        Me.btnHolidayBank.Text = "Holiday Bank"
        Me.btnHolidayBank.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(183, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 35)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.ForeColor = System.Drawing.Color.Red
        Me.lblMainMenu.Location = New System.Drawing.Point(170, 40)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(109, 20)
        Me.lblMainMenu.TabIndex = 7
        Me.lblMainMenu.Text = "MAIN MENU"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(474, 446)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHolidayBank)
        Me.Controls.Add(Me.btnHolidayRequest)
        Me.Controls.Add(Me.btnUserAdministration)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnTimeRegistration)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnTimeRegistration As System.Windows.Forms.Button
    Friend WithEvents btnProfile As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnUserAdministration As System.Windows.Forms.Button
    Friend WithEvents btnHolidayRequest As System.Windows.Forms.Button
    Friend WithEvents btnHolidayBank As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblMainMenu As System.Windows.Forms.Label
End Class
