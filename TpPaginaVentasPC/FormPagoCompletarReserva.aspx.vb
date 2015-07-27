Imports Negocioo
Imports Entidades
Public Class FormPagoCompletarReserva
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then


            Dim objLocalidadNegocio As New LocalidadNegocio
            Dim objModeloNegocio As New ModeloNegocio
            Dim objTarjetasNegocio As New TarjetaNegocio
            Dim dtTarjetas As DataTable
            Dim costoTotal As Double = 0


            Dim costoReserva As Double
            Dim objReservaNegocio As New ReservaNegocio
            Dim dtmostrar As New DataTable


            
            If (CType(Session("Tipo"), String) = "Empleado") Then
                costoReserva = CInt(objReservaNegocio.TraerPagoPorReserva(CInt(Session("Reserva")))(0)(0)) * 70 / 30
                Me.lblMontoAPagar.Text = costoReserva.ToString
                dtmostrar.Columns.Add("Id")
                dtmostrar.Columns.Add("Nombre")
                dtTarjetas = objTarjetasNegocio.TraerTarjetaPorCliente(CInt(Session("EmpleadoVentaCliente")), CType(Date.Now, DateTime))
                Dim t As DataRow = dtmostrar.NewRow
                t("Id") = "---"
                t("Nombre") = "Seleccione"
                dtmostrar.Rows.Add(t)
                Dim s As DataRow = dtmostrar.NewRow
                s("Id") = "Efectivo"
                s("Nombre") = "Efectivo"
                dtmostrar.Rows.Add(s)
                If dtTarjetas.Rows.Count > 0 Then

                    For Each fila As DataRow In dtTarjetas.Rows
                        Dim f As DataRow = dtmostrar.NewRow
                        Dim Nombre As String

                        Nombre = CType(fila(1), String) + " Caducada en " + CType(fila(2), String)
                        f("Nombre") = Nombre
                        f("Id") = fila(0)
                        dtmostrar.Rows.Add(f)
                    Next

                    

                    End If

                    Me.ddlTipoTarjeta.DataSource = dtmostrar
                    Me.ddlTipoTarjeta.DataValueField = "Id"
                    Me.ddlTipoTarjeta.DataTextField = "Nombre"
                    Me.ddlTipoTarjeta.DataBind()
            Else
                costoReserva = CInt(objReservaNegocio.TraerPagoPorReserva(CInt(Session("ReservaSelec")))(0)(0)) * 70 / 30
                Me.lblMontoAPagar.Text = costoReserva.ToString
                dtmostrar.Columns.Add("Id")
                dtmostrar.Columns.Add("Nombre")
                dtTarjetas = objTarjetasNegocio.TraerTarjetaPorCliente(CType(Session("Usuario"), CLientes).NumeroCliente, CType(Date.Now, DateTime))
                Dim a As DataRow = dtmostrar.NewRow
                a("Id") = "---"
                a("Nombre") = "Seleccione"
                dtmostrar.Rows.Add(a)


                If dtTarjetas.Rows.Count > 0 Then

                    For Each fila As DataRow In dtTarjetas.Rows
                        Dim f As DataRow = dtmostrar.NewRow
                        Dim Nombre As String

                        Nombre = CType(fila(1), String) + " Caducada en " + CType(fila(2), String)
                        f("Nombre") = Nombre
                        f("Id") = fila(0)
                        dtmostrar.Rows.Add(f)
                    Next

                    Me.ddlTipoTarjeta.DataSource = dtmostrar
                    Me.ddlTipoTarjeta.DataValueField = "Id"
                    Me.ddlTipoTarjeta.DataTextField = "Nombre"
                    Me.ddlTipoTarjeta.DataBind()
                End If
                End If
            End If

    End Sub

    Protected Sub btnRealizarCompra_Click(sender As Object, e As EventArgs) Handles btnRealizarCompra.Click

        Dim objPagoNegocio As New PagoNegocio
        Dim objVentaNegocio As New VentaNegocio
        Dim costoTotal As Double
        Dim costoReserva As Double
        Dim objModeloNegocio As New ModeloNegocio
        Dim objReservaNegocio As New ReservaNegocio
        Dim idVenta As Integer
        If (CType(Session("Tipo"), String) = "Cliente") Then
            costoReserva = CInt(objReservaNegocio.TraerPagoPorReserva(CInt(Session("ReservaSelec")))(0)(0)) * 70 / 30
            costoTotal = CDbl(objReservaNegocio.TraerPagoPorReserva(CInt(Session("ReservaSelec")))(0)(0)) * 100 / 30
            idVenta = objVentaNegocio.InsertaVenta(CType(Session("Usuario"), CLientes).NumeroCliente, CType(Date.Now, DateTime), -1, costoTotal, "pedido", -1)
            objPagoNegocio.AgregarPago("Tarjeta", CInt(Me.ddlTipoTarjeta.SelectedValue), costoReserva, idVenta, CType(Date.Now, DateTime))


            objReservaNegocio.ActualizarEstadoReserva(CInt(Session("ReservaSelec")), "Completado")
            
            MsgBox("Se completo su reserva")
            Response.Redirect("FormClientePrincipalF.aspx")
        Else
            costoReserva = CDbl(objReservaNegocio.TraerPagoPorReserva(CInt(Session("Reserva")))(0)(0)) * 70 / 30
            costoTotal = CDbl(objReservaNegocio.TraerPagoPorReserva(CInt(Session("Reserva")))(0)(0)) * 100 / 30

            idVenta = objVentaNegocio.InsertaVenta(CInt(Session("EmpleadoVentaCliente")), CType(Date.Now, DateTime), CType(Session("Usuario"), Empleados).Legajo, costoTotal, "pedido", -1)
            If Me.ddlTipoTarjeta.SelectedValue = "Efectivo" Then
                objPagoNegocio.AgregarPago("Efectivo", -1, costoReserva, idVenta, CType(Date.Now, DateTime))
            Else
                objPagoNegocio.AgregarPago("Tarjeta", CInt(Me.ddlTipoTarjeta.SelectedValue), costoReserva, idVenta, CType(Date.Now, DateTime))
            End If

            objReservaNegocio.ActualizarEstadoReserva(CInt(Session("Reserva")), "Completado")
            
            MsgBox("Se completo su reserva")
            Response.Redirect("FormEmpVentPrincipal.aspx")

        End If
    End Sub

  
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Session("Vengode") = "FormPagoCompletarReserva.aspx"
        Session("PagoPor") = "CompletarReserva"
        Response.Redirect("FormAltaTarjeta.aspx")
    End Sub
End Class