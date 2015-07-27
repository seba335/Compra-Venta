Imports Negocioo
Public Class FormArmadoFaltantes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.GridView1.DataSource = CType(Session("Faltantes2"), DataTable)
        Me.GridView1.DataBind()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ddlCantidadFaltante.SelectedValue = "" Then
            MsgBox("Seleccione una pieza")

        Else
            Dim repetida As Boolean = False
            For Each fi As DataRow In CType(Session("FaltantesAComprar"), DataTable).Rows
                If CInt(fi(0)) = CInt(CType(Session("Faltantes2"), DataTable)(Me.GridView1.SelectedIndex)(0)) Then
                    repetida = True
                End If
            Next
            If repetida = True Then
                For Each fi As DataRow In CType(Session("FaltantesAComprar"), DataTable).Rows
                    If CInt(fi(0)) = CInt(CType(Session("Faltantes2"), DataTable)(Me.GridView1.SelectedIndex)(0)) Then
                        fi(2) = CInt(Me.ddlCantidadFaltante.SelectedValue)
                    End If
                Next
            Else
                Dim fila As DataRow = CType(Session("FaltantesAComprar"), DataTable).NewRow
                fila(0) = CType(Session("Faltantes2"), DataTable)(Me.GridView1.SelectedIndex)(0)
                fila(1) = CType(Session("Faltantes2"), DataTable)(Me.GridView1.SelectedIndex)(1)
                fila(2) = CInt(Me.ddlCantidadFaltante.SelectedValue)
                CType(Session("FaltantesAComprar"), DataTable).Rows.Add(fila)
            End If
            Response.Redirect("FormArmadoFaltantes.aspx")
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Me.ddlCantidadFaltante.Items.Clear()
        Me.ddlCantidadFaltante.Items.Add("Seleccione")
        For i As Integer = 1 To CInt(CType(Session("Faltantes2"), DataTable)(Me.GridView1.SelectedIndex)(2))
            Me.ddlCantidadFaltante.Items.Add(i.ToString)
        Next
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        CType(Session("FaltantesAComprar"), DataTable).Rows.Clear()
        Response.Redirect("FormArmadoPrincipal.aspx")
    End Sub

    Protected Sub ddlCantidadFaltante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlCantidadFaltante.SelectedIndexChanged

    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim dtPiezasTotales As New DataTable
        dtPiezasTotales.Columns.Add("Codigo de pieza")
        dtPiezasTotales.Columns.Add("Descripcion")
        dtPiezasTotales.Columns.Add("Cantidad Faltante")
        Dim dtPiezasFaltantes As DataTable
        Dim dtPiezasRestantes As DataTable
        Dim dtPiezasNecesarias As DataTable
        Dim objModeloPieazasNegocio As New ModeloPiezaNegocio
        dtPiezasNecesarias = objModeloPieazasNegocio.TraerPiezasPorModelo(CInt(Session("Mod"))).Tables(0)
        dtPiezasFaltantes = CType(Session("FaltantesAComprar"), DataTable)
        For Each a As DataRow In CType(Session("Faltantes2"), DataTable).Rows
            Dim r As DataRow = dtPiezasTotales.NewRow
            r(0) = a(0)
            r(1) = a(1)
            r(2) = a(2)
            dtPiezasTotales.Rows.Add(r)
        Next

        For Each fTotales As DataRow In dtPiezasTotales.Rows
            For Each fFaltantes As DataRow In dtPiezasFaltantes.Rows
                If CInt(fTotales(0)) = CInt(fFaltantes(0)) Then

                    fTotales(2) = CInt(fTotales(2)) - CInt(fFaltantes(2))

                End If
            Next
        Next
        dtPiezasRestantes = dtPiezasTotales
        Dim alcanza As Boolean = True
        For Each filanecesaria As DataRow In dtPiezasNecesarias.Rows
            For Each filaRestantes As DataRow In dtPiezasRestantes.Rows
                If CInt(filanecesaria(0)) = CInt(filaRestantes(0)) Then
                    filaRestantes(2) = CInt(filaRestantes(2)) - CInt(filanecesaria(4))
                    If CInt(filaRestantes(2)) >= 0 Then
                    Else
                        alcanza = False
                    End If

                End If
            Next
        Next
        If alcanza = True Then
            MsgBox("Con los faltantes indicados alcanza para realizar al menos un modelo mas revise los faltantes indicados")
        Else
            Dim objPiezasNegocio As New PiezaNegocio
            Dim objListaNegocio As New ListaDeArmadoNegocio
            For Each fila As DataRow In CType(Session("FaltantesAComprar"), DataTable).Rows
                objPiezasNegocio.ReducirStockDePieza(CInt(fila(0)), CInt(fila(2)))
            Next
            objListaNegocio.ActualizarListaDeArmado(CInt(Session("IdLista")), CType(Date.Now, DateTime), 0)
            MsgBox("Se registraron los faltantes muchas gracias")
            Response.Redirect("FormArmadoPrincipal.aspx")
        End If

    End Sub
End Class