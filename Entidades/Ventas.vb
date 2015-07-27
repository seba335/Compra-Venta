Public Class Ventas

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


    Private _id_modelo As String
    Public Property IdModelo() As String
        Get
            Return _id_modelo
        End Get
        Set(ByVal value As String)
            _id_modelo = value
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



    Private _id_envio As Integer
    Public Property IdEnvio() As Integer
        Get
            Return _id_envio
        End Get
        Set(ByVal value As Integer)
            _id_envio = value
        End Set
    End Property


    Private _id_pago As Integer
    Public Property IdPago() As Integer
        Get
            Return _id_pago
        End Get
        Set(ByVal value As Integer)
            _id_pago = value
        End Set
    End Property

    Private _fecha As DateTime
    Public Property NewProperty() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property











End Class
