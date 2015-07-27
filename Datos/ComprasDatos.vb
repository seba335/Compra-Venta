
Imports Entidades
Public Class ComprasDatos
 
    Public Function InsertarCompra(ByVal idProveedor As Integer, idEmpleado As Integer,
                                   fecha As DateTime, estado As String, costo As Double, ByVal objConn As SqlClient.SqlConnection, ByVal objTran As SqlClient.SqlTransaction) As Integer
        Dim objSqlParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(5) {}

        objSqlParam(0) = New SqlClient.SqlParameter("@IdProveedor", SqlDbType.Int)
        objSqlParam(0).Value = idProveedor

        objSqlParam(1) = New SqlClient.SqlParameter("@IdEmpleado", SqlDbType.Int)
        objSqlParam(1).Value = idEmpleado

        objSqlParam(2) = New SqlClient.SqlParameter("@Fecha", SqlDbType.DateTime)
        objSqlParam(2).Value = fecha

        objSqlParam(3) = New SqlClient.SqlParameter("@Estado", SqlDbType.VarChar, 100)
        objSqlParam(3).Value = estado

        objSqlParam(4) = New SqlClient.SqlParameter("@Costo", SqlDbType.Float)
        objSqlParam(4).Value = costo

        objSqlParam(5) = New SqlClient.SqlParameter("@Id", SqlDbType.Int)
        objSqlParam(5).Direction = ParameterDirection.Output


        ClaseDatos.executeNonQuery("InsertarCompra", objSqlParam, objConn, objTran)
        Return objSqlParam(5).Value

    End Function

    Public Function TraerCompras() As DataSet

        Try
            Return ClaseDatos.executeDataSet("TraerCompras")
        Catch ex As Exception

        End Try
        Return ClaseDatos.executeDataSet("TraerCompras")
    End Function

    Public Function BuscarComprasPorProveedor(Nombre As String) As DataSet

        Dim objSqlParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParam(0) = New SqlClient.SqlParameter("@NombreProveedor", SqlDbType.Char, 20)
        objSqlParam(0).Value = Nombre
        Try
            Return ClaseDatos.executeDataSet("BuscarComprasPorProveedor", objSqlParam)
        Catch ex As Exception

        End Try
        Return ClaseDatos.executeDataSet("BuscarComprasPorProveedor", objSqlParam)
    End Function

    Public Sub CambiarEstadoDeCompra(idCompra As Integer, estado As String)
        Dim objSqlParam() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParam(0) = New SqlClient.SqlParameter("@IdCompra", SqlDbType.Int)
        objSqlParam(0).Value = idCompra

        objSqlParam(1) = New SqlClient.SqlParameter("@Estado", SqlDbType.VarChar, 100)
        objSqlParam(1).Value = estado
        Try
            ClaseDatos.executeDataSet("CambiarEstadoDeCompra", objSqlParam)
        Catch ex As Exception
            Throw New Exception("Error al cambiar de estado")
        End Try

    End Sub

End Class
