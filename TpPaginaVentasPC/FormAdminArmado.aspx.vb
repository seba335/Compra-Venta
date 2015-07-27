Imports Datos
Imports Entidades
Imports Negocioo
Public Class FormAdminArmado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim objDato As New CalculoDeArmado
        Dim dt As DataTable
        Dim modelo As Modelos
        Dim objModelo As New ModeloNegocio
        Dim dtArmar As New DataTable
        Dim cantidad As Integer = 0
        Dim objEmpleadoNegocio As New EmpleadoNegocio
        Dim dtEmp As DataTable
        dtArmar.Columns.Add("Id")
        dtArmar.Columns.Add("Cantidad")
        dt = objModelo.TraerTodosLosModelos
        For Each f As DataRow In dt.Rows
            modelo = objModelo.TraerModelo(CType(f("Id"), Integer))
            If ((modelo.StockCapacidad - modelo.Minimo) < 0) Then
                Dim fila As DataRow = dtArmar.NewRow
                fila("Id") = modelo.Id
                fila("Cantidad") = (modelo.Maximo - modelo.StockCapacidad)
                cantidad = cantidad + (modelo.Maximo - modelo.StockCapacidad)
                dtArmar.Rows.Add(fila)
            End If

        Next
        Me.lblCantidaddePcs.Text = cantidad.ToString

        dtEmp = objEmpleadoNegocio.TraerEmpleadosDeArmado()
        Me.lblCantidaddeEmpleados.Text = dtEmp.Rows.Count.ToString




        Dim objModeloPiezasNegocio As New ModeloPiezaNegocio

        Dim dtPiezas As New DataTable
        Dim dtPiezasEnStock As DataTable
        Dim objPiezaNegocio As New PiezaNegocio
        Dim dtSePuedeArmar As New DataTable
        dtSePuedeArmar.Columns.Add("Id")
        dtSePuedeArmar.Columns.Add("CantidadPosibleaArmar")

        dt = objModelo.TraerTodosLosModelos

        'For Each f As DataRow In dt.Rows
        '    modelo = objModelo.TraerModelo(CType(f("Id"), Integer))
        '    If ((modelo.StockCapacidad - modelo.Minimo) < 0) Then
        '        Dim fila As DataRow = dtArmar.NewRow
        '        fila("Id") = modelo.Id
        '        fila("Cantidad") = (modelo.Maximo - modelo.StockCapacidad)
        '        cantidad = cantidad + 1
        '        dtArmar.Rows.Add(fila)
        '    End If

        'Next
        dtPiezasEnStock = objPiezaNegocio.TraerPiezas()




        For Each f As DataRow In dtArmar.Rows
            Dim filaArmar As DataRow = dtSePuedeArmar.NewRow
            filaArmar(0) = f(0)
            filaArmar(1) = 0
            For i As Integer = 1 To CInt(f(1))
                Dim alcanza As Boolean = True

                For Each p As DataRow In objModeloPiezasNegocio.TraerPiezasPorModelo(CInt(f(0))).Tables(0).Rows

                    Dim PiezasRequeridas As Integer
                    PiezasRequeridas = CInt(p(4))
                    For Each ps As DataRow In dtPiezasEnStock.Rows
                        If CInt(ps(0)) = CInt(p(0)) Then


                            If CInt(ps(1)) - PiezasRequeridas >= 0 Then
                            Else
                                alcanza = False
                            End If
                        End If

                    Next

                Next
                If alcanza = True Then
                    filaArmar(1) = CInt(filaArmar(1)) + 1

                    For Each p As DataRow In objModeloPiezasNegocio.TraerPiezasPorModelo(CInt(f(0))).Tables(0).Rows
                        Dim fila As DataRow = dtPiezas.NewRow
                        Dim PiezasRequeridas As Integer
                        PiezasRequeridas = CInt(p(4))
                        For Each ps As DataRow In dtPiezasEnStock.Rows
                            If CInt(ps(0)) = CInt(p(0)) Then


                                ps(1) = CInt(ps(1)) - PiezasRequeridas

                            End If

                        Next

                    Next
                End If
            Next
            dtSePuedeArmar.Rows.Add(filaArmar)
        Next
        Dim l As New List(Of DataRow)
        Dim objListadeArmadoNegocio As New ListaDeArmadoNegocio
        For Each f As DataRow In objListadeArmadoNegocio.TraerListaDeArmado().Rows
            For Each a As DataRow In dtSePuedeArmar.Rows
                If CInt(a(0)) = CInt(f(0)) Then
                    a(1) = CInt(a(1)) - (CInt(f(1)) - CInt(f(2)))

                End If
            Next
        Next
        For Each a As DataRow In dtSePuedeArmar.Rows
            If CInt(a(1)) <= 0 Then
                l.Add(a)


            End If

        Next
        For Each a As DataRow In l
            dtSePuedeArmar.Rows.Remove(a)
        Next
        Dim cantidadSePuedeArmar As Integer = 0
        For Each f As DataRow In dtSePuedeArmar.Rows
            cantidadSePuedeArmar = cantidadSePuedeArmar + CInt(f(1))
        Next
        Me.lblCantidadPosible.Text = cantidadSePuedeArmar.ToString

    End Sub

    Protected Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim cantidadAdmin As Integer
        cantidadAdmin = CInt(Me.ddlCantidaddePcs.SelectedValue)
        'Dim objDato As New CalculoDeArmado

        Dim dt As DataTable
        Dim modelo As Modelos
        Dim objModelo As New ModeloNegocio
        Dim dtArmar As New DataTable
        Dim cantidad As Integer = 0
        Dim objEmpleadoNegocio As New EmpleadoNegocio
        Dim objModeloPiezasNegocio As New ModeloPiezaNegocio
        Dim dtEmp As DataTable
        Dim dtPiezas As New DataTable
        Dim dtPiezasEnStock As DataTable
        Dim objPiezaNegocio As New PiezaNegocio
        Dim dtSePuedeArmar As New DataTable
        dtSePuedeArmar.Columns.Add("Id")
        dtSePuedeArmar.Columns.Add("CantidadPosibleaArmar")
        dtArmar.Columns.Add("Id")
        dtArmar.Columns.Add("Cantidad")
        dt = objModelo.TraerTodosLosModelos()
        For Each f As DataRow In dt.Rows
            modelo = objModelo.TraerModelo(CType(f("Id"), Integer))
            If ((modelo.StockCapacidad - modelo.Minimo) < 0) Then
                Dim fila As DataRow = dtArmar.NewRow
                fila("Id") = modelo.Id
                fila("Cantidad") = (modelo.Maximo - modelo.StockCapacidad)
                cantidad = cantidad + 1
                dtArmar.Rows.Add(fila)
            End If

        Next
        dtPiezasEnStock = objPiezaNegocio.TraerPiezas()



        For Each f As DataRow In dtArmar.Rows
            Dim filaArmar As DataRow = dtSePuedeArmar.NewRow
            filaArmar(0) = f(0)
            filaArmar(1) = 0
            For i As Integer = 1 To CInt(f(1))
                Dim alcanza As Boolean = True

                For Each p As DataRow In objModeloPiezasNegocio.TraerPiezasPorModelo(CInt(f(0))).Tables(0).Rows

                    Dim PiezasRequeridas As Integer
                    PiezasRequeridas = CInt(p(4))
                    For Each ps As DataRow In dtPiezasEnStock.Rows
                        If CInt(ps(0)) = CInt(p(0)) Then


                            If CInt(ps(1)) - PiezasRequeridas >= 0 Then
                            Else
                                alcanza = False
                            End If
                        End If

                    Next

                Next
                If alcanza = True Then
                    filaArmar(1) = CInt(filaArmar(1)) + 1

                    For Each p As DataRow In objModeloPiezasNegocio.TraerPiezasPorModelo(CInt(f(0))).Tables(0).Rows
                        Dim fila As DataRow = dtPiezas.NewRow
                        Dim PiezasRequeridas As Integer
                        PiezasRequeridas = CInt(p(4))
                        For Each ps As DataRow In dtPiezasEnStock.Rows
                            If CInt(ps(0)) = CInt(p(0)) Then


                                ps(1) = CInt(ps(1)) - PiezasRequeridas

                            End If

                        Next

                    Next
                End If
            Next
            dtSePuedeArmar.Rows.Add(filaArmar)
        Next


        Dim l As New List(Of DataRow)
        Dim objListadeArmadoNegocio As New ListaDeArmadoNegocio
        For Each f As DataRow In objListadeArmadoNegocio.TraerListaDeArmado().Rows
            For Each a As DataRow In dtSePuedeArmar.Rows
                If CInt(a(0)) = CInt(f(0)) Then
                    a(1) = CInt(a(1)) - (CInt(f(1)) - CInt(f(2)))
                    

                End If
            Next
        Next

        For Each a As DataRow In dtSePuedeArmar.Rows
            If CInt(a(1)) < 1 Then
                l.Add(a)


            End If

        Next
        For Each a As DataRow In l
            dtSePuedeArmar.Rows.Remove(a)
        Next
        dtEmp = objEmpleadoNegocio.TraerEmpleadosDeArmado()
        For i As Integer = 0 To dtEmp.Rows.Count - 1
            Dim dtArmarEmp As New DataTable
            dtArmarEmp.Columns.Add("Id")
            dtArmarEmp.Columns.Add("CantidadaArmar")
            Dim lista As New List(Of DataRow)
            Dim contador As Integer = 0
            Dim lista2 As New List(Of DataRow)
            For Each a As DataRow In dtSePuedeArmar.Rows
                Dim fil As DataRow = dtArmarEmp.NewRow
                If contador < CInt(Me.ddlCantidaddePcs.SelectedValue) Then
                    If CInt(a(1)) > 0 Then
                        If CInt(a(1)) > (CInt(Me.ddlCantidaddePcs.SelectedValue) - contador) Then
                            fil(0) = a(0)
                            fil(1) = CInt(Me.ddlCantidaddePcs.SelectedValue) - contador
                            a(1) = CInt(a(1)) - (CInt(Me.ddlCantidaddePcs.SelectedValue) - contador)
                            lista.Add(fil)
                            contador = contador + CInt(Me.ddlCantidaddePcs.SelectedValue) - contador
                        Else
                            fil(0) = a(0)
                            fil(1) = CInt(a(1))
                            contador = contador + CInt(a(1))
                            a(1) = CInt(a(1)) - CInt(a(1))
                            lista.Add(fil)

                            lista2.Add(a)
                        End If
                    End If
                End If

            Next
            For Each a As DataRow In lista
                dtArmarEmp.Rows.Add(a)
            Next
            For Each a As DataRow In lista2
                dtSePuedeArmar.Rows.Remove(a)
            Next
            For Each a As DataRow In dtArmarEmp.Rows
                objListadeArmadoNegocio.AgregarListaDeArmado(CInt(a(0)), CInt(dtEmp(i)(0)), CInt(a(1)), 0, CType(Date.Now, DateTime))
            Next

        Next
        Response.Redirect("FormAdminPrncipal.aspx")
    End Sub


End Class