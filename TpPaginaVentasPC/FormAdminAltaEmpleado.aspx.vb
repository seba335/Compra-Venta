Imports Negocioo
Imports Entidades
Public Class FormAdminAltaEmpleado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenarComboLocalidad()


    End Sub

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        AgregarEmpleado()
        MsgBox("empleado ingresado con exito!!")
        Response.Redirect("FormAdminEmpleados.aspx")
    End Sub
    Public Sub AgregarEmpleado()
        Dim objEmpleado As New Empleados

        Dim objEmpleadoNegocio As New EmpleadoNegocio


        With objEmpleado

            .Calle = Me.txtCalle.Text
            .Contraseña = Me.txtContraseña.Text
            .Departamento = Me.txtDepartamento.Text
            If Me.txtDepartamento.Text = "" Then
                .Departamento = ""
            Else
                .Departamento = Me.txtDepartamento.Text
            End If

            .NumeroCalle = CInt(Me.txtNumero.Text)
            If Me.txtPiso.Text = "" Then
                .Piso = -1
            Else
                .Piso = CInt(Me.txtPiso.Text)
            End If


            .Telefono = CInt(Me.txtTelefono.Text)
            .Tipo = Me.ddlTipo.SelectedValue
            .IdLocalidad = CInt(Me.ddlLocalidad.SelectedItem.Value)
            .Usuario = Me.txtUsuario.Text
            .Apellido = Me.txtApellido.Text
            .Nombre = Me.txtNombre.Text
            .EstadoCivil = Me.ddlEstadoCivil.SelectedValue



        End With

        Try
            objEmpleadoNegocio.AgregarEmpleado(objEmpleado)


        Catch ex As Exception

        End Try
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

End Class