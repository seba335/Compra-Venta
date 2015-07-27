Imports Negocioo
Public Class FormRegistrodePiezas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objCompraNegocio As New CompraNegocio
        Dim dtMostrar As New DataTable
        Dim dtCompras As DataTable
        dtMostrar.Columns.Add("Fecha")
        dtMostrar.Columns.Add("Estado")
        dtMostrar.Columns.Add("Costo")
        dtMostrar.Columns.Add("Proveedor")
        dtMostrar.Columns.Add("Empleado")
        
        dtCompras = objCompraNegocio.TraerCompras()
        Session("Compras") = dtCompras
        For Each fila As DataRow In dtCompras.Rows
            Dim f As DataRow = dtMostrar.NewRow
            f("Fecha") = fila("Fecha")
            f("Estado") = fila("Estado")
            f("Costo") = fila("Costo")
            f("Proveedor") = fila("Proveedor")
            f("Empleado") = fila("Empleado")
            dtMostrar.Rows.Add(f)
        Next

        Me.GridView1.DataSource = dtMostrar
        Me.GridView1.DataBind()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Session("CompraSeleccionada") = CType(Session("Compras"), DataTable)(Me.GridView1.SelectedIndex)("Id")
        Response.Redirect("FormRegistrodePiezasDetalle.aspx")
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objCompraNegocio As New CompraNegocio
        Dim dtMostrar As New DataTable
        Dim dtCompras As DataTable
        dtMostrar.Columns.Add("Fecha")
        dtMostrar.Columns.Add("Estado")
        dtMostrar.Columns.Add("Costo")
        dtMostrar.Columns.Add("Proveedor")
        dtMostrar.Columns.Add("Empleado")
        If Me.txtBuscar.Text = "" Then
            dtCompras = objCompraNegocio.TraerCompras()
        Else
            dtCompras = objCompraNegocio.BuscarComprasPorProveedor(Me.txtBuscar.Text)
        End If

        Session("Compras") = dtCompras
        For Each fila As DataRow In dtCompras.Rows
            Dim f As DataRow = dtMostrar.NewRow
            f("Fecha") = fila("Fecha")
            f("Estado") = fila("Estado")
            f("Costo") = fila("Costo")
            f("Proveedor") = fila("Proveedor")
            f("Empleado") = fila("Empleado")
            dtMostrar.Rows.Add(f)
        Next

        Me.GridView1.DataSource = dtMostrar
        Me.GridView1.DataBind()
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub
End Class