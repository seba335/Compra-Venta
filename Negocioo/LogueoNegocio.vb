Imports Datos
Imports Entidades
Public Class LogueoNegocio
    Public Function TraerEmpleado(Usuario As String, Contraseña As String) As Empleados
        Dim objLogueo As New LogueoDatos
        Dim objEmpleado As New Empleados
        Try
            Dim a As DataSet = objLogueo.TraerEmpleado(Usuario, Contraseña)
            objEmpleado.Apellido = a.Tables(0).Rows(0)("Apellido")
            objEmpleado.Calle = a.Tables(0).Rows(0)("Calle")
            objEmpleado.Contraseña = a.Tables(0).Rows(0)("Contraseña")
            objEmpleado.Departamento = a.Tables(0).Rows(0)("Departamento")
            objEmpleado.EstadoCivil = a.Tables(0).Rows(0)("EstadoCivil")
            objEmpleado.IdLocalidad = a.Tables(0).Rows(0)("IdLocalidad")
            objEmpleado.Legajo = a.Tables(0).Rows(0)("Legajo")
            objEmpleado.Nombre = a.Tables(0).Rows(0)("Nombre")
            objEmpleado.NumeroCalle = a.Tables(0).Rows(0)("Numero")
            objEmpleado.Piso = a.Tables(0).Rows(0)("Piso")
            objEmpleado.Telefono = a.Tables(0).Rows(0)("Telefono")
            objEmpleado.Tipo = a.Tables(0).Rows(0)("Tipo")
            objEmpleado.Usuario = a.Tables(0).Rows(0)("Usuario")


        Catch ex As Exception
            'mostrar mensaje
            Console.WriteLine("El usuario y/o contraseña son incorrectos")
            Console.ReadLine()
        End Try
        Return objEmpleado
    End Function

    Public Function TraerCliente(Usuario As String, Contraseña As String) As CLientes
        Dim objLogueo As New LogueoDatos
        Dim objCliente As New CLientes
        Try
            Dim a As DataSet = objLogueo.TraerCliente(Usuario, Contraseña)
            objCliente.NumeroCliente = a.Tables(0).Rows(0)("NumeroCliente")
            objCliente.Nombre = a.Tables(0).Rows(0)("Nombre")
            objCliente.Apellido = a.Tables(0).Rows(0)("Apellido")
            objCliente.IdLocalidad = a.Tables(0).Rows(0)("IdLocalidad")
            objCliente.Telefono = a.Tables(0).Rows(0)("Telefono")
            objCliente.Calle = a.Tables(0).Rows(0)("Calle")
            objCliente.NumeroCalle = a.Tables(0).Rows(0)("Numero")


            objCliente.Email = a.Tables(0).Rows(0)("Email")
            objCliente.Contraseña = a.Tables(0).Rows(0)("Contraseña")
            objCliente.Valoracion = a.Tables(0).Rows(0)("Valoracion")
            If (IsDBNull(a.Tables(0).Rows(0)("Piso"))) Then
                objCliente.Piso = 0
            Else
                objCliente.Piso = a.Tables(0).Rows(0)("Piso")
            End If

            If (IsDBNull(a.Tables(0).Rows(0)("Departamento"))) Then
                objCliente.Departamento = "-"
            Else
                objCliente.Departamento = a.Tables(0).Rows(0)("Departamento")
            End If





        Catch ex As Exception
            'mostrar mensaje
            Console.WriteLine("El usuario y/o contraseña son incorrectos")
            Console.ReadLine()
        End Try
        Return objCliente
    End Function
End Class
