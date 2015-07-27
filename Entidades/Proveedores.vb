Public Class Proveedores

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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


    Private _telefono As Double
    Public Property Telefono() As Double
        Get
            Return _telefono
        End Get
        Set(ByVal value As Double)
            _telefono = value
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






End Class
