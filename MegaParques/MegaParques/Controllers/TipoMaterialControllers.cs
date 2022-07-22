using MegaParques.Transactions;
using MegaParques.wData.Model;
using Microsoft.AspNetCore.Mvc;


namespace MegaParques.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoMaterialControllers : ControllerBase
    {
        private readonly ILogger<TipoMaterialControllers> _logger;
        TipoMaterialTransaccion TipoMaterialTransactions;
        public TipoMaterialControllers(ILogger<TipoMaterialControllers> logger)
        {
            _logger = logger;

            TipoMaterialTransactions = new TipoMaterialTransaccion();
        }

        [HttpGet(Name = "GetTipoMaterial")]
        public IEnumerable<TipoMaterial> Get()
        {
            List<TipoMaterial> listaDeTipoMaterial = TipoMaterialTransactions.ConsultarTodo();
            return listaDeTipoMaterial;
        }
        [HttpPost(Name = "InsertarTipoMaterial")]
        public ActionResult Insertar(TipoMaterial tipoMaterial)
        {
            TipoMaterialTransactions.Insertar(tipoMaterial);
            return Ok();
        }
        [HttpPut(Name = "ActualizarTipoMaterial")]
        public ActionResult Actualizar(TipoMaterial tipoMaterial)
        {
            TipoMaterialTransactions.Actualizar(tipoMaterial);
            return Ok();
        }
        [HttpDelete(Name = "EliminarIdTipoMaterial")]
        public ActionResult Eliminar(int IdTipoMaterial)
        {
            TipoMaterialTransactions.Eliminar(IdTipoMaterial);
            return Ok();
        }
    }

   
}
