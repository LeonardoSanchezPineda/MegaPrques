using MegaParques.Transactions;
using MegaParques.wData.Model;
using Microsoft.AspNetCore.Mvc;

namespace MegaParques.Controllers 
{

    [ApiController]
    [Route("[controller]")]
    public class DetalleOrdenCompraController: ControllerBase
    {
        private readonly ILogger<DetalleOrdenCompraController> _logger;
        DetalleOrdenCompraTransaction detalleOrdenCompraTransaction;
        public DetalleOrdenCompraController(ILogger<DetalleOrdenCompraController> logger)
        {
            _logger = logger;
            detalleOrdenCompraTransaction = new DetalleOrdenCompraTransaction ();
        }

        [HttpGet(Name = "GetDetalleOrdenCompra")]
        public IEnumerable<DetalleOrdenCompra> Get()

        {
            List<DetalleOrdenCompra> ListaDetalleOrdenCompra = detalleOrdenCompraTransaction.ConsultarTodo();

            return ListaDetalleOrdenCompra;
        }

        [HttpPost(Name = "InsertarDetalleOrdenCompra")]
      
           public ActionResult Insertar(DetalleOrdenCompra detalleOrdenCompra)
           {
             detalleOrdenCompraTransaction.Insertar(detalleOrdenCompra);
             return Ok();
            
           }

            [HttpPut(Name = "ActualizarDetalleOrdenCompra")]
            public ActionResult Actualizar(DetalleOrdenCompra DetalleOrdenCompra)

            {
             detalleOrdenCompraTransaction.Actualizar(DetalleOrdenCompra);
              return Ok();

            }


             [HttpDelete(Name = "EliminarDetalleOrdenCompra")]
             public ActionResult Eliminar(int IdDetalleOrdenCompra)

             {
               detalleOrdenCompraTransaction.Eliminar(IdDetalleOrdenCompra);
               return Ok();
            
             }

    }
}
