Imports MySql.Data.MySqlClient

Public Class Form5


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            read("SELECT * FROM alumnos", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form8.Show()
        Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            deletew("delete from alumnos WHERE usuario='" & TextBox1.Text & "'")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            GenerarPDFUsuarios("SELECT * FROM usuarios;")
        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF:" & ex.Message)
        End Try
    End Sub

End Class