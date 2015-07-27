Imports Entidades
Imports Negocioo
Public Class FormAdminAltaModelo
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnVerFoto_Click(sender As Object, e As EventArgs) Handles btnVerFoto.Click

        If (Not (FileUpload1.FileName = "")) Then

            Dim savelocation As String = Server.MapPath("Imagenes/")
            Dim fileExtention As String = System.IO.Path.GetExtension(FileUpload1.FileName)

            Dim fileName As String = Guid.NewGuid().ToString()

            Dim savePath As String = savelocation + fileName + fileExtention
            FileUpload1.SaveAs(savePath)
            Image1.ImageUrl = "~/Imagenes/" + fileName + fileExtention
            Me.btnVerFoto.Text = "Recargar imagen"

        End If




    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        AgregarModelo()


    End Sub
    Public Sub AgregarModelo()
        Dim objModelo As New Modelos
        Dim objModeloNegocio As New ModeloNegocio
        Dim idModelo As Integer

        With objModelo
            .Activo = True
            .StockCapacidad = 0
            .Costo = CType(Me.txtPrecio.Text, Double)
            .Nombre = Me.txtModelo.Text
            .Imagen = Me.Image1.ImageUrl.ToString
            .Minimo = CInt(Me.ddlMinimo.SelectedValue)
            .Maximo = CInt(Me.ddlMaximo.SelectedValue)



        End With

        Try
            idModelo = objModeloNegocio.AgregarModelo(objModelo)
            Dim objModeloPiezas As New ModeloPiezaNegocio
            objModeloPiezas.AgregarModeloPiezas(idModelo, CType(Me.ddlProcesador.SelectedValue, Integer), 1)
            objModeloPiezas.AgregarModeloPiezas(idModelo, CType(Me.ddlPlacadeVideo.SelectedValue, Integer), 1)
            objModeloPiezas.AgregarModeloPiezas(idModelo, CType(Me.ddlMother.SelectedValue, Integer), 1)
            objModeloPiezas.AgregarModeloPiezas(idModelo, CType(Me.ddlMemoria.SelectedValue, Integer), CType(Me.ddlMemoriaCantidad.SelectedValue, Integer))
            objModeloPiezas.AgregarModeloPiezas(idModelo, CType(Me.ddlLectora.SelectedValue, Integer), 1)
            objModeloPiezas.AgregarModeloPiezas(idModelo, CType(Me.ddlGabinete.SelectedValue, Integer), 1)
            objModeloPiezas.AgregarModeloPiezas(idModelo, CType(Me.ddlFuente.SelectedValue, Integer), 1)
            objModeloPiezas.AgregarModeloPiezas(idModelo, CType(Me.ddlDisco.SelectedValue, Integer), CType(Me.ddlDiscoCantidad.SelectedValue, Integer))
        Catch ex As Exception

        End Try


        Response.Redirect("FormAdminModelos.aspx")
    End Sub


End Class