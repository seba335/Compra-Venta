Imports Negocioo
Public Class FormRegistrodePiezasFaltantes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack = False Then
            Dim dtFaltantes As New DataTable

            Dim objCompraPiezaNegocio As New CompraPiezaNegocio
            Dim dtPiezas As New DataTable
            Dim dtMostrar As New DataTable
            Dim dtMostrarFaltantes As New DataTable

            dtMostrar.Columns.Add("Descripcion")
            dtMostrar.Columns.Add("Cantidad")
            dtMostrar.Columns.Add("Costo por unidad")

            dtFaltantes.Columns.Add("Id")
            dtFaltantes.Columns.Add("Descripcion")
            dtFaltantes.Columns.Add("Cantidad Faltante")

            dtMostrarFaltantes.Columns.Add("Descripcion")
            dtMostrarFaltantes.Columns.Add("Cantidad Faltante")

            dtPiezas = objCompraPiezaNegocio.TraerPiezasPorCompra(CType(Session("CompraSeleccionada"), Integer))
            For Each fila As DataRow In dtPiezas.Rows
                Dim f As DataRow = dtMostrar.NewRow
                f("Descripcion") = fila("Descripcion")
                f("Cantidad") = fila("Cantidad")
                f("Costo por unidad") = fila("Costo por unidad")

                dtMostrar.Rows.Add(f)
            Next

            Me.GridView1.DataSource = dtMostrar
            Me.GridView1.DataBind()

            Session("Faltantes") = dtFaltantes

            For Each f As DataRow In dtFaltantes.Rows
                Dim fila As DataRow = dtMostrarFaltantes.NewRow
                fila("Descripcion") = f("Descripcion")
                fila("Cantidad Faltante") = f("Cantidad Faltante")
                dtMostrarFaltantes.Rows.Add(fila)
            Next
            Me.GridViewFaltante.DataSource = dtMostrarFaltantes
            Me.GridViewFaltante.DataBind()
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Dim dtPiezas As New DataTable

        Dim objCompraPiezaNegocio As New CompraPiezaNegocio
        dtPiezas = objCompraPiezaNegocio.TraerPiezasPorCompra(CType(Session("CompraSeleccionada"), Integer))

        For i As Integer = 0 To CType(dtPiezas(Me.GridView1.SelectedIndex())(2), Integer)
            Me.ddlCantidadFaltante.Items.Add(i.ToString)

        Next
    End Sub

    Protected Sub btnFaltante_Click(sender As Object, e As EventArgs) Handles btnFaltante.Click
        Dim dtMostrarFaltantes As New DataTable
        Dim objCompraPiezaNegocio As New CompraPiezaNegocio
        Dim dtPiezas As New DataTable
        Dim duplicado As Boolean = False

        dtMostrarFaltantes.Columns.Add("Descripcion")
        dtMostrarFaltantes.Columns.Add("Cantidad Faltante")



        dtPiezas = objCompraPiezaNegocio.TraerPiezasPorCompra(CType(Session("CompraSeleccionada"), Integer))
        If Me.GridView1.SelectedIndex = -1 Then
            MsgBox("Seleccione una Pieza")
        Else
            Dim dtCopia As New List(Of DataRow)

            For Each f As DataRow In CType(Session("Faltantes"), DataTable).Rows
                If CInt(dtPiezas(Me.GridView1.SelectedIndex())(0)) = CInt(f(0)) Then
                    If CInt(ddlCantidadFaltante.SelectedValue) = 0 Then
                        dtCopia.Add(f)
                        duplicado = True
                    Else
                        f(2) = Me.ddlCantidadFaltante.SelectedValue
                        duplicado = True
                    End If

                End If
            Next
            For Each f As DataRow In dtCopia
                CType(Session("Faltantes"), DataTable).Rows.Remove(f)
            Next
            If (duplicado = False And Not (CInt(Me.ddlCantidadFaltante.SelectedValue) = 0)) Then
                Dim fila As DataRow = CType(Session("Faltantes"), DataTable).NewRow
                fila(0) = dtPiezas(Me.GridView1.SelectedIndex())(0)
                fila(1) = dtPiezas(Me.GridView1.SelectedIndex())(1)
                fila(2) = Me.ddlCantidadFaltante.SelectedValue
                CType(Session("Faltantes"), DataTable).Rows.Add(fila)
            End If

            For Each f As DataRow In CType(Session("Faltantes"), DataTable).Rows
                Dim fila As DataRow = dtMostrarFaltantes.NewRow
                fila("Descripcion") = f("Descripcion")
                fila("Cantidad Faltante") = f("Cantidad Faltante")
                dtMostrarFaltantes.Rows.Add(fila)
            Next
            Me.GridViewFaltante.DataSource = dtMostrarFaltantes
            Me.GridViewFaltante.DataBind()

        End If
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim objCompraNegocio As New CompraNegocio
        Dim objCompraPiezaNegocio As New CompraPiezaNegocio
        Dim objPiezaNegocio As New PiezaNegocio
        Dim dtPiezas As DataTable
        If CType(Session("Faltantes"), DataTable).Rows.Count > 0 Then

            For Each f As DataRow In CType(Session("Faltantes"), DataTable).Rows

                objCompraPiezaNegocio.ModificarCompraPiezasCantidadFaltante(CType(Session("CompraSeleccionada"), Integer), CInt(f(0)), CInt(f(2)))


            Next
            dtPiezas = objCompraPiezaNegocio.TraerPiezasPorCompra(CType(Session("CompraSeleccionada"), Integer))
            For Each f As DataRow In dtPiezas.Rows

                objPiezaNegocio.ActualizarStockPorPieza(CType(f(0), Integer), (CType(f(2), Integer) - CType(f(3), Integer)))

            Next

            objCompraNegocio.CambiarEstadoDeCompra(CType(Session("CompraSeleccionada"), Integer), "Completado Con Faltantes")
            Response.Redirect("FormRegistrodePiezas.aspx")
        Else
            MsgBox("Indique los faltantes")
        End If
    End Sub
End Class