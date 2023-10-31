using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_Parcial
{
    public class Sofa : Mueble
    {
        public int tamañoMts { get; set; }
        public MaterialSofa Material { get; set; }
        public int NroPlazas { get; set; }
    }
}
