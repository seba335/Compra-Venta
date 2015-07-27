Imports Entidades
Imports Negocioo
Public Class FormClientePrincipalF
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If CType(Session("Tipo"), String) = "Cliente" Then
            Dim objReservaNegocio As New ReservaNegocio


            If objReservaNegocio.TraerReservaPorCliente(CType(Session("Usuario"), CLientes).NumeroCliente).Rows.Count > 0 Then
                Me.btnReserva.Visible = True
            Else
                Me.btnReserva.Visible = False
            End If
        End If
    End Sub

    Protected Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Me.txtBuscar.Text = "" Then
            Me.GridView1.DataSourceID = Me.SqlDataSource1.ID
            Me.GridView1.DataBind()
        Else
            Me.GridView1.DataSourceID = Me.SqlDataSource2.ID
            Me.GridView1.DataBind()
        End If
        

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GridView1.SelectedIndexChanged

        Session("Seleccion") = CType(Me.GridView1.SelectedValue, Integer)

        Response.Redirect("FormDetalles.aspx")
        'Dim objModelo As New Modelos
        'Dim objModeloNegocio As New ModeloNegocio
        'Try
        '    Dim Fila As DataRow
        '    Fila = objModelo.CrearTabla().NewRow()
        '    objModelo = objModeloNegocio.TraerModelo(CType(Me.GridView1.SelectedValue, Integer))
        '    Fila("Id") = objModelo.Id
        '    Fila("Nombre") = objModelo.Nombre
        '    Fila("Activo") = objModelo.Activo
        '    Fila("StockCapacidad") = objModelo.StockCapacidad
        '    Fila("Costo") = objModelo.Costo
        '    Fila("Imagen") = objModelo.Nombre
        '    CType(Session("Carrito"), DataTable).Rows.Add(Fila)



        'Catch ex As Exception

        'End Try

        'MsgBox(Me.GridView1.SelectedRow.Cells(2).Text.ToString)
        'Me.GridView1.DataSource = dddd

        'MsgBox("asfdgasfdgsd",

    End Sub
    

  
   


    
    Protected Sub btnReserva_Click(sender As Object, e As EventArgs) Handles btnReserva.Click
        Dim objReservaNegocio As New ReservaNegocio
        Session("Vengode") = "FormClientePrincipalF.aspx"
        Session("ReservaSelec") = CInt(objReservaNegocio.TraerReservaPorCliente(CType(Session("Usuario"), CLientes).NumeroCliente)(0)(0))
        Response.Redirect("FormReservaCliente.aspx")
    End Sub
End Class