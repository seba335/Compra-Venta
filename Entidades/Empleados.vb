Public Class Empleados

    Private _estadoCivil As String
    Public Property EstadoCivil() As String
        Get
            Return _estadoCivil
        End Get
        Set(ByVal value As String)
            _estadoCivil = value
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


    Private _legajo As Integer
    Public Property Legajo() As Integer
        Get
            Return _legajo
        End Get
        Set(ByVal value As Integer)
            _legajo = value
        End Set
    End Property


    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
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

    Private _telefono As Double
    Public Property Telefono() As Double
        Get
            Return _telefono
        End Get
        Set(ByVal value As Double)
            _telefono = value
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

    Private _tipo As String
    Public Property Tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
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

    Private _numeroCalle As Integer
    Public Property NumeroCalle() As Integer
        Get
            Return _numeroCalle
        End Get
        Set(ByVal value As Integer)
            _numeroCalle = value
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

    Private _activo As Boolean
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property








End Class
