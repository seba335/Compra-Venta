Imports Datos
Public Class CompraPiezaNegocio

    Private objconexion As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=CompraVentaComputadoras;Integrated Security=True")
    Private objTransaction As SqlClient.SqlTransaction
    Public Sub AgregarCompraPieza(ByVal idCompra As Integer, ByVal IdPieza As Integer, ByVal cantPieza As Integer, ByVal costoPieza As Double)

        Dim blnTrans As Boolean = False
        Dim objCompraPiezaDatos As New CompraPiezasDatos
        Try
            objconexion.Open()
            objTransaction = objconexion.BeginTransaction
            blnTrans = True
            objCompraPiezaDatos.AgregarCompraPiezas(idCompra, IdPieza, cantPieza, costoPieza, objconexion, objTransaction)

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


    Public Function TraerCompraPiezas() As DataTable


        Dim objCompraPiezasDatos As New CompraPiezasDatos

        Try
            Return objCompraPiezasDatos.TraerCompraPiezas().Tables(0)
        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Function TraerPiezasPorCompra(idCompra As Integer) As DataTable


        Dim objCompraPiezasDatos As New CompraPiezasDatos

        Try
            Return objCompraPiezasDatos.TraerPiezasPorCompra(idCompra).Tables(0)
        Catch ex As Exception
            Throw ex
        End Try


    End Function

    Public Sub ModificarCompraPiezasCantidadFaltante(ByVal idCompra As Integer, ByVal IdPieza As Integer, ByVal cantPiezaFaltante As Integer)

        Dim objCompraPiezaDatos As New CompraPiezasDatos
        Try
            
            objCompraPiezaDatos.ModificarCompraPiezasCantidadFaltante(idCompra, IdPieza, cantPiezaFaltante)

            

        Catch ex As Exception

            
            Throw (ex)
        

        End Try

    End Sub
End Class

