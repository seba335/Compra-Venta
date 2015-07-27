Imports Negocioo
Imports Entidades
Public Class FormReserva
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objModeloNegocio As New ModeloNegocio
        Dim objModelo As Modelos
        Dim costoReserva As Double
        objModelo = objModeloNegocio.TraerModelo(CType(Session("Seleccion"), Integer))
        Me.lblModelo.Text = objModelo.Nombre
        Me.lblCostoTotal.Text = objModelo.Costo.ToString
        costoReserva = objModelo.Costo * 30 / 100
        Me.lblCostoReserva.Text = costoReserva.ToString
    End Sub

    Protected Sub btnReservar_Click(sender As Object, e As EventArgs) Handles btnReservar.Click
        
        If CType(Session("Tipo"), String) = "Cliente" Then

            Response.Redirect("FormPagoPorReserva.aspx")


        Else
            MsgBox("Debe estar registrado para realizar una reserva")
        End If
    End Sub
End Class