Imports Entidades
Public Class ZonaDatos
    Public Function AgregarZona(ByVal zona As Zonas) As System.Data.DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Descripcion", SqlDbType.VarChar, 50)
        objSqlParameters(0).Value = zona.Descripcion

        objSqlParameters(1) = New SqlClient.SqlParameter("@Costo", SqlDbType.Float)
        objSqlParameters(1).Value = zona.Costo



        Try
            Return ClaseDatos.executeDataSet("AgregarZona", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo agregar la zona")
        End Try

    End Function

End Class
