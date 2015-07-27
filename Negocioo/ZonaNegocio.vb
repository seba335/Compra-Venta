Imports Entidades
Imports Datos
Public Class ZonaNegocio
    Public Sub AgregarZona(ByVal zona As Zonas)
        Dim objZona As New ZonaDatos()

        Try
            objZona.AgregarZona(zona)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
