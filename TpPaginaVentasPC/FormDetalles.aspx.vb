Imports Entidades
Imports Negocioo
Public Class FormDetalles
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objModelo As New Modelos
        Dim objModeloNegocio As New ModeloNegocio
        Dim objModeloPiezaNegocio As New ModeloPiezaNegocio
        Dim dtPiezas As DataTable
        Try
            
            objModelo = objModeloNegocio.TraerModelo(CType(Session("Seleccion"), Integer))

            Me.lblNombre.Text = objModelo.Nombre
            'Me.lblStock.Text = objModelo.StockCapacidad.ToString
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
            If (CType(Session("Tipo"), String) = "Cliente") Then
                Me.btnReservar.Visible = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnAgregaraLaListadeCompras_Click(sender As Object, e As EventArgs) Handles btnAgregaraLaListadeCompras.Click
        Dim objModelo As New Modelos
        Dim objModeloNegocio As New ModeloNegocio
        If CType(Session("Tipo"), String) = "Nothing" Then
            MsgBox("Debe registrarse para realizar una compra")
        Else

            Try
                Dim Fila As DataRow
                Dim Duplicada As Boolean = False
                Fila = CType(Session("Carrito"), DataTable).NewRow()
                objModelo = objModeloNegocio.TraerModelo(CType(Session("Seleccion"), Integer))
                If objModelo.StockCapacidad >= CInt(Me.ddlCantidad.SelectedValue) Then


                    For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows
                        If (CType(f("Id"), Integer) = objModelo.Id) Then
                            Duplicada = True
                            f("Cantidad") = Me.ddlCantidad.SelectedValue
                        End If
                    Next
                    If (Duplicada = False) Then
                        Fila("Id") = objModelo.Id
                        Fila("Nombre") = objModelo.Nombre

                        Fila("StockCapacidad") = objModelo.StockCapacidad
                        Fila("Costo") = objModelo.Costo

                        Fila("Cantidad") = Me.ddlCantidad.SelectedValue
                        CType(Session("Carrito"), DataTable).Rows.Add(Fila)
                    End If


                    Response.Redirect("FormClientePrincipalF.aspx")
                Else
                    MsgBox("No se dispone de stock suficiente para esa compra")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub

    Protected Sub btnVolveraLaTienda_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVolveraLaTienda.Click

    End Sub

    Protected Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
       
            Dim objReservaNegocio As New ReservaNegocio
            If objReservaNegocio.TraerReservaPorCliente(CType(Session("Usuario"), CLientes).NumeroCliente).Rows.Count > 0 Then
                MsgBox("No puede realizar otra reserva hasta que se retire la anterior")
        Else
            Dim objModelo As New Modelos
            Dim objModeloNegocio As New ModeloNegocio
            objModelo = objModeloNegocio.TraerModelo(CType(Session("Seleccion"), Integer))
            If objModelo.StockCapacidad >= CInt(Me.ddlCantidad.SelectedValue) Then
                Dim objClienteNegocio As New ClienteNegocio
                If CInt(objClienteNegocio.TraerClientePorNumeroDeCliente(CType(Session("Usuario"), CLientes).NumeroCliente)(0)(11)) > -2 Then
                    Response.Redirect("FormReserva.aspx")
                Else
                    MsgBox("No puede realizar otra reserva ya que no se concluyeron sus recervas anteriores, si realiza por lo menos una compra exitosa se le permitira reservar nuevamente")
                End If
            Else
                MsgBox("No se dispone de stock suficiente para esta reserva")
            End If
            End If


    End Sub

    
End Class