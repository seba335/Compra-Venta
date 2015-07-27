Imports Entidades
Imports Datos
Public Class ProveedorNegocio
    Public Sub AgregarProveedor(ByVal prove As Proveedores)

        Dim objProveedor As New ProveedorDatos

        Try
            objProveedor.AgregarProveedor(prove)

        Catch ex As Exception
            Throw ex
        End Try


    End Sub
End Class
