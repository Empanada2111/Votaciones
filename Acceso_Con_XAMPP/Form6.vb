Imports MySql.Data.MySqlClient

Public Class Form6
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form7.Show()
        Hide()

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'conectarse con el servidor de XAMPP'
            conectarmysql = New MySqlConnection("server=localhost;" + "database = ejercicio1;user=root;password=;")
            'abre la conexion'
            conectarmysql.Open()
            'da acceso a los comandos de XAMPP'
            conectarmysqlcomand = New MySqlCommand
            conectarmysqlcomand.CommandType = CommandType.Text
            conectarmysqlcomand.Connection = conectarmysql

        Catch ex As Exception
            MsgBox("Error nos falta ejecutar el SQL o XAMPP" + ex.Message, MsgBoxStyle.Critical, "BD ERROR")
        End Try
    End Sub
End Class