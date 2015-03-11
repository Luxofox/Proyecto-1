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


    Dim strConexion As String = "Data Source=(LocalDB)\v11.0;Initial Catalog=Clessidra;Integrated Security=True"
    Dim connection As New SqlConnection(strConexion)
    Dim dataTableUser As New DataTable
    Dim dataTableRole As New DataTable
    Public Function createDataTableUser() As DataTable

        dataTableUser = New DataTable
        dataTableUser.Columns.Add("User ID")
        dataTableUser.Columns.Add("Name")
        dataTableUser.Columns.Add("Last Name")
        dataTableUser.Columns.Add("Status")
        dataTableUser.Columns.Add("Username")
        dataTableUser.Columns.Add("Password")
        dataTableUser.Columns.Add("Role ID")
        'dataTableUser.Columns.Add("Entry Date")

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

  
    Public Sub insertUsers(ByVal user As User)

        Dim cmdInsert As New SqlCommand
        cmdInsert = New SqlCommand("insert into User(,userName,userLastname,userStatus,userPassword,UserIdRole)" & _
                                   "values(@userID,@userName,@userLastname,@userStatus,@userPassword,@UserIdRole)", connection)

        With cmdInsert

            .Parameters.AddWithValue("@userID", user.user_Id)
            .Parameters.AddWithValue("@userName", user.user_Name)
            .Parameters.AddWithValue("@userLastname", user.user_Lastname)
            .Parameters.AddWithValue("@userStatus", user.user_Status)
            .Parameters.AddWithValue("@userPassword", user.user_Password)
            .Parameters.AddWithValue("@UserIdRole", user.User_IdRole)

        End With

        connection.Open()
        cmdInsert.ExecuteNonQuery()
        connection.Close()
        MsgBox("The data of the user has been succesfully added")

    End Sub
    
    Public Sub insertRoles(ByVal role As Role)

        Dim cmdInsert As New SqlCommand
        cmdInsert = New SqlCommand("insert into Role(,roleName,roleDescription,roleId)" & _
                                   "values(@roleId,@roleDescription,@roleId)", connection)

        With cmdInsert

            .Parameters.AddWithValue("@roleId", role.role_Id)
            .Parameters.AddWithValue("@roleName", role.role_Name)
            .Parameters.AddWithValue("@roleDescription", role.role_Description)
           
        End With

        connection.Open()
        cmdInsert.ExecuteNonQuery()
        connection.Close()
        MsgBox("The data of the roles has been succesfully added")

    End Sub
    
    ' Public Function listOfUser() As List(Of User)
    'From Users Table, obtains all the rows
    'Dim cmdSelectUser As New SqlCommand("select * from User", connection)
    'connection.Open()

    ' Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()
    ' Dim userList As New List(Of User)

    ' Dim users As New User

    '  Do While reader.HasRows
    '       Do While reader.Read()
    '           users = New User
    '           users.user_Id = reader.GetInt32(1)
    '           users.name_Of_User = reader.GetString(2)
    '          users.user_Lastname = reader.GetString(3)
    '         users.user_Status = reader.GetBoolean(4)
    '        users.user_Name = reader.GetString(5)
    '       users.user_Password = reader.GetString(6)
    '      users.User_IdRole = reader.GetInt32(7)
    '     userList.Add(users)
    'Loop
    ' reader.NextResult()
    ' Loop

    '    listOfUser = userList
    '   connection.Close()
    ' End Function  



    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdSelectUser As New SqlCommand("select * from User", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()

        Dim users As New User
        MessageBox("hola")
        ' createDataTableUser()
        ' insertUsers(askUserInputs())

        ' Do While reader.HasRows

        'Do While reader.Read()



        ' Loop
        'reader.NextResult()
        ' Loop


        ' Select Case reader.valueOf(FK_Role_User)

        'End Select


    End Sub
End Class