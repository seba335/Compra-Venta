Public Class Modelos

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
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


    Private _activo As Boolean
    Public Property Activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
        End Set
    End Property


    Private _stock_capacidad As Integer
    Public Property StockCapacidad() As Integer
        Get
            Return _stock_capacidad
        End Get
        Set(ByVal value As Integer)
            _stock_capacidad = value
        End Set
    End Property
    Private _imagen As String
    Public Property Imagen() As String
        Get
            Return _imagen
        End Get
        Set(ByVal value As String)
            _imagen = value
        End Set
    End Property
    Private _costo As Double
    Public Property Costo() As Double
        Get
            Return _costo
        End Get
        Set(ByVal value As Double)
            _costo = value
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

    Private _maximo As Integer
    Public Property Maximo() As Integer
        Get
            Return _maximo
        End Get
        Set(ByVal value As Integer)
            _maximo = value
        End Set
    End Property





    Public Function CrearTabla() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("Id")
        'Dim primaryKey(1) As DataColumn
        'primaryKey(1) = dt.Columns("Id")
        'dt.PrimaryKey = primaryKey
        dt.Columns.Add("Nombre")
        dt.Columns.Add("Activo")
        dt.Columns.Add("StockCapacidad")
        dt.Columns.Add("Costo")

        dt.Columns.Add("Cantidad")
        Return dt

    End Function

End Class
