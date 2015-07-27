Imports Entidades

Public Class PiezaDatos
    Public Sub AgregarPieza(ByVal pieza As Piezas)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(3) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Descripcion", SqlDbType.VarChar, 30)
        objSqlParameters(0).Value = pieza.Descripcion


        objSqlParameters(1) = New SqlClient.SqlParameter("@Costo", SqlDbType.Float)
        objSqlParameters(1).Value = pieza.Costo


        objSqlParameters(2) = New SqlClient.SqlParameter("@Stock", SqlDbType.Int)
        objSqlParameters(2).Value = pieza.StockPieza

        objSqlParameters(3) = New SqlClient.SqlParameter("@Tipo", SqlDbType.VarChar, 30)
        objSqlParameters(3).Value = pieza.TipoPieza




        Try
            ClaseDatos.executeNonQuery("AgregarPieza", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo agregar la pieza")
        End Try

    End Sub
    Public Sub ActualizarCosto(ByVal pieza As Piezas)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Id", SqlDbType.Int)
        objSqlParameters(0).Value = pieza.IdPieza

        objSqlParameters(1) = New SqlClient.SqlParameter("@Costo", SqlDbType.Float)
        objSqlParameters(1).Value = pieza.Costo

        Try
            ClaseDatos.executeNonQuery("ActualizarCosto", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("No se pudo agregar la pieza")
        End Try

    End Sub
    Public Function TraerPiezas() As DataSet
        Try
            Return ClaseDatos.executeDataSet("TraerPiezas")
        Catch ex As Exception
            Throw New Exception("No se pudo traer piezas")
        End Try

    End Function

    Public Sub ActualizarStockPorPieza(idPieza As Integer, stockComprado As Integer)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdPieza", SqlDbType.Int)
        objSqlParameters(0).Value = idPieza

        objSqlParameters(1) = New SqlClient.SqlParameter("@StockComprado", SqlDbType.Int)
        objSqlParameters(1).Value = stockComprado

        Try
            ClaseDatos.executeNonQuery("ActualizarStockPorPieza", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("Error al actualizar estado de la pieza")
        End Try
    End Sub

    Public Sub ReducirStockDePieza(idPieza As Integer, cantidadPieza As Integer)

        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdPieza", SqlDbType.Int)
        objSqlParameters(0).Value = idPieza

        objSqlParameters(1) = New SqlClient.SqlParameter("@CantidadPieza", SqlDbType.Int)
        objSqlParameters(1).Value = cantidadPieza

        Try
            ClaseDatos.executeNonQuery("ReducirStockDePieza", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("error al reducir stock de pieza")
        End Try

    End Sub
End Class
