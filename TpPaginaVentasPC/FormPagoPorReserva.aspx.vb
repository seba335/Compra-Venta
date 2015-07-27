Imports Negocioo
Imports Entidades
Public Class FormPagoPorReserva
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then


            Dim objLocalidadNegocio As New LocalidadNegocio
            Dim objModeloNegocio As New ModeloNegocio
            Dim objTarjetasNegocio As New TarjetaNegocio
            Dim dtTarjetas As DataTable
            Dim costoTotal As Double = 0

            Dim objModelo As Modelos
            Dim costoReserva As Double
            objModelo = objModeloNegocio.TraerModelo(CType(Session("Seleccion"), Integer))
            costoReserva = objModelo.Costo * 30 / 100
            Me.lblMontoAPagar.Text = costoReserva.ToString
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
            
            End If
        End If
    End Sub

    Protected Sub btnRealizarCompra_Click(sender As Object, e As EventArgs) Handles btnRealizarCompra.Click
        Dim idPago As Integer = 0
        Dim objPagoNegocio As New PagoNegocio
        Dim objModelo As Modelos
        Dim costoReserva As Double
        Dim objModeloNegocio As New ModeloNegocio
        objModelo = objModeloNegocio.TraerModelo(CType(Session("Seleccion"), Integer))
        costoReserva = objModelo.Costo * 30 / 100
        idPago = objPagoNegocio.AgregarPagoParaReserva("Tarjeta", CInt(Me.ddlTipoTarjeta.SelectedValue), costoReserva, CType(Date.Now, DateTime))

        Dim objReservaNegocio As New ReservaNegocio
        objModeloNegocio.ActualizarStockModeloVenta(CType(Session("Seleccion"), Integer), 1)
        objReservaNegocio.AgregarReserva(CType(Session("Usuario"), CLientes).NumeroCliente, idPago, -1, CType(Session("Seleccion"), Integer), "Reservado", CType(Date.Now, DateTime))
        MsgBox("Se realizo su reserva")
        Response.Redirect("FormClientePrincipalF.aspx")

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Session("PagoPor") = "Reserva"
        Response.Redirect("FormAltaTarjeta.aspx")
    End Sub
End Class