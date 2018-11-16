Public Class Partido
    'Campos
    Private _jornada As Byte
    Private _golesLocal As Byte
    Private _golesVisitantes As Byte
    Private _MinutosGolesLocales As List(Of Byte)
    Private _MinutosGolesVisitantes As List(Of Byte)
    Private _Local As Equipo
    Private _Visitante As Equipo
    Private _Referee As Referee
    Private _Finalizado As Boolean

    'Constructor sobrecargado
    Sub New(jornada As Byte, equipoLocal As Equipo, equipoVisitante As Equipo)
        Me.Jornada = jornada
        Me.Local = equipoLocal
        Me.Visitante = equipoVisitante
        _Finalizado = False
    End Sub

    Sub New(jornada As Byte, equipoLocal As Equipo, equipoVisitante As Equipo, golesLocal As Byte, golesvisitantes As Byte)
        Me.New(jornada, equipoLocal, equipoVisitante)
        _golesLocal = golesLocal
        _golesVisitantes = golesvisitantes
        Finalizado()
    End Sub

    'Propiedades
    Public Property Jornada As Byte
        Get
            Return _jornada
        End Get

        Set(value As Byte)
            _jornada = value
        End Set
    End Property

    Public ReadOnly Property GolesLocal As Byte
        Get
            Return _golesLocal
        End Get
    End Property

    Public ReadOnly Property GolesVisitante As Byte
        Get
            Return _golesVisitantes
        End Get
    End Property

    Public ReadOnly Property MinutosGolesLocales As List(Of Byte)
        Get
            Return _MinutosGolesLocales
        End Get
    End Property

    Public ReadOnly Property MinutosGolesVisitantes As List(Of Byte)
        Get
            Return _MinutosGolesVisitantes
        End Get
    End Property

    Public Property Referee As Referee
        Get
            Return _Referee
        End Get
        Set(value As Referee)
            _Referee = value
        End Set
    End Property

    Public Property Local As Equipo
        Get
            Return _Local
        End Get
        Set(value As Equipo)
            _Local = value
        End Set
    End Property

    Public Property Visitante As Equipo
        Get
            Return _Visitante
        End Get
        Set(value As Equipo)
            _Visitante = value
        End Set
    End Property

    'Metodos
    Public Sub NuevoGolLocal(Minutos As UShort)
        If _Finalizado = False Then
            _golesLocal += 1
            _MinutosGolesLocales.Add(Minutos)
        End If

    End Sub

    Public Sub NuevoGolVisitante(Minutos As UShort)
        If _Finalizado = False Then
            _golesVisitantes += 1
            _MinutosGolesVisitantes.Add(Minutos)
        End If

    End Sub

    Public Sub Finalizado()
        _Finalizado = True
    End Sub

    'Sobrescribir ToString
    Public Overrides Function ToString() As String
        Return Local.Nombre & " (" & GolesLocal & ") - " & Visitante.Nombre & " (" & GolesVisitante & ")"
    End Function

End Class
