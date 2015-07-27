Imports Negocioo
Imports Entidades
Public Class FormAltaTarjeta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim objTarjetaNegocio As New TarjetaNegocio
        If (CType(Session("Tipo"), String) = "Cliente") Then
            objTarjetaNegocio.AgregarTarjeta(CType(Me.txtNumero.Text, String), CType(Session("Usuario"), CLientes).NumeroCliente, Me.txtApellido.Text, Me.txtNombre.Text, Me.txtCodigo.Text, Me.ddlTipoTarjeta.SelectedValue, CType(Me.txtFecha.Text, Date), True)
            If CType(Session("PagoPor"), String) = "Compra" Then
                Response.Redirect("FormPago.aspx")
            ElseIf CType(Session("PagoPor"), String) = "Reserva" Then
                Response.Redirect("FormPagoPorReserva.aspx")
            ElseIf CType(Session("PagoPor"), String) = "CompletarReserva" Then
                Response.Redirect("FormPagoCompletarReserva.aspx")
            End If
        ElseIf CType(Session("Tipo"), String) = "Empleado" Then
            
            objTarjetaNegocio.AgregarTarjeta(CType(Me.txtNumero.Text, String), CType(Session("EmpleadoVentaCliente"), Integer), Me.txtApellido.Text, Me.txtNombre.Text, Me.txtCodigo.Text, Me.ddlTipoTarjeta.SelectedValue, CType(Me.txtFecha.Text, Date), True)
            Response.Redirect(CType(Session("Vengode"), String))


        End If

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Response.Redirect(CType(Session("Vengode"), String))
    End Sub
End Class