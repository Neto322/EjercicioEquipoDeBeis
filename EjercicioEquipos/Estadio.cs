using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEquipos
{
    class Estadio
    {
        public string Nombrest { get; set; }
        public string Dirrecion { get; set; }
        public int Capacidad { get; set; }
        public Estadio()
        {

        }
        public Estadio(string nombre, string dirrecion , int capacidad)
        {
            Nombrest = nombre;
            Dirrecion = dirrecion;
            Capacidad = capacidad;
        }
    }
}
