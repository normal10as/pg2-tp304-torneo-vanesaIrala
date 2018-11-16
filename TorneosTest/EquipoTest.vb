Imports TorneosEntidades
Module EquipoTest
    Sub Main()

        Dim Equipo1 As New Equipo("River Plate")
        Dim Equipo2 As New Equipo("Boca Juniors")

        Dim Jugador1 As New Jugador("Franco Armani", #10/05/1988#, 1)
        Dim Jugador2 As New Jugador("Jonatan Maidana", #10/05/1988#, 2)
        Dim Jugador3 As New Jugador("Jorge Moreira", #11/05/1988#, 3)
        Dim Jugador4 As New Jugador("Milton Casco", #12/05/1988#, 7)
        Dim Jugador5 As New Jugador("Enzo Pérez", #12/05/1988#, 7)

        Dim Jugador6 As New Jugador("Esteban Andrada", #10/05/1988#, 1)
        Dim Jugador7 As New Jugador("Paolo Goltz", #10/05/1988#, 2)
        Dim Jugador8 As New Jugador("Lucas Olaza", #11/05/1988#, 3)
        Dim Jugador9 As New Jugador("Agustín Almendra", #12/05/1988#, 7)
        Dim Jugador10 As New Jugador("Sebastián Villa", #12/05/1988#, 7)


        Equipo1.ComprarJugador(Jugador1)
        Equipo1.ComprarJugador(Jugador2)
        Equipo1.ComprarJugador(Jugador3)
        Equipo1.ComprarJugador(Jugador4)
        Equipo1.ComprarJugador(Jugador5)

        Equipo2.ComprarJugador(Jugador6)
        Equipo2.ComprarJugador(Jugador7)
        Equipo2.ComprarJugador(Jugador8)
        Equipo2.ComprarJugador(Jugador9)
        Equipo2.ComprarJugador(Jugador10)

        'Console.WriteLine("Nombre del Equipo1: " & Equipo1.ToString())
        'For Each Jugador As Jugador In Equipo1.getAllJugador
        '    Console.WriteLine("Nombre del jugador: " & Jugador.ToString())
        '    Console.WriteLine("Fecha de Nacimiento del jugador: " & Jugador.FechaNacimiento)
        '    Console.WriteLine("Edad del jugador: " & Jugador.Edad)
        'Next
        'Console.WriteLine()
        mostrar(Equipo1)
        'Console.WriteLine("Nombre del Equipo2: " & Equipo2.ToString())
        'For Each Jugador As Jugador In Equipo2.getAllJugador
        '    Console.WriteLine("Nombre del jugador: " & Jugador.ToString())
        '    Console.WriteLine("Fecha de Nacimiento del jugador: " & Jugador.FechaNacimiento)
        '    Console.WriteLine("Edad del jugador: " & Jugador.Edad)
        'Next
        mostrar(Equipo2)

        Equipo1.LiberarJugador(Jugador5)
        Console.WriteLine("********************************************************************")
        mostrar(Equipo1)
        Console.ReadKey()

    End Sub
    Private Sub mostrar(Equipo As Equipo)
        Console.WriteLine("Nombre del Equipo: " & Equipo.ToString())
        For Each Jugador As Jugador In Equipo.getAllJugador
            Console.WriteLine("Nombre del jugador: " & Jugador.ToString())
            Console.WriteLine("Fecha de Nacimiento del jugador: " & Jugador.FechaNacimiento)
            Console.WriteLine("Edad del jugador: " & Jugador.Edad)
        Next
    End Sub

End Module
