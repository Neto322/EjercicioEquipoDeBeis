using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEquipos
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Entrenador { get; set; }
       public List<Jugador> listajugadores { get; set; }
        public Estadio estadio { get; set; }
        public Equipo()
        {
            Nombre = "Nombre";
            Ciudad = "Ciudad";
            Entrenador = "Entrenador";
            listajugadores = new List<Jugador>();
        }
    }
}
