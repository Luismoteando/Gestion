Imports GestorEpidemias

Public Class Viaje
    Private id As Integer
    Private destino As Pais
    Private ida, vuelta As Date
    Private emp As Empleado
    Private DAO As DAOViaje

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Destino1 As Pais
        Get
            Return destino
        End Get
        Set(value As Pais)
            destino = value
        End Set
    End Property

    Public Property Ida1 As Date
        Get
            Return ida
        End Get
        Set(value As Date)
            ida = value
        End Set
    End Property

    Public Property Vuelta1 As Date
        Get
            Return vuelta
        End Get
        Set(value As Date)
            vuelta = value
        End Set
    End Property

    Public Property Emp1 As Empleado
        Get
            Return emp
        End Get
        Set(value As Empleado)
            emp = value
        End Set
    End Property

    Public Sub New(dni As Empleado)
        Me.emp = dni
        Me.DAO = New DAOViaje
    End Sub

    Public Sub read()
        DAO.readViaje(Me)
    End Sub
End Class
