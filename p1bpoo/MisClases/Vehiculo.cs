using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using p1bpoo.Interfaces;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get; }
        public int Year { get; }

        private int velocidad = 0;

        //Atributos nuevos
        protected List<string> TiposLicenciaAceptado = new List<string> { "A", "B", "C" };

        //atrubuto nuevo de tarea 
        protected virtual int CapacidadTanque { get; set; }
        protected virtual int ConsumoCombustible { get; set; }
        protected virtual int VelocidadMaxima { get; set; }

       





        private Chofer piloto = null;
        protected int EstadoVehiculo { get; set; } = 0;// 0 = apagado, 1 = encendido, 2 = en movimiento
        public string asignarPiloto(Chofer ElPiloto)
        {
            if (ElPiloto == null)
            {
                return "No se puede asignar piloto";
            }

            if (!TiposLicenciaAceptado.Contains(ElPiloto.TipoLicencia))
            {
                return "No se puede asignar piloto, no tiene licencia adecuada";
            }
            if (piloto != null)
            {
                return "No se puede asignar piloto";
            }

            piloto = ElPiloto;
            return "Piloto asignado";
        }


        public Vehiculo(int anio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = anio;
          
        }

        public virtual void InformacionVehiculo()
        {
            Console.WriteLine("__________________________________");
            string mensajepiloto = "No hay piloto asignado";
            string mensajedeestado = "No hay informacion de la velocidad";
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
            Console.WriteLine("Velocidad {0} KMS / Hora", this.velocidad);
            Console.WriteLine("Velocidad Maxima {0} KMS / Hora", this.VelocidadMaxima);
            if (EstadoVehiculo == 0)
            {
                mensajedeestado = "apagado";
              
            }
            if (EstadoVehiculo == 1)
            {
                mensajedeestado = "encendido";
            }
            if (EstadoVehiculo == 2)
            {
                mensajedeestado = "en movimiento";
            }
            Console.WriteLine($"Estado del vehiculo esta {mensajedeestado}");
            if (piloto != null)
            {
                mensajepiloto = piloto.Nombre;
            }
            Console.WriteLine($"El piloto es {mensajepiloto}");

            Console.WriteLine("__________________________________");
        }

        public string encender()
        {
            if (piloto == null)
            {
                return "No se puede encender el vehiculo, no tiene piloto";
            }
            if (EstadoVehiculo == 0)
            {
                EstadoVehiculo = 1;
                return "Vehiculo encendido";
            }
            if (EstadoVehiculo == 2)
            {
                return "Vehiculo esta en movimiento";
            }

            return "Vehiculo ya estaba encendido";
        }
        public virtual void acelerar(int cuanto)
        {
            if (velocidad + cuanto >= VelocidadMaxima)
            {
                Console.WriteLine("No se puede acelerar mas de {0} KMS / Hora", VelocidadMaxima);
                return;
            }
            if (EstadoVehiculo == 1)
            {
                velocidad += cuanto;
                Console.WriteLine("vas a {0} KMS / Hora", velocidad);
                EstadoVehiculo = 2;
                return;

            }
            if (EstadoVehiculo == 0)
            {
                Console.WriteLine("Vehiculo esta apagado");
                return;
            }
            if ( EstadoVehiculo == 2)
            {
                velocidad += cuanto;
                Console.WriteLine("vas a {0} KMS / Hora", velocidad);
                return;

            }

        }
        public virtual void frenar (int cuanto)
        {
            if (piloto == null)
            {
                Console.WriteLine("No se puede frenar el vehiculo, no tiene piloto");
                return;
            }
            if (EstadoVehiculo == 0)
            {
                Console.WriteLine("Vehiculo esta apagado");
                return;
            }
            else if (EstadoVehiculo == 1)
            {
                Console.WriteLine("Vehiculo esta encendido, pero no en movimiento no puedes frenar");
                
                return;
            }

            if (velocidad - cuanto <= 0)
            {
                velocidad -= cuanto;
                EstadoVehiculo =1;
                Console.WriteLine("vas a {0} KMS / Hora, entonces tu vehiculo solo esta encendido", velocidad);
                return;
            }
            

            EstadoVehiculo = 2;
            velocidad -= cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }
        public virtual void apagar ()
        {
            if (EstadoVehiculo == 0)
            {
                Console.WriteLine("Vehiculo ya estaba apagado");
                return;
            }
            if (EstadoVehiculo == 2)
            {
                Console.WriteLine("Vehiculo esta en movimiento, no puedes apagarlo");
                return;
            }
            if (velocidad == 0)
            {
                EstadoVehiculo = 0;
                Console.WriteLine("Vehiculo apagado");
            }
           
          
        }
    }
}
