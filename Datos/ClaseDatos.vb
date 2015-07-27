Public Class ClaseDatos
    Private Shared objConexion As SqlClient.SqlConnection
    Private Shared objAdapter As SqlClient.SqlDataAdapter
    Private Shared objCommand As SqlClient.SqlCommand
    Private Shared lstrConexion As String = My.Settings.lstrConexion

    Public Shared Function executeDataSet(ByVal nombreSP As String) As System.Data.DataSet
        Dim ds As New DataSet
        objConexion = New SqlClient.SqlConnection(lstrConexion)
        objCommand = New SqlClient.SqlCommand()
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandText = nombreSP
        objCommand.Connection = objConexion
        objAdapter = New SqlClient.SqlDataAdapter
        objAdapter.SelectCommand = objCommand
        Try '
            objConexion.Open()
            objAdapter.Fill(ds)
            Return ds
            objConexion.Close()
        Catch ex As Exception
            objConexion.Close()
            Throw ex
        End Try

    End Function


    Public Shared Function executeDataSet(ByVal nombreSP As String, ByVal params As SqlClient.SqlParameter()) As System.Data.DataSet
        Dim ds As New DataSet
        objConexion = New SqlClient.SqlConnection(lstrConexion)
        objCommand = New SqlClient.SqlCommand()
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandText = nombreSP
        objCommand.Connection = objConexion

        'Agrego parámetros al command
        For Each parametro As SqlClient.SqlParameter In params
            objCommand.Parameters.Add(parametro)
        Next

        objAdapter = New SqlClient.SqlDataAdapter
        objAdapter.SelectCommand = objCommand

        Try
            objConexion.Open()
            objAdapter.Fill(ds)
            Return ds
            objConexion.Close()
        Catch ex As Exception
            objConexion.Close()
            Throw ex
        End Try

    End Function

    Public Shared Function executeReader(ByVal nombreSP As String) As SqlClient.SqlDataReader
        objConexion = New SqlClient.SqlConnection(lstrConexion)
        objCommand = New SqlClient.SqlCommand()
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandText = nombreSP
        objCommand.Connection = objConexion

        Try
            objConexion.Open()
            Return objCommand.ExecuteReader()
            objConexion.Close()
        Catch ex As Exception
            objConexion.Close()
            Throw ex
        End Try

    End Function

    Public Function executeReader(ByVal nombreSP As String, ByVal params As SqlClient.SqlParameter()) As SqlClient.SqlDataReader
        objConexion = New SqlClient.SqlConnection(lstrConexion)
        objCommand = New SqlClient.SqlCommand()
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandText = nombreSP
        objCommand.Connection = objConexion

        'Agrego parámetros al command
        For Each parametro As SqlClient.SqlParameter In params
            objCommand.Parameters.Add(parametro)
        Next

        Try
            objConexion.Open()
            Return objCommand.ExecuteReader()
            objConexion.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Sub executeNonQuery(ByVal nombreSP As String)
        objConexion = New SqlClient.SqlConnection(lstrConexion)
        objCommand = New SqlClient.SqlCommand()
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandText = nombreSP
        objCommand.Connection = objConexion


        Try
            objConexion.Open()
            objCommand.ExecuteNonQuery()
            objConexion.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub



    Public Shared Sub executeNonQuery(ByVal nombreSP As String, ByVal params As SqlClient.SqlParameter())
        objConexion = New SqlClient.SqlConnection(lstrConexion)
        objCommand = New SqlClient.SqlCommand()
        objCommand.CommandType = CommandType.StoredProcedure
        objCommand.CommandText = nombreSP
        objCommand.Connection = objConexion

        'Agrego parámetros al command
        For Each parametro As SqlClient.SqlParameter In params
            objCommand.Parameters.Add(parametro)
        Next

        Try
            objConexion.Open()
            objCommand.ExecuteNonQuery()
            objConexion.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Shared Sub executeNonQuery(ByVal nombreSP As String, ByRef params As SqlClient.SqlParameter(), ByRef objConn As SqlClient.SqlConnection, ByRef objTran As SqlClient.SqlTransaction)
        'Hago que el try encierre todo el bloque del procedimiento, sino me puede quedar la transacción colgada 
        Try
            objCommand = New SqlClient.SqlCommand()
            objCommand.CommandType = CommandType.StoredProcedure
            objCommand.CommandText = nombreSP
            'La conexión que pasé como parámetro
            objCommand.Connection = objConn
            'la transacción que pasé como parámetro
            objCommand.Transaction = objTran

            For Each parametro As SqlClient.SqlParameter In params
                objCommand.Parameters.Add(parametro)
            Next

            objCommand.Connection = objConn

            objCommand.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error")
        End Try

    End Sub


End Class

