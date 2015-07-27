Imports Entidades
Imports Negocioo


Public Class FormLogueo
    Inherits System.Web.UI.Page
    Implements IUsuario
    Public objCliente As CLientes
    Public objEmpleado As Empleados

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        chequeoUsuario()
    End Sub

    Public Sub chequeoUsuario()



        Try

            Dim objLogNegocio As New LogueoNegocio
            objEmpleado = objLogNegocio.TraerEmpleado(Me.txtUsuario.Text, Me.txtContraseña.Text)
            If (objEmpleado.Legajo = Nothing) Then

                objCliente = objLogNegocio.TraerCliente(Me.txtUsuario.Text, Me.txtContraseña.Text)
                If (objCliente.NumeroCliente = Nothing) Then

                    Me.lbError.Visible = True
                Else
                    Session("Usuario") = objCliente

                    Session("Tipo") = "Cliente"


                    Response.Redirect("FormClientePrincipalF.aspx")
                End If



            Else
                Session("Usuario") = objEmpleado

                Session("Tipo") = "Empleado"

                If (objEmpleado.Tipo.Contains("Administrador")) Then

                    Response.Redirect("FormAdminPrncipal.aspx")

                ElseIf (objEmpleado.Tipo.Contains("Compras")) Then

                    Response.Redirect("FormCompras.aspx")

                ElseIf (objEmpleado.Tipo.Contains("Ventas")) Then

                    Response.Redirect("FormEmpVentPrincipal.aspx")

                ElseIf (objEmpleado.Tipo.Contains("Armado")) Then

                    Response.Redirect("FormArmadoPrincipal.aspx")



                End If





            End If


        Catch ex As Exception



        End Try





    End Sub

    





    Public Property ClienteEmail As String Implements IUsuario.ClienteEmail
        Get
            Return Me.objCliente.Email
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property ClienteNumero As Integer Implements IUsuario.ClienteNumero
        Get
            Return Me.objCliente.NumeroCliente
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property EmpleadoLegajo As Integer Implements IUsuario.EmpleadoLegajo
        Get
            Return Me.objEmpleado.Legajo
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property EmpleadoUsuario As String Implements IUsuario.EmpleadoUsuario
        Get
            Return Me.objEmpleado.Usuario
        End Get
        Set(value As String)

        End Set
    End Property
End Class