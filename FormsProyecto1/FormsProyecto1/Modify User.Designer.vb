<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modify_User
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblUserSelection = New System.Windows.Forms.Label()
        Me.lblModifyUsername = New System.Windows.Forms.Label()
        Me.lblModifyUserPassword = New System.Windows.Forms.Label()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.txtModifyUserName = New System.Windows.Forms.TextBox()
        Me.txtModifyUserPassword = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToUserAdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblModifyFirstName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModifyFirstName = New System.Windows.Forms.TextBox()
        Me.txtModifyLastName = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(157, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'lblUserSelection
        '
        Me.lblUserSelection.AutoSize = True
        Me.lblUserSelection.Location = New System.Drawing.Point(48, 45)
        Me.lblUserSelection.Name = "lblUserSelection"
        Me.lblUserSelection.Size = New System.Drawing.Size(65, 13)
        Me.lblUserSelection.TabIndex = 1
        Me.lblUserSelection.Text = "Select User:"
        '
        'lblModifyUsername
        '
        Me.lblModifyUsername.AutoSize = True
        Me.lblModifyUsername.Location = New System.Drawing.Point(48, 99)
        Me.lblModifyUsername.Name = "lblModifyUsername"
        Me.lblModifyUsername.Size = New System.Drawing.Size(60, 13)
        Me.lblModifyUsername.TabIndex = 3
        Me.lblModifyUsername.Text = "UserName:"
        '
        'lblModifyUserPassword
        '
        Me.lblModifyUserPassword.AutoSize = True
        Me.lblModifyUserPassword.Location = New System.Drawing.Point(49, 136)
        Me.lblModifyUserPassword.Name = "lblModifyUserPassword"
        Me.lblModifyUserPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblModifyUserPassword.TabIndex = 4
        Me.lblModifyUserPassword.Text = "Password:"
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(96, 275)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(128, 23)
        Me.btnSaveChanges.TabIndex = 5
        Me.btnSaveChanges.Text = "Save changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'txtModifyUserName
        '
        Me.txtModifyUserName.Location = New System.Drawing.Point(157, 92)
        Me.txtModifyUserName.Name = "txtModifyUserName"
        Me.txtModifyUserName.Size = New System.Drawing.Size(121, 20)
        Me.txtModifyUserName.TabIndex = 6
        '
        'txtModifyUserPassword
        '
        Me.txtModifyUserPassword.Location = New System.Drawing.Point(157, 136)
        Me.txtModifyUserPassword.Name = "txtModifyUserPassword"
        Me.txtModifyUserPassword.Size = New System.Drawing.Size(121, 20)
        Me.txtModifyUserPassword.TabIndex = 7
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(340, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToUserAdministrationToolStripMenuItem, Me.ReturnToMainMenuToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ReturnToUserAdministrationToolStripMenuItem
        '
        Me.ReturnToUserAdministrationToolStripMenuItem.Name = "ReturnToUserAdministrationToolStripMenuItem"
        Me.ReturnToUserAdministrationToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ReturnToUserAdministrationToolStripMenuItem.Text = "Return to User Administration"
        '
        'ReturnToMainMenuToolStripMenuItem
        '
        Me.ReturnToMainMenuToolStripMenuItem.Name = "ReturnToMainMenuToolStripMenuItem"
        Me.ReturnToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ReturnToMainMenuToolStripMenuItem.Text = "Return to Main Menu"
        '
        'lblModifyFirstName
        '
        Me.lblModifyFirstName.AutoSize = True
        Me.lblModifyFirstName.Location = New System.Drawing.Point(52, 181)
        Me.lblModifyFirstName.Name = "lblModifyFirstName"
        Me.lblModifyFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblModifyFirstName.TabIndex = 9
        Me.lblModifyFirstName.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Last Name:"
        '
        'txtModifyFirstName
        '
        Me.txtModifyFirstName.Location = New System.Drawing.Point(157, 181)
        Me.txtModifyFirstName.Name = "txtModifyFirstName"
        Me.txtModifyFirstName.Size = New System.Drawing.Size(121, 20)
        Me.txtModifyFirstName.TabIndex = 11
        '
        'txtModifyLastName
        '
        Me.txtModifyLastName.Location = New System.Drawing.Point(157, 226)
        Me.txtModifyLastName.Name = "txtModifyLastName"
        Me.txtModifyLastName.Size = New System.Drawing.Size(121, 20)
        Me.txtModifyLastName.TabIndex = 12
        '
        'Modify_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(340, 337)
        Me.Controls.Add(Me.txtModifyLastName)
        Me.Controls.Add(Me.txtModifyFirstName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblModifyFirstName)
        Me.Controls.Add(Me.txtModifyUserPassword)
        Me.Controls.Add(Me.txtModifyUserName)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.lblModifyUserPassword)
        Me.Controls.Add(Me.lblModifyUsername)
        Me.Controls.Add(Me.lblUserSelection)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Modify_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modify_User"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lblUserSelection As System.Windows.Forms.Label
    Friend WithEvents lblModifyUsername As System.Windows.Forms.Label
    Friend WithEvents lblModifyUserPassword As System.Windows.Forms.Label
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents txtModifyUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtModifyUserPassword As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToUserAdministrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblModifyFirstName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtModifyFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtModifyLastName As System.Windows.Forms.TextBox
End Class
