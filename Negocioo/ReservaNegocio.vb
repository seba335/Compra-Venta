Imports Datos
Public Class ReservaNegocio
    Public Sub AgregarReserva(idCliente As Integer, idPago As Integer, idEmpleado As Integer,
                              idModelo As Integer, estado As String, fecha As DateTime)

        Dim objReservaDatos As New ReservasDatos
        Try
            objReservaDatos.AgregarReserva(idCliente, idPago, idEmpleado, idModelo,
                                           estado, fecha)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Sub

    Public Function TraerReservaPorCliente(idCliente As Integer) As DataTable
        Dim objReservaDatos As New ReservasDatos
        Try
            Return objReservaDatos.TraerReservaPorCliente(idCliente).Tables(0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return objReservaDatos.TraerReservaPorCliente(idCliente).Tables(0)
    End Function
    Public Sub ActualizarEstadoReserva(idReserva As Integer, estado As String)

        Dim objReservaDatos As New ReservasDatos
        Try
            objReservaDatos.ActualizarEstadoReserva(idReserva, estado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Sub

    Public Function TraerPagoPorReserva(idReserva) As DataTable
        Dim objReservaDatos As New ReservasDatos
        Try
            Return objReservaDatos.TraerPagoPorReserva(idReserva).Tables(0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

End Class
