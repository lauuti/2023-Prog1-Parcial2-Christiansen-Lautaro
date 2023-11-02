using _2do_Parcial;
using BibliotecaDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

//CORRECCION: EL CONTROLE DEBE IR EN LA CARPETA CONTROLLER.
namespace WebController
{
    [Route("[controller]")]
    [ApiController]
    public class MesaController : ControllerBase
    {
        Gestion logica = new Gestion();
        [HttpDelete("{id}")]
        public IActionResult EliminarMesa(int id)
        {
            if (id == 0)
            {
                return BadRequest("No se envio la id correctamente");
            }
            //CORRECCION: EL ERROR DEL SERVICE SE ARRASTRA ACÁ.
            int res = logica.BajaMesa(id);
            if (res == 404)
            {
                return NotFound("No se encontro la mesa a eliminar");
            }
            return Ok("Se elimino la mesa correctamente");
        }

        [HttpGet]
        public IActionResult ObtenerListadoMesa()
        {
            List<Mesa> lista = logica.ObtenerListadoMesas();
            if (lista != null)
            {
                return Ok(lista);
            }
            return BadRequest("La lista esta vacia");
        }
        [HttpPost]
        public IActionResult AltaMesa([FromBody] MesaDTO mesa)
        {
            bool res = logica.AltaMesa(mesa);
            if (res == false)
            {
                //CORRECCION: NO SE DEBEN DEVOLVER TEXTOS SIN ESTAR DENTRO DE UNA CLASE
                return BadRequest("No se enviaron correctame las credenciales");

            }
            //CORRECCION: NO SE DEBEN DEVOLVER TEXTOS SIN ESTAR DENTRO DE UNA CLASE
            return Ok("La mesa se cargo correctamente");
        }
        [HttpPut("{id}")]
        public IActionResult ActualizarMesa(int id, [FromBody] MesaDTO mesa)
        {
            int res = logica.ActualizarMesa(id, mesa);
            if (res == 400)
            {
                //CORRECCION: NO SE DEBEN DEVOLVER TEXTOS SIN ESTAR DENTRO DE UNA CLASE
                return BadRequest("No se cargaron las credenciales correctamente");
            }
            if (res == 404)
            {
                //CORRECCION: NO SE DEBEN DEVOLVER TEXTOS SIN ESTAR DENTRO DE UNA CLASE
                return NotFound("no se encontro una mesa con esa id");
            }
            return Ok($"Se actualizo la informacion de la mesa con la id: {id}");
        }
        [HttpGet("{id}")]
        public IActionResult ObtenerMesa(int id)
        {
            Mesa mesa = logica.ObtenerMesa(id);
            if (mesa == null)
            {
                //CORRECCION: NO SE DEBEN DEVOLVER TEXTOS SIN ESTAR DENTRO DE UNA CLASE
                return NotFound("No se encontro la mesa con esa id");
            }
            return Ok(mesa);
        }
    }
}
