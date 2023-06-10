using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Programacion
{
    public class Alumno
    {
        public string Carnet { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Grado { get; set; }

        public Alumno(string carnet, string nombre, string telefono, string grado)
        {
            Carnet = carnet;
            Nombre = nombre;
            Telefono = telefono;
            Grado = grado;
        }
    }
}