Imports Datos

Public Class PagoNegocio
    Private objconexion As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=CompraVentaComputadoras;Integrated Security=True")
    Private objTransaction As SqlClient.SqlTransaction
    Public Sub AgregarPago(ByVal tipo As String, idTarjeta As Integer, monto As Double,
                                idVenta As Integer, fecha As DateTime)
        Dim objPagoDatos As New PagosDatos

        Try
            objPagoDatos.AgregarPago(tipo, idTarjeta, monto, idVenta, fecha)

        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub

    Public Function AgregarPagoParaReserva(ByVal tipo As String, idTarjeta As Integer, monto As Double,
                                fecha As DateTime) As Integer



        Dim idpago As Integer
        Dim blnTrans As Boolean = False
        Dim objPagoDatos As New PagosDatos

        Try
            objconexion.Open()
            objTransaction = objconexion.BeginTransaction
            blnTrans = True

            idpago = objPagoDatos.AgregarPagoParaReserva(tipo, idTarjeta, monto, fecha,
                                                         objconexion, objTransaction)

            objTransaction.Commit()
            Return idpago
            blnTrans = False

        Catch ex As Exception

            If blnTrans Then
                objTransaction.Rollback()
            End If
            Throw (ex)
        Finally
            objconexion.Close()

        End Try

    End Function


End Class
