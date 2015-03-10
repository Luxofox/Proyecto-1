<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proyect_Administration
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
        Me.btnCreateProyect = New System.Windows.Forms.Button()
        Me.lblNameOfProyect = New System.Windows.Forms.Label()
        Me.lblBudget = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.mcDueDate = New System.Windows.Forms.MonthCalendar()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.btnUsersInProyects = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToAddUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToMainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateProyect
        '
        Me.btnCreateProyect.Location = New System.Drawing.Point(59, 344)
        Me.btnCreateProyect.Name = "btnCreateProyect"
        Me.btnCreateProyect.Size = New System.Drawing.Size(102, 43)
        Me.btnCreateProyect.TabIndex = 0
        Me.btnCreateProyect.Text = "Create Proyect"
        Me.btnCreateProyect.UseVisualStyleBackColor = True
        '
        'lblNameOfProyect
        '
        Me.lblNameOfProyect.AutoSize = True
        Me.lblNameOfProyect.Location = New System.Drawing.Point(56, 82)
        Me.lblNameOfProyect.Name = "lblNameOfProyect"
        Me.lblNameOfProyect.Size = New System.Drawing.Size(77, 13)
        Me.lblNameOfProyect.TabIndex = 1
        Me.lblNameOfProyect.Text = "Proyect Name:"
        '
        'lblBudget
        '
        Me.lblBudget.AutoSize = True
        Me.lblBudget.Location = New System.Drawing.Point(62, 128)
        Me.lblBudget.Name = "lblBudget"
        Me.lblBudget.Size = New System.Drawing.Size(44, 13)
        Me.lblBudget.TabIndex = 2
        Me.lblBudget.Text = "Budget:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(139, 56)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Allowed weekends"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(139, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(227, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(139, 125)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(227, 20)
        Me.TextBox2.TabIndex = 5
        '
        'mcDueDate
        '
        Me.mcDueDate.Location = New System.Drawing.Point(139, 157)
        Me.mcDueDate.Name = "mcDueDate"
        Me.mcDueDate.TabIndex = 6
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(62, 231)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(56, 13)
        Me.lblDueDate.TabIndex = 7
        Me.lblDueDate.Text = "Due Date:"
        '
        'btnUsersInProyects
        '
        Me.btnUsersInProyects.Location = New System.Drawing.Point(263, 344)
        Me.btnUsersInProyects.Name = "btnUsersInProyects"
        Me.btnUsersInProyects.Size = New System.Drawing.Size(103, 43)
        Me.btnUsersInProyects.TabIndex = 8
        Me.btnUsersInProyects.Text = "Add Users to Proyects"
        Me.btnUsersInProyects.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(489, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GoToAddUsersToolStripMenuItem, Me.GoToMainMenuToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'GoToAddUsersToolStripMenuItem
        '
        Me.GoToAddUsersToolStripMenuItem.Name = "GoToAddUsersToolStripMenuItem"
        Me.GoToAddUsersToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.GoToAddUsersToolStripMenuItem.Text = "Go to Add Users"
        '
        'GoToMainMenuToolStripMenuItem
        '
        Me.GoToMainMenuToolStripMenuItem.Name = "GoToMainMenuToolStripMenuItem"
        Me.GoToMainMenuToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.GoToMainMenuToolStripMenuItem.Text = "Go to Main Menu"
        '
        'Proyect_Administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(489, 428)
        Me.Controls.Add(Me.btnUsersInProyects)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.mcDueDate)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblBudget)
        Me.Controls.Add(Me.lblNameOfProyect)
        Me.Controls.Add(Me.btnCreateProyect)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Proyect_Administration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyect_Administration"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreateProyect As System.Windows.Forms.Button
    Friend WithEvents lblNameOfProyect As System.Windows.Forms.Label
    Friend WithEvents lblBudget As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents mcDueDate As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblDueDate As System.Windows.Forms.Label
    Friend WithEvents btnUsersInProyects As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToAddUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GoToMainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
