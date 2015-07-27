Public Class CalculoDeArmado
    Public Function Calcular(idModelo As Integer) As DataSet


        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdModelo", SqlDbType.Int)
        objSqlParameters(0).Value = idModelo
        Try
            Return ClaseDatos.executeDataSet("CalcularArmado", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo traer la cantidad calculada")
        End Try

    End Function

    Public Function TraerModelosActivos() As DataSet
        Try
            Return ClaseDatos.executeDataSet("TraerModelosActivos")
        Catch ex As Exception
            Throw New Exception("No se pudo traer los modelos")
        End Try

    End Function
End Class
