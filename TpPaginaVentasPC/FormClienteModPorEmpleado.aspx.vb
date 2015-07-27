Imports Entidades
Imports Negocioo
Public Class FormClienteModPorEmpleado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then


            Dim objClienteNegocio As New ClienteNegocio
            Dim dt As New DataTable
            dt = objClienteNegocio.TraerClientePorNumeroDeCliente(CInt(Session("EmpleadoVentaCliente")))

            For Each fila As DataRow In dt.Rows
                Me.txtNombre.Text = CType(fila(1), String)
                Me.txtApellido.Text = CType(fila(2), String)
                Me.ddlLocalidad.SelectedValue = CType(fila(3), String)
                Me.txtTelefono.Text = CType(fila(4), String)
                Me.txtCalle.Text = CType(fila(5), String)
                Me.txtNumero.Text = CType(fila(6), String)
                If fila(7).Equals(DBNull.Value) Then

                Else
                    Me.txtPiso.Text = CType(fila(7), String)
                End If
                If fila(8).Equals(DBNull.Value) Then
                Else
                    Me.txtDepartamento.Text = CType(fila(8), String)
                End If
                If fila(9).Equals(DBNull.Value) Then
                Else
                    Me.txtEmail.Text = CType(fila(9), String)
                End If
                If fila(10).Equals(DBNull.Value) Then
                    Me.txtContraseña.Enabled = True
                    Me.txtContraseña2.Enabled = True
                Else
                    'Me.txtContraseña.Enabled = False
                    'Me.txtContraseña2.Enabled = False
                End If

            Next
            Me.txtNombre.Enabled = False
            Me.txtApellido.Enabled = False

        End If
    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        Dim cliente As New CLientes
        
        Dim objClienteNegocio As New ClienteNegocio
        Dim dt As New DataTable
        dt = objClienteNegocio.TraerClientePorNumeroDeCliente(CInt(Session("EmpleadoVentaCliente")))

        For Each fila As DataRow In dt.Rows
            cliente.Valoracion = CInt(fila(11))
            If fila(10).Equals(DBNull.Value) Then

            Else
                cliente.Contraseña = CType(fila(10), String)
            End If

        Next


        With cliente
            .NumeroCliente = CInt(Session("EmpleadoVentaCliente"))
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

            .Email = Me.txtEmail.Text

            If Me.txtContraseña.Enabled = False Then


            Else
                .Contraseña = Me.txtContraseña.Text
            End If


        End With
        Try
            Dim clientenegocio As New ClienteNegocio
            clientenegocio.ModificarClientePorEmpleado(cliente)
        Catch ex As Exception
            MsgBox("Error al modificar el cliente")
        End Try

        Response.Redirect("FormListadeClientes.aspx")

    End Sub
End Class