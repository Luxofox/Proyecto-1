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
    Public Function createDataTable() As DataTable

        dataTableUser = New DataTable
        dataTableUser.Columns.Add("Sigla")
        dataTableUser.Columns.Add("Nombre")
        dataTableUser.Columns.Add("Nivel")
        dataTableUser.Columns.Add("Créditos")
        dataTableUser.Columns.Add("Capacidad")
        dataTableUser.Columns.Add("Profesor")

        createDataTable = dataTableUser

    End Function



    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class