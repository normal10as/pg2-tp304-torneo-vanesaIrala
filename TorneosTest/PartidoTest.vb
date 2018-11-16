Imports TorneosEntidades
Module PartidoTest
    Sub Main()
        Dim equipolocal = New Equipo("River")
        Dim equipovisitante = New Equipo("Boca")


        Dim partido1 = New Partido(1, equipolocal, equipovisitante)

        Mostrar(partido1)


        partido1 = New Partido(2, equipovisitante, equipolocal, 1, 3)

        Mostrar(partido1)
        Console.ReadKey()
    End Sub
    Private Sub Mostrar(partido1 As Partido)
        Console.WriteLine("Jornada: " & partido1.Jornada)
        Console.WriteLine("Equipo Local: " & partido1.Local.ToString)
        Console.WriteLine("Equipo Visitante: " & partido1.Visitante.ToString)
        Console.WriteLine("Resultado del Partido: " & partido1.ToString)


    End Sub
End Module
