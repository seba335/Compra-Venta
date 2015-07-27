Public Class MaestraFaltantes
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GridView1.DataSource = CType(Session("FaltantesAComprar"), DataTable)
        Me.GridView1.DataBind()

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        CType(Session("FaltantesAComprar"), DataTable).Rows.RemoveAt(Me.GridView1.SelectedIndex)
        Response.Redirect("FormArmadoFaltantes.aspx")
    End Sub
End Class