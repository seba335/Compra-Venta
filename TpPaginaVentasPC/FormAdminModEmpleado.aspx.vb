Imports Entidades
Imports Negocioo
Public Class FormAdminModEmpleado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            LlenarComboLocalidad()

            If (Session("Tipo").ToString = "Empleado") Then
                Dim objEmpleadoNegocio As New EmpleadoNegocio
                Dim empleado As New Empleados
                Dim dtEmp As DataTable
                dtEmp = objEmpleadoNegocio.TraerEmpleadoPorId(CInt(Session("EmpleadoSeleccionado")))
                Me.TxtApellido.Text = CType(dtEmp(0)(11), String)
                Me.TxtApellido.Enabled = False
                Me.TxtNombre.Text = CType(dtEmp(0)(10), String)
                Me.TxtNombre.Enabled = False
                Me.txtCalle.Text = CType(dtEmp(0)(6), String)
                Me.txtNumero.Text = CType(dtEmp(0)(7), String)
                If dtEmp(0)(8) Is DBNull.Value Then

                Else
                    Me.txtPiso.Text = CType(dtEmp(0)(8), String)
                End If

                Me.txtTelefono.Text = CType(dtEmp(0)(3), String)
                Me.ddlLocalidad.SelectedValue = CType(dtEmp(0)(4), String)
                Me.ddlTipo.SelectedValue = CType(dtEmp(0)(5), String)
                Me.ddlEstadoCivil.SelectedValue = CType(dtEmp(0)(12), String)
                If dtEmp(0)(9) Is DBNull.Value Then

                Else
                    Me.txtDepartamento.Text = CType(dtEmp(0)(9), String)
                End If

                If (CType(dtEmp(0)(13), Boolean) = True) Then
                    BtnBaja.Visible = True
                    Me.btnAceptar.Text = "Aceptar"
                Else
                    BtnBaja.Visible = False
                    Me.btnAceptar.Text = "Reactivar"
                End If

            End If


        End If



    End Sub

    Public Sub LlenarComboLocalidad()
        Try
            Dim objConexion = New SqlClient.SqlConnection("Data Source=.;Initial Catalog=CompraVentaComputadoras;Integrated Security=True")

            Dim Adapter = New SqlClient.SqlDataAdapter("SELECT * FROM Localidad", objConexion)
            Dim ds = New DataSet()
            Adapter.Fill(ds)
            objConexion.Close()

            With Me.ddlLocalidad
                .DataSource = ds.Tables(0).DefaultView
                .DataValueField = "Id"
                .DataTextField = "Nombre"
                .DataBind()

            End With
        Catch ex As Exception

        End Try





    End Sub

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        If (Session("Tipo").ToString = "Empleado") Then
            Dim empleado As New Empleados

         
            If Me.txtPiso.Text = "" Then
                empleado.Piso = -1
            Else
                empleado.Piso = CInt(Me.txtPiso.Text)
            End If

            


            



                With empleado
                    .Calle = Me.txtCalle.Text.ToString
                    .Tipo = Me.ddlTipo.SelectedValue
                    .Telefono = CType(Me.txtTelefono.Text, Double)
                    .EstadoCivil = Me.ddlEstadoCivil.SelectedValue
                    .NumeroCalle = CType(Me.txtNumero.Text, Integer)
                    .IdLocalidad = CInt(Me.ddlLocalidad.SelectedValue)
                    .Departamento = Me.txtDepartamento.Text.ToString
                    .Legajo = CInt(Session("EmpleadoSeleccionado"))

                End With
            empleado.Departamento = Me.txtDepartamento.Text
                Dim empleadoNegocio As New EmpleadoNegocio
                Try
                    empleadoNegocio.ModificarEmpleado(empleado)

                Catch ex As Exception
                End Try
                Response.Redirect("FormAdminEmpleados.aspx")
            End If
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Protected Sub BtnBaja_Click(sender As Object, e As EventArgs) Handles BtnBaja.Click
        Dim objempNegocio As New EmpleadoNegocio
        objempNegocio.ModificarActivoEmpleado(CInt(Session("EmpleadoSeleccionado")), False)
        Response.Redirect("FormAdminEmpleados.aspx")

    End Sub
End Class