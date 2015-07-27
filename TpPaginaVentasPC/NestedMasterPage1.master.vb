Imports Negocioo
Public Class NestedMasterPage1
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        If (CType(Session("Carrito"), DataTable).Rows.Count > 0) Then
            Me.lblCosto.Visible = True
            Me.lclCarrito.Visible = True
            Me.Button1.Visible = True
            Me.Button2.Visible = True
            Me.Button9.Visible = True
            Me.GridView1.Visible = True
            Me.lblCostoTotal.Visible = True

            Dim dtMostrar As New DataTable
            Dim objModeloNegocio As New ModeloNegocio
            dtMostrar.Columns.Add("Nombre")
            'dtMostrar.Columns.Add("StockCapacidad")
            dtMostrar.Columns.Add("Costo")
            dtMostrar.Columns.Add("Cantidad")
            Dim costoTotal As Double = 0
            For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows

                costoTotal = costoTotal + (objModeloNegocio.TraerModelo(CInt(f(0))).Costo * CInt(f(5)))

            Next
            Me.lblCosto.Text = costoTotal.ToString
            For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows
                Dim fila As DataRow = dtMostrar.NewRow
                fila("Nombre") = f("Nombre")
                'fila("StockCapacidad") = f("StockCapacidad")
                fila("Costo") = f("Costo")
                fila("Cantidad") = f("Cantidad")
                dtMostrar.Rows.Add(fila)
            Next


            Me.GridView1.DataSource = dtMostrar

            Me.GridView1.DataBind()
        Else
            Me.lblCosto.Visible = False
            Me.lclCarrito.Visible = False
            Me.Button1.Visible = False
            Me.Button2.Visible = False
            Me.Button9.Visible = False
            Me.GridView1.Visible = False
            Me.lblCostoTotal.Visible = False
        End If



    End Sub










    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged



        'If (e. = "Delete") Then
        '    CType(Session("Carrito"), DataTable).Rows(Me.GridView1.SelectedRow.RowIndex).Delete()
        '    Me.GridView1.DataBind()

        'End If
        'If (a.CommandName = "Select") Then
        '    Session("Seleccion") = CType(Session("Carrito"), DataTable).Rows(Me.GridView1.SelectedIndex)("Id")


        '    Response.Redirect("FormDetalles.aspx")

        'End If



    End Sub

    Protected Sub GridView1_boton(sender As Object, e As GridViewCommandEventArgs)
        'GridView1_SelectedIndexChanged(sender, e)
        'If (e.CommandName = "Delete") Then
        '    CType(Session("Carrito"), DataTable).Rows(Me.GridView1.SelectedRow.RowIndex).Delete()
        '    Me.GridView1.DataBind()

        'End If
        'If (e.CommandName = "Select") Then
        '    Session("Seleccion") = CType(Session("Carrito"), DataTable).Rows(Me.GridView1.SelectedIndex)("Id")


        '    Response.Redirect("FormDetalles.aspx")

        'End If


    End Sub



    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.GridView1.SelectedIndex = -1) Then
            MsgBox("Seleccione un elemento para ver sus detalles")
        Else
            Session("Seleccion") = CType(Session("Carrito"), DataTable).Rows(Me.GridView1.SelectedIndex)("Id")
            Me.GridView1.SelectedIndex = -1
            Response.Redirect("FormDetalles.aspx")
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Me.GridView1.SelectedIndex = -1) Then
            MsgBox("Seleccione un elemento para eliminar")
        Else
            CType(Session("Carrito"), DataTable).Rows(Me.GridView1.SelectedIndex).Delete()
            Me.GridView1.DataSource = CType(Session("Carrito"), DataTable)
            Me.GridView1.DataBind()
            Me.GridView1.SelectedIndex = -1
            Dim costoTotal As Double = 0
            Dim objModeloNegocio As New ModeloNegocio
            For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows

                costoTotal = costoTotal + (objModeloNegocio.TraerModelo(CInt(f(0))).Costo * CInt(f(5)))

            Next
            Me.lblCosto.Text = costoTotal.ToString
            If CType(Session("Carrito"), DataTable).Rows.Count > 0 Then
                Me.lblCosto.Visible = True
                Me.lclCarrito.Visible = True
                Me.Button1.Visible = True
                Me.Button2.Visible = True
                Me.Button9.Visible = True
                Me.GridView1.Visible = True
                Me.lblCostoTotal.Visible = True
            Else
                
                Me.lblCosto.Visible = False
                Me.lclCarrito.Visible = False
                Me.Button1.Visible = False
                Me.Button2.Visible = False
                Me.Button9.Visible = False
                Me.GridView1.Visible = False
                Me.lblCostoTotal.Visible = False

            End If
        End If
    End Sub



    Protected Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If CType(Session("Carrito"), DataTable).Rows.Count > 0 Then
            If CType(Session("Tipo"), String) = "Empleado" Then
                Response.Redirect("FormListadeClientes.aspx")
            Else
                Response.Redirect("FormEnvio.aspx")
            End If
        Else
            MsgBox("Agregue algo a la lista de compras para realizar la compra")
        End If
    End Sub
End Class