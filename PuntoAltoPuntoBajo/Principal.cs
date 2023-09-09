using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoAltoPuntoBajo
{
    public class Principal
    {

        
        public double[] costos { get; set; }
        public double[] unidades { get; set; }
        

        public double MayorCosto()
        {
            return costos.Max();
        }

        public double MenorCosto()
        {
            return costos.Min();
        }

        public double MayorUnidad()
        {
            return unidades.Max();
        }

        public double MenorUnidad()
        {
            return unidades.Min();
        }

        // PROBANDO PROBANDO

    }
}
