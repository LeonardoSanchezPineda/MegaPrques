using MegaParques.Transactions;
using MegaParques.wData.Model;
using Microsoft.AspNetCore.Mvc;



namespace MegaParques.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PermisosRolControllers : ControllerBase
    {
        private readonly ILogger<PermisosRolControllers> _logger;
        PermisosRolTransaccion permisosRolTransactions;
        public PermisosRolControllers(ILogger<PermisosRolControllers> logger)
        {
            _logger = logger;
            permisosRolTransactions = new  PermisosRolTransaccion();
        }


        [HttpGet(Name = "GetPermisosRol")]
        public IEnumerable<PermisosRol> Get()
        {
            List<PermisosRol> listaPermisosRol = permisosRolTransactions.ConsultarTodo();

            return listaPermisosRol;
        }


        [HttpPost(Name = "InsertarPermisosRol")]

        public ActionResult Insertar(PermisosRol permisosRol)
        {
            permisosRolTransactions.Insertar(permisosRol);

            return Ok();
        }


        [HttpPut(Name = "ActualizarPermisosRol")]

        public ActionResult Actualizar(PermisosRol permisosRol)
        {
            permisosRolTransactions.Actualizar(permisosRol);

            return Ok();
        }



        [HttpDelete(Name = "EliminarPermisosRol")]

        public ActionResult Eliminar(int IdPermisosRol)
        {
            permisosRolTransactions.Eliminar(IdPermisosRol);

            return Ok();
        }
    }
}
