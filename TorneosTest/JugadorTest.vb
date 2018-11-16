Imports TorneosEntidades
Module JugadorTest
    Sub Main()
        Dim jugador1 As New Jugador("julio", #12/10/1997#, 7)

        Console.WriteLine("Nombre: " & jugador1.Nombre)
        Console.WriteLine("Numero: " & jugador1.Numero)
        Console.WriteLine("Fecha de Nacimiento: " & jugador1.FechaNacimiento)
        Console.WriteLine("Edad: " & jugador1.Edad)
        Console.WriteLine("ToString: " & jugador1.ToString)

        Console.ReadKey()
    End Sub

End Module
