Imports TorneosEntidades
Module RefereeTest
    Sub Main()
        Dim Referee1 As New Referee("julio", #12/10/1997#, True)

        Console.WriteLine("Nombre: " & Referee1.Nombre)
        Console.WriteLine("Fecha de Nacimiento: " & Referee1.FechaNacimiento)
        Console.WriteLine("Edad: " & Referee1.Edad)
        Console.WriteLine("ToString: " & Referee1.ToString)

        Console.ReadKey()
    End Sub
End Module
