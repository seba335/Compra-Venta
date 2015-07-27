Imports Entidades
Public Class ProveedorDatos
    Public Function AgregarProveedor(ByVal prove As Proveedores) As System.Data.DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(4) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Nombre", SqlDbType.VarChar, 50)
        objSqlParameters(0).Value = prove.Nombre

        objSqlParameters(1) = New SqlClient.SqlParameter("@Apellido", SqlDbType.VarChar, 50)
        objSqlParameters(1).Value = prove.Apellido

        objSqlParameters(2) = New SqlClient.SqlParameter("@IdLocalidad", SqlDbType.Int)
        objSqlParameters(2).Value = prove.IdLocalidad

        objSqlParameters(3) = New SqlClient.SqlParameter("@Telefono", SqlDbType.BigInt)
        objSqlParameters(3).Value = prove.Telefono

        objSqlParameters(4) = New SqlClient.SqlParameter("@Email", SqlDbType.VarChar, 50)
        objSqlParameters(4).Value = prove.Email
        Try
            Return ClaseDatos.executeDataSet("AgregarProveedor", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo agregar el proveedor")
        End Try

    End Function
End Class
