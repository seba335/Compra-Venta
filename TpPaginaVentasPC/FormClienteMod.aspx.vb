Imports Entidades
Imports Negocioo
Public Class FormClienteMod
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then


            If (Session("Tipo").ToString = "Cliente") Then
                LlenarComboLocalidad()
                Me.txtApellido.Text = CType(Session("Usuario"), CLientes).Apellido
                Me.txtNombre.Text = CType(Session("Usuario"), CLientes).Nombre
                Me.txtApellido.Enabled = False
                Me.txtNombre.Enabled = False
                Me.txtCalle.Text = CType(Session("Usuario"), CLientes).Calle
                Me.lblEmail.Text = CType(Session("Usuario"), CLientes).Email
                Me.txtNumero.Text = CType(Session("Usuario"), CLientes).NumeroCalle.ToString()
                Me.txtPiso.Text = CType(Session("Usuario"), CLientes).Piso.ToString
                Me.txtTelefono.Text = CType(Session("Usuario"), CLientes).Telefono.ToString
                Me.ddlLocalidad.SelectedValue = CType(Session("Usuario"), CLientes).IdLocalidad.ToString
                If (CType(Session("Usuario"), CLientes).Departamento = "-") Then

                Else
                    Me.txtDepartamento.Text = CType(Session("Usuario"), CLientes).Departamento
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

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If (Session("Tipo").ToString = "Cliente") Then

            Dim cliente As New CLientes
            CType(Session("Usuario"), CLientes).Calle = Me.txtCalle.Text.ToString
            CType(Session("Usuario"), CLientes).NumeroCalle = CType(Me.txtNumero.Text, Integer)
            If Me.txtPiso.Text = "" Then
                CType(Session("Usuario"), CLientes).Piso = Nothing
            Else
                CType(Session("Usuario"), CLientes).Piso = CType(Me.txtPiso.Text, Integer)
            End If

            CType(Session("Usuario"), CLientes).Telefono = CType(Me.txtTelefono.Text, Double)
            CType(Session("Usuario"), CLientes).IdLocalidad = CInt(Me.ddlLocalidad.SelectedValue)
           
            CType(Session("Usuario"), CLientes).Departamento = Me.txtDepartamento.Text.ToString



                With cliente
                    .Departamento = Me.txtDepartamento.Text.ToString
                .Calle = Me.txtCalle.Text.ToString
                If Me.txtPiso.Text = "" Then
                    .Piso = -1
                Else
                    .Piso = CInt(Me.txtPiso.Text)
                End If

                .Telefono = CDbl(Me.txtTelefono.Text)
                    .IdLocalidad = CInt(Me.ddlLocalidad.SelectedValue)
                .NumeroCalle = CInt(Me.txtNumero.Text)
                .NumeroCliente = CType(Session("Usuario"), CLientes).NumeroCliente
                End With
                Try
                    Dim clientenegocio As New ClienteNegocio
                clientenegocio.ModificarCliente(cliente)
                Response.Redirect("FormClientePrincipalF.aspx")
                Catch ex As Exception

                End Try


            End If
    End Sub

End Class