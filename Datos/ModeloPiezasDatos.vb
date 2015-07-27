
Public Class ModeloPiezasDatos
    Public Sub AgregarModeloPiezas(IdModelo As Integer, IdPieza As Integer, CantidadPieza As Integer)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(2) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdModelo", SqlDbType.Int)
        objSqlParameters(0).Value = IdModelo


        objSqlParameters(1) = New SqlClient.SqlParameter("@IdPieza", SqlDbType.Int)
        objSqlParameters(1).Value = IdPieza


        objSqlParameters(2) = New SqlClient.SqlParameter("@Cantidad", SqlDbType.Int)
        objSqlParameters(2).Value = CantidadPieza

        ClaseDatos.executeNonQuery("AgregarModeloPiezas", objSqlParameters)



    End Sub

    Public Function TraerPiezasPorModelo(IdModelo As Integer) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdModelo", SqlDbType.Int)
        objSqlParameters(0).Value = IdModelo

        Try
            Return ClaseDatos.executeDataSet("TraerPiezasPorModelo", objSqlParameters)

        Catch ex As Exception
            Throw New Exception("Error")
        End Try




    End Function


      
End Class
