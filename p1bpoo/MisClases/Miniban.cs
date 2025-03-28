using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Miniban : Vehiculo
    {
        private string numerodeasientos;
        private string gasolina;
        public Miniban(int anio, string elColor, string elModelo, string numerodeasientos, string gasolina) : base(anio, elColor, elModelo)
        {
            TiposLicenciaAceptado = new List<string> { "B","A" };
            this.numerodeasientos = numerodeasientos;
            this.gasolina = gasolina;
        }

        public override void InformacionVehiculo()
        {
            base.InformacionVehiculo();
            Console.WriteLine("Numero de asientos {0}", this.numerodeasientos);
        }
        public void cargargasolina(int cuanto)
        {
            gasolina += cuanto;
            Console.WriteLine("Cargando gasolina {0}", this.gasolina);
        }
    }
}
 
