Public MustInherit Class Persona
    'Campos
    Private _FechaNacimiento As Date
    Private _Edad As UShort
    Private _nombre As String

    ''Constructor
    'Sub New()
    'End Sub

    'Constructor sobrecargado
    Sub New(nombre As String, fechaNacimiento As Date)
        Me.Nombre = nombre
        Me.FechaNacimiento = fechaNacimiento
    End Sub

    'Propiedades
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            ' If value <> "" And value.Length <= 30 Then

            If value.Length = 0 Then
                Throw New ArgumentException("Nombre no puede estar vacio.")
            ElseIf value.Length > 30 Then
                Throw New ArgumentException("Nombre tiene como maximo 30 letras.")

            End If
            _nombre = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            If CalcularEdad(value) >= 16 Then
                _FechaNacimiento = value
            End If
        End Set
    End Property

    Public ReadOnly Property Edad As UShort
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property

    'Metodos
    Private Function CalcularEdad(FechaNacimiento As Date) As UShort
        Return DateDiff(DateInterval.Year, FechaNacimiento, Today)
    End Function

    Public Overrides Function ToString() As String
        Return Nombre
    End Function


End Class
