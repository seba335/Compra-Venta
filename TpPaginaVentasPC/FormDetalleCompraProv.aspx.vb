Imports Entidades
Imports Negocioo
Public Class FormDetalleCompraProv
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Me.GridView1.DataSource = CType(Session("CompraAUnProveedor"), DataTable)
            Me.GridView1.DataBind()
        End If
    
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged



    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim objCompra As New Compras
        Dim objCompraNegocio As New CompraNegocio
        Dim objCompraPiezaNegocio As New CompraPiezaNegocio
        Dim costoCompra As New Double
        costoCompra = 0

        For Each fila As System.Web.UI.WebControls.GridViewRow In Me.GridView1.Rows
            Dim Textbox As TextBox = CType(fila.FindControl("TextBox1"), TextBox)
            Dim costo As Double
            costo = CType(Textbox.Text, Double)
            costoCompra = costoCompra + (costo * CType(CType(Session("CompraAUnProveedor"), DataTable)(fila.RowIndex())(4), Integer))

        Next

        objCompra.IdCompras = objCompraNegocio.InsertarCompra(CInt(Me.ddlProveedores.SelectedValue), CType(Session("Usuario"), Empleados).Legajo, (CType(Date.Now, DateTime)), "Pedido", costoCompra)

        For Each fila As System.Web.UI.WebControls.GridViewRow In Me.GridView1.Rows
            Dim objPiezaNegocio As New PiezaNegocio
            Dim pieza As New Piezas
            Dim Textbox As TextBox = CType(fila.FindControl("TextBox1"), TextBox)
            Dim costo As Double
            costo = CType(Textbox.Text, Double)
            pieza.Costo = costo
            pieza.IdPieza = CType(CType(Session("CompraAUnProveedor"), DataTable)(fila.RowIndex())(0), String)

            objCompraPiezaNegocio.AgregarCompraPieza(objCompra.IdCompras, CType(CType(Session("CompraAUnProveedor"), DataTable)(fila.RowIndex())(0), Integer), CType(CType(Session("CompraAUnProveedor"), DataTable)(fila.RowIndex())(4), Integer), costo)
            objPiezaNegocio.ActualizarCosto(pieza)
        Next
        CType(Session("CompraAUnProveedor"), DataTable).Rows.Clear()

        Session("Iniciada") = False
        Response.Redirect("FormListadeComprasaProv.aspx")
    End Sub

    
End Class