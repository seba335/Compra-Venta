Imports Negocioo
Imports Entidades
Public Class FormClienteReg
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        AgregarCliente()
    End Sub

    Public Sub AgregarCliente()
        Dim objCliente As New CLientes

        Dim objClienteNegocio As New ClienteNegocio
        objCliente.Apellido = Me.txtApellido.Text
        objCliente.Calle = Me.txtApellido.Text
        objCliente.Contraseña = Me.txtContraseña.Text
  
            objCliente.Departamento = Me.txtDepartamento.Text


            objCliente.Email = Me.txtCorreo.Text
        objCliente.IdLocalidad = CInt(Me.ddlLocalidad.SelectedValue)
            objCliente.Nombre = Me.txtNombre.Text
            objCliente.NumeroCalle = CInt(Me.txtNumero.Text)

        If Me.txtPiso.Text = "" Then
            objCliente.Piso = -1
        Else
            objCliente.Piso = CInt(Me.txtPiso.Text)

        End If


        objCliente.Telefono = CInt(Me.txtTelefono.Text)
        objCliente.Valoracion = 0




        Try
            objClienteNegocio.AgregarCliente(objCliente)

            Response.Redirect("FormRegExitoso.aspx")
        Catch ex As Exception

        End Try

    End Sub

    






End Class