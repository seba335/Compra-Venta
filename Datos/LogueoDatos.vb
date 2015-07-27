Imports Entidades
Public Class LogueoDatos
    Public Function TraerEmpleado(Usuario As String, Contraseña As String) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar, 50)
        objSqlParameters(0).Value = Usuario

        objSqlParameters(1) = New SqlClient.SqlParameter("@Contraseña", SqlDbType.VarChar, 50)
        objSqlParameters(1).Value = Contraseña

        Try
            Return ClaseDatos.executeDataSet("TraerEmpleado", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("El usuario y/o contraseña son incorrectos.")
        End Try

    End Function

    Public Function TraerCliente(Usuario As String, Contraseña As String) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Email", SqlDbType.VarChar, 50)
        objSqlParameters(0).Value = Usuario

        objSqlParameters(1) = New SqlClient.SqlParameter("@Contraseña", SqlDbType.VarChar, 50)
        objSqlParameters(1).Value = Contraseña

        Try
            Return ClaseDatos.executeDataSet("TraerCliente", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("El usuario y/o contraseña son incorrectos.")
        End Try

    End Function


End Class
