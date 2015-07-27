Imports Datos

Public Class VentaNegocio
    Private objconexion As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=CompraVentaComputadoras;Integrated Security=True")
    Private objTransaction As SqlClient.SqlTransaction

    Public Function InsertaVenta(ByVal idCliente As Integer,
                                   fecha As DateTime, idEmpleado As Integer,
                                   costo As Double, estado As String, idEnvio As Integer) As Integer


        Dim idVenta As Integer
        Dim blnTrans As Boolean = False
        Dim objVentadatos As New VentasDatos

        Try
            objconexion.Open()
            objTransaction = objconexion.BeginTransaction
            blnTrans = True

            idVenta = objVentadatos.InsertarVenta(idCliente, fecha, idEmpleado,
                                                   costo, estado, idEnvio,
                                                  objconexion, objTransaction)

            objTransaction.Commit()
            Return idVenta
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

    Public Function TraerVentasConEmpleado() As DataTable
        Dim objVentaDatos As New VentasDatos
        Try
            Return objVentaDatos.TraerVentasConEmpleado().Tables(0)
        Catch ex As Exception
            Throw New Exception("error al traer ventas")
        End Try


    End Function

    Public Function TraerVentasSinEmpleado() As DataTable
        Dim objVentaDatos As New VentasDatos
        Try
            Return objVentaDatos.TraerVentasSinEmpleado().Tables(0)
        Catch ex As Exception
            Throw New Exception("error al traer ventas")
        End Try


    End Function

    Public Sub ActualizarEstadoDeVenta(idVenta As Integer, estado As String)
        Dim objVentaDatos As New VentasDatos
        Try
            objVentaDatos.ActualizarEstadoDeVenta(idVenta, estado)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Function TraerEstadoYcostoDeVentasPorId(idVenta As Integer) As DataTable
        Dim objVentaDatos As New VentasDatos
        Try
            Return objVentaDatos.TraerEstadoYcostoDeVentasPorId(idVenta).Tables(0)

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

End Class
