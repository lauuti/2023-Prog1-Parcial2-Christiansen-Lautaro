using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2do_Parcial
{
    public class ArchivoMesa
    {
        public static List<Mesa> LeerArchivo()
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mesa.json");
            if (File.Exists(ruta))
            {
                string json = File.ReadAllText(ruta);
                return JsonConvert.DeserializeObject<List<Mesa>>(json);
            }
            else
                return new List<Mesa>();
        }
      public static void GuardarArchivo(Mesa mesa)
      {
        List<Mesa> lista = LeerArchivo();
        if (mesa.id != 0)
        {
            lista.RemoveAll(x => x.id == mesa.id);
        }
        lista.Add(mesa);
        string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mesa.json");
        string json = JsonConvert.SerializeObject(lista,(Newtonsoft.Json.Formatting)System.Xml.Formatting.Indented);
        File.WriteAllText(ruta, json);
      }
        public static void Guardar(List<Mesa> mesa)
        {
            string json = JsonConvert.SerializeObject(mesa);
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Mesa.json");
            File.WriteAllText(ruta, json);
        }
    }

}
