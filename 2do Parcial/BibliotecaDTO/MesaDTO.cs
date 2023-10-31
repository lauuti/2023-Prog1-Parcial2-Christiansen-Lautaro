using _2do_Parcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BibliotecaDTO
{
    public class MesaDTO
    {
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public string FechaEliminacion { get; set; }
        public int Tamaño { get; set; }
        public MaterialMesa Material { get; set; }
        public int CantidadPersonas { get; set; }

        public resultado Validar()
        {
            resultado res = new resultado();
            if (Nombre == default)
            {
                res.Mensaje.Add("no se agrego el Nombre");
            }
            if (Marca == default)
            {
                res.Mensaje.Add("no se agrego la marca");
            }
            if (Precio == 0)
            {
                res.Mensaje.Add("no se agrego el precio");
            }
            if (Stock == 0)
            {
                res.Mensaje.Add("no se agrego el stock");
            }
            if (FechaEliminacion == default)
            {
                res.Mensaje.Add("no se agrego la fecha de eliminacion");
            }
            if (Tamaño == 0)
            {
                res.Mensaje.Add("no se agrego el tamaño");
            }
            if (Material == default)
            {
                res.Mensaje.Add("no se agrego el material");
            }
            if (CantidadPersonas == 0)
            {
                res.Mensaje.Add("no se agrego la cantidad de personas");
            }
            if (res.Mensaje.Count() != 0)
            {
                res.Exito = false;
                return res;
            }
            res.Exito = true;
            return res;
        }
    }
}
