<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfile
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
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.btnUserProfileBack = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mtsUserMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfProyectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlertsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MassagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestedHolidaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblEnterpriseCharge = New System.Windows.Forms.Label()
        Me.btnSendMessage = New System.Windows.Forms.Button()
        Me.ReturnToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(60, 59)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(74, 16)
        Me.lblUserName.TabIndex = 0
        Me.lblUserName.Text = "UserName"
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserEmail.Location = New System.Drawing.Point(60, 135)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(71, 16)
        Me.lblUserEmail.TabIndex = 1
        Me.lblUserEmail.Text = "UserEmail"
        '
        'btnUserProfileBack
        '
        Me.btnUserProfileBack.Location = New System.Drawing.Point(63, 190)
        Me.btnUserProfileBack.Name = "btnUserProfileBack"
        Me.btnUserProfileBack.Size = New System.Drawing.Size(75, 29)
        Me.btnUserProfileBack.TabIndex = 2
        Me.btnUserProfileBack.Text = "Back"
        Me.btnUserProfileBack.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mtsUserMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(194, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mtsUserMenu
        '
        Me.mtsUserMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProyectsToolStripMenuItem, Me.InboxToolStripMenuItem, Me.RequestedHolidaysToolStripMenuItem, Me.ReturnToMainMenuToolStripMenuItem})
        Me.mtsUserMenu.Name = "mtsUserMenu"
        Me.mtsUserMenu.Size = New System.Drawing.Size(50, 20)
        Me.mtsUserMenu.Text = "Menu"
        '
        'ProyectsToolStripMenuItem
        '
        Me.ProyectsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfProyectsToolStripMenuItem})
        Me.ProyectsToolStripMenuItem.Name = "ProyectsToolStripMenuItem"
        Me.ProyectsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ProyectsToolStripMenuItem.Text = "Proyects"
        '
        'ListOfProyectsToolStripMenuItem
        '
        Me.ListOfProyectsToolStripMenuItem.Name = "ListOfProyectsToolStripMenuItem"
        Me.ListOfProyectsToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ListOfProyectsToolStripMenuItem.Text = "List of proyects"
        '
        'InboxToolStripMenuItem
        '
        Me.InboxToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlertsToolStripMenuItem, Me.MassagesToolStripMenuItem})
        Me.InboxToolStripMenuItem.Name = "InboxToolStripMenuItem"
        Me.InboxToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.InboxToolStripMenuItem.Text = "Inbox"
        '
        'AlertsToolStripMenuItem
        '
        Me.AlertsToolStripMenuItem.Name = "AlertsToolStripMenuItem"
        Me.AlertsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AlertsToolStripMenuItem.Text = "Alerts"
        '
        'MassagesToolStripMenuItem
        '
        Me.MassagesToolStripMenuItem.Name = "MassagesToolStripMenuItem"
        Me.MassagesToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.MassagesToolStripMenuItem.Text = "Messages"
        '
        'RequestedHolidaysToolStripMenuItem
        '
        Me.RequestedHolidaysToolStripMenuItem.Name = "RequestedHolidaysToolStripMenuItem"
        Me.RequestedHolidaysToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.RequestedHolidaysToolStripMenuItem.Text = "Requested Holidays"
        '
        'lblEnterpriseCharge
        '
        Me.lblEnterpriseCharge.AutoSize = True
        Me.lblEnterpriseCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterpriseCharge.Location = New System.Drawing.Point(42, 94)
        Me.lblEnterpriseCharge.Name = "lblEnterpriseCharge"
        Me.lblEnterpriseCharge.Size = New System.Drawing.Size(113, 16)
        Me.lblEnterpriseCharge.TabIndex = 5
        Me.lblEnterpriseCharge.Text = "EnterpriseCharge"
        '
        'btnSendMessage
        '
        Me.btnSendMessage.Location = New System.Drawing.Point(36, 225)
        Me.btnSendMessage.Name = "btnSendMessage"
        Me.btnSendMessage.Size = New System.Drawing.Size(126, 29)
        Me.btnSendMessage.TabIndex = 6
        Me.btnSendMessage.Text = "Send a message"
        Me.btnSendMessage.UseVisualStyleBackColor = True
        '
        'ReturnToMainMenuToolStripMenuItem
        '
        Me.ReturnToMainMenuToolStripMenuItem.Name = "ReturnToMainMenuToolStripMenuItem"
        Me.ReturnToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ReturnToMainMenuToolStripMenuItem.Text = "Return to Main Menu"
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(194, 278)
        Me.Controls.Add(Me.btnSendMessage)
        Me.Controls.Add(Me.lblEnterpriseCharge)
        Me.Controls.Add(Me.btnUserProfileBack)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "UserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents btnUserProfileBack As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mtsUserMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProyectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfProyectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestedHolidaysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InboxToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlertsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MassagesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblEnterpriseCharge As System.Windows.Forms.Label
    Friend WithEvents btnSendMessage As System.Windows.Forms.Button
    Friend WithEvents ReturnToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
