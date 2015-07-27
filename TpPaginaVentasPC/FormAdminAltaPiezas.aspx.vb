Imports Negocioo
Imports Entidades

Public Class FormAdminAltaPiezas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        AgregarPieza()

    End Sub

    Public Sub AgregarPieza()
        Dim objPieza As New Piezas
        Dim objPiezaNegocio As New PiezaNegocio

        With objPieza

            .Costo = CInt(Me.txtCosto.Text)
            .Descripcion = txtDescripcion.Text
            .StockPieza = 0
            .TipoPieza = Me.ddlTipo.SelectedValue.ToString

        End With

        Try
            objPiezaNegocio.AgregarPieza(objPieza)

        Catch ex As Exception

        End Try


        Response.Redirect("FormAdminPiezas.aspx")
    End Sub

End Class