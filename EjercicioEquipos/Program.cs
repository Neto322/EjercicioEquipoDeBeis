using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEquipos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> Equipos = new List<Equipo>();
            Equipos.Add(new Equipo());
            Equipos[0].Nombre = "Los yaquis";
            Equipos[0].Ciudad = "Obregon";
            Equipos[0].Entrenador = "Mario";
            Equipos[0].listajugadores.Add(new Jugador("Marito", "23"));
            Equipos[0].listajugadores.Add(new Jugador("Marito", "23"));
            Equipos[0].listajugadores.Add(new Jugador("Marito", "23"));
            Equipos[0].listajugadores.Add(new Jugador("Marito", "23"));
            Equipos[0].listajugadores.Add(new Jugador("Marito", "23"));
            Equipos[0].listajugadores.Add(new Jugador("Marito", "23"));
            Equipos[0].listajugadores.Add(new Jugador("Marito", "23"));
            Equipos[0].listajugadores.Add(new Jugador("Marito", "23"));
            Equipos[0].listajugadores.Add(new Jugador("Marito", "23"));
            Equipos.Add(new Equipo());
            Equipos[0].Nombre = "Los yaquis";
            Equipos[0].Ciudad = "Obregon";
            Equipos[0].Entrenador = "Mario";
        }
        
    }
}
