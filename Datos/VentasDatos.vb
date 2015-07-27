Imports Entidades
Public Class VentasDatos

    Public Function InsertarVenta(ByVal idCliente As Integer,
                                fecha As DateTime, idEmpleado As Integer, costo As Double,
                                estado As String, idEnvio As Integer, ByVal objConn As SqlClient.SqlConnection, ByVal objTran As SqlClient.SqlTransaction) As Integer
        Dim objSqlParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(6) {}

        objSqlParam(0) = New SqlClient.SqlParameter("@IdCliente", SqlDbType.Int)
        objSqlParam(0).Value = idCliente
        If idEmpleado = -1 Then
            objSqlParam(1) = New SqlClient.SqlParameter("@IdEmpleado", DBNull.Value)
            objSqlParam(1).Value = DBNull.Value
        Else
            objSqlParam(1) = New SqlClient.SqlParameter("@IdEmpleado", SqlDbType.Int)
            objSqlParam(1).Value = idEmpleado
        End If
        

        objSqlParam(2) = New SqlClient.SqlParameter("@Estado", SqlDbType.VarChar, 50)
        objSqlParam(2).Value = estado

        objSqlParam(3) = New SqlClient.SqlParameter("@Costo", SqlDbType.Float)
        objSqlParam(3).Value = costo

        If idEnvio = -1 Then
            objSqlParam(4) = New SqlClient.SqlParameter("@IdEnvio", DBNull.Value)
            objSqlParam(4).Value = DBNull.Value

        Else
            objSqlParam(4) = New SqlClient.SqlParameter("@IdEnvio", SqlDbType.Int)
            objSqlParam(4).Value = idEnvio
        End If

        objSqlParam(5) = New SqlClient.SqlParameter("@Fecha", SqlDbType.DateTime)
        objSqlParam(5).Value = fecha

        objSqlParam(6) = New SqlClient.SqlParameter("@Id", SqlDbType.Int)
        objSqlParam(6).Direction = ParameterDirection.Output


        ClaseDatos.executeNonQuery("InsertarVenta", objSqlParam, objConn, objTran)
        Return objSqlParam(6).Value

    End Function

    Public Function TraerVentasConEmpleado() As DataSet
        Try
            Return ClaseDatos.executeDataSet("TraerVentasConEmpleado")
        Catch ex As Exception
            Throw New Exception("error al traer ventas")
        End Try


    End Function
    Public Function TraerVentasSinEmpleado() As DataSet
        Try
            Return ClaseDatos.executeDataSet("TraerVentasSinEmpleado")
        Catch ex As Exception
            Throw New Exception("error al traer ventas")
        End Try


    End Function

    Public Sub ActualizarEstadoDeVenta(idVenta As Integer, estado As String)
        Dim objSqlParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParam(0) = New SqlClient.SqlParameter("@IdVenta", SqlDbType.Int)
        objSqlParam(0).Value = idVenta

        objSqlParam(1) = New SqlClient.SqlParameter("@Estado", SqlDbType.VarChar, 50)
        objSqlParam(1).Value = estado

        Try
            ClaseDatos.executeNonQuery("ActualizarEstadoDeVenta", objSqlParam)

        Catch ex As Exception
            Throw New Exception("error al actualizar la venta")
        End Try
    End Sub

    Public Function TraerEstadoYcostoDeVentasPorId(idVenta As Integer) As DataSet
        Dim objSqlParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParam(0) = New SqlClient.SqlParameter("@IdVenta", SqlDbType.Int)
        objSqlParam(0).Value = idVenta

        Try
            Return ClaseDatos.executeDataSet("TraerEstadoYcostoDeVentasPorId", objSqlParam)
        Catch ex As Exception
            Throw New Exception("error al traer la venta")
        End Try
    End Function

End Class
