using MegaParques.Transactions;
using MegaParques.wData.Model;
using Microsoft.AspNetCore.Mvc;


namespace MegaParques.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoControllers : ControllerBase
    {
        private readonly ILogger<ProductoControllers> _logger;
        ProductoTransaccions productoTransactions;
        public ProductoControllers(ILogger<ProductoControllers> logger)
        {
            _logger = logger;
            productoTransactions = new ProductoTransaccions();
        }


        [HttpGet(Name = "GetProducto")]
        public IEnumerable<Producto> Get()
        {
            List<Producto> listaProducto = productoTransactions.ConsultarTodo();
            return listaProducto;
        }

       


        [HttpPost(Name = "InsertarProducto")]

        public ActionResult Insertar(Producto producto)
        {
            productoTransactions.Insertar(producto);

            return Ok();
        }

        [HttpPut(Name = "ActualizarProducto")]

        public ActionResult Actualizar(Producto producto)
        {
            productoTransactions.Actualizar(producto);

            return Ok();
        }

        [HttpDelete(Name = "EliminarProducto")]

        public ActionResult Eliminar(int IdProducto)
        {

            productoTransactions.Eliminar(IdProducto);

            return Ok();
        }
    }
}