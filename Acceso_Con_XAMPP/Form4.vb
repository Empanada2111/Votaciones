Public Class Form4
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            create("insert into alumnos(nombre, apellido, grado, clave, usuario,mesa) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & ComboBox2.Text & "')")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox2.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form8.Show()
        Hide()
    End Sub
End Class