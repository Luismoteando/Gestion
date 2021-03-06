﻿Imports MySql.Data.Types

Public Class Enfermedad

    Private DAO As DAOEnfermedad
    Private id, n_focos, radio, contagiosa As Integer
    Private nombre, síntomas, localización, incubación, prevención, cura As String

    Public Property _id As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property _nfocos As Integer
        Get
            Return n_focos
        End Get
        Set(value As Integer)
            n_focos = value
        End Set
    End Property

    Public Property _radio As Integer
        Get
            Return radio
        End Get
        Set(value As Integer)
            radio = value
        End Set
    End Property

    Public Property _contagiosa As Integer
        Get
            Return contagiosa
        End Get
        Set(value As Integer)
            contagiosa = value
        End Set
    End Property

    Public Property _nombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property _sintomas As String
        Get
            Return síntomas
        End Get
        Set(value As String)
            síntomas = value
        End Set
    End Property

    Public Property _localización As String
        Get
            Return localización
        End Get
        Set(value As String)
            localización = value
        End Set
    End Property

    Public Property _incubacion As String
        Get
            Return incubación
        End Get
        Set(value As String)
            incubación = value
        End Set
    End Property

    Public Property _prevencion As String
        Get
            Return prevención
        End Get
        Set(value As String)
            prevención = value
        End Set
    End Property

    Public Property _cura As String
        Get
            Return cura
        End Get
        Set(value As String)
            cura = value
        End Set
    End Property

    Public Sub New()
        Me.DAO = New DAOEnfermedad
    End Sub

    Public Function readLatLon(ByVal enf As Enfermedad) As MySqlGeometry
        Return DAO.readLatLon(enf)
    End Function

    Public Sub readByName(ByRef enf As Enfermedad)
        DAO.readByName(enf)
    End Sub

    Public Function readAllByCountry(ByVal pais As Pais) As Collection
        DAO.readAllByCountry(pais)
        Return DAO.lista
    End Function

    Public Function readAll() As Collection
        DAO.readAll()
        Return DAO.lista
    End Function
End Class
