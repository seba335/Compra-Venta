Imports Entidades
Imports Datos
Public Class ListaDeArmadoNegocio
    Public Function TraerListaDeArmadoPorEmpleado(ByVal IdEmp As Integer) As DataSet
        Dim objLista As New ListaDeArmadoDatos
        Dim a As DataSet
        Try
            a = objLista.TraerListaDeArmadoPorEmpleado(IdEmp)

        Catch ex As Exception
            Throw ex
        End Try
        Return a
    End Function

    Public Sub AgregarListaDeArmado(idModelo As Integer, idEmpleado As Integer, cantidad As Integer,
                                 cantidadArmada As Integer, fechaOrden As DateTime)

        Dim objListaDeArmadoDatos As New ListaDeArmadoDatos
        Try
            objListaDeArmadoDatos.AgregarListaDeArmado(idModelo, idEmpleado, cantidad,
                                                       cantidadArmada, fechaOrden)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Function TraerListaDeArmado() As DataTable
        Dim objListaDeArmadoDatos As New ListaDeArmadoDatos
        Try
            Return objListaDeArmadoDatos.TraerListaDeArmado().Tables(0)
        Catch ex As Exception
            Throw New Exception("No se pudo traer la lista de armado")
        End Try
        Return objListaDeArmadoDatos.TraerListaDeArmado().Tables(0)
    End Function

    Public Sub ActualizarListaDeArmado(idLista As Integer, fechaFin As DateTime, cantidadArmada As Integer)
        Dim objListaDeArmadoDatos As New ListaDeArmadoDatos
        Try
            objListaDeArmadoDatos.ActualizarListaDeArmado(idLista, fechaFin, cantidadArmada)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub

    Public Sub ActualizarListaDeArmadoConFaltantes(idLista As Integer, cantidadArmada As Integer)
        Dim objListaDeArmadoDatos As New ListaDeArmadoDatos
        Try
            objListaDeArmadoDatos.ActualizarListaDeArmadoConFaltantes(idLista, cantidadArmada)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Sub
End Class
