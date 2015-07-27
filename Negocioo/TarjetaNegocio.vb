Imports Datos
Public Class TarjetaNegocio
    Public Sub AgregarTarjeta(NumerodeTarjeta As String, IdCliente As Integer, Apellido As String, Nombre As String, CodigodeSeguridad As String, Tipo As String, FechadeCaducidad As Date, Actva As Boolean)
        Dim objTarjetaDatos As New TarjetaDatos
        Try
            objTarjetaDatos.AgregarTarjeta(NumerodeTarjeta, IdCliente, Apellido, Nombre, CodigodeSeguridad, Tipo, FechadeCaducidad, Actva)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub EliminarTarjeta(IdTarjeta As Integer, Activa As Boolean)
        Dim objTarjetaDatos As New TarjetaDatos
        Try
            objTarjetaDatos.EliminarTarjeta(IdTarjeta, Activa)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function TraerTarjetaPorCliente(numeroCliente As Integer, fecha As DateTime) As DataTable
        Dim objTarjetaDatos As New TarjetaDatos
        Try
            Return objTarjetaDatos.TraerTarjetaPorCliente(numeroCliente, fecha).Tables(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
