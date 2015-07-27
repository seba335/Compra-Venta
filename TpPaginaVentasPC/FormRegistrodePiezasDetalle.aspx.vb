Imports Negocioo
Public Class FormRegistrodePiezasDetalle
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objCompraPiezaNegocio As New CompraPiezaNegocio
        Dim dtPiezas As New DataTable
        Dim dtMostrar As New DataTable
        dtMostrar.Columns.Add("Descripcion")
        dtMostrar.Columns.Add("Cantidad")
        dtMostrar.Columns.Add("Cantidad faltante")

        dtPiezas = objCompraPiezaNegocio.TraerPiezasPorCompra(CType(Session("CompraSeleccionada"), Integer))
        For Each fila As DataRow In dtPiezas.Rows
            Dim f As DataRow = dtMostrar.NewRow
            f("Descripcion") = fila("Descripcion")
            f("Cantidad") = fila("Cantidad")
            f("Cantidad faltante") = fila("Cantidad faltante")
            dtMostrar.Rows.Add(f)
        Next
        Me.GridView1.DataSource = dtMostrar
        Me.GridView1.DataBind()
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim objPiezaNegocio As New PiezaNegocio
        Dim objCopraNegocio As New CompraNegocio
        Dim objCompraPiezaNegocio As New CompraPiezaNegocio
        Dim dtPiezas As DataTable
        Dim dtCompras As DataTable
        Dim estado As String = ""

        dtCompras = objCopraNegocio.TraerCompras()
        For Each compra As DataRow In dtCompras.Rows
            If CType(compra(0), Integer) = CType(Session("CompraSeleccionada"), Integer) Then

                estado = CType(compra(2), String)

            End If

        Next

        If Not (estado = "Completado") Then



            If Me.ddlEstado.SelectedValue = "Completado" Then

                If estado = "Pedido" Or estado = "Cancelado" Then

                    dtPiezas = objCompraPiezaNegocio.TraerPiezasPorCompra(CType(Session("CompraSeleccionada"), Integer))
                    For Each f As DataRow In dtPiezas.Rows
                        objPiezaNegocio.ActualizarStockPorPieza(CType(f(0), Integer), CType(f(2), Integer))

                    Next
                    objCopraNegocio.CambiarEstadoDeCompra(CType(Session("CompraSeleccionada"), Integer), "Completado")
                ElseIf estado = "Completado Con Faltantes" Then
                    dtPiezas = objCompraPiezaNegocio.TraerPiezasPorCompra(CType(Session("CompraSeleccionada"), Integer))

                    For Each f As DataRow In dtPiezas.Rows

                        objPiezaNegocio.ActualizarStockPorPieza(CType(f(0), Integer), CType(f(3), Integer))
                        objCompraPiezaNegocio.ModificarCompraPiezasCantidadFaltante(CType(Session("CompraSeleccionada"), Integer), CInt(f(0)), 0)
                    Next



                    objCopraNegocio.CambiarEstadoDeCompra(CType(Session("CompraSeleccionada"), Integer), "Completado")

                End If
                Response.Redirect("FormRegistrodePiezas.aspx")

            ElseIf Me.ddlEstado.SelectedValue = "Completado Con Faltantes" Then
                If Not (estado = "Completado Con Faltantes") Then
                    Response.Redirect("FormRegistrodePiezasFaltantes.aspx")
                Else
                    MsgBox("Esta compra ya esta registrada con faltantes")
                End If
                ElseIf Me.ddlEstado.SelectedValue = "Cancelado" Then
                If Not (estado = "Completado Con Faltantes") Then
                    objCopraNegocio.CambiarEstadoDeCompra(CType(Session("CompraSeleccionada"), Integer), "Cancelado")
                    Response.Redirect("FormRegistrodePiezas.aspx")
                Else
                    MsgBox("Esta compra ya esta ingresada con faltantes")
                End If
                End If
            Else
                MsgBox("Este compra ya ha sido completada")
            End If
    End Sub
End Class