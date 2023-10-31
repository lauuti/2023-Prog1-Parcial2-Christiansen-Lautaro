using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_Parcial
{
    public class Mesa : Mueble
    {
        public int Tamaño { get; set; }
        public MaterialMesa Material { get; set; }
        public int CantidadPersonas { get; set; }
    }
}
