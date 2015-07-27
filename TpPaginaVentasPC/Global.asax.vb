Imports Entidades
Imports System.Web.SessionState

Public Class Global_asax
    Inherits System.Web.HttpApplication
    Dim modelo As New Modelos

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al iniciar la aplicación
       
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)

        ' Se desencadena al iniciar la sesión
        Session("Usuario") = "Nothing"
        Session("Tipo") = "Nothing"
        Session("CompraProv") = "Nothing"
        Dim dt As New DataTable
        dt.Columns.Add("Id")
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Tipo")
        dt.Columns.Add("Costo")
        dt.Columns.Add("Cantidad")
        Session("CompraAUnProveedor") = dt
        Session("Iniciada") = False
        Session("Carrito") = modelo.CrearTabla()
        Session("Seleccion") = "Nothing"
        Session("Compras") = "Nothing"
        Session("CompraSeleccionada") = "Nothing"
        Dim dtFaltantes As New DataTable
        dtFaltantes.Columns.Add("Id")
        dtFaltantes.Columns.Add("Descripcion")
        dtFaltantes.Columns.Add("Cantidad Faltante")
        Session("Faltantes") = dtFaltantes
        Dim dtEnvio As New DataTable
        dtEnvio.Columns.Add("Localidad")
        dtEnvio.Columns.Add("Calle")
        dtEnvio.Columns.Add("Numero")
        dtEnvio.Columns.Add("Departamento")
        dtEnvio.Columns.Add("Piso")
        dtEnvio.Columns.Add("Telefono")
        Session("Envio") = dtEnvio
        Session("EmpleadoVentaCliente") = Nothing
        Session("VentaSeleccionada") = "Nothing"
        Session("Reserva") = "Nothing"
        Session("Vengode") = "Nothing"
        Session("ReservaSelec") = "Nothing"
        Session("PagoPor") = "Nothing"
        Session("EmpleadoSeleccionado") = "Nothing"
        Dim dtArmadoFaltante As New DataTable
        dtArmadoFaltante.Columns.Add("Codigo de pieza")
        dtArmadoFaltante.Columns.Add("Descripcion")
        dtArmadoFaltante.Columns.Add("Cantidad Faltante")
        Session("FaltantesAComprar") = dtArmadoFaltante
        Dim dtArmadoFaltante2 As New DataTable
        dtArmadoFaltante2.Columns.Add("Codigo de pieza")
        dtArmadoFaltante2.Columns.Add("Descripcion")
        dtArmadoFaltante2.Columns.Add("Cantidad Faltante")
        Session("Faltantes2") = dtArmadoFaltante2
        Session("Mod") = "Nothing"
        Session("IdLista") = "Nothing"
       
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al comienzo de cada solicitud
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena al intentar autenticar el uso
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando se produce un error
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la sesión
        Session("Usuario") = "Nothing"
        Session("Tipo") = "Nothing"
        Session("CompraProv") = "Nothing"
        Dim dt As New DataTable
        dt.Columns.Add("Id")
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Tipo")
        dt.Columns.Add("Costo")
        dt.Columns.Add("Cantidad")
        Session("CompraAUnProveedor") = dt
        Session("Iniciada") = False
        Session("Carrito") = modelo.CrearTabla()
        Session("Seleccion") = "Nothing"
        Session("Compras") = "Nothing"
        Session("CompraSeleccionada") = "Nothing"
        Dim dtFaltantes As New DataTable
        dtFaltantes.Columns.Add("Id")
        dtFaltantes.Columns.Add("Descripcion")
        dtFaltantes.Columns.Add("Cantidad Faltante")
        Session("Faltantes") = dtFaltantes
        Dim dtEnvio As New DataTable
        dtEnvio.Columns.Add("Localidad")
        dtEnvio.Columns.Add("Calle")
        dtEnvio.Columns.Add("Numero")
        dtEnvio.Columns.Add("Departamento")
        dtEnvio.Columns.Add("Piso")
        dtEnvio.Columns.Add("Telefono")
        Session("Envio") = dtEnvio
        Session("EmpleadoVentaCliente") = Nothing
        Session("VentaSeleccionada") = "Nothing"
        Session("Reserva") = "Nothing"
        Session("Vengode") = "Nothing"
        Session("ReservaSelec") = "Nothing"
        Session("PagoPor") = "Nothing"
        Session("EmpleadoSeleccionado") = "Nothing"
        Dim dtArmadoFaltante As New DataTable
        dtArmadoFaltante.Columns.Add("Codigo de pieza")
        dtArmadoFaltante.Columns.Add("Descripcion")
        dtArmadoFaltante.Columns.Add("Cantidad Faltante")
        Session("FaltantesAComprar") = dtArmadoFaltante
        Dim dtArmadoFaltante2 As New DataTable
        dtArmadoFaltante2.Columns.Add("Codigo de pieza")
        dtArmadoFaltante2.Columns.Add("Descripcion")
        dtArmadoFaltante2.Columns.Add("Cantidad Faltante")
        Session("Faltantes2") = dtArmadoFaltante2
        Session("Mod") = "Nothing"
        Session("IdLista") = "Nothing"
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Se desencadena cuando finaliza la aplicación
    End Sub

End Class