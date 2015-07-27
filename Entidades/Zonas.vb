Public Class Zonas

    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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


End Class
