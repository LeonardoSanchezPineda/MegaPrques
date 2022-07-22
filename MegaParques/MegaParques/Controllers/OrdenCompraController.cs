using MegaParques.Transactions;
using MegaParques.wData.Model;
using Microsoft.AspNetCore.Mvc;

namespace MegaParques.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdenCompraController : ControllerBase
    {
        private readonly ILogger<OrdenCompraController> _logger;
        OrdenCompraTransactions ordenCompraTransactions;
        public OrdenCompraController(ILogger<OrdenCompraController> logger)
        {
            _logger = logger;
            ordenCompraTransactions = new OrdenCompraTransactions();
        }

        [HttpGet(Name = "GetOrdenCompra")]
        public IEnumerable<OrdenCompra> Get()
        {
            List<OrdenCompra> listaDeOrdenesDeCompra = ordenCompraTransactions.ConsultarTodo();
            return listaDeOrdenesDeCompra;
        }

        [HttpPost(Name = "InsertarOrdenCompra")]
        public ActionResult Insertar(OrdenCompra ordenCompra)
        {
            ordenCompraTransactions.Insertar(ordenCompra);
            return Ok();
        }

        [HttpPut(Name = "ActualizarOrdenCompra")]
        public ActionResult Actualizar(OrdenCompra ordenCompra)
        {
            ordenCompraTransactions.Actualizar(ordenCompra);
            return Ok();
        }

        [HttpDelete(Name = "EliminarOrdenCompra")]
        public ActionResult Eliminar(int idOrdenCompra)
        {
            ordenCompraTransactions.Eliminar(idOrdenCompra);
            return Ok();
        }
    }
}