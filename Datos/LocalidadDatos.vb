Imports Entidades

Public Class LocalidadDatos
    Public Function AgregarLocalidad(ByVal localidad As Localidades) As System.Data.DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Nombre", SqlDbType.VarChar, 30)
        objSqlParameters(0).Value = localidad.Nombre

        objSqlParameters(1) = New SqlClient.SqlParameter("@IdZona", SqlDbType.Int)
        objSqlParameters(1).Value = localidad.IdZona



        Try
            Return ClaseDatos.executeDataSet("AgregarLocalidad", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo agregar la localidad")
        End Try

    End Function

    Public Function TraerCostoPorLocalidad(ByVal idLocalidad As Integer) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@idLocalidad", SqlDbType.Int)
        objSqlParameters(0).Value = idLocalidad

        Try
            Return ClaseDatos.executeDataSet("TraerCostoPorLocalidad", objSqlParameters)

        Catch ex As Exception
            Throw New Exception("No se pudo traer el costo del envio")
        End Try



    End Function


End Class
