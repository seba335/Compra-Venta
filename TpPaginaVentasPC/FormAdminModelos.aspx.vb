Public Class FormAdminModelos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Me.txtBusqueda.Text = "" Then
            Me.GridView1.DataSourceID = Me.SqlDataSource1.ID
            Me.GridView1.DataBind()
        Else
            Me.GridView1.DataSourceID = Me.SqlDataSource2.ID
            Me.GridView1.DataBind()
        End If


    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Session("Seleccion") = Me.GridView1.SelectedDataKey.Value
    End Sub

    Protected Sub BtnDetalles_Click(sender As Object, e As EventArgs) Handles BtnDetalles.Click
        If Me.GridView1.SelectedIndex = -1 Then
            MsgBox("Seleccione un modelo")
        Else
            Response.Redirect("FormDetalleVentaReserva.aspx")
        End If
    End Sub

    Protected Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If Me.GridView1.SelectedIndex = -1 Then
            MsgBox("Seleccione un modelo")
        Else
            Response.Redirect("FormAdminModificarModelo.aspx")
        End If
    End Sub
End Class