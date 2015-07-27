Public Class Piezas
    Private _id_pieza As Integer
    Private _descripcion As String
    Private _costo As Double
    Private _stock As Integer
    Private _tipo As String

    Public Property IdPieza() As String
        Get
            Return Me._id_pieza
        End Get
        Set(ByVal value As String)
            Me._id_pieza = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return Me._descripcion
        End Get
        Set(ByVal value As String)
            Me._descripcion = value
        End Set
    End Property
    Public Property Costo() As Double
        Get
            Return Me._costo
        End Get
        Set(ByVal value As Double)
            Me._costo = value
        End Set
    End Property
    Public Property StockPieza() As Integer
        Get
            Return Me._id_pieza
        End Get
        Set(ByVal value As Integer)
            Me._id_pieza = value
        End Set
    End Property
    Public Property TipoPieza() As String
        Get
            Return Me._tipo
        End Get
        Set(ByVal value As String)
            Me._tipo = value
        End Set
    End Property

End Class
