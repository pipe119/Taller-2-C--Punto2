namespace SeleccionJugadores;
using System;
using System.Collections;
using System.Collections.Generic; //esto es para la interfaz generica

class Equipo : IEnumerable<IJugador>
{
    private List<IJugador> jugadores = new List<IJugador>();

    public void AgregarJugador(IJugador jugador)
    {
        jugadores.Add(jugador);
    }

    public int CalcularPuntosTotales()
    {
        int puntosTotales = 0;
        foreach (var jugador in jugadores)
        {
            puntosTotales += jugador.Rendimiento;
        }
        return puntosTotales;
    }

    public IEnumerator<IJugador> GetEnumerator()
    {
        return jugadores.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}