Public Class TarjetaDatos
    Public Sub AgregarTarjeta(NumerodeTarjeta As String, IdCliente As Integer, Apellido As String, Nombre As String, CodigodeSeguridad As String, Tipo As String, FechadeCaducidad As Date, Actva As Boolean)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(7) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Numero", SqlDbType.VarChar, 50)
        objSqlParameters(0).Value = NumerodeTarjeta


        objSqlParameters(1) = New SqlClient.SqlParameter("@IdCliente", SqlDbType.Int)
        objSqlParameters(1).Value = IdCliente


        objSqlParameters(2) = New SqlClient.SqlParameter("@Apellido", SqlDbType.VarChar, 50)
        objSqlParameters(2).Value = Apellido

        objSqlParameters(3) = New SqlClient.SqlParameter("@Nombre", SqlDbType.VarChar, 50)
        objSqlParameters(3).Value = Nombre

        objSqlParameters(4) = New SqlClient.SqlParameter("@CodigoDeSeguridad", SqlDbType.VarChar, 10)
        objSqlParameters(4).Value = CodigodeSeguridad

        objSqlParameters(5) = New SqlClient.SqlParameter("@Tipo", SqlDbType.VarChar, 50)
        objSqlParameters(5).Value = Tipo

        objSqlParameters(6) = New SqlClient.SqlParameter("@FechaCaducidad", SqlDbType.Date)
        objSqlParameters(6).Value = FechadeCaducidad

        objSqlParameters(7) = New SqlClient.SqlParameter("@Activa", SqlDbType.Bit)
        objSqlParameters(7).Value = Actva

        ClaseDatos.executeNonQuery("AgregarTarjeta", objSqlParameters)



    End Sub

    Public Sub EliminarTarjeta(IdTarjeta As Integer, Activa As Boolean)
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@Id", SqlDbType.Int)
        objSqlParameters(0).Value = IdTarjeta


        objSqlParameters(1) = New SqlClient.SqlParameter("@Activa", SqlDbType.Bit)
        objSqlParameters(1).Value = Activa




        ClaseDatos.executeNonQuery("EliminarTarjeta", objSqlParameters)

    End Sub

    Public Function TraerTarjetaPorCliente(numeroCliente As Integer, fecha As DateTime) As DataSet
        Dim objSqlParameters() As SqlClient.SqlParameter = New SqlClient.SqlParameter(1) {}

        objSqlParameters(0) = New SqlClient.SqlParameter("@NumeroCliente", SqlDbType.Int)
        objSqlParameters(0).Value = numeroCliente

        objSqlParameters(1) = New SqlClient.SqlParameter("@Fecha", SqlDbType.DateTime)
        objSqlParameters(1).Value = fecha

        Try
            Return ClaseDatos.executeDataSet("TraerTarjetaPorCliente", objSqlParameters)
        Catch ex As Exception
            Throw New Exception("error al traer las tarjetas")
        End Try

    End Function
End Class
