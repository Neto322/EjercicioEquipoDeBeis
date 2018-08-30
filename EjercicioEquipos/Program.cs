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
            Equipos[0].listajugadores.Add(new Jugador("Marito", "1"));
            Equipos[0].listajugadores.Add(new Jugador("Yisuscrais", "2"));
            Equipos[0].listajugadores.Add(new Jugador("Adrian", "3"));
            Equipos[0].listajugadores.Add(new Jugador("Michael", "4"));
            Equipos[0].listajugadores.Add(new Jugador("Juasjuas", "5"));
            Equipos[0].listajugadores.Add(new Jugador("Mario", "6"));
            Equipos[0].listajugadores.Add(new Jugador("Laikabaus", "7"));
            Equipos[0].listajugadores.Add(new Jugador("Meinkaracter", "8"));
            Equipos[0].listajugadores.Add(new Jugador("efe", "9"));
            Equipos.Add(new Equipo());
            Equipos[1].Nombre = "Los mayos que valen bestia";
            Equipos[1].Ciudad = "Navojoa";
            Equipos[1].Entrenador = "Michael Quesadilla";
            Equipos[1].listajugadores.Add(new Jugador("Jotaro", "1"));
            Equipos[1].listajugadores.Add(new Jugador("Mikimiki", "2"));
            Equipos[1].listajugadores.Add(new Jugador("Niko", "3"));
            Equipos[1].listajugadores.Add(new Jugador("Niko", "4"));
            Equipos[1].listajugadores.Add(new Jugador("Niii", "5"));
            Equipos[1].listajugadores.Add(new Jugador("Jejejje", "6"));
            Equipos[1].listajugadores.Add(new Jugador("sdasd", "7"));
            Equipos[1].listajugadores.Add(new Jugador("mequedesinideas", "8"));
            Equipos[1].listajugadores.Add(new Jugador("ya", "9"));
            Equipos[0].estadio = new Estadio("Estadio nacional de Uchurubusco", "Enrique segoviano", 8001);
            Equipos[1].estadio = new Estadio();
            Equipos[1].estadio = null;

            foreach (Equipo equipo in Equipos)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Nombre: " + equipo.Nombre);
                Console.WriteLine("Ciudad: " + equipo.Ciudad);
                Console.WriteLine("Entrenador: " + equipo.Entrenador);
                Console.WriteLine(" ");
                if (equipo.estadio != null)
                {
                    Console.WriteLine("Nombre " + equipo.estadio.Nombrest);
                    Console.WriteLine("Dirrecion " + equipo.estadio.Dirrecion);
                    Console.WriteLine("Capacidad " + equipo.estadio.Capacidad);
                    Console.WriteLine(" " );
                }
                else
                {
                    Console.WriteLine("No tiene estadio");
                    Console.WriteLine(" ");
                }
                foreach(Jugador jugador in equipo.listajugadores)
                {
                    Console.WriteLine("Nombre: " + jugador.Nombre);
                    Console.WriteLine("Numero " + jugador.Numero);
                }
            }
            Console.ReadLine();
        }
        
    }
}
