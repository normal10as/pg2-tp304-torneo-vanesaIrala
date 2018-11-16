Public Class Referee
    Inherits Persona

    'Campos
    Private _Internacional As Boolean


    'Constructor sobrecargado
    Sub New(nombre As String, fechaNacimiento As Date, internacional As Boolean)
        MyBase.New(nombre, fechaNacimiento)
        Me.Internacional = internacional
    End Sub
    'Propiedades
    Public Property Internacional As Boolean
        Get
            Return _Internacional
        End Get
        Set(value As Boolean)
            _Internacional = value
        End Set
    End Property

    'Metodos
    Public Overrides Function ToString() As String
        Return Nombre & If(_Internacional, "( " & "i" & " )", "")
    End Function
End Class
