Public Class CLientes

    Private _numero_cliente As Integer
    Public Property NumeroCliente() As Integer
        Get
            Return _numero_cliente
        End Get
        Set(ByVal value As Integer)
            _numero_cliente = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Private _apellido As String
    Public Property Apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property


    Private _id_localidad As Integer
    Public Property IdLocalidad() As Integer
        Get
            Return _id_localidad
        End Get
        Set(ByVal value As Integer)
            _id_localidad = value
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

    Private _numero_calle As Integer
    Public Property NumeroCalle() As Integer
        Get
            Return _numero_calle
        End Get
        Set(ByVal value As Integer)
            _numero_calle = value
        End Set
    End Property
    Private _telefono As Double
    Public Property Telefono() As Double
        Get
            Return _telefono
        End Get
        Set(ByVal value As Double)
            _telefono = value
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

    Private _email As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property


    Private _valoracion As Integer
    Public Property Valoracion() As Integer
        Get
            Return _valoracion
        End Get
        Set(ByVal value As Integer)
            _valoracion = value
        End Set
    End Property


    Private _contraseña As String
    Public Property Contraseña() As String
        Get
            Return _contraseña
        End Get
        Set(ByVal value As String)
            _contraseña = value
        End Set
    End Property










End Class
