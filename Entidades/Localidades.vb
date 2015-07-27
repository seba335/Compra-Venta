Public Class Localidades

    Private _id As Integer
    Public Property idLocalidad() As Integer
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


    Private _id_zona As Integer
    Public Property IdZona() As Integer
        Get
            Return _id_zona
        End Get
        Set(ByVal value As Integer)
            _id_zona = value
        End Set
    End Property



End Class
