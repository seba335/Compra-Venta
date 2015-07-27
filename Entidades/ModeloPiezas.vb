Public Class ModeloPiezas

    Private _id_modelo As String
    Public Property IdModelo() As String
        Get
            Return _id_modelo
        End Get
        Set(ByVal value As String)
            _id_modelo = value
        End Set
    End Property


    Private _id_pieza As Integer
    Public Property IdPieza() As Integer
        Get
            Return _id_pieza
        End Get
        Set(ByVal value As Integer)
            _id_pieza = value
        End Set
    End Property


    Private _cantidad As Integer
    Public Property Cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property


End Class
