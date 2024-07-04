Public Class Comprobante 'Y abrimos una ultima clase que sera el comprobante del boleto usando la herencia de la clase Boleto'

    Property NumeroTransaccion As Integer

    Property FechaCompra As Date

    Property TotalAPagar As Double

    ' Luego utilizamos la funcion para generar el comprobante en formato de texto y que sea lo mas cercano a un boleto de cine'
    Public Shared Function GenerarComprobante(boleto As Boleto) As String
        Dim comprobante As String = "===== BOLETO DE CINE =====" & Environment.NewLine
        comprobante &= "Nombre: " & boleto.GetNombre() & Environment.NewLine
        comprobante &= "Apellido: " & boleto.GetApellido() & Environment.NewLine
        comprobante &= "Cédula: " & boleto.GetCedula() & Environment.NewLine
        comprobante &= "Sala: " & boleto.GetSala() & Environment.NewLine
        comprobante &= "Hora de Función: " & boleto.GetHora() & Environment.NewLine
        comprobante &= "Película: " & boleto.GetPelicula() & Environment.NewLine
        comprobante &= "==========================="

        Return comprobante
    End Function
End Class 'Cerramos la funcion y la clase para poder terminar el proceso'


