
using MegaParques.Transaccion;
using MegaParques.Transactions;
using MegaParques.wData.Model;
using Microsoft.AspNetCore.Mvc;



namespace MegaParques.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PermisosControllers : ControllerBase
    {
        private readonly ILogger<PermisosControllers> _logger;
        PermisosTansaccion permisosTransactions;
        public PermisosControllers(ILogger<PermisosControllers> logger)
        {
            _logger = logger;
            permisosTransactions = new PermisosTansaccion();
        }


        [HttpGet(Name = "GetPermisos")]
        public IEnumerable<Permiso> Get()
        {
            List<Permiso> listaPermisos = permisosTransactions.ConsultarTodo();

            return listaPermisos;
        }

        [HttpPost(Name = "InsertarPermisos")]
        public ActionResult Insertar(Permiso permisos)
        {
            permisosTransactions.Insertar(permisos);

            return Ok();
        }

        [HttpPut(Name = "ActualizarPermisos")]

        public ActionResult Actualizar(Permiso permisos)
        {
            permisosTransactions.Actualizar(permisos);

            return Ok();
        }


        [HttpDelete(Name = "EliminarPermisos")]

        public ActionResult Eliminar(int IdPermisos)
        {
            permisosTransactions.Eliminar(IdPermisos);

            return Ok();
        }
    }

}
