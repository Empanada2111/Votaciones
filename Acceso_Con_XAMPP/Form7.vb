Imports MySql.Data.MySqlClient

Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conectarmysqlcomand.CommandText = "select * from administracion where usuario= '" + TextBox1.Text + "'AND contraseña='" + TextBox2.Text + "'"
        Dim waldir As MySqlDataReader
        waldir = conectarmysqlcomand.ExecuteReader

        If waldir.HasRows <> False Then
            MsgBox("Accesso Correcto")
            Form8.Show()
        Else
            MsgBox("ACCESO DENEGADO")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
        Hide()

    End Sub
End Class