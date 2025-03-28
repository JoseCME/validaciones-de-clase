using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.Interfaces
{
    internal interface IPiloto
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        string TipoLicencia { get; set; }//A, B, C, D, M
        void MostrarInformacion();
    }
}
