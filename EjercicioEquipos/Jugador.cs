using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEquipos
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public Jugador()
        {
            Nombre = "Jugador";
            Numero = "00";
        }
        public Jugador(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
