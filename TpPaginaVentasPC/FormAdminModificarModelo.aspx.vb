Imports Negocioo
Imports Entidades
Public Class FormAdminModificarModelo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim objModeloNegocio As New ModeloNegocio
            Dim modelo As New Modelos
            For i As Integer = 1 To 20
                Me.DdlMinimo.Items.Add(i.ToString)
                Me.DdlMaximo.Items.Add(i.ToString)
            Next
            modelo = objModeloNegocio.TraerModelo(CInt(Session("Seleccion")))
            Me.TxtCosto.Text = modelo.Costo.ToString
            Me.DdlMaximo.SelectedValue = modelo.Maximo.ToString
            Me.DdlMinimo.SelectedValue = modelo.Minimo.ToString
            Me.LblModeloNombre.Text = modelo.Nombre
            Me.ChboxActivo.Enabled = False
            If modelo.Activo Then
                Me.ChboxActivo.Checked = True
            Else
                Me.ChboxActivo.Checked = False
            End If
        End If


    End Sub

    Protected Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim objModeloNegocio As New ModeloNegocio
        Dim modelo As New Modelos
        modelo = objModeloNegocio.TraerModelo(CInt(Session("Seleccion")))
        If Me.ChboxActivo.Checked Then
            modelo.Activo = True
        Else
            modelo.Activo = False
        End If

        objModeloNegocio.ModificarModelo(modelo.Id, modelo.Activo, CDbl(Me.TxtCosto.Text), CInt(Me.DdlMaximo.SelectedValue),
                                           CInt(Me.DdlMinimo.SelectedValue))

        Response.Redirect("FormAdminModelos.aspx")


    End Sub

    Protected Sub BtnActivo_Click(sender As Object, e As EventArgs) Handles BtnActivo.Click
        If Me.ChboxActivo.Checked Then
            Me.ChboxActivo.Checked = False
        Else
            Me.ChboxActivo.Checked = True
        End If


    End Sub
End Class