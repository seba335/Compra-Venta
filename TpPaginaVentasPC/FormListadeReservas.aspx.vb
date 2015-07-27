Imports Negocioo
Imports Entidades
Public Class FormListadeReservas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.GridView1.Rows.Count = 0 Then
            MsgBox("No hay reservas por el momento")
            Response.Redirect("FormEmpVentPrincipal.aspx")
        End If
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Me.DropDownList1.Items.Clear()
        Me.DropDownList1.Items.Add("Seleccione")
        Me.DropDownList1.Items.Add("Completado")
        Me.DropDownList1.Items.Add("Cancelado")
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.GridView1.SelectedIndex = -1 Then
            MsgBox("Seleccione una reserva")
        Else
            If CType(Me.GridView1.SelectedRow.Cells(6).Text, String) = "Cancelado" Or CType(Me.GridView1.SelectedRow.Cells(6).Text, String) = "Completado" Then
                MsgBox("No se puede cambiar el estado ya que se encuentra en un estado final")
            Else
                If Me.DropDownList1.SelectedValue = "Completado" Then
                    Dim objReservaNegocio As New ReservaNegocio
                    objReservaNegocio.ActualizarEstadoReserva(CInt(Me.GridView1.SelectedDataKey.Value), Me.DropDownList1.SelectedValue)
                    Session("Reserva") = CInt(Me.GridView1.SelectedRow.Cells(1).Text)
                    Session("EmpleadoVentaCliente") = CInt(Me.GridView1.SelectedRow.Cells(2).Text)
                    Response.Redirect("FormPagoCompletarReserva.aspx")
                ElseIf Me.DropDownList1.SelectedValue = "Cancelado" Then
                    Dim objReservaNegocio As New ReservaNegocio
                    Dim objClienteNegocio As New ClienteNegocio
                    Dim objModeloNegocio As New ModeloNegocio


                    objModeloNegocio.ActualizarStockModeloArmado(CInt(objReservaNegocio.TraerReservaPorCliente(CInt(Me.GridView1.SelectedRow.Cells(2).Text))(0)(4)), 1)
                    If CInt(objClienteNegocio.TraerClientePorNumeroDeCliente(CInt(Me.GridView1.SelectedRow.Cells(2).Text))(0)(11)) > -2 Then
                        objClienteNegocio.ActualizarValoracionDelCliente(CInt(Me.GridView1.SelectedRow.Cells(2).Text), -1)
                    End If
                    objReservaNegocio.ActualizarEstadoReserva(CInt(Me.GridView1.SelectedDataKey.Value), Me.DropDownList1.SelectedValue)
                    Response.Redirect("FormEmpVentPrincipal.aspx")



                    End If
            End If
          
        End If
    End Sub
End Class