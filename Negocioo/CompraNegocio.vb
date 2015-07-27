Imports Entidades
Imports Datos
Public Class CompraNegocio
    Private objconexion As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=CompraVentaComputadoras;Integrated Security=True")
    Private objTransaction As SqlClient.SqlTransaction
    Public Function InsertarCompra(ByVal idProveedor As Integer, idEmpleado As Integer,
                                   fecha As DateTime, estado As String, costo As Double) As Integer


        Dim idCompra As Integer
        Dim blnTrans As Boolean = False
        Dim objcompradatos As New ComprasDatos
        Try
            objconexion.Open()
            objTransaction = objconexion.BeginTransaction
            blnTrans = True

            idCompra = objcompradatos.InsertarCompra(idProveedor, idEmpleado, fecha, estado, costo, objconexion, objTransaction)

            objTransaction.Commit()
            Return idCompra
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

    Public Function TraerCompras() As DataTable
        Dim objcompradatos As New ComprasDatos


        Dim dt As DataTable
        dt = objcompradatos.TraerCompras().Tables(0)
        Return dt
    End Function

    Public Function BuscarComprasPorProveedor(nombre As String) As DataTable
        Dim objcompradatos As New ComprasDatos


        Dim dt As DataTable
        dt = objcompradatos.BuscarComprasPorProveedor(nombre).Tables(0)
        Return dt
    End Function

    Public Sub CambiarEstadoDeCompra(idCompra As Integer, estado As String)
        Dim objCompraDatos As New ComprasDatos
        Try
            objCompraDatos.CambiarEstadoDeCompra(idCompra, estado)
        Catch ex As Exception

        End Try
    End Sub
End Class
