using SeleccionJugadores;

class Program
{

    static void Main()
    {
        Random rand = new Random();

        List<IJugador> listaJugadores = new List<IJugador>
        {
            new Jugador("Jugador1", "Carlos", rand.Next(11)),
            new Jugador("Jugador2", "Pedro", rand.Next(11)),
            new Jugador("Jugador3", "Martin", rand.Next(11)),
            new Jugador("Jugador4", "Juan", rand.Next(11)),
            new Jugador("Jugador5", "Camilo", rand.Next(11)),
            new Jugador("Jugador6", "David", rand.Next(11))
        };

        Equipo equipo1 = new Equipo();
        Equipo equipo2 = new Equipo();

        for (int i = 0; i < 3; i++)
        {
            int seleccionJugador1 = rand.Next(listaJugadores.Count);
            int seleccionJugador2 = rand.Next(listaJugadores.Count);

            IJugador jugador1 = listaJugadores[seleccionJugador1];
            IJugador jugador2 = listaJugadores[seleccionJugador2];

            equipo1.AgregarJugador(jugador1);
            equipo2.AgregarJugador(jugador2);

            listaJugadores.RemoveAt(seleccionJugador1);
            listaJugadores.RemoveAt(seleccionJugador2);
        }

        int puntosEquipo1 = equipo1.CalcularPuntosTotales();
        int puntosEquipo2 = equipo2.CalcularPuntosTotales();

        Console.WriteLine("Equipo 1:");
        foreach (var jugador in equipo1)
        {
            Console.WriteLine($"{jugador.Nombre} ({jugador.Posicion}): {jugador.Rendimiento}");
        }
        Console.WriteLine($"Puntaje total del Equipo 1: {puntosEquipo1}");

        Console.WriteLine("\nEquipo 2:");
        foreach (var jugador in equipo2)
        {
            Console.WriteLine($"{jugador.Nombre} ({jugador.Posicion}): {jugador.Rendimiento}");
        }
        Console.WriteLine($"Puntaje total del Equipo 2: {puntosEquipo2}");

        if (puntosEquipo1 > puntosEquipo2)
        {
            Console.WriteLine("El Equipo 1 gana el partido.");
        }
        else if (puntosEquipo2 > puntosEquipo1)
        {
            Console.WriteLine("El Equipo 2 gana el partido.");
        }
        else
        {
            Console.WriteLine("El partido termina en empate.");
        }
    }


}
