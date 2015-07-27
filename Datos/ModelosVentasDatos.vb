Public Class ModelosVentasDatos
    Public Sub AgregarModelosVentas(ByVal idVenta As Integer, ByVal IdModelo As Integer, ByVal cantidad As Integer, ByVal costomodelo As Double,
                                   ByVal objConn As SqlClient.SqlConnection, ByVal objTran As SqlClient.SqlTransaction)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(3) {}
        objSqlParameters(0) = New SqlClient.SqlParameter("@IdVenta", SqlDbType.Int)
        objSqlParameters(0).Value = idVenta

        objSqlParameters(1) = New SqlClient.SqlParameter("@IdModelo", SqlDbType.Int)
        objSqlParameters(1).Value = IdModelo

        objSqlParameters(2) = New SqlClient.SqlParameter("@Cantidad", SqlDbType.Int)
        objSqlParameters(2).Value = cantidad

        objSqlParameters(3) = New SqlClient.SqlParameter("@CostoModelo", SqlDbType.Float)
        objSqlParameters(3).Value = costomodelo

        Try
            ClaseDatos.executeNonQuery("AgregarModelosVentas", objSqlParameters, objConn, objTran)
        Catch ex As Exception
            Throw New Exception("Error al insertar un modelo a la venta")
        End Try

    End Sub

    Public Function TraetModeloVentasConIdVenta(idVenta As Integer) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdVenta", SqlDbType.Int)
        objSqlParameters(0).Value = idVenta

        Try
            Return ClaseDatos.executeDataSet("TraetModeloVentasConIdVenta", objSqlParameters)

        Catch ex As Exception
            Throw New Exception("error al traer moelo")
        End Try
    End Function
End Class
