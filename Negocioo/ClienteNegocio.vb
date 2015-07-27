Imports Entidades
Imports Datos
Public Class ClienteNegocio
    Public Sub AgregarCliente(ByVal cliente As CLientes)

        Dim objCliente As New ClienteDatos

        Try
            objCliente.AgregarCliente(cliente)

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub ModificarCliente(ByVal cliente As CLientes)

        Dim objCliente As New ClienteDatos

        Try
            objCliente.ModificarCliente(cliente)

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub ModificarClientePorEmpleado(ByVal cliente As CLientes)

        Dim objCliente As New ClienteDatos

        Try
            objCliente.ModificarClientePorEmpleado(cliente)

        Catch ex As Exception
            Throw ex
        End Try


    End Sub
    Public Function TraerClientePorNumeroDeCliente(ByVal numerodeCliente As Integer) As DataTable
        Dim objCliente As New ClienteDatos
        Try
            Return objCliente.TraerClientePorNumeroDeCliente(numerodeCliente).Tables(0)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub ActualizarValoracionDelCliente(idcliente As Integer, valoracion As Integer)
        Dim objClienteDatos As New ClienteDatos
        Try
            objClienteDatos.ActualizarValoracionDelCliente(idcliente, valoracion)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
