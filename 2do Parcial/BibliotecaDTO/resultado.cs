using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDTO
{
    public class resultado
    {
        public bool Exito { get; set; }
        public List<string> Mensaje { get; set; }
        public resultado()
        {
            Mensaje = new List<string>();
        }
    }
}
