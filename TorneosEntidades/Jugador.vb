Public Class Jugador
    Inherits Persona

    'Campos
    Private _Numero As Byte
    Private _Equipo As Equipo

    'Constructor sobrecargado
    Sub New(nombre As String, fechaNacimiento As Date, numero As Byte)
        MyBase.New(nombre, fechaNacimiento)
        Me.Numero = numero
    End Sub

    'Propiedades
    Public Property Numero As Byte
        Get
            Return _Numero
        End Get
        Set(value As Byte)
            If value >= 1 And value <= 99 Then _Numero = value
        End Set
    End Property

    Public Property Equipo As Equipo
        Get
            Return _Equipo
        End Get
        Friend Set(value As Equipo)
            _Equipo = value
        End Set
    End Property

    'Metodos
    Public Overrides Function ToString() As String
        Return Nombre & " (" & Numero & ")"
    End Function
End Class
