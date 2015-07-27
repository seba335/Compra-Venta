Public Class ComprasPiezas

    Private _id_compra As Integer
    Public Property IdCompra() As Integer
        Get
            Return _id_compra
        End Get
        Set(ByVal value As Integer)
            _id_compra = value
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

    Private _cantidad_piezas As Integer
    Public Property CantidadPiezas() As Integer
        Get
            Return _cantidad_piezas
        End Get
        Set(ByVal value As Integer)
            _cantidad_piezas = value
        End Set
    End Property


    Private _costo_pieza As Integer
    Public Property NewProperty() As Integer
        Get
            Return _costo_pieza
        End Get
        Set(ByVal value As Integer)
            _costo_pieza = value
        End Set
    End Property






End Class
