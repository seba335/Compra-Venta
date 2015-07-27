Imports Entidades
Public Class Logueo
    Inherits System.Web.UI.MasterPage



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (CType(Session("Tipo"), String) = Nothing) Then
            Me.hlLoguearse.Text = "Loguearse"
            Me.hlLoguearse.NavigateUrl = "~/FormLogueo.aspx"
            Me.btnRegistrarse.Text = "Registrarse"
            Me.btnRegistrarse.PostBackUrl = "~/FormClienteReg.aspx"
            Me.btnCarrito.Visible = False
        Else
            If (CType(Session("Tipo"), String) = "Cliente") Then
                Me.hlLoguearse.Text = CType(Session("Usuario"), CLientes).Email.ToString
                Me.hlLoguearse.NavigateUrl = "~/FormClienteMod.aspx"
                Me.btnRegistrarse.Text = "Salir"

                Me.btnCarrito.Visible = True
            ElseIf (CType(Session("Tipo"), String) = "Empleado") Then


                Me.hlLoguearse.Text = CType(Session("Usuario"), Empleados).Nombre & " " & CType(Session("Usuario"), Empleados).Apellido
                Me.hlLoguearse.NavigateUrl = "~/FormClientePrincipalF.aspx"
                Me.btnRegistrarse.Text = "Salir"

                If CType(Session("Usuario"), Empleados).Tipo = "Ventas" Then
                    Me.hlLoguearse.NavigateUrl = "~/FormEmpVentPrincipal.aspx"
                ElseIf CType(Session("Usuario"), Empleados).Tipo = "Compras" Then
                    Me.btnCarrito.Visible = True
                End If

            End If


        End If
        

       
        
    End Sub
    
  






    
    
    
   
    
    
    Protected Sub btnRegistrarse_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        
        If (CType(Session("Tipo"), String) = "Nothing") Then
            Response.Redirect("FormClienteReg.aspx")
        ElseIf (CType(Session("Tipo"), String) = "Cliente") Then
            Session.Abandon()
            Response.Redirect("FormClientePrincipalF.aspx")
        ElseIf (CType(Session("Tipo"), String) = "Empleado") Then
            Session.Abandon()
            Response.Redirect("FormClientePrincipalF.aspx")
        End If



    End Sub

    
    Protected Sub btnCarrito_Click(sender As Object, e As EventArgs) Handles btnCarrito.Click
        If (CType(Session("Tipo"), String) = "Cliente") Then
            Response.Redirect("FormListadeCompras.aspx")
        ElseIf (CType(Session("Tipo"), String) = "Empleado") Then
            If (CType(Session("Usuario"), Empleados).Tipo = "Compras") Then
                Response.Redirect("FormDetalleCompraProv.aspx")
            Else
                Response.Redirect("FormListadeCompras.aspx")
            End If

        End If
    End Sub
End Class