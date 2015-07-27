Imports Datos
Imports Negocioo
Imports Entidades
Public Class FormListadeComprasaProv
    Inherits System.Web.UI.Page
    Dim dtMostrar As New DataTable
    Dim dtMostrar2 As New DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
     

        If CType(Session("Iniciada"), Boolean) = False Then


            Dim dt As DataTable
            Dim modelo As Modelos
            Dim objDato As New CalculoDeArmado
            Dim objModelo As New ModeloNegocio
            Dim objPiezaNegocio As New PiezaNegocio
            Dim dtPiezasDisponibles As DataTable
            Dim objCompraPiezasNegocio As New CompraPiezaNegocio
            Dim dtPiezasPedidas As DataTable
            Dim listaux As New List(Of DataRow)
            dtMostrar.Columns.Add("Id")

            dtMostrar.Columns.Add("Nombre")
            dtMostrar.Columns.Add("Tipo")
            dtMostrar.Columns.Add("Costo")
            dtMostrar.Columns.Add("Cantidad")


            dtMostrar2.Columns.Add("Nombre")
            dtMostrar2.Columns.Add("Tipo")
            dtMostrar2.Columns.Add("Costo")
            dtMostrar2.Columns.Add("Cantidad")

            dt = objDato.TraerModelosActivos().Tables(0)
            For Each f As DataRow In dt.Rows




                modelo = objModelo.TraerModelo(CType(f("Id"), Integer))
                If ((modelo.StockCapacidad - modelo.Minimo) < 0) Then

                    Dim objModeloPieza As New ModeloPiezaNegocio
                    Dim dtPiezas As DataTable
                    dtPiezas = objModeloPieza.TraerPiezasPorModelo(CType(f("Id"), Integer)).Tables(0)

                    For Each fpieza As DataRow In dtPiezas.Rows
                        Dim fila As DataRow = dtMostrar.NewRow()
                        Dim repetida As Boolean = False
                        For Each Fmostrar As DataRow In dtMostrar.Rows
                            If (CType(fpieza(0), Integer) = CType(Fmostrar("Id"), Integer)) Then
                                repetida = True
                                Fmostrar("Cantidad") = CType(Fmostrar("Cantidad"), Integer) + (CType(fpieza(4), Integer) * (modelo.Maximo - modelo.StockCapacidad))
                            End If

                        Next
                        If repetida = False Then
                            fila("Id") = fpieza(0)
                            fila("Nombre") = fpieza(1)
                            fila("Tipo") = fpieza(2)
                            fila("Costo") = fpieza(3)
                            fila("Cantidad") = CType(fpieza(4), Integer) * (modelo.Maximo - modelo.StockCapacidad)
                            dtMostrar.Rows.Add(fila)
                        End If

                    Next



                End If
            Next


            dtPiezasDisponibles = objPiezaNegocio.TraerPiezas()

            For Each m As DataRow In dtMostrar.Rows
                For Each p As DataRow In dtPiezasDisponibles.Rows
                    If CType(m("Id"), Integer) = CType(p("Id"), Integer) Then
                        m("Cantidad") = CType(m("Cantidad"), Integer) - CType(p("Stock"), Integer)

                    End If

                Next
            Next

            dtPiezasPedidas = objCompraPiezasNegocio.TraerCompraPiezas()
            For Each m As DataRow In dtMostrar.Rows
                For Each p As DataRow In dtPiezasPedidas.Rows
                    If CType(m("Id"), Integer) = CType(p("IdPieza"), Integer) Then
                        m("Cantidad") = CType(m("Cantidad"), Integer) - CType(p("CantidadPiezas"), Integer)

                    End If

                Next
            Next


            For Each m As DataRow In dtMostrar.Rows
                If CType(m("Cantidad"), Integer) <= 0 Then
                    listaux.Add(m)
                End If
            Next
            For Each dr As DataRow In listaux

                dtMostrar.Rows.Remove(dr)

            Next
            Session("CompraProv") = dtMostrar
            For Each f As DataRow In dtMostrar.Rows()
                Dim fila As DataRow = dtMostrar2.NewRow
                Dim nombre As String
                Dim tipo As String
                Dim costo As Double
                Dim cantidad As Integer
                nombre = CType(f("Nombre"), String)
                fila("Nombre") = nombre
                tipo = CType(f("Nombre"), String)
                fila("Tipo") = tipo
                costo = CType(f("Costo"), Double)
                fila("Costo") = costo
                cantidad = CType(f("Cantidad"), Integer)
                fila("Cantidad") = cantidad
                dtMostrar2.Rows.Add(fila)
            Next

            Session("Iniciada") = True
            Me.GridView1.DataSource = dtMostrar2

            Me.GridView1.DataBind()

       

        Else
            dtMostrar2.Columns.Add("Nombre")
            dtMostrar2.Columns.Add("Tipo")
            dtMostrar2.Columns.Add("Costo")
            dtMostrar2.Columns.Add("Cantidad")
            For Each f2 As DataRow In CType(Session("CompraProv"), DataTable).Rows
                Dim fila2 As DataRow = dtMostrar2.NewRow
                Dim nombre As String
                Dim tipo As String
                Dim costo As Double
                Dim cantidad As Integer
                nombre = CType(f2("Nombre"), String)
                fila2("Nombre") = nombre
                tipo = CType(f2("Nombre"), String)
                fila2("Tipo") = tipo
                costo = CType(f2("Costo"), Double)
                fila2("Costo") = costo
                cantidad = CType(f2("Cantidad"), Integer)
                fila2("Cantidad") = cantidad
                dtMostrar2.Rows.Add(fila2)
            Next


            Me.GridView1.DataSource = dtMostrar2

            Me.GridView1.DataBind()
        End If

    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Dim cantidad As Integer
        cantidad = CType(CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)("Cantidad"), Integer)
        Me.ddlCantidad.Items.Clear()
        For i As Integer = 1 To cantidad
            Me.ddlCantidad.Items.Add(i.ToString())
        Next

    End Sub

    
    Protected Sub btnAgregarALaCompra_Click(sender As Object, e As EventArgs) Handles btnAgregarALaCompra.Click
        If (Not (CType(Session("CompraAUnProveedor"), DataTable).Rows.Count > 0)) Then
            Dim fila As DataRow = CType(Session("CompraAUnProveedor"), DataTable).NewRow
            fila(0) = CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)("Id")
            fila(1) = CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)("Nombre")
            fila(2) = CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)("Tipo")
            fila(3) = CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)("Costo")
            fila(4) = Me.ddlCantidad.SelectedValue
            CType(Session("CompraAUnProveedor"), DataTable).Rows.Add(fila)
            CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)(4) = CType(CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)(4), Integer) - CType(Me.ddlCantidad.SelectedValue, Integer)

            dtMostrar2.Rows.Clear()
            For Each f2 As DataRow In CType(Session("CompraProv"), DataTable).Rows
                Dim fila2 As DataRow = dtMostrar2.NewRow
                Dim nombre As String
                Dim tipo As String
                Dim costo As Double
                Dim cantidad As Integer
                nombre = CType(f2("Nombre"), String)
                fila2("Nombre") = nombre
                tipo = CType(f2("Nombre"), String)
                fila2("Tipo") = tipo
                costo = CType(f2("Costo"), Double)
                fila2("Costo") = costo
                cantidad = CType(f2("Cantidad"), Integer)
                fila2("Cantidad") = cantidad
                dtMostrar2.Rows.Add(fila2)
            Next


            
        Else
            Dim duplicado As Boolean = False
            For Each f As DataRow In CType(Session("CompraAUnProveedor"), DataTable).Rows

                If CType(f(0), Integer) = CType(CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)("Id"), Integer) Then
                    CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)(4) = CType(CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)(4), Integer) + CType(f(4), Integer) - CType(Me.ddlCantidad.SelectedValue, Integer)
                    f(4) = Me.ddlCantidad.SelectedValue
                    dtMostrar2.Rows.Clear()
                    For Each f2 As DataRow In CType(Session("CompraProv"), DataTable).Rows
                        Dim fila As DataRow = dtMostrar2.NewRow
                        Dim nombre As String
                        Dim tipo As String
                        Dim costo As Double
                        Dim cantidad As Integer
                        nombre = CType(f2("Nombre"), String)
                        fila("Nombre") = nombre
                        tipo = CType(f2("Nombre"), String)
                        fila("Tipo") = tipo
                        costo = CType(f2("Costo"), Double)
                        fila("Costo") = costo
                        cantidad = CType(f2("Cantidad"), Integer)
                        fila("Cantidad") = cantidad
                        dtMostrar2.Rows.Add(fila)
                    Next



                    duplicado = True
                End If

            Next
            If duplicado = False Then
                Dim fila As DataRow = CType(Session("CompraAUnProveedor"), DataTable).NewRow
                fila(0) = CType(CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)("Id"), Integer)
                fila(1) = CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)("Nombre")
                fila(2) = CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)("Tipo")
                fila(3) = CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)("Costo")
                fila(4) = Me.ddlCantidad.SelectedValue
                CType(Session("CompraAUnProveedor"), DataTable).Rows.Add(fila)
                CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)(4) = CType(CType(Session("CompraProv"), DataTable)(Me.GridView1.SelectedIndex)(4), Integer) - CType(Me.ddlCantidad.SelectedValue, Integer)
                dtMostrar2.Rows.Clear()
                For Each f2 As DataRow In CType(Session("CompraProv"), DataTable).Rows
                    Dim fila2 As DataRow = dtMostrar2.NewRow
                    Dim nombre As String
                    Dim tipo As String
                    Dim costo As Double
                    Dim cantidad As Integer
                    nombre = CType(f2("Nombre"), String)
                    fila2("Nombre") = nombre
                    tipo = CType(f2("Nombre"), String)
                    fila2("Tipo") = tipo
                    costo = CType(f2("Costo"), Double)
                    fila2("Costo") = costo
                    cantidad = CType(f2("Cantidad"), Integer)
                    fila2("Cantidad") = cantidad
                    dtMostrar2.Rows.Add(fila2)
                Next



            End If

        End If

        Me.GridView1.DataSource = dtMostrar2

        Me.GridView1.DataBind()
    End Sub

    Protected Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

    End Sub
End Class