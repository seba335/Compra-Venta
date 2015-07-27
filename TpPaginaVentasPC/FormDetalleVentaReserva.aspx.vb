Imports Entidades
Imports Negocioo
Public Class FormDetalleVentaReserva
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objModelo As New Modelos
        Dim objModeloNegocio As New ModeloNegocio
        Dim objModeloPiezaNegocio As New ModeloPiezaNegocio
        Dim dtPiezas As DataTable
        Try

            objModelo = objModeloNegocio.TraerModelo(CType(Session("Seleccion"), Integer))

            Me.lblNombre.Text = objModelo.Nombre

            Me.lblPrecio.Text = objModelo.Costo.ToString
            dtPiezas = objModeloPiezaNegocio.TraerPiezasPorModelo(CType(Session("Seleccion"), Integer)).Tables(0)
            For Each fila As DataRow In dtPiezas.Rows
                If CType(fila(2), String).Contains("Procesador") Then
                    Me.lblProcesador.Text = (CType(fila(1), String))
                End If

                If CType(fila(2), String).Contains("Memoria") Then
                    Me.lblMemoria.Text = (CType(fila(1), String))
                    Me.lblCantidadMemoria.Text = (CType(fila(4), String))
                End If
                If CType(fila(2), String).Contains("Disco") Then
                    Me.lblDisco.Text = (CType(fila(1), String))
                    Me.lblCantidadDisco.Text = (CType(fila(4), String))
                End If
                If CType(fila(2), String).Contains("Gabinete") Then
                    Me.lblGabinete.Text = (CType(fila(1), String))
                End If
                If CType(fila(2), String).Contains("Mother") Then
                    Me.lblMother.Text = (CType(fila(1), String))
                End If
                If CType(fila(2), String).Contains("Fuente") Then
                    Me.lblFuente.Text = (CType(fila(1), String))
                End If
                If CType(fila(2), String).Contains("Lectora") Then
                    Me.lblLectora.Text = (CType(fila(1), String))
                End If
                If CType(fila(2), String).Contains("PlacaDeVideo") Then
                    Me.lblPlacadeVideo.Text = (CType(fila(1), String))
                End If
            Next
            
        Catch ex As Exception

        End Try
    End Sub

    
    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If CType(Session("Usuario"), Empleados).Tipo = "Administrador" Then
            Response.Redirect("FormAdminModelos.aspx")
        Else
            Response.Redirect("FormArmadoPrincipal.aspx")
        End If

    End Sub
End Class