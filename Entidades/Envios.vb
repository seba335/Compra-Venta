Public Class Envios

    Private _id_envio As Integer
    Public Property IdEnvio() As Integer
        Get
            Return _id_envio
        End Get
        Set(ByVal value As Integer)
            _id_envio = value
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
    Private _id_empleado As Integer
    Public Property IdEmpleado() As Integer
        Get
            Return _id_empleado
        End Get
        Set(ByVal value As Integer)
            _id_empleado = value
        End Set
    End Property
    Private _id_zona As Integer
    Public Property IdZona() As Integer
        Get
            Return _id_zona
        End Get
        Set(ByVal value As Integer)
            _id_zona = value
        End Set
    End Property

    Private _calle As String
    Public Property Calle() As String
        Get
            Return _calle
        End Get
        Set(ByVal value As String)
            _calle = value
        End Set
    End Property

    Private _numero As Integer
    Public Property Numero() As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property

    Private _piso As Integer
    Public Property Piso() As Integer
        Get
            Return _piso
        End Get
        Set(ByVal value As Integer)
            _piso = value
        End Set
    End Property

    Private _departamento As String
    Public Property Departamento() As String
        Get
            Return _departamento
        End Get
        Set(ByVal value As String)
            _departamento = value
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

    Private _tel As Double
    Public Property NewProperty() As Double
        Get
            Return _tel
        End Get
        Set(ByVal value As Double)
            _tel = value
        End Set
    End Property


End Class
