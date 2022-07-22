using MegaParques.Transactions;
using MegaParques.wData.Model;
using Microsoft.AspNetCore.Mvc;



namespace MegaParques.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioRolController : ControllerBase
    {


        private readonly ILogger<UsuarioRolController>  _logger;
        UsuarioRolTransaccion usuarioRolTransaction;
        public UsuarioRolController(ILogger<UsuarioRolController> logger)
        {
            _logger = logger;
            usuarioRolTransaction = new UsuarioRolTransaccion();
        }
       


        [HttpGet(Name = "GetUsuarioRol")]
        public IEnumerable<UsuarioRol> Get(UsuarioRolTransaccion usuarioRolTransaccion)
        {
            List<UsuarioRol> ListaUsuarioRolTransaction = usuarioRolTransaccion.ConsultarTodo();

            return ListaUsuarioRolTransaction;
        }




        [HttpPost(Name = "InsertarUsuarioRol")]
        public ActionResult Insertar(UsuarioRol usuarioRol)
        {
            usuarioRolTransaction.Insertar(usuarioRol);
            return Ok();
        }



        [HttpPut(Name = "ActualizarUsuarioRol")]
        public ActionResult Actualizar(UsuarioRol usuarioRol)
        {
            usuarioRolTransaction.Actualizar(usuarioRol);
            return Ok();
        }



        [HttpDelete(Name = "EliminarUsuarioRol")]
        public ActionResult Eliminar(int IdUsuarioRol)
        {
            usuarioRolTransaction.Eliminar(IdUsuarioRol);
            return Ok();
        }

    }
   
    
   
}
