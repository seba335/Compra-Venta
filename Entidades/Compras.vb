Public Class Compras



    Private _id_compra As Integer
    Public Property IdCompras() As Integer
        Get
            Return _id_compra
        End Get
        Set(ByVal value As Integer)
            _id_compra = value
        End Set
    End Property

    Private _estado As String
    Public Property Estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property


    Private _id_proveedor As Integer
    Public Property IdProveedor() As Integer
        Get
            Return _id_proveedor
        End Get
        Set(ByVal value As Integer)
            _id_proveedor = value
        End Set
    End Property

    Private _id_empleado As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return _id_empleado
        End Get
        Set(ByVal value As Integer)
            _id_empleado = value
        End Set
    End Property

    Private _fecha As DateTime
    Public Property Fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property


End Class
