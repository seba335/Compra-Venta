Imports Negocioo
Public Class FormAdminEmpleados
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

        Session("EmpleadoSeleccionado") = CInt(Me.GridView1.SelectedDataKey.Value)
        Response.Redirect("FormAdminModEmpleado.aspx")


    End Sub
End Class