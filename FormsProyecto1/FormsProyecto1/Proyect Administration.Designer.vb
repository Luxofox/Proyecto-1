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
        Me.SuspendLayout()
        '
        'btnCreateProyect
        '
        Me.btnCreateProyect.Location = New System.Drawing.Point(152, 354)
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
        Me.CheckBox1.Location = New System.Drawing.Point(139, 45)
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
        Me.TextBox1.Size = New System.Drawing.Size(166, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(139, 125)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 20)
        Me.TextBox2.TabIndex = 5
        '
        'mcDueDate
        '
        Me.mcDueDate.Location = New System.Drawing.Point(349, 79)
        Me.mcDueDate.Name = "mcDueDate"
        Me.mcDueDate.TabIndex = 6
        '
        'lblDueDate
        '
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Location = New System.Drawing.Point(62, 233)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(56, 13)
        Me.lblDueDate.TabIndex = 7
        Me.lblDueDate.Text = "Due Date:"
        '
        'Proyect_Administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(664, 428)
        Me.Controls.Add(Me.lblDueDate)
        Me.Controls.Add(Me.mcDueDate)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblBudget)
        Me.Controls.Add(Me.lblNameOfProyect)
        Me.Controls.Add(Me.btnCreateProyect)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Proyect_Administration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proyect_Administration"
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
End Class
