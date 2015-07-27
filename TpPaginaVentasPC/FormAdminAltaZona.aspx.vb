Imports Negocioo
Imports Entidades
Public Class FormAdminAltaZona
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        AgregarZona()
    End Sub


    Public Sub AgregarZona()
        Dim objZona As New Zonas

        Dim objZonaNegocio As New ZonaNegocio
        objZona.Descripcion = Me.txtDescripcion.Text
        objZona.Costo = CType(txtCosto.Text, Double)


        Try
            objZonaNegocio.AgregarZona(objZona)
            Response.Redirect("FormAdminZonas.aspx")
        Catch ex As Exception

        End Try

    End Sub
End Class