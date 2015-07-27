Imports Negocioo

Public Class FormDetalleVenta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim objEnvioNegocio As New EnvioNegocio
            Dim dtEnvio As DataTable
            dtEnvio = objEnvioNegocio.TraerEnvioPorVenta(CInt(Session("VentaSeleccionada")))
            If dtEnvio.Rows.Count > 0 Then

                Me.lblEnvio.Visible = True
                Me.DropDownList1.Items.Add("Enviado")
                Me.DropDownList1.Items.Add("Entregado")
                Me.DropDownList1.Items.Add("Envio cancelado")
            End If
            Dim objVentaNegocio As New VentaNegocio
            Dim dt As DataTable
            dt = objVentaNegocio.TraerEstadoYcostoDeVentasPorId(CInt(Session("VentaSeleccionada")))
            Me.DropDownList1.SelectedValue = CType(dt(0)(0), String)
            Me.lblMonto.Text = CType(dt(0)(1), String)
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objVentaNegocio As New VentaNegocio
        Dim dt As DataTable

        
        dt = objVentaNegocio.TraerEstadoYcostoDeVentasPorId(CInt(Session("VentaSeleccionada")))
        If CType(dt(0)(0), String) = "Cancelado" Or CType(dt(0)(0), String) = "Entregado" Or CType(dt(0)(0), String) = "Retirado" Then
            MsgBox("No se puede cambiar el estado de la venta ya que es un estado final")
        Else
            If CType(dt(0)(0), String) = "Envio cancelado" Then
                If Me.DropDownList1.SelectedValue = "Cancelado" Or Me.DropDownList1.SelectedValue = "Retirado" Then
                    objVentaNegocio.ActualizarEstadoDeVenta(CInt(Session("VentaSeleccionada")), Me.DropDownList1.SelectedValue)
                    Response.Redirect("FormVentas.aspx")

                End If
            Else
                If Me.DropDownList1.SelectedValue = "Pedido" Then
                    MsgBox("No se puede pasar a ese estado")
                ElseIf Me.DropDownList1.SelectedValue = "Cancelado" Then
                    Dim objModeloNegocio As New ModeloNegocio
                    objVentaNegocio.ActualizarEstadoDeVenta(CInt(Session("VentaSeleccionada")), Me.DropDownList1.SelectedValue)
                    Dim dtmod As DataTable
                    Dim objModelosVentasNegocio As New ModelosVentasNegocio
                    dtmod = objModelosVentasNegocio.TraetModeloVentasConIdVenta(CInt(Session("VentaSeleccionada")))
                    For Each f As DataRow In dtmod.Rows
                        objModeloNegocio.SumarStockModelo(CInt(f(0)), CInt(f(2)))
                    Next

                    Response.Redirect("FormVentas.aspx")
                Else
                    objVentaNegocio.ActualizarEstadoDeVenta(CInt(Session("VentaSeleccionada")), Me.DropDownList1.SelectedValue)
                    Response.Redirect("FormVentas.aspx")
                End If
                
            End If
        End If

    End Sub
End Class