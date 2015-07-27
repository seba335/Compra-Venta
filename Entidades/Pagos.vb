Public Class Pagos

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Private _id_cliente As Integer
    Public Property IdCliente() As Integer
        Get
            Return _id_cliente
        End Get
        Set(ByVal value As Integer)
            _id_cliente = value
        End Set
    End Property


    Private _id_venta As Integer
    Public Property IdVenta() As Integer
        Get
            Return _id_venta
        End Get
        Set(ByVal value As Integer)
            _id_venta = value
        End Set
    End Property


    Private _monto As Integer
    Public Property Monto() As Integer
        Get
            Return _monto
        End Get
        Set(ByVal value As Integer)
            _monto = value
        End Set
    End Property


    Private _tipo As String
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property





End Class
