Imports Negocioo

Public Class FormVentas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dtVentasConEmpleado As DataTable
        Dim dtVentasSinEmpleado As DataTable


        Dim objVentasNegocio As New VentaNegocio
        dtVentasConEmpleado = objVentasNegocio.TraerVentasConEmpleado
        dtVentasSinEmpleado = objVentasNegocio.TraerVentasSinEmpleado
        For Each fila As DataRow In dtVentasSinEmpleado.Rows
            Dim filaNueva As DataRow = dtVentasConEmpleado.NewRow
            filaNueva(0) = fila(0)
            filaNueva(1) = fila(1)
            filaNueva(2) = fila(2)
            filaNueva(3) = fila(3)
            filaNueva(4) = fila(4)
            filaNueva(5) = fila(5)
            filaNueva(6) = DBNull.Value
            dtVentasConEmpleado.Rows.Add(filaNueva)
        Next

        Me.GridView1.DataSource = dtVentasConEmpleado
        Me.GridView1.DataBind()
   
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Session("VentaSeleccionada") = Me.GridView1.SelectedDataKey.Value
        Response.Redirect("FormDetalleVenta.aspx")
    End Sub
End Class