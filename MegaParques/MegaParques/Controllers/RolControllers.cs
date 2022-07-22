using MegaParques.Transactions;
using MegaParques.wData.Model;
using Microsoft.AspNetCore.Mvc;



namespace MegaParques.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class RolController : ControllerBase
    {
        private readonly ILogger<RolController> _logger;
        RolTransactions rolTransactions;

        public RolController(ILogger<RolController> logger)
        {
            _logger = logger;
            rolTransactions = new RolTransactions();
        }

        [HttpGet(Name = "GetRol")]
        public IEnumerable<Rol> Get()
        {
            List<Rol> listaRol = rolTransactions.ConsultarTodo();

            return listaRol;
        }


        [HttpPost(Name = "InsertarRol")]
        public int Insertar(Rol rol)
        {
            rolTransactions.Insertar(rol);

            return 2;
        }

        [HttpPut(Name = "ActualizarRol")]
        public ActionResult Actualizar(Rol Rol)
        {
            rolTransactions.Actualizar(Rol);

            return Ok();
        }
        [HttpDelete(Name = "EliminarRol")]
        public ActionResult Eliminar(int IdRol)
        {
            rolTransactions.Eliminar(IdRol);

            return Ok();
        }

    }
}
