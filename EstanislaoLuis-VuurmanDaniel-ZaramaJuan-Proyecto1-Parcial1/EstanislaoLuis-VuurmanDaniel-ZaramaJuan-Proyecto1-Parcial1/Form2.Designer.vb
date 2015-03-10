<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RequestHolidays
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
        Me.lblHolidayRequestUser = New System.Windows.Forms.Label()
        Me.btnHolidayBack = New System.Windows.Forms.Button()
        Me.btnRequestHolidays = New System.Windows.Forms.Button()
        Me.txtHolidayRequestUser = New System.Windows.Forms.TextBox()
        Me.mcStartHolidayCalendary = New System.Windows.Forms.MonthCalendar()
        Me.mcFinishHolidayCalendary = New System.Windows.Forms.MonthCalendar()
        Me.lblStartDayHolidays = New System.Windows.Forms.Label()
        Me.lblFinishDayHolidays = New System.Windows.Forms.Label()
        Me.lblHolidayAvailable = New System.Windows.Forms.Label()
        Me.txtAvailableDays = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblHolidayRequestUser
        '
        Me.lblHolidayRequestUser.AutoSize = True
        Me.lblHolidayRequestUser.Location = New System.Drawing.Point(95, 56)
        Me.lblHolidayRequestUser.Name = "lblHolidayRequestUser"
        Me.lblHolidayRequestUser.Size = New System.Drawing.Size(32, 13)
        Me.lblHolidayRequestUser.TabIndex = 0
        Me.lblHolidayRequestUser.Text = "User:"
        '
        'btnHolidayBack
        '
        Me.btnHolidayBack.Location = New System.Drawing.Point(393, 352)
        Me.btnHolidayBack.Name = "btnHolidayBack"
        Me.btnHolidayBack.Size = New System.Drawing.Size(89, 31)
        Me.btnHolidayBack.TabIndex = 1
        Me.btnHolidayBack.Text = "Back"
        Me.btnHolidayBack.UseVisualStyleBackColor = True
        '
        'btnRequestHolidays
        '
        Me.btnRequestHolidays.Location = New System.Drawing.Point(110, 352)
        Me.btnRequestHolidays.Name = "btnRequestHolidays"
        Me.btnRequestHolidays.Size = New System.Drawing.Size(89, 31)
        Me.btnRequestHolidays.TabIndex = 2
        Me.btnRequestHolidays.Text = "Request"
        Me.btnRequestHolidays.UseVisualStyleBackColor = True
        '
        'txtHolidayRequestUser
        '
        Me.txtHolidayRequestUser.Location = New System.Drawing.Point(220, 56)
        Me.txtHolidayRequestUser.Name = "txtHolidayRequestUser"
        Me.txtHolidayRequestUser.ReadOnly = True
        Me.txtHolidayRequestUser.Size = New System.Drawing.Size(196, 20)
        Me.txtHolidayRequestUser.TabIndex = 3
        '
        'mcStartHolidayCalendary
        '
        Me.mcStartHolidayCalendary.Location = New System.Drawing.Point(42, 157)
        Me.mcStartHolidayCalendary.Name = "mcStartHolidayCalendary"
        Me.mcStartHolidayCalendary.TabIndex = 4
        '
        'mcFinishHolidayCalendary
        '
        Me.mcFinishHolidayCalendary.Location = New System.Drawing.Point(325, 157)
        Me.mcFinishHolidayCalendary.Name = "mcFinishHolidayCalendary"
        Me.mcFinishHolidayCalendary.TabIndex = 5
        '
        'lblStartDayHolidays
        '
        Me.lblStartDayHolidays.AutoSize = True
        Me.lblStartDayHolidays.Location = New System.Drawing.Point(144, 135)
        Me.lblStartDayHolidays.Name = "lblStartDayHolidays"
        Me.lblStartDayHolidays.Size = New System.Drawing.Size(29, 13)
        Me.lblStartDayHolidays.TabIndex = 6
        Me.lblStartDayHolidays.Text = "Start"
        '
        'lblFinishDayHolidays
        '
        Me.lblFinishDayHolidays.AutoSize = True
        Me.lblFinishDayHolidays.Location = New System.Drawing.Point(425, 135)
        Me.lblFinishDayHolidays.Name = "lblFinishDayHolidays"
        Me.lblFinishDayHolidays.Size = New System.Drawing.Size(34, 13)
        Me.lblFinishDayHolidays.TabIndex = 7
        Me.lblFinishDayHolidays.Text = "Finish"
        '
        'lblHolidayAvailable
        '
        Me.lblHolidayAvailable.AutoSize = True
        Me.lblHolidayAvailable.Location = New System.Drawing.Point(95, 86)
        Me.lblHolidayAvailable.Name = "lblHolidayAvailable"
        Me.lblHolidayAvailable.Size = New System.Drawing.Size(78, 13)
        Me.lblHolidayAvailable.TabIndex = 8
        Me.lblHolidayAvailable.Text = "Available days:"
        '
        'txtAvailableDays
        '
        Me.txtAvailableDays.Location = New System.Drawing.Point(220, 86)
        Me.txtAvailableDays.Name = "txtAvailableDays"
        Me.txtAvailableDays.ReadOnly = True
        Me.txtAvailableDays.Size = New System.Drawing.Size(196, 20)
        Me.txtAvailableDays.TabIndex = 9
        '
        'RequestHolidays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(570, 429)
        Me.Controls.Add(Me.txtAvailableDays)
        Me.Controls.Add(Me.lblHolidayAvailable)
        Me.Controls.Add(Me.lblFinishDayHolidays)
        Me.Controls.Add(Me.lblStartDayHolidays)
        Me.Controls.Add(Me.mcFinishHolidayCalendary)
        Me.Controls.Add(Me.mcStartHolidayCalendary)
        Me.Controls.Add(Me.txtHolidayRequestUser)
        Me.Controls.Add(Me.btnRequestHolidays)
        Me.Controls.Add(Me.btnHolidayBack)
        Me.Controls.Add(Me.lblHolidayRequestUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RequestHolidays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHolidayRequestUser As System.Windows.Forms.Label
    Friend WithEvents btnHolidayBack As System.Windows.Forms.Button
    Friend WithEvents btnRequestHolidays As System.Windows.Forms.Button
    Friend WithEvents txtHolidayRequestUser As System.Windows.Forms.TextBox
    Friend WithEvents mcStartHolidayCalendary As System.Windows.Forms.MonthCalendar
    Friend WithEvents mcFinishHolidayCalendary As System.Windows.Forms.MonthCalendar
    Friend WithEvents lblStartDayHolidays As System.Windows.Forms.Label
    Friend WithEvents lblFinishDayHolidays As System.Windows.Forms.Label
    Friend WithEvents lblHolidayAvailable As System.Windows.Forms.Label
    Friend WithEvents txtAvailableDays As System.Windows.Forms.TextBox
End Class
