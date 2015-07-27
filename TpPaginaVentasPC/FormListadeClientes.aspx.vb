Public Class FormListadeClientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GridView1.DataBind()
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
        Session("EmpleadoVentaCliente") = CInt(Me.GridView1.SelectedValue)
    End Sub

    Protected Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If Me.GridView1.SelectedIndex = -1 Then
            MsgBox("Seleccione un Cliente para modificar")
        Else

            Response.Redirect("FormClienteModPorEmpleado.aspx")
        End If
    End Sub

    Protected Sub btnVenta_Click(sender As Object, e As EventArgs) Handles btnVenta.Click
        If Me.GridView1.SelectedIndex = -1 Then
            MsgBox("Seleccione un Cliente para realizar la venta")
        Else
            Session("EmpleadoVentaCliente") = Me.GridView1.SelectedDataKey().Value
            Response.Redirect("FormEnvio.aspx")
        End If
    End Sub
End Class