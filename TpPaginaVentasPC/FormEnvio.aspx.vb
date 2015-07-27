Imports Negocioo
Imports Entidades
Public Class FormEnvio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        If Me.rbConEnvio.Checked = True Then
            Response.Redirect("FormEnvioDetalles.aspx")
        Else

            CType(Session("Envio"), DataTable).Rows.Clear()
            Response.Redirect("FormPago.aspx")
        End If
    End Sub

    




 
End Class