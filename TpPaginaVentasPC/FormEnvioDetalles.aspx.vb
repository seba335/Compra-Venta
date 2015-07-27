Imports Negocioo
Imports Entidades
Public Class FormEnvioDetalles
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then



            If (CType(Session("Tipo"), String) = "Cliente") Then


                Dim dtEnvio As DataTable
                Dim objEnvioNegocio As New EnvioNegocio
                dtEnvio = objEnvioNegocio.TraerUltimaDireccionDeEnvio(CType(Session("Usuario"), CLientes).NumeroCliente)

                If dtEnvio.Rows.Count > 0 Then
                    Me.txtCalle.Text = dtEnvio(0)(0).ToString
                    Me.txtNumero.Text = dtEnvio(0)(1).ToString
                    Me.txtPiso.Text = dtEnvio(0)(2).ToString
                    Me.txtDepartamento.Text = dtEnvio(0)(3).ToString
                    Me.txtTelefono.Text = dtEnvio(0)(4).ToString
                    Me.ddlLocalidad.SelectedValue = dtEnvio(0)(6).ToString
                End If

              

            Else
                Dim dtEnvio As DataTable
                Dim objEnvioNegocio As New EnvioNegocio
                dtEnvio = objEnvioNegocio.TraerUltimaDireccionDeEnvio(CType(Session("EmpleadoVentaCliente"), Integer))


                If dtEnvio.Rows.Count > 0 Then
                    Me.txtCalle.Text = dtEnvio(0)(0).ToString
                    Me.txtNumero.Text = dtEnvio(0)(1).ToString
                    Me.txtPiso.Text = dtEnvio(0)(2).ToString
                    Me.txtDepartamento.Text = dtEnvio(0)(3).ToString
                    Me.txtTelefono.Text = dtEnvio(0)(4).ToString
                    Me.ddlLocalidad.SelectedValue = dtEnvio(0)(6).ToString
                End If
           
            End If
        End If
    End Sub

    
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objLocalidadNegocio As New LocalidadNegocio
        Me.lblCostodeEnvio.Text = objLocalidadNegocio.TraerCostoPorLocalidad(CInt(Me.ddlLocalidad.SelectedValue))(0)(0).ToString
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        CType(Session("Envio"), DataTable).Rows.Clear()
        Dim fila As DataRow = CType(Session("Envio"), DataTable).NewRow
        fila("Localidad") = Me.ddlLocalidad.SelectedValue
        fila("Calle") = Me.txtCalle.Text
        fila("Numero") = Me.txtNumero.Text
        fila("Departamento") = Me.txtDepartamento.Text
        fila("Piso") = Me.txtPiso.Text
        fila("Telefono") = Me.txtTelefono.Text
        CType(Session("Envio"), DataTable).Rows.Add(fila)
        Response.Redirect("FormPago.aspx")
    End Sub
End Class