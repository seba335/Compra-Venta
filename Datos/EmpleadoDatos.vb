Imports Entidades

Public Class EmpleadoDatos
    Public Function AgregarEmpleado(ByVal empleado As Empleados) As System.Data.DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(12) {}
        objSqlParameters(0) = New SqlClient.SqlParameter("@Usuario", SqlDbType.VarChar, 50)
        objSqlParameters(0).Value = empleado.Usuario

        objSqlParameters(1) = New SqlClient.SqlParameter("@Contraseña", SqlDbType.VarChar, 50)
        objSqlParameters(1).Value = empleado.Contraseña

        objSqlParameters(2) = New SqlClient.SqlParameter("@Telefono", SqlDbType.BigInt)
        objSqlParameters(2).Value = empleado.Telefono

        objSqlParameters(3) = New SqlClient.SqlParameter("@IdLocalidad", SqlDbType.Int)
        objSqlParameters(3).Value = empleado.IdLocalidad

        objSqlParameters(4) = New SqlClient.SqlParameter("@Tipo", SqlDbType.VarChar, 50)
        objSqlParameters(4).Value = empleado.Tipo

        objSqlParameters(5) = New SqlClient.SqlParameter("@Calle", SqlDbType.VarChar, 50)
        objSqlParameters(5).Value = empleado.Calle

        objSqlParameters(6) = New SqlClient.SqlParameter("@Numero", SqlDbType.Int)
        objSqlParameters(6).Value = empleado.NumeroCalle

        If empleado.Piso = -1 Then
            objSqlParameters(7) = New SqlClient.SqlParameter("@Piso", DBNull.Value)
            objSqlParameters(7).Value = DBNull.Value
        Else
            objSqlParameters(7) = New SqlClient.SqlParameter("@Piso", SqlDbType.Int)
            objSqlParameters(7).Value = empleado.Piso
        End If

        If empleado.Departamento = "" Then
            objSqlParameters(8) = New SqlClient.SqlParameter("@Departamento", DBNull.Value)
            objSqlParameters(8).Value = DBNull.Value
        Else
            objSqlParameters(8) = New SqlClient.SqlParameter("@Departamento", SqlDbType.Char, 10)
            objSqlParameters(8).Value = empleado.Piso
        End If

        objSqlParameters(9) = New SqlClient.SqlParameter("@Apellido", SqlDbType.VarChar, 50)
        objSqlParameters(9).Value = empleado.Apellido

        objSqlParameters(10) = New SqlClient.SqlParameter("@Nombre", SqlDbType.VarChar, 50)
        objSqlParameters(10).Value = empleado.Nombre

        objSqlParameters(11) = New SqlClient.SqlParameter("@EstadoCivil", SqlDbType.VarChar, 50)
        objSqlParameters(11).Value = empleado.EstadoCivil

        objSqlParameters(12) = New SqlClient.SqlParameter("@Activo", SqlDbType.Bit)
        objSqlParameters(12).Value = True


        Try
            Return ClaseDatos.executeDataSet("AgregarEmpleado", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo agregar el empleado")
        End Try

    End Function

    Public Sub ModificarEmpleado(ByVal empleado As Empleados)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(9) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Legajo", SqlDbType.Int)
        objSqlParameters(0).Value = empleado.Legajo

        objSqlParameters(1) = New SqlClient.SqlParameter("@Calle", SqlDbType.VarChar, 50)
        objSqlParameters(1).Value = empleado.Calle

        objSqlParameters(2) = New SqlClient.SqlParameter("@Numero", SqlDbType.Int)
        objSqlParameters(2).Value = empleado.NumeroCalle

        objSqlParameters(3) = New SqlClient.SqlParameter("@Telefono", SqlDbType.BigInt)
        objSqlParameters(3).Value = empleado.Telefono

        objSqlParameters(4) = New SqlClient.SqlParameter("@IdLocalidad", SqlDbType.Int)
        objSqlParameters(4).Value = empleado.IdLocalidad

        objSqlParameters(5) = New SqlClient.SqlParameter("@Tipo", SqlDbType.VarChar, 50)
        objSqlParameters(5).Value = empleado.Tipo

        If empleado.Piso = -1 Then
            objSqlParameters(6) = New SqlClient.SqlParameter("@Piso", DBNull.Value)
            objSqlParameters(6).Value = DBNull.Value
        Else
            objSqlParameters(6) = New SqlClient.SqlParameter("@Piso", SqlDbType.Int)
            objSqlParameters(6).Value = empleado.Piso
        End If

        objSqlParameters(7) = New SqlClient.SqlParameter("@EstadoCivil", SqlDbType.VarChar, 50)
        objSqlParameters(7).Value = empleado.EstadoCivil

        If empleado.Departamento = "" Then
            objSqlParameters(8) = New SqlClient.SqlParameter("@Departamento", DBNull.Value)
            objSqlParameters(8).Value = DBNull.Value
        Else
            objSqlParameters(8) = New SqlClient.SqlParameter("@Departamento", SqlDbType.Char, 10)
            objSqlParameters(8).Value = empleado.Piso
        End If
        objSqlParameters(9) = New SqlClient.SqlParameter("@Activo", SqlDbType.Bit)
        objSqlParameters(9).Value = True
        Try
            ClaseDatos.executeNonQuery("ModificarEmpleado", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("Error al modificar empleado")
        End Try

    End Sub


    Public Function TraerEmpleadosDeArmado() As DataSet

        Try
            Return ClaseDatos.executeDataSet("TraerEmpleadosDeArmado")
        Catch ex As Exception
            Throw New Exception("error al traer empleados de armado")
        End Try
        Return ClaseDatos.executeDataSet("TraerEmpleadosDeArmado")
    End Function

    Public Sub ModificarActivoEmpleado(legajo As Integer, activo As Boolean)

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Legajo", SqlDbType.Int)
        objSqlParameters(0).Value = legajo

        objSqlParameters(1) = New SqlClient.SqlParameter("@Activo", SqlDbType.Bit)
        objSqlParameters(1).Value = activo

        Try
            ClaseDatos.executeNonQuery("ModificarActivoEmpleado", objSqlParameters)
        Catch ex As Exception

        End Try
    End Sub

    Public Function TraerEmpleadoPorId(idEmpleado As Integer) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@idEmpleado", SqlDbType.Int)
        objSqlParameters(0).Value = idEmpleado

        Try
            Return ClaseDatos.executeDataSet("TraerEmpleadoPorId", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("Error al traer empleado")
        End Try
    End Function
End Class
