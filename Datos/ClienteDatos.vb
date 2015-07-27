Imports Entidades
Public Class ClienteDatos
    Public Function AgregarCliente(ByVal cliente As CLientes) As System.Data.DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(10) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Nombre", SqlDbType.VarChar, 50)
        objSqlParameters(0).Value = cliente.Nombre

        objSqlParameters(1) = New SqlClient.SqlParameter("@Apellido", SqlDbType.VarChar, 50)
        objSqlParameters(1).Value = cliente.Apellido

        objSqlParameters(2) = New SqlClient.SqlParameter("@IdLocalidad", SqlDbType.Int)
        objSqlParameters(2).Value = cliente.IdLocalidad

        objSqlParameters(3) = New SqlClient.SqlParameter("@Telefono", SqlDbType.BigInt)
        objSqlParameters(3).Value = cliente.Telefono

        objSqlParameters(4) = New SqlClient.SqlParameter("@Calle", SqlDbType.VarChar, 50)
        objSqlParameters(4).Value = cliente.Calle

        objSqlParameters(5) = New SqlClient.SqlParameter("@NumeroCalle", SqlDbType.Int)
        objSqlParameters(5).Value = cliente.NumeroCalle

        If cliente.Piso = -1 Then
            objSqlParameters(6) = New SqlClient.SqlParameter("@Piso", DBNull.Value)
            objSqlParameters(6).Value = DBNull.Value
        Else
            objSqlParameters(6) = New SqlClient.SqlParameter("@Piso", SqlDbType.Int)
            objSqlParameters(6).Value = cliente.Piso
        End If

        If cliente.Departamento = "" Then
            objSqlParameters(7) = New SqlClient.SqlParameter("@Departamento", DBNull.Value)
            objSqlParameters(7).Value = DBNull.Value
        Else
            objSqlParameters(7) = New SqlClient.SqlParameter("@Departamento", SqlDbType.Char, 10)
            objSqlParameters(7).Value = cliente.Departamento
        End If

        If cliente.Email = "" Then
            objSqlParameters(8) = New SqlClient.SqlParameter("@Email", DBNull.Value)
            objSqlParameters(8).Value = DBNull.Value
        Else
            objSqlParameters(8) = New SqlClient.SqlParameter("@Email", SqlDbType.VarChar, 50)
            objSqlParameters(8).Value = cliente.Email

        End If

        
        If cliente.Contraseña = "" Then
            objSqlParameters(9) = New SqlClient.SqlParameter("@Contraseña", DBNull.Value)
            objSqlParameters(9).Value = DBNull.Value
        Else
            objSqlParameters(9) = New SqlClient.SqlParameter("@Contraseña", SqlDbType.VarChar, 50)
            objSqlParameters(9).Value = cliente.Contraseña
        End If
        

        objSqlParameters(10) = New SqlClient.SqlParameter("@Valoracion", SqlDbType.Int)
        objSqlParameters(10).Value = cliente.Valoracion

        Try
            Return ClaseDatos.executeDataSet("AgregarCliente", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo agregar el cliente")
        End Try

    End Function

    Public Function ModificarCliente(ByVal cliente As CLientes) As System.Data.DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(6) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdLocalidad", SqlDbType.Int)
        objSqlParameters(0).Value = cliente.IdLocalidad

        objSqlParameters(1) = New SqlClient.SqlParameter("@Telefono", SqlDbType.BigInt)
        objSqlParameters(1).Value = cliente.Telefono

        objSqlParameters(2) = New SqlClient.SqlParameter("@Calle", SqlDbType.VarChar, 50)
        objSqlParameters(2).Value = cliente.Calle

        objSqlParameters(3) = New SqlClient.SqlParameter("@Numero", SqlDbType.Int)
        objSqlParameters(3).Value = cliente.NumeroCalle
        If cliente.Piso = -1 Then
            objSqlParameters(4) = New SqlClient.SqlParameter("@Piso", DBNull.Value)
            objSqlParameters(4).Value = DBNull.Value
        Else
            objSqlParameters(4) = New SqlClient.SqlParameter("@Piso", SqlDbType.Int)
            objSqlParameters(4).Value = cliente.Piso
        End If
        
        If cliente.Departamento = "" Then
            objSqlParameters(5) = New SqlClient.SqlParameter("@Departamento", DBNull.Value)
            objSqlParameters(5).Value = DBNull.Value
        Else
            objSqlParameters(5) = New SqlClient.SqlParameter("@Departamento", SqlDbType.Char, 10)
            objSqlParameters(5).Value = cliente.Departamento
        End If
        

        objSqlParameters(6) = New SqlClient.SqlParameter("@NumeroCliente", SqlDbType.Int)
        objSqlParameters(6).Value = cliente.NumeroCliente

        Try
            Return ClaseDatos.executeDataSet("ModificarCliente", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo Modificar el cliente")
        End Try

    End Function

    Public Sub ModificarClientePorEmpleado(ByVal cliente As CLientes)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(8) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdLocalidad", SqlDbType.Int)
        objSqlParameters(0).Value = cliente.IdLocalidad

        objSqlParameters(1) = New SqlClient.SqlParameter("@Telefono", SqlDbType.BigInt)
        objSqlParameters(1).Value = cliente.Telefono

        objSqlParameters(2) = New SqlClient.SqlParameter("@Calle", SqlDbType.VarChar, 50)
        objSqlParameters(2).Value = cliente.Calle

        objSqlParameters(3) = New SqlClient.SqlParameter("@Numero", SqlDbType.Int)
        objSqlParameters(3).Value = cliente.NumeroCalle
        If cliente.Piso = -1 Then
            objSqlParameters(4) = New SqlClient.SqlParameter("@Piso", DBNull.Value)
            objSqlParameters(4).Value = DBNull.Value
        Else
            objSqlParameters(4) = New SqlClient.SqlParameter("@Piso", SqlDbType.Int)
            objSqlParameters(4).Value = cliente.Piso
        End If
        
        If cliente.Departamento = "" Then
            objSqlParameters(5) = New SqlClient.SqlParameter("@Departamento", DBNull.Value)
            objSqlParameters(5).Value = DBNull.Value
        Else
            objSqlParameters(5) = New SqlClient.SqlParameter("@Departamento", SqlDbType.Char, 10)
            objSqlParameters(5).Value = cliente.Departamento
        End If
        

        objSqlParameters(6) = New SqlClient.SqlParameter("@NumeroCliente", SqlDbType.Int)
        objSqlParameters(6).Value = cliente.NumeroCliente
        If cliente.Email = "" Then
            objSqlParameters(7) = New SqlClient.SqlParameter("@Email", DBNull.Value)
            objSqlParameters(7).Value = DBNull.Value
        Else
            objSqlParameters(7) = New SqlClient.SqlParameter("@Email", SqlDbType.VarChar, 50)
            objSqlParameters(7).Value = cliente.Email
        End If
        
        If cliente.Contraseña = "" Then
            objSqlParameters(8) = New SqlClient.SqlParameter("@Contraseña", DBNull.Value)
            objSqlParameters(8).Value = DBNull.Value
        Else
            objSqlParameters(8) = New SqlClient.SqlParameter("@Contraseña", SqlDbType.VarChar, 50)
            objSqlParameters(8).Value = cliente.Contraseña
        End If
        

        Try
            ClaseDatos.executeNonQuery("ModificarClientePorEmpleado", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo Modificar el cliente")
        End Try

    End Sub


    Public Function TraerClientePorNumeroDeCliente(ByVal numerodeCliente As Integer) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@NumeroCliente", SqlDbType.Int)
        objSqlParameters(0).Value = numerodeCliente

        Try
            Return ClaseDatos.executeDataSet("TraerClientePorNumeroDeCliente", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo encontrar al cliente")
        End Try
    End Function

    Public Sub ActualizarValoracionDelCliente(idcliente As Integer, valoracion As Integer)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdCliente", SqlDbType.Int)
        objSqlParameters(0).Value = idcliente

        objSqlParameters(1) = New SqlClient.SqlParameter("@Valoracion", SqlDbType.Int)
        objSqlParameters(1).Value = valoracion


        Try
            ClaseDatos.executeNonQuery("ActualizarValoracionDelCliente", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo actualizar la valoracion")
        End Try
    End Sub

End Class
