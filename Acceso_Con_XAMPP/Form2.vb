Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Dim votoEnBaseDatos As String = ""

    ' Función para obtener el voto del usuario desde la base de datos
    Function getVotoUsuario(usuario As String) As String
        ' Aquí simulamos una consulta a la base de datos
        ' En tu implementación real, reemplaza esto con tu código de consulta real
        ' Se devuelve "Aprobado" para el usuario "ejemploUsuario", de lo contrario, se devuelve una cadena vacía
        If usuario = "ejemploUsuario" Then
            Return "Aprobado"
        Else
            Return ""
        End If
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim votoEnBaseDatos As String = ""

        ' Consultar la base de datos para obtener el valor de voto para el usuario actual
        ' Esto asume que tienes una función que realiza la consulta y devuelve el valor de la columna 'voto' para el usuario proporcionado
        ' Por ejemplo, algo así como una función llamada 'getVotoUsuario' que toma el usuario como parámetro y devuelve el voto para ese usuario
        votoEnBaseDatos = getVotoUsuario(TextBox1.Text)

        If String.IsNullOrEmpty(votoEnBaseDatos) Then
            ' Si la columna de votos está vacía para este usuario, actualiza la base de datos con el nuevo voto
            Try
                supdate("UPDATE alumnos SET voto='" & ComboBox1.Text & "', mesa='" & ComboBox2.Text & "' WHERE usuario='" & TextBox1.Text & "'")
                MessageBox.Show("Voto enviado correctamente")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            ' Si la columna de votos no está vacía para este usuario, muestra un mensaje indicando que ya se ha votado
            MessageBox.Show("Ya se ha votado.")
        End If

        ' Cierra el formulario
        Me.Close()




    End Sub

End Class