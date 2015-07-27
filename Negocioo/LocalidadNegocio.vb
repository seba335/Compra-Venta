Imports Entidades
Imports Datos
Public Class LocalidadNegocio
    Public Sub AgregarLocalidad(ByVal localidad As Localidades)
        Dim objLocalidad As New LocalidadDatos

        Try
            objLocalidad.AgregarLocalidad(localidad)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function TraerCostoPorLocalidad(ByVal idLocalidad As Integer) As DataTable
        Dim objLocalidadDatos As New LocalidadDatos
        Dim dt As DataTable

        Try
            dt = objLocalidadDatos.TraerCostoPorLocalidad(idLocalidad).Tables(0)
            Return dt
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try



    End Function
End Class


