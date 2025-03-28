using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
        internal class Trailer : Vehiculo
    {
        private string numerodeejes;
        private int gasolina;
        public Trailer(int anio, string elColor, string elModelo, string numerodeejes, int gasolina) : base(anio, elColor, elModelo)
        {
            TiposLicenciaAceptado = new List<string> { "A" };
            this.numerodeejes = numerodeejes;
            this.gasolina = gasolina;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            gasolina -= 2;
        }

        public override void InformacionVehiculo()
        {
            base.InformacionVehiculo();
            Console.WriteLine("Numero de de ejes es {0}", this.numerodeejes);
        }
    }
}
