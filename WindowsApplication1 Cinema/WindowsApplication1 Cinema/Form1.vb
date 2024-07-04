Public Class Form1
    'Aqui creamos una nueva clase para manejar los eventos y la lógica de la pagina'
    Private Sub btnGenerarBoleto_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Aqui activamos el proceso que se hacer despues de hacer click del boton de "Generar Boleto en la pagina"
        Dim Nombre As String = Nombre  'Obtener el texto del campo de los nombres'
        Dim Apellido As String = Apellido
        Dim Cedula As String = Cedula
        Dim Sala As String = Sala
        Dim Hora As String = Hora
        Dim Pelicula As String = Pelicula

        'Con esta condicional lo que hacemos es validar que todos los campos están llenos, sino habra otra un mensaje que diga que hubo un error'
        If String.IsNullOrWhiteSpace(nombres) OrElse
           String.IsNullOrWhiteSpace(apellidos) OrElse
           String.IsNullOrWhiteSpace(cedula) OrElse
           String.IsNullOrWhiteSpace(sala) OrElse
           String.IsNullOrWhiteSpace(horaFuncion) OrElse
           String.IsNullOrWhiteSpace(pelicula) Then

            'Aqui mostramos mensaje de error si algún campo está vacío'
            MessageBox.Show("Error al ingresar los datos requeridos. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            'Generamos el texto del boleto de cine'

            rtbBoleto.Text = "Boleto de Cine" & "----------------------------------" & Environment.NewLine & "Nombre: " & nombres() & Environment.NewLine & "Apellido: " & apellidos() & Environment.NewLine & "Cédula: " & Cedula & Environment.NewLine & "Sala: " & Sala & Environment.NewLine & "Hora" & Hora & "Película"








        End If
    End Sub

    Private Function txtNombres() As Object
        Throw New NotImplementedException
    End Function

    Private Function txtCedula() As Object
        Throw New NotImplementedException
    End Function

    Private Function rtbBoleto() As Object
        Throw New NotImplementedException
    End Function

    Private Function Nombre() As String
        Throw New NotImplementedException
    End Function

    Private Function Apellido() As String
        Throw New NotImplementedException
    End Function

    Private Function Hora() As String
        Throw New NotImplementedException
    End Function

    Private Function nombres() As String
        Throw New NotImplementedException
    End Function

    Private Function apellidos() As String
        Throw New NotImplementedException
    End Function

    Private Function horaFuncion() As String
        Throw New NotImplementedException
    End Function

End Class 'Y cerramos esta clase para hora asi tener listo el proceso de la boleteria'