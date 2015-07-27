Public Class ReservasDatos
    Public Sub AgregarReserva(idCliente As Integer, idPago As Integer, idEmpleado As Integer,
                              idModelo As Integer, estado As String, fecha As DateTime)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(5) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdCliente", SqlDbType.Int)
        objSqlParameters(0).Value = idCliente

        objSqlParameters(1) = New SqlClient.SqlParameter("@IdPago", SqlDbType.Int)
        objSqlParameters(1).Value = idPago


        If idEmpleado = -1 Then
            objSqlParameters(2) = New SqlClient.SqlParameter("@IdEmpleado", DBNull.Value)
            objSqlParameters(2).Value = DBNull.Value
        Else
            objSqlParameters(2) = New SqlClient.SqlParameter("@IdEmpleado", SqlDbType.Int)
            objSqlParameters(2).Value = idEmpleado
        End If

        objSqlParameters(3) = New SqlClient.SqlParameter("@IdModelo", SqlDbType.Int)
        objSqlParameters(3).Value = idModelo

        objSqlParameters(4) = New SqlClient.SqlParameter("@Estado", SqlDbType.VarChar, 50)
        objSqlParameters(4).Value = estado

        objSqlParameters(5) = New SqlClient.SqlParameter("@fecha", SqlDbType.DateTime)
        objSqlParameters(5).Value = fecha

        Try
            ClaseDatos.executeNonQuery("AgregarReserva", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("error al agregar reserva")
        End Try

    End Sub

    Public Function TraerReservaPorCliente(idCliente As Integer) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdCliente", SqlDbType.Int)
        objSqlParameters(0).Value = idCliente

        Try
            Return ClaseDatos.executeDataSet("TraerReservaPorCliente", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("error al traer reserva")
        End Try
        Return ClaseDatos.executeDataSet("TraerReservaPorCliente", objSqlParameters)

    End Function
    Public Sub ActualizarEstadoReserva(idReserva As Integer, estado As String)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdReserva", SqlDbType.Int)
        objSqlParameters(0).Value = idReserva

        objSqlParameters(1) = New SqlClient.SqlParameter("@Estado", SqlDbType.VarChar, 50)
        objSqlParameters(1).Value = estado




        Try
            ClaseDatos.executeNonQuery("ActualizarEstadoReserva", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("error al actualizar el estado de la reserva")
        End Try

    End Sub

    Public Function TraerPagoPorReserva(idReserva) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdReserva", SqlDbType.Int)
        objSqlParameters(0).Value = idReserva

        Try
            Return ClaseDatos.executeDataSet("TraerPagoPorReserva", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("Error al traer el pago")
        End Try

    End Function
End Class
