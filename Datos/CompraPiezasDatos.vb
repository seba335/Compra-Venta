Public Class CompraPiezasDatos


    Public Sub AgregarCompraPiezas(ByVal idCompra As Integer, ByVal IdPieza As Integer, ByVal cantPieza As Integer, ByVal costoPieza As Double,
                                   ByVal objConn As SqlClient.SqlConnection, ByVal objTran As SqlClient.SqlTransaction)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(4) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdCompra", SqlDbType.Int)
        objSqlParameters(0).Value = idCompra

        objSqlParameters(1) = New SqlClient.SqlParameter("@IdPieza", SqlDbType.Int)
        objSqlParameters(1).Value = IdPieza

        objSqlParameters(2) = New SqlClient.SqlParameter("@CantidadPiezas", SqlDbType.Int)
        objSqlParameters(2).Value = cantPieza


        objSqlParameters(3) = New SqlClient.SqlParameter("@CostoPieza", SqlDbType.Float)
        objSqlParameters(3).Value = costoPieza

        objSqlParameters(4) = New SqlClient.SqlParameter("@CantidadFaltante", SqlDbType.Int)
        objSqlParameters(4).Value = 0
        Try
            ClaseDatos.executeNonQuery("AgregarCompraPiezas", objSqlParameters, objConn, objTran)
        Catch ex As Exception
            Throw New Exception("Error al insertar una compra de pieza")
        End Try




    End Sub

    Public Function TraerCompraPiezas() As DataSet
        Try
            Return ClaseDatos.executeDataSet("TraerCompraPiezas")
        Catch ex As Exception
            Throw New Exception("No se pudo traer piezas compradas")
        End Try

    End Function

    Public Function TraerPiezasPorCompra(idCompra As Integer) As DataSet

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdCompra", SqlDbType.Int)
        objSqlParameters(0).Value = idCompra

        Try
            Return ClaseDatos.executeDataSet("TraerPiezasPorCompra", objSqlParameters)
        Catch ex As Exception

        End Try
        Return ClaseDatos.executeDataSet("TraerPiezasPorCompra", objSqlParameters)
    End Function


    Public Sub ModificarCompraPiezasCantidadFaltante(idCompra As Integer, IdPieza As Integer, CantidadFaltante As Integer)

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdCompra", SqlDbType.Int)
        objSqlParameters(0).Value = idCompra

        objSqlParameters(1) = New SqlClient.SqlParameter("@IdPieza", SqlDbType.Int)
        objSqlParameters(1).Value = IdPieza

        objSqlParameters(2) = New SqlClient.SqlParameter("@CantidadFaltante", SqlDbType.Int)
        objSqlParameters(2).Value = CantidadFaltante
        Try
            ClaseDatos.executeNonQuery("ModificarCompraPiezasCantidadFaltante", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("Error al modificar una cantidad faltante de pieza")
        End Try




    End Sub
End Class