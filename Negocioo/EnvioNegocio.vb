Imports Entidades
Imports Datos
Public Class EnvioNegocio
    Private objconexion As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=CompraVentaComputadoras;Integrated Security=True")
    Private objTransaction As SqlClient.SqlTransaction
    Public Function AgregarEnvio(ByVal idCliente As Integer,
                                 idLocalidad As Integer, calle As String, numero As Integer, tel As Double,
                                 piso As Integer, departamento As String, fecha As DateTime) As Integer

        Dim objEnvio As New EnvioDatos
        Dim blnTrans As Boolean = False

        Dim id As Integer = 0
        Try

            objconexion.Open()
            objTransaction = objconexion.BeginTransaction
            blnTrans = True

            id = objEnvio.AgregarEnvio(idCliente, idLocalidad, calle, numero,
                                  piso, departamento, fecha, tel, objconexion, objTransaction)

            Return id

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
    End Function

    Public Function TraerUltimaDireccionDeEnvio(idcliente As Integer) As DataTable
        Dim objenvioDatos As New EnvioDatos
        Try
            Return objenvioDatos.TraerUltimaDireccionDeEnvio(idcliente).Tables(0)

        Catch ex As Exception
            Throw New Exception("error al traer la direccion de envio")
        End Try
    End Function


    Public Function TraerEnvioPorVenta(idVenta As Integer) As DataTable
        Dim objenvioDatos As New EnvioDatos
        Try
            Return objenvioDatos.TraerEnvioPorVenta(idVenta).Tables(0)

        Catch ex As Exception
            Throw New Exception("error al traer la direccion de envio")
        End Try

    End Function
End Class
