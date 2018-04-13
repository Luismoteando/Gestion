Public Class Empleado

    Private DAO As DAOEmpleado
    Private _dni, _telefono As Integer
    Private _nombre, _apellidos, _email, _departamento As String

    Public Property Dni As Integer
        Get
            Return _dni
        End Get
        Set(value As Integer)
            _dni = value
        End Set
    End Property

    Public Property Telefono As Integer
        Get
            Return _telefono
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellidos As String
        Get
            Return _apellidos
        End Get
        Set(value As String)
            _apellidos = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property Departamento As String
        Get
            Return _departamento
        End Get
        Set(value As String)
            _departamento = value
        End Set
    End Property

    Public Sub New()
        Me.DAO = New DAOEmpleado
    End Sub

    Public Function readAll() As Collection
        DAO.readAll()
        Return DAO.lista
    End Function

End Class
