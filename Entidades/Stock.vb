Public Class Stock

    Private _id As Integer
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Private _id_modelo As String
    Public Property IdModelo() As String
        Get
            Return _id_modelo
        End Get
        Set(ByVal value As String)
            _id_modelo = value
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


    Private _maximo As Integer
    Public Property Maximo() As Integer
        Get
            Return _maximo
        End Get
        Set(ByVal value As Integer)
            _maximo = value
        End Set
    End Property


    Private _minimo As Integer
    Public Property Minimo() As Integer
        Get
            Return _minimo
        End Get
        Set(ByVal value As Integer)
            _minimo = value
        End Set
    End Property



End Class
