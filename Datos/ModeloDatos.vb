Imports Entidades
Public Class ModeloDatos
    Public Function AgregarModelo(ByVal modelo As Modelos, ByVal objConn As SqlClient.SqlConnection, ByVal objTran As SqlClient.SqlTransaction) As Integer
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(7) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Nombre", SqlDbType.Char, 20)
        objSqlParameters(0).Value = modelo.Nombre


        objSqlParameters(1) = New SqlClient.SqlParameter("@Activo", SqlDbType.Bit)
        objSqlParameters(1).Value = modelo.Activo


        objSqlParameters(2) = New SqlClient.SqlParameter("@StockCapacidad", SqlDbType.Int)
        objSqlParameters(2).Value = modelo.StockCapacidad

        objSqlParameters(3) = New SqlClient.SqlParameter("@Costo", SqlDbType.Float)
        objSqlParameters(3).Value = modelo.Costo

        objSqlParameters(4) = New SqlClient.SqlParameter("@Imagen", SqlDbType.VarChar, 100)
        objSqlParameters(4).Value = modelo.Imagen

        objSqlParameters(5) = New SqlClient.SqlParameter("@Minimo", SqlDbType.Int)
        objSqlParameters(5).Value = modelo.Minimo

        objSqlParameters(6) = New SqlClient.SqlParameter("@Maximo", SqlDbType.Int)
        objSqlParameters(6).Value = modelo.Maximo

        objSqlParameters(7) = New SqlClient.SqlParameter("@IdModelo", SqlDbType.Int)
        objSqlParameters(7).Direction = ParameterDirection.Output

        Try
            ClaseDatos.executeNonQuery("AgregarModelo", objSqlParameters, objConn, objTran)
            Return objSqlParameters(7).Value
        Catch ex As Exception
            Throw New Exception("No se pudo agregar el modelo")
        End Try
      

    End Function


    Public Function TraerModelo(ByVal id As Integer) As System.Data.DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Id", SqlDbType.Int)
        objSqlParameters(0).Value = id

        Try
            Return ClaseDatos.executeDataSet("TraerModelo", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo traer el modelo")
        End Try

    End Function

    Public Sub ActualizarStockModeloVenta(idModelo As Integer, cantidadModelo As Integer)

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdModelo", SqlDbType.Int)
        objSqlParameters(0).Value = idModelo


        objSqlParameters(1) = New SqlClient.SqlParameter("@CantidadModelo", SqlDbType.Int)
        objSqlParameters(1).Value = cantidadModelo

        Try

            ClaseDatos.executeNonQuery("ActualizarStockModeloVenta", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("error al actualizar stock del modelo")
        End Try
    End Sub

    Public Sub ActualizarStockModeloArmado(idModelo As Integer, cantidadModelo As Integer)

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdModelo", SqlDbType.Int)
        objSqlParameters(0).Value = idModelo


        objSqlParameters(1) = New SqlClient.SqlParameter("@CantidadModelo", SqlDbType.Int)
        objSqlParameters(1).Value = cantidadModelo

        Try

            ClaseDatos.executeNonQuery("ActualizarStockModeloVentaArmado", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("error al actualizar stock del modelo")
        End Try
    End Sub

    Public Sub SumarStockModelo(idModelo As Integer, cantidadModelo As Integer)

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdModelo", SqlDbType.Int)
        objSqlParameters(0).Value = idModelo


        objSqlParameters(1) = New SqlClient.SqlParameter("@CantidadModelo", SqlDbType.Int)
        objSqlParameters(1).Value = cantidadModelo

        Try

            ClaseDatos.executeNonQuery("SumarStockModelo", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("error al actualizar stock del modelo")
        End Try

    End Sub

    Public Sub ModificarModelo(idmodelo As Integer, activo As Boolean, costo As Double,
                               maximo As Integer, minimo As Integer)

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(4) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdModelo", SqlDbType.Int)
        objSqlParameters(0).Value = idmodelo


        objSqlParameters(1) = New SqlClient.SqlParameter("@Activo", SqlDbType.Bit)
        objSqlParameters(1).Value = activo


        objSqlParameters(2) = New SqlClient.SqlParameter("@Costo", SqlDbType.Float)
        objSqlParameters(2).Value = costo

        objSqlParameters(3) = New SqlClient.SqlParameter("@Maximo", SqlDbType.Int)
        objSqlParameters(3).Value = maximo

        objSqlParameters(4) = New SqlClient.SqlParameter("@Minimo", SqlDbType.Int)
        objSqlParameters(4).Value = minimo

        Try

            ClaseDatos.executeNonQuery("ModificarModelo", objSqlParameters)

        Catch ex As Exception
            Throw New Exception("Error al modificar modelo")
        End Try
    End Sub

    Public Function TraerTodosLosModelos() As DataSet

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        Try
            Return ClaseDatos.executeDataSet("TraerTodosLosModelos")
        Catch ex As Exception
            Throw New Exception("Error al traer los modelos")
        End Try
    End Function
End Class
