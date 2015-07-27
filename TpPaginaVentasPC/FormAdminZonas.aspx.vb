Public Class FormAdminZonas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAgregarZona_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAgregarZona.Click
        Response.Redirect("FormAdminAltaZona.aspx")
    End Sub

 
    
    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub
End Class