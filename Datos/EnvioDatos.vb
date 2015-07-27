Imports Entidades
Public Class EnvioDatos
    Public Function AgregarEnvio(ByVal idCliente As Integer,
                                 idLocalidad As Integer, calle As String, numero As Integer,
                                 piso As Integer, departamento As String, fecha As DateTime, tel As Double,
                                  ByVal objConn As SqlClient.SqlConnection, ByVal objTran As SqlClient.SqlTransaction) As Integer
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(8) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdCliente", SqlDbType.Int)
        objSqlParameters(0).Value = idCliente

        objSqlParameters(1) = New SqlClient.SqlParameter("@IdLocalidad", SqlDbType.Int)
        objSqlParameters(1).Value = idLocalidad

        objSqlParameters(2) = New SqlClient.SqlParameter("@Calle", SqlDbType.VarChar, 50)
        objSqlParameters(2).Value = calle

        objSqlParameters(3) = New SqlClient.SqlParameter("@Numero", SqlDbType.Int)
        objSqlParameters(3).Value = numero
        If piso = -1 Then
            objSqlParameters(4) = New SqlClient.SqlParameter("@Piso", DBNull.Value)
            objSqlParameters(4).Value = DBNull.Value
        Else
            objSqlParameters(4) = New SqlClient.SqlParameter("@Piso", SqlDbType.Int)
            objSqlParameters(4).Value = piso
        End If

        If departamento = "" Then
            objSqlParameters(5) = New SqlClient.SqlParameter("@Departamento", DBNull.Value)
            objSqlParameters(5).Value = DBNull.Value
        Else
            objSqlParameters(5) = New SqlClient.SqlParameter("@Departamento", SqlDbType.Char, 10)
            objSqlParameters(5).Value = departamento
        End If


        objSqlParameters(6) = New SqlClient.SqlParameter("@Fecha", SqlDbType.DateTime)
        objSqlParameters(6).Value = fecha

        objSqlParameters(7) = New SqlClient.SqlParameter("@Telefono", SqlDbType.BigInt)
        objSqlParameters(7).Value = tel

        objSqlParameters(8) = New SqlClient.SqlParameter("@Id", SqlDbType.Int)
        objSqlParameters(8).Direction = ParameterDirection.Output

        Try
            ClaseDatos.executeDataSet("AgregarEnvio", objSqlParameters)
            Return objSqlParameters(8).Value
        Catch ex As Exception
            Throw New Exception("No se pudo agregar el envio")
        End Try


    End Function


    Public Function TraerUltimaDireccionDeEnvio(idcliente As Integer) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@NumeroCliente", SqlDbType.Int)
        objSqlParameters(0).Value = idcliente
        Try
            Return ClaseDatos.executeDataSet("TraerUltimaDireccionDeEnvio", objSqlParameters)

        Catch ex As Exception
            Throw New Exception("error al traer la direccion de envio")
        End Try
    End Function

    Public Function TraerEnvioPorVenta(idVenta As Integer) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(0) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@IdVenta", SqlDbType.Int)
        objSqlParameters(0).Value = idVenta

        Try
            Return ClaseDatos.executeDataSet("TraerEnvioPorVenta", objSqlParameters)

        Catch ex As Exception
            Throw New Exception("error al traer la direccion de envio")
        End Try
    End Function

End Class
