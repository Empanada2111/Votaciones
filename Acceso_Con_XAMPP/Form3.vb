Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox2.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            supdate("UPDATE alumnos SET nombre='" & TextBox1.Text & "', apellido='" & TextBox2.Text & "', grado='" & ComboBox1.Text & "', clave='" & TextBox4.Text & "', mesa='" & ComboBox2.Text & "' WHERE usuario='" & TextBox5.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Close()
        Form5.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form8.Show()
        Hide()

    End Sub
End Class