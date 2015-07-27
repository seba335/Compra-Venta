Imports Entidades
Imports Datos
Public Class PiezaNegocio

    Public Sub AgregarPieza(ByVal pieza As Piezas)


        Dim objPiezasDatos As New PiezaDatos

        Try
            objPiezasDatos.AgregarPieza(pieza)
        Catch ex As Exception
            Throw ex
        End Try


    End Sub
    Public Sub ActualizarCosto(ByVal pieza As Piezas)


        Dim objPiezasDatos As New PiezaDatos

        Try
            objPiezasDatos.ActualizarCosto(pieza)
        Catch ex As Exception
            Throw ex
        End Try


    End Sub

    Public Function TraerPiezas() As DataTable


        Dim objPiezasDatos As New PiezaDatos

        Try
            Return objPiezasDatos.TraerPiezas().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Sub ActualizarStockPorPieza(idPieza As Integer, stockComprado As Integer)
        Dim objPiezaDatos As New PiezaDatos

        Try
            objPiezaDatos.ActualizarStockPorPieza(idPieza, stockComprado)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub ReducirStockDePieza(idPieza As Integer, cantidadPieza As Integer)

        Dim objPiezaDatos As New PiezaDatos

        Try
            objPiezaDatos.ReducirStockDePieza(idPieza, cantidadPieza)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
End Class
