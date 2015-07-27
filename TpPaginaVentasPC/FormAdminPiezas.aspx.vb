Public Class FormAdminPiezas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.GridView1.DataSourceID = Me.SqlDataSource2.ID
        Me.SqlDataSource2.DataBind()

    End Sub

    Protected Sub btnTodo_Click(sender As Object, e As EventArgs) Handles btnTodo.Click
        Me.GridView1.DataSourceID = Me.SqlDataSource1.ID
        Me.SqlDataSource1.DataBind()

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class