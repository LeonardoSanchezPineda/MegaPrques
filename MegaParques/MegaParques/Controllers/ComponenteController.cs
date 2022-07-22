using MegaParques.Transactions;
using MegaParques.wData.Model;
using Microsoft.AspNetCore.Mvc;

namespace MegaParques.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComponenteController : ControllerBase

    {
        private readonly ILogger<ComponenteController> _logger;
        ComponenteTransactions _componenteTransaction;
        public ComponenteController(ILogger<ComponenteController> logger)
        {
            _logger = logger;

            _componenteTransaction = new ComponenteTransactions();

        }


        [HttpGet(Name = "GetComponente")]
        public IEnumerable<Componente> Get()
        {
            List<Componente> ListaDeComponenteTransaction = _componenteTransaction.ConsultarTodo();

            return ListaDeComponenteTransaction;
        }



        [HttpPost(Name = "InsertarComponente")]
        public int Insertar(Componente componente)
        {
            _componenteTransaction.Insertar(componente);

            return 1;
        }



        [HttpPut(Name = "ActualizarComponente")]
        public ActionResult Actualizar(Componente Componente)
        {
            _componenteTransaction.Actualizar(Componente);                 

            return Ok();
        }



        [HttpDelete(Name = "EliminarComponente")]
        public ActionResult Eliminar(int idComponente)
        {
            _componenteTransaction.Eliminar(idComponente);

            return Ok();
        }
    }
}
