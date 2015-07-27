Imports Entidades
Public Class ListaDeArmadoDatos
    Public Function TraerListaDeArmadoPorEmpleado(Idemp As Integer) As System.Data.DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdEmpleado", SqlDbType.Int)
        objSqlParameters(0).Value = Idemp

        Try
            Return ClaseDatos.executeDataSet("TrerListaDeArmadoPorEmpleado", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo traer la lista de armado")
        End Try

    End Function

    Public Sub AgregarListaDeArmado(idModelo As Integer, idEmpleado As Integer, cantidad As Integer,
                                 cantidadArmada As Integer, fechaOrden As DateTime)

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(5) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdModelo", SqlDbType.Int)
        objSqlParameters(0).Value = idModelo


        objSqlParameters(1) = New SqlClient.SqlParameter("@IdEmpleado", SqlDbType.Int)
        objSqlParameters(1).Value = idEmpleado


        objSqlParameters(2) = New SqlClient.SqlParameter("@Cantidad", SqlDbType.Int)
        objSqlParameters(2).Value = cantidad

        objSqlParameters(3) = New SqlClient.SqlParameter("@CantidadArmada", SqlDbType.Int)
        objSqlParameters(3).Value = 0

        objSqlParameters(4) = New SqlClient.SqlParameter("@FechaDeOrden", SqlDbType.DateTime)
        objSqlParameters(4).Value = fechaOrden

        objSqlParameters(5) = New SqlClient.SqlParameter("@FechaFinOrden", DBNull.Value)
        objSqlParameters(5).Value = DBNull.Value

        Try
            ClaseDatos.executeNonQuery("AgregarListaDeArmado", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("error al agregar lista de armado")
        End Try

    End Sub

    Public Function TraerListaDeArmado() As System.Data.DataSet

        Try
            Return ClaseDatos.executeDataSet("TraerListaDeArmado")
        Catch ex As Exception
            Throw New Exception("No se pudo traer la lista de armado")
        End Try

    End Function

    Public Sub ActualizarListaDeArmado(idLista As Integer, fechaFin As DateTime, cantidadArmada As Integer)

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdLista", SqlDbType.Int)
        objSqlParameters(0).Value = idLista

       
        objSqlParameters(1) = New SqlClient.SqlParameter("@Fecha", SqlDbType.DateTime)
        objSqlParameters(1).Value = fechaFin


        

        objSqlParameters(2) = New SqlClient.SqlParameter("@CantidadArmada", SqlDbType.Int)
        objSqlParameters(2).Value = cantidadArmada
        Try

            ClaseDatos.executeNonQuery("ActualizarListaDeArmado", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("error al actualizar la lista de armado")
        End Try
    End Sub
    Public Sub ActualizarListaDeArmadoConFaltantes(idLista As Integer, cantidadArmada As Integer)

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdLista", SqlDbType.Int)
        objSqlParameters(0).Value = idLista


        objSqlParameters(1) = New SqlClient.SqlParameter("@Fecha", DBNull.Value)
        objSqlParameters(1).Value = DBNull.Value




        objSqlParameters(2) = New SqlClient.SqlParameter("@CantidadArmada", SqlDbType.Int)
        objSqlParameters(2).Value = cantidadArmada
        Try

            ClaseDatos.executeNonQuery("ActualizarListaDeArmado", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("error al actualizar la lista de armado")
        End Try
    End Sub
End Class



