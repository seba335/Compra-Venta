Imports Entidades
Imports Datos
Public Class EmpleadoNegocio
    Public Sub AgregarEmpleado(ByVal empleado As Empleados)

        Dim objEmpleado As New EmpleadoDatos

        Try
            objEmpleado.AgregarEmpleado(empleado)

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Sub ModificarEmpleado(ByVal empleado As Empleados)

        Dim objEmpleado As New EmpleadoDatos

        Try
            objEmpleado.ModificarEmpleado(empleado)

        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Function TraerEmpleadosDeArmado() As DataTable
        Dim objEmpleadoDatos As New EmpleadoDatos
        Try
            Return objEmpleadoDatos.TraerEmpleadosDeArmado.Tables(0)

        Catch ex As Exception

        End Try
        Return objEmpleadoDatos.TraerEmpleadosDeArmado.Tables(0)

    End Function

    Public Sub ModificarActivoEmpleado(Legajo As Integer, activo As Boolean)
        Dim objempleadoDatos As New EmpleadoDatos
        objempleadoDatos.ModificarActivoEmpleado(Legajo, activo)

    End Sub
    Public Function TraerEmpleadoPorId(idEmpleado As Integer) As DataTable
        Dim objEmpleadoDatos As New EmpleadoDatos

        Try
            Return objEmpleadoDatos.TraerEmpleadoPorId(idEmpleado).Tables(0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
