Imports System.Data.SqlClient

Public Class MainMenu
    'Set the color red to Borders
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim AnchoBorde As Integer = 5
        Dim ColorBorde As Color = Color.Red
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, ColorBorde,
        AnchoBorde, ButtonBorderStyle.Solid, ColorBorde, AnchoBorde,
        ButtonBorderStyle.Solid, ColorBorde, AnchoBorde, ButtonBorderStyle.Solid,
        ColorBorde, AnchoBorde, ButtonBorderStyle.Solid)
    End Sub


    Dim strConexion As String = "Data Source=(localdb)\ProjectsV12;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"
    Dim connection As New SqlConnection(strConexion)
    Dim dataTableUser As New DataTable
    Dim dataTableRole As New DataTable
    Public Function createDataTableUser() As DataTable

        dataTableUser = New DataTable
        dataTableUser.Columns.Add("User ID")
        dataTableUser.Columns.Add("Name")
        dataTableUser.Columns.Add("Last Name")
        dataTableUser.Columns.Add("Username")
        dataTableUser.Columns.Add("Password")
        dataTableUser.Columns.Add("Active")
        dataTableUser.Columns.Add("Entry Date")
        dataTableUser.Columns.Add("Role ID")

        createDataTableUser = dataTableUser

    End Function
    Public Function askUserInputs() As User
        Dim nameOfUser As String
        Dim userName As String
        Dim userId As Integer
        Dim userLastname As String
        Dim userStatus As Boolean
        ' Dim userEntryDate As Date
        Dim userPassword As String
        Dim UserIdRole As Integer
        Dim user As New User
        nameOfUser = InputBox("Please enter the name of the user: ")
        userLastname = InputBox("Please enter the last name of the user : ")
        userName = InputBox("Please enter the username: ")
        userPassword = InputBox("Please enter the password of the user: ")
        UserIdRole = CInt(InputBox("Please enter the user Role: "))
        userId = CInt(InputBox("Please enter the user ID: "))
        userStatus = MsgBox("Please select if the user its active or not", MsgBoxStyle.YesNo, "Please select one")
        If userStatus = 0 Then
            userStatus = True
        Else : userStatus = False
        End If
        'userEntryDate = InputBox()
        'Here we create the object
        user.user_Id = userId
        user.user_Name = userName
        user.name_Of_User = nameOfUser
        user.user_Lastname = userLastname
        user.user_Status = userStatus
        user.user_Password = userPassword
        user.User_IdRole = UserIdRole
        'return user
        askUserInputs = user

    End Function

    Public Function createDataTableRole() As DataTable

        dataTableUser = New DataTable
        dataTableUser.Columns.Add("Role ID")
        dataTableUser.Columns.Add("Role Name")
        dataTableUser.Columns.Add("Role Description")
       

        createDataTableRole = dataTableUser

    End Function
    Public Function askRoleInputs() As Role
        Dim roleId As Integer
        Dim roleName As String
        Dim roleDescription As String


        Dim role As New Role
        roleName = InputBox("Please enter the name of the user: ")
        roleDescription = InputBox("Please enter the last name of the user : ")
        roleId = CInt(InputBox("Please enter the user Role: "))


        'Here we create the object
        role.role_Id = roleId
        role.role_Name = roleName
        role.role_Description = roleDescription
        'return course
        askRoleInputs = role

    End Function

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class