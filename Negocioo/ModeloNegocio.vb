Imports Entidades
Imports Datos
    Public Class ModeloNegocio
    Private objconexion As New SqlClient.SqlConnection("Data Source=.;Initial Catalog=CompraVentaComputadoras;Integrated Security=True")
        Private objTransaction As SqlClient.SqlTransaction
        Public Function AgregarModelo(ByVal modelo As Modelos) As Integer

            Dim blnTrans As Boolean = False
            Dim objModeloDatos As New ModeloDatos
            Try
                objconexion.Open()
                objTransaction = objconexion.BeginTransaction
                blnTrans = True

                modelo.Id = objModeloDatos.AgregarModelo(modelo, objconexion, objTransaction)

                objTransaction.Commit()
                Return modelo.Id
                blnTrans = False

            Catch ex As Exception

                If blnTrans Then
                    objTransaction.Rollback()
                End If
                Throw (ex)
            Finally
                objconexion.Close()

            End Try
            Return modelo.Id
        End Function
        Public Function TraerModelo(ByVal id As Integer) As Modelos
            Dim objModelo As New Modelos
            Dim objModeloDatos As New ModeloDatos

            Try
                Dim a As DataSet = objModeloDatos.TraerModelo(id)

                With objModelo
                    .Activo = a.Tables(0).Rows(0)("Activo")
                    .Costo = a.Tables(0).Rows(0)("Costo")
                    .Id = a.Tables(0).Rows(0)("Id")
                    .Imagen = a.Tables(0).Rows(0)("Imagen")
                    .Nombre = a.Tables(0).Rows(0)("Nombre")
                    .StockCapacidad = a.Tables(0).Rows(0)("StockCapacidad")
                    .Maximo = a.Tables(0).Rows(0)("Maximo")
                    .Minimo = a.Tables(0).Rows(0)("Minimo")
                End With
            Catch ex As Exception
                Throw ex
            End Try
            Return objModelo
    End Function

    Public Sub ActualizarStockModeloVenta(idModelo As Integer, cantidadModelo As Integer)

        Dim objModeloDatos As New ModeloDatos
        Try

            objModeloDatos.ActualizarStockModeloVenta(idModelo, cantidadModelo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub ActualizarStockModeloArmado(idModelo As Integer, cantidadModelo As Integer)

        Dim objModeloDatos As New ModeloDatos

        Try
            objModeloDatos.ActualizarStockModeloArmado(idModelo, cantidadModelo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub SumarStockModelo(idModelo As Integer, cantidadModelo As Integer)
        Dim objModeloDatos As New ModeloDatos

        Try
            objModeloDatos.SumarStockModelo(idModelo, cantidadModelo)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub ModificarModelo(idmodelo As Integer, activo As Boolean, costo As Double,
                               maximo As Integer, minimo As Integer)
        Dim objModeloDatos As New ModeloDatos
        Try
            objModeloDatos.ModificarModelo(idmodelo, activo, costo, maximo, minimo)
        Catch ex As Exception

        End Try
    End Sub

    Public Function TraerTodosLosModelos() As DataTable
        Dim objModeloDatos As New ModeloDatos
        Try
            Return objModeloDatos.TraerTodosLosModelos.Tables(0)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try


    End Function
End Class
