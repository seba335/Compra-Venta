Public Class ModeloVentas

    Private _id_venta As Integer
    Public Property IdVenta() As Integer
        Get
            Return _id_venta
        End Get
        Set(ByVal value As Integer)
            _id_venta = value
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


    Private _costo_fisico As Integer
    Public Property CostoFisico() As Integer
        Get
            Return _costo_fisico
        End Get
        Set(ByVal value As Integer)
            _costo_fisico = value
        End Set
    End Property




End Class
