Imports Entidades
Imports Datos

Public Class PiezaNegocio
    Public Sub AgregarPieza(ByVal piezanueva As Piezas)


        Dim objPiezaDatos As New PiezaDatos

        Try
            objPiezaDatos.AgregarPieza(piezanueva)
        Catch ex As Exception
            Throw ex
        End Try


    End Sub
End Class
