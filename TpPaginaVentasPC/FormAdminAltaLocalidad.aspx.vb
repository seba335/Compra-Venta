Imports Negocioo
Imports Entidades

Public Class FormAdminAltaLocalidad
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenarComboZonas()
    End Sub

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        AgregarLocalidad()
    End Sub

    Public Sub AgregarLocalidad()
        Dim objLocalidad As New Localidades

        Dim objLocalidadNegocio As New LocalidadNegocio
        objLocalidad.Nombre = Me.txtNombre.Text
        objLocalidad.IdZona = CInt(Me.ddZonas.SelectedItem.Value)

    
        Try
            objLocalidadNegocio.AgregarLocalidad(objLocalidad)
            MsgBox("Localidad ingresada con exito!!")
            Response.Redirect("FormAdminLocalidades.aspx")
        Catch ex As Exception

        End Try

    End Sub

    Public Sub LlenarComboZonas()
        Try
            Dim objConexion = New SqlClient.SqlConnection("Data Source=.;Initial Catalog=CompraVentaComputadoras;Integrated Security=True")

            Dim Adapter = New SqlClient.SqlDataAdapter("SELECT * FROM Zonas", objConexion)
            Dim ds = New DataSet()
            Adapter.Fill(ds)
            objConexion.Close()

            With Me.ddZonas

                .DataSource = ds.Tables(0).DefaultView
                .DataValueField = "Id"
                .DataTextField = "Descripcion"
                .DataBind()

            End With
        Catch ex As Exception

        End Try





    End Sub
End Class