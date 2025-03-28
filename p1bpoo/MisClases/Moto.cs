using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Moto : Vehiculo
    {
        public Moto(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            TiposLicenciaAceptado = new List<string> {"M"};
        }

        protected override int CapacidadTanque
        {
            get => 15;
            set => base.CapacidadTanque = value;
        }
        protected override int VelocidadMaxima 
        {
            get => 150; 
            set => base.VelocidadMaxima = value;

        }

        protected override int ConsumoCombustible 
        {
            get => 1;
            set => base.ConsumoCombustible = value;
        }

        public void hacerCaballito()
        {
            if (EstadoVehiculo == 2)
            {
                Console.WriteLine("Haciendo caballito");
            }
            else
            {
                Console.WriteLine("No se puede hacer caballito, el vehiculo no esta en movimiento");
            }
        }

    }
    
}
