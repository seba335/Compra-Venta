Imports Negocioo
Imports Entidades
Public Class FormPago
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then


            Dim objLocalidadNegocio As New LocalidadNegocio
            Dim objModeloNegocio As New ModeloNegocio
            Dim objTarjetasNegocio As New TarjetaNegocio
            Dim dtTarjetas As DataTable
            Dim costoTotal As Double = 0
            If CType(Session("Envio"), DataTable).Rows.Count > 0 Then
                For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows

                    costoTotal = costoTotal + (objModeloNegocio.TraerModelo(CInt(f(0))).Costo * CInt(f(5)))

                Next
                costoTotal = costoTotal + CType(objLocalidadNegocio.TraerCostoPorLocalidad(CInt(CType(Session("Envio"), DataTable)(0)(0)))(0)(0), Double)
                Me.lblMontoAPagar.Text = costoTotal.ToString
            Else
                For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows

                    costoTotal = costoTotal + (objModeloNegocio.TraerModelo(CInt(f(0))).Costo * CInt(f(5)))

                Next
                Me.lblMontoAPagar.Text = costoTotal.ToString
            End If
            If (CType(Session("Tipo"), String) = "Cliente") Then
                Dim dtmostrar As New DataTable
                dtmostrar.Columns.Add("Id")
                dtmostrar.Columns.Add("Nombre")
                dtTarjetas = objTarjetasNegocio.TraerTarjetaPorCliente(CType(Session("Usuario"), CLientes).NumeroCliente, CType(Date.Now, DateTime))
                Dim t As DataRow = dtmostrar.NewRow
                t("Id") = "---"
                t("Nombre") = "Seleccione"
                dtmostrar.Rows.Add(t)
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
            ElseIf CType(Session("Tipo"), String) = "Empleado" Then
                Dim dtmostrar As New DataTable
                dtmostrar.Columns.Add("Id")
                dtmostrar.Columns.Add("Nombre")
                dtTarjetas = objTarjetasNegocio.TraerTarjetaPorCliente(CType(Session("EmpleadoVentaCliente"), Integer), CType(Date.Now, DateTime))
                Dim t As DataRow = dtmostrar.NewRow
                t("Id") = "---"
                t("Nombre") = "Seleccione"
                Dim r As DataRow = dtmostrar.NewRow

                r("Id") = "Efectivo"
                r("Nombre") = "Efectivo"
                dtmostrar.Rows.Add(t)
                dtmostrar.Rows.Add(r)
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
            End If
        End If
    End Sub

    Protected Sub btnRealizarCompra_Click(sender As Object, e As EventArgs) Handles btnRealizarCompra.Click

        Dim objVentaNegocio As New VentaNegocio
        Dim objEnvioNegocio As New EnvioNegocio
        Dim objModeloNegocio As New ModeloNegocio
        Dim objLocalidadNegocio As New LocalidadNegocio
        Dim objModeloVentaNegocio As New ModelosVentasNegocio
        Dim objPagoNegocio As New PagoNegocio
        Dim costoTotal As Double = 0
        If CType(Session("Envio"), DataTable).Rows.Count > 0 Then
            For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows

                costoTotal = costoTotal + (objModeloNegocio.TraerModelo(CInt(f(0))).Costo * CInt(f(5)))

            Next
            costoTotal = costoTotal + CType(objLocalidadNegocio.TraerCostoPorLocalidad(CInt(CType(Session("Envio"), DataTable)(0)(0)))(0)(0), Double)
            Me.lblMontoAPagar.Text = costoTotal.ToString
        Else


        End If
        If CType(Session("Tipo"), String) = "Cliente" Then
            If CType(Session("Envio"), DataTable).Rows.Count > 0 Then
                Dim idEnvio As Integer
                Dim idVenta As Integer
                If CType(CType(Session("Envio"), DataTable)(0)(4), String) = "" Then
                    CType(Session("Envio"), DataTable)(0)(4) = -1
                End If
                idEnvio = objEnvioNegocio.AgregarEnvio(CType(Session("Usuario"), CLientes).NumeroCliente, CInt(CType(Session("Envio"), DataTable)(0)(0)), CType(Session("Envio"), DataTable)(0)(1).ToString, CInt(CType(Session("Envio"), DataTable)(0)(2)), CDbl(CType(Session("Envio"), DataTable)(0)(5)), CInt(CType(Session("Envio"), DataTable)(0)(4)), CType(CType(Session("Envio"), DataTable)(0)(3), String), CType(Date.Now, DateTime))
                idVenta = objVentaNegocio.InsertaVenta(CType(Session("Usuario"), CLientes).NumeroCliente, CType(Date.Now, DateTime), -1, costoTotal, "Pedido", idEnvio)
                objPagoNegocio.AgregarPago("Tarjeta", CInt(Me.ddlTipoTarjeta.SelectedValue), costoTotal, idVenta, CType(Date.Now, DateTime))
                Dim objClienteNegocio As New ClienteNegocio
                If CInt(objClienteNegocio.TraerClientePorNumeroDeCliente(CType(Session("Usuario"), CLientes).NumeroCliente)(0)(11)) < 2 Then
                    objClienteNegocio.ActualizarValoracionDelCliente(CType(Session("Usuario"), CLientes).NumeroCliente, 1)
                End If


                For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows

                    objModeloVentaNegocio.AgregarModelosVentas(idVenta, CInt(f("Id")), CInt(f("Cantidad")), (objModeloNegocio.TraerModelo(CInt(f("Id"))).Costo) * CInt(f("Cantidad")))
                    objModeloNegocio.ActualizarStockModeloVenta(CInt(f("Id")), CInt(f("Cantidad")))
                Next

            Else
                For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows

                    costoTotal = costoTotal + (objModeloNegocio.TraerModelo(CInt(f(0))).Costo * CInt(f(5)))

                Next
                Dim idVenta As Integer
                idVenta = objVentaNegocio.InsertaVenta(CType(Session("Usuario"), CLientes).NumeroCliente, CType(Date.Now, DateTime), -1, costoTotal, "Pedido", -1)
                objPagoNegocio.AgregarPago("Tarjeta", CInt(Me.ddlTipoTarjeta.SelectedValue), costoTotal, idVenta, CType(Date.Now, DateTime))
                Dim objClienteNegocio As New ClienteNegocio
                If CInt(objClienteNegocio.TraerClientePorNumeroDeCliente(CType(Session("Usuario"), CLientes).NumeroCliente)(0)(11)) < 2 Then
                    objClienteNegocio.ActualizarValoracionDelCliente(CType(Session("Usuario"), CLientes).NumeroCliente, 1)
                End If

                For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows

                    objModeloVentaNegocio.AgregarModelosVentas(idVenta, CInt(f("Id")), CInt(f("Cantidad")), (objModeloNegocio.TraerModelo(CInt(f("Id"))).Costo) * CInt(f("Cantidad")))
                    objModeloNegocio.ActualizarStockModeloVenta(CInt(f("Id")), CInt(f("Cantidad")))
                Next
            End If
            Dim modelo As New Modelos
            Session("Carrito") = modelo.CrearTabla()
            MsgBox("Su compra se realizo con exito")
            Response.Redirect("FormClientePrincipalF.aspx")
        ElseIf CType(Session("Tipo"), String) = "Empleado" Then
            If CType(Session("Envio"), DataTable).Rows.Count > 0 Then
                Dim idEnvio As Integer
                Dim idVenta As Integer
                If CType(CType(Session("Envio"), DataTable)(0)(4), String) = "" Then
                    CType(Session("Envio"), DataTable)(0)(4) = -1
                End If
                idEnvio = objEnvioNegocio.AgregarEnvio(CType(Session("EmpleadoVentaCliente"), Integer), CInt(CType(Session("Envio"), DataTable)(0)(0)), CType(Session("Envio"), DataTable)(0)(1).ToString, CInt(CType(Session("Envio"), DataTable)(0)(2)), CInt(CType(Session("Envio"), DataTable)(0)(5)), CInt(CType(Session("Envio"), DataTable)(0)(4)), CType(CType(Session("Envio"), DataTable)(0)(3), String), CType(Date.Now, DateTime))
                idVenta = objVentaNegocio.InsertaVenta(CType(Session("EmpleadoVentaCliente"), Integer), CType(Date.Now, DateTime), CType(Session("Usuario"), Empleados).Legajo, costoTotal, "Pedido", idEnvio)
                If CType(Me.ddlTipoTarjeta.SelectedValue, String) = "Efectivo" Then
                    objPagoNegocio.AgregarPago("Efectivo", -1, costoTotal, idVenta, CType(Date.Now, DateTime))
                Else
                    objPagoNegocio.AgregarPago("Tarjeta", CInt(Me.ddlTipoTarjeta.SelectedValue), costoTotal, idVenta, CType(Date.Now, DateTime))
                End If
                Dim objClienteNegocio As New ClienteNegocio
                If CInt(objClienteNegocio.TraerClientePorNumeroDeCliente(CType(Session("EmpleadoVentaCliente"), Integer))(0)(11)) < 2 Then
                    objClienteNegocio.ActualizarValoracionDelCliente(CType(Session("EmpleadoVentaCliente"), Integer), 1)
                End If

                For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows

                    objModeloVentaNegocio.AgregarModelosVentas(idVenta, CInt(f("Id")), CInt(f("Cantidad")), (objModeloNegocio.TraerModelo(CInt(f("Id"))).Costo) * CInt(f("Cantidad")))
                    objModeloNegocio.ActualizarStockModeloVenta(CInt(f("Id")), CInt(f("Cantidad")))
                Next

            Else
                For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows

                    costoTotal = costoTotal + (objModeloNegocio.TraerModelo(CInt(f(0))).Costo * CInt(f(5)))

                Next
                Dim idVenta As Integer
                idVenta = objVentaNegocio.InsertaVenta(CType(Session("EmpleadoVentaCliente"), Integer), CType(Date.Now, DateTime), CType(Session("Usuario"), Empleados).Legajo, costoTotal, "Pedido", -1)
                If CType(Me.ddlTipoTarjeta.SelectedValue, String) = "Efectivo" Then
                    objPagoNegocio.AgregarPago("Efectivo", -1, costoTotal, idVenta, CType(Date.Now, DateTime))
                Else
                    objPagoNegocio.AgregarPago("Tarjeta", CInt(Me.ddlTipoTarjeta.SelectedValue), costoTotal, idVenta, CType(Date.Now, DateTime))
                End If

                Dim objClienteNegocio As New ClienteNegocio
                If CInt(objClienteNegocio.TraerClientePorNumeroDeCliente(CType(Session("EmpleadoVentaCliente"), Integer))(0)(11)) < 2 Then
                    objClienteNegocio.ActualizarValoracionDelCliente(CType(Session("EmpleadoVentaCliente"), Integer), 1)
                End If

                For Each f As DataRow In CType(Session("Carrito"), DataTable).Rows

                    objModeloVentaNegocio.AgregarModelosVentas(idVenta, CInt(f("Id")), CInt(f("Cantidad")), (objModeloNegocio.TraerModelo(CInt(f("Id"))).Costo) * CInt(f("Cantidad")))
                    objModeloNegocio.ActualizarStockModeloVenta(CInt(f("Id")), CInt(f("Cantidad")))
                Next
            End If
            Dim modelo As New Modelos
            Session("Carrito") = modelo.CrearTabla()
            MsgBox("Su venta se realizo con exito")
            Response.Redirect("FormEmpVentPrincipal.aspx")
        End If
        
    End Sub

    'Protected Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
    '    Dim objTarjetasNegocio As New TarjetaNegocio
    '    objTarjetasNegocio.EliminarTarjeta(CInt(Me.ddlTipoTarjeta.SelectedValue), False)
    '    Me.ddlTipoTarjeta.Items.RemoveAt(Me.ddlTipoTarjeta.SelectedIndex)

    'End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Session("Vengode") = "FormPago.aspx"
        Session("PagoPor") = "Compra"
        Response.Redirect("FormAltaTarjeta.aspx")
    End Sub
End Class