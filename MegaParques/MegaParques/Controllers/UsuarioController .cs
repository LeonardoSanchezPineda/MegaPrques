using MegaParques.Transactions;
using MegaParques.wData.Model;
using Microsoft.AspNetCore.Mvc;



namespace MegaParques.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        UsuarioTransaccion usuarioTransaction;
        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
            usuarioTransaction = new UsuarioTransaccion();
        }


        [HttpGet(Name = "GetUsuario")]
        public IEnumerable<Usuario> Get(UsuarioTransaccion usuarioTransaccion)
        {
            List<Usuario> ListaUsuarioTransaction = usuarioTransaccion.ConsultarTodo();

            return ListaUsuarioTransaction;
        }


        [HttpPost(Name = "InsertarUsuario")]
        public ActionResult Insertar(Usuario usuario)
        {
            usuarioTransaction.Insertar(usuario);
            return Ok();
        }


        [HttpPut(Name = "ActualizarUsuario")]
        public ActionResult Actualizar(Usuario usuario)
        {
            usuarioTransaction.Actualizar(usuario);
            return Ok();
        }


        [HttpDelete(Name = "EliminarUsuario")]
        public ActionResult Eliminar(int IdUsuario)
        {
            usuarioTransaction.Eliminar(IdUsuario);
            return Ok();
        }
    }
}
