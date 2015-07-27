Imports Datos
Public Class ModeloPiezaNegocio
    Public Sub AgregarModeloPiezas(IdModelo As Integer, IdPieza As Integer, CantidadPieza As Integer)
        Dim objModeloPiezaDatos As New ModeloPiezasDatos
        Try
            objModeloPiezaDatos.AgregarModeloPiezas(IdModelo, IdPieza, CantidadPieza)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function TraerPiezasPorModelo(IdModelo As Integer) As DataSet
        Dim objModeloPiezaDatos As New ModeloPiezasDatos
        Try
            Return objModeloPiezaDatos.TraerPiezasPorModelo(IdModelo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class


