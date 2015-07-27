Imports Datos
Public Class ModelosVentasNegocio
    Private objconexion As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=CompraVentaComputadoras;Integrated Security=True")
    Private objTransaction As SqlClient.SqlTransaction
    Public Sub AgregarModelosVentas(ByVal idVenta As Integer, ByVal IdModelo As Integer, ByVal cantidad As Integer, ByVal costoModelo As Double)

        Dim blnTrans As Boolean = False
        Dim objModeloVentaDatos As New ModelosVentasDatos
        Try
            objconexion.Open()
            objTransaction = objconexion.BeginTransaction
            blnTrans = True
            objModeloVentaDatos.AgregarModelosVentas(idVenta, IdModelo, cantidad, costoModelo, objconexion, objTransaction)

            objTransaction.Commit()

            blnTrans = False

        Catch ex As Exception

            If blnTrans Then
                objTransaction.Rollback()
            End If
            Throw (ex)
        Finally
            objconexion.Close()

        End Try

    End Sub

    Public Function TraetModeloVentasConIdVenta(idVenta As Integer) As DataTable
        Dim objModeloVentasDatos As New ModelosVentasDatos
        Try
            Return objModeloVentasDatos.TraetModeloVentasConIdVenta(idVenta).Tables(0)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
End Class
