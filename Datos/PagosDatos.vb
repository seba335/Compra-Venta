Imports Entidades
Public Class PagosDatos
    Public Sub AgregarPago(ByVal tipo As String, idTarjeta As Integer, monto As Double,
                                idVenta As Integer, fecha As DateTime)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(4) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Tipo", SqlDbType.VarChar, 50)
        objSqlParameters(0).Value = tipo

        If idTarjeta = -1 Then
            objSqlParameters(1) = New SqlClient.SqlParameter("@IdTarjeta", DBNull.Value)
            objSqlParameters(1).Value = DBNull.Value
        Else
            objSqlParameters(1) = New SqlClient.SqlParameter("@IdTarjeta", SqlDbType.Int)
            objSqlParameters(1).Value = idTarjeta
        End If
        


        objSqlParameters(2) = New SqlClient.SqlParameter("@Monto", SqlDbType.Float)
        objSqlParameters(2).Value = monto

        objSqlParameters(3) = New SqlClient.SqlParameter("@IdVenta", SqlDbType.Int)
        objSqlParameters(3).Value = idVenta

        objSqlParameters(4) = New SqlClient.SqlParameter("@Fecha", SqlDbType.DateTime)
        objSqlParameters(4).Value = fecha
        Try
            ClaseDatos.executeNonQuery("AgregarPago", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo agregar el modelo")
        End Try

    End Sub

    Public Function AgregarPagoParaReserva(ByVal tipo As String, idTarjeta As Integer, monto As Double,
                             fecha As DateTime,
                                 ByVal objConn As SqlClient.SqlConnection, ByVal objTran As SqlClient.SqlTransaction) As Integer

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(5) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Tipo", SqlDbType.VarChar, 50)
        objSqlParameters(0).Value = tipo

        If idTarjeta = -1 Then
            objSqlParameters(1) = New SqlClient.SqlParameter("@IdTarjeta", DBNull.Value)
            objSqlParameters(1).Value = DBNull.Value
        Else
            objSqlParameters(1) = New SqlClient.SqlParameter("@IdTarjeta", SqlDbType.Int)
            objSqlParameters(1).Value = idTarjeta
        End If



        objSqlParameters(2) = New SqlClient.SqlParameter("@Monto", SqlDbType.Float)
        objSqlParameters(2).Value = monto

        objSqlParameters(3) = New SqlClient.SqlParameter("@IdVenta", DBNull.Value)
        objSqlParameters(3).Value = DBNull.Value

        objSqlParameters(4) = New SqlClient.SqlParameter("@Fecha", SqlDbType.DateTime)
        objSqlParameters(4).Value = fecha

        objSqlParameters(5) = New SqlClient.SqlParameter("@Id", SqlDbType.Int)
        objSqlParameters(5).Direction = ParameterDirection.Output
        Try
            ClaseDatos.executeNonQuery("AgregarPagoTrayendoId", objSqlParameters, objConn, objTran)
            Return objSqlParameters(5).Value
        Catch ex As Exception
            Throw New Exception("No se pudo agregar el pago")
        End Try
    End Function
End Class
