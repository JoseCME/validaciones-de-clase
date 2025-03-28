using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.Interfaces;

namespace p1bpoo.MisClases
{
    internal class Chofer : IPiloto
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string TipoLicencia { get; set; }

        public Chofer(string nombre, int edad, string tipoLicencia)
        {
            Nombre = nombre;
            Edad = edad;
            TipoLicencia = tipoLicencia;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("El piloto es: " + Nombre);
            Console.WriteLine("Tipo de licencia {0}", TipoLicencia);
        }
    }
}
