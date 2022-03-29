using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SISTEMA_DE_DEUDA
{
    public class cliente
    {

        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public double Deudabruta { get; set; }
        public DateTime Fechadepago { get; set; }
        public DateTime Fechavencimiento { get; set; }
        public double Recargo { get; set; }
        public double Descuento { get; set; }

        public double DeudaTotal { get; set; }


        public cliente()
        { }




    }
}