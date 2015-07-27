Imports Entidades
Imports Negocioo
Public Class FormArmadoPrincipal
    Inherits System.Web.UI.Page
    Dim dtOrdenes As DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            Dim listaNegocio As New ListaDeArmadoNegocio
            Dim dt As DataTable
            dt = listaNegocio.TraerListaDeArmadoPorEmpleado(CType(Session("Usuario"), Empleados).Legajo).Tables(0)
            dtOrdenes = listaNegocio.TraerListaDeArmadoPorEmpleado(CType(Session("Usuario"), Empleados).Legajo).Tables(0)
            If dtOrdenes.Rows.Count > 0 Then
                Me.BtnDetalles.Visible = True
                Me.btnTerminado.Visible = True
                Me.DropDownList1.Visible = True
                Me.Label2.Visible = False
            Else
                Me.BtnDetalles.Visible = False
                Me.btnTerminado.Visible = False
                Me.DropDownList1.Visible = False
                Me.Label2.Visible = True
            End If
            dt.Columns.RemoveAt(0)
            dt.Columns.RemoveAt(0)
            Me.GridView1.DataSource = dt
            Me.GridView1.DataBind()
        End If

       
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        If Me.GridView1.SelectedIndex = -1 Then
            Me.DropDownList1.Items.Clear()
        Else
            Me.GridView1.SelectedRowStyle.BackColor = Drawing.Color.Aquamarine
            Dim listaNegocio As New ListaDeArmadoNegocio
            Me.DropDownList1.Items.Clear()
            dtOrdenes = listaNegocio.TraerListaDeArmadoPorEmpleado(CType(Session("Usuario"), Empleados).Legajo).Tables(0)
            For i As Integer = 1 To CInt(dtOrdenes(Me.GridView1.SelectedIndex)(3))
                Me.DropDownList1.Items.Add(i.ToString)
            Next
        End If
    End Sub

    Protected Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnDetalles.Click
        If Me.GridView1.SelectedIndex = -1 Then
            MsgBox("Seleccione una orden")
        Else

            Dim listaNegocio As New ListaDeArmadoNegocio
            dtOrdenes = listaNegocio.TraerListaDeArmadoPorEmpleado(CType(Session("Usuario"), Empleados).Legajo).Tables(0)
            Session("Seleccion") = dtOrdenes.Rows(Me.GridView1.SelectedIndex)("IdModelo")
            Response.Redirect("FormDetalleVentaReserva.aspx")
        End If
    End Sub

    Protected Sub btnTerminado_Click(sender As Object, e As EventArgs) Handles btnTerminado.Click
        Dim listaNegocio As New ListaDeArmadoNegocio
        Dim objModeloNegocio As New ModeloNegocio
        Dim objPiezaNegocio As New PiezaNegocio
        Dim objModeloPiezaNegocio As New ModeloPiezaNegocio
        Dim dt As New DataTable
        If Me.GridView1.SelectedIndex = -1 Or Me.DropDownList1.SelectedValue = "" Then
            MsgBox("Seleccione una orden")
        Else
            dtOrdenes = listaNegocio.TraerListaDeArmadoPorEmpleado(CType(Session("Usuario"), Empleados).Legajo).Tables(0)

            objModeloNegocio.ActualizarStockModeloArmado(CInt(dtOrdenes(Me.GridView1.SelectedIndex)(1)), CInt(Me.DropDownList1.SelectedValue))
            If (CInt(dtOrdenes(Me.GridView1.SelectedIndex)(3)) - CInt(Me.DropDownList1.SelectedValue)) > 0 Then
                listaNegocio.ActualizarListaDeArmadoConFaltantes(CInt(dtOrdenes(Me.GridView1.SelectedIndex)(0)), CInt(Me.DropDownList1.SelectedValue))
            Else
                listaNegocio.ActualizarListaDeArmado(CInt(dtOrdenes(Me.GridView1.SelectedIndex)(0)), CType(Date.Now, DateTime), CInt(Me.DropDownList1.SelectedValue))
            End If

            dt = objModeloPiezaNegocio.TraerPiezasPorModelo(CInt(dtOrdenes(Me.GridView1.SelectedIndex)(1))).Tables(0)
            For Each a As DataRow In dt.Rows
                objPiezaNegocio.ReducirStockDePieza(CInt(a(0)), CInt(a(4)) * CInt(Me.DropDownList1.SelectedValue))
            Next

            Me.DropDownList1.ClearSelection()
            Me.DropDownList1.Items.Clear()
            Me.GridView1.SelectedRowStyle.BackColor = Drawing.Color.White
            Me.DropDownList1.SelectedIndex = -1


            dtOrdenes = listaNegocio.TraerListaDeArmadoPorEmpleado(CType(Session("Usuario"), Empleados).Legajo).Tables(0)
            Me.GridView1.DataSource = dtOrdenes
            Me.GridView1.DataBind()
            If dtOrdenes.Rows.Count > 0 Then
                Me.BtnDetalles.Visible = True
                Me.btnTerminado.Visible = True
                Me.DropDownList1.Visible = True
                Me.Label2.Visible = False
            Else
                Me.BtnDetalles.Visible = False
                Me.btnTerminado.Visible = False
                Me.DropDownList1.Visible = False
                Me.Label2.Visible = True
            End If
        End If
    End Sub

    Protected Sub btnFaltantes_Click(sender As Object, e As EventArgs) Handles btnFaltantes.Click
        If Me.GridView1.SelectedIndex = -1 Then
            MsgBox("Seleccione una orden")
        Else
            CType(Session("Faltantes2"), DataTable).Rows.Clear()
            Dim listaNegocio As New ListaDeArmadoNegocio
            Dim dt As DataTable
            Dim dtPiezas As DataTable
            Dim objModeloPiezasNegocio As New ModeloPiezaNegocio
            dt = listaNegocio.TraerListaDeArmadoPorEmpleado(CType(Session("Usuario"), Empleados).Legajo).Tables(0)
            dtPiezas = objModeloPiezasNegocio.TraerPiezasPorModelo(CInt(dt(Me.GridView1.SelectedIndex)(1))).Tables(0)
            For Each f As DataRow In dtPiezas.Rows
                Dim fila As DataRow = CType(Session("Faltantes2"), DataTable).NewRow
                fila(0) = f(0)
                fila(1) = f(1)
                fila(2) = CInt(f(4)) * CInt(dt(Me.GridView1.SelectedIndex)(3))
                CType(Session("Faltantes2"), DataTable).Rows.Add(fila)

            Next
            dtOrdenes = listaNegocio.TraerListaDeArmadoPorEmpleado(CType(Session("Usuario"), Empleados).Legajo).Tables(0)
            Session("Mod") = CInt(dt(Me.GridView1.SelectedIndex)(1))
            Session("IdLista") = CInt(dtOrdenes(Me.GridView1.SelectedIndex)(0))
            Response.Redirect("FormArmadoFaltantes.aspx")
        End If
    End Sub
End Class