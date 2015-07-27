Public Class FormAdminLocalidades
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLocalidad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLocalidad.Click
        Response.Redirect("FormAdminAltaLocalidad.aspx")
    End Sub
End Class