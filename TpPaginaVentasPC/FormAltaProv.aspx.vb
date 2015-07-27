Imports Negocioo
Imports Entidades
Public Class FormAltaProv
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        AgregarProveedor()
        Response.Redirect("FormDetalleCompraProv.aspx")
    End Sub

 
    Public Sub AgregarProveedor()

        Dim objProveedor As New Proveedores
        Dim objProveedorNegocio As New ProveedorNegocio

        With objProveedor
            .Telefono = CInt(Me.txtTelefono.Text)
            .Apellido = Me.txtApellido.Text
            .Nombre = Me.txtNombre.Text
            .IdLocalidad = CInt(Me.ddlLocalidad.SelectedValue)
            .Email = Me.txtEmail.Text
        End With

        objProveedorNegocio.AgregarProveedor(objProveedor)


    End Sub


End Class