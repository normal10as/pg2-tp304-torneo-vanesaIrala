Public Class Equipo
    'Campos
    Private _nombre As String
    Private _jugadores As List(Of Jugador)


    'Constructor sobrecargado
    Sub New(nombre As String)
        Me.Nombre = nombre
        _jugadores = New List(Of Jugador)
    End Sub

    'Propiedades
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value <> "" And value.Length <= 50 Then _nombre = value
        End Set
    End Property

    'Metodos
    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Sub ComprarJugador(Jugador As Jugador)
        Jugador.Equipo = Me
        _jugadores.Add(Jugador)
    End Sub

    Public Function getAllJugador() As List(Of Jugador)
        Return _jugadores
    End Function

    Public Sub VenderJugador(jugador As Jugador, equipodestino As Equipo)
        equipodestino.ComprarJugador(jugador)
        _jugadores.Remove(jugador)
    End Sub

    Public Sub LiberarJugador(jugador As Jugador)
        jugador.Equipo = Nothing
        _jugadores.Remove(jugador)
    End Sub

End Class
