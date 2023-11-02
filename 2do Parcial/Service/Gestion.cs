using _2do_Parcial;
using BibliotecaDTO;
using System.ComponentModel;

namespace Service
{
    public class Gestion
    {
        //CORRECCION: ESTO DEBIA DEVOLVER LAS VALIDACIONES CON ERROR, ESTA MAL EL TIPO DE DATOS DE RESPUESTA
        public bool AltaMesa(MesaDTO mesa)
        {
            resultado res = mesa.Validar();
            if (res.Exito == true)
            {
                Mesa mesaDB = new Mesa { id = ArchivoMesa.LeerArchivo().Count() + 1, CantidadPersonas = mesa.CantidadPersonas, FechaEliminacion = DateTime.Parse(mesa.FechaEliminacion), Marca = mesa.Marca, Material = (MaterialMesa)mesa.Material, Nombre = mesa.Nombre, Precio = mesa.Precio, Stock = mesa.Stock, Tamaño = mesa.Tamaño };
                ArchivoMesa.GuardarArchivo(mesaDB);
                return true;
            };
            return false;
        }
        public int BajaMesa(int id)
        {

                List<Mesa> lista = ArchivoMesa.LeerArchivo();
                Mesa mesaDB = lista.FirstOrDefault(x => x.id == id);
                if (mesaDB == null)
                {
                    return 404;
                }
                lista.Remove(mesaDB);
                ArchivoMesa.Guardar(lista);
                return 200;
            
            
        }
        //CORRECCION: ESTO DEBIA DEVOLVER LAS VALIDACIONES CON ERROR, ESTA MAL EL TIPO DE DATOS DE RESPUESTA
        public int ActualizarMesa(int id, MesaDTO mesa)
        {
            resultado res = mesa.Validar();
            if (res.Exito == false)
            {
                return 400;
            }
            List<Mesa> lista = ArchivoMesa.LeerArchivo();
            Mesa MesaDB = lista.FirstOrDefault(x => x.id == id);
            if (MesaDB == null)
            {
                return 404;
            }
            MesaDB.Nombre = mesa.Nombre;
            MesaDB.Material =(MaterialMesa)mesa.Material;
            MesaDB.Tamaño = mesa.Tamaño;
            MesaDB.CantidadPersonas = mesa.CantidadPersonas;
            MesaDB.FechaEliminacion = DateTime.Parse(mesa.FechaEliminacion);
            MesaDB.Stock = mesa.Stock;
            MesaDB.Precio = mesa.Precio;
            MesaDB.Marca = mesa.Marca;
            ArchivoMesa.GuardarArchivo(MesaDB);
            return 200;
        }
        public List<Mesa> ObtenerListadoMesas()
        {
             List<Mesa> lista = ArchivoMesa.LeerArchivo();
            return lista;

        }
        public Mesa ObtenerMesa(int id)
        {
            List<Mesa> lista = ArchivoMesa.LeerArchivo();
            Mesa mesaDB = lista.FirstOrDefault(x => x.id == id);
            if (mesaDB == null)
            {
                return null;
            }

            return mesaDB;
        }
    }
        
        //CORRECCION: ESPACIOS INNECESARIOS
    
}

            


   
