Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            supdate("UPDATE alumnos SET voto='" & ComboBox1.Text & "', mesa='" & ComboBox2.Text & "' WHERE usuario='" & TextBox1.Text & "'")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MessageBox.Show("Voto enviado correctamente")
        Me.Close()
    End Sub
End Class