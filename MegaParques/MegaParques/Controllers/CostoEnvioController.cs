using MegaParques.Transactions;
using MegaParques.wData.Model;
using Microsoft.AspNetCore.Mvc;


namespace MegaParques.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CostoEnvioController : ControllerBase
    {
        private readonly ILogger<CostoEnvioController> _logger;
        CostoEnvioTransaccion costoEnvioTransactions;
        public CostoEnvioController(ILogger<CostoEnvioController> logger)
        {
            _logger = logger;
            costoEnvioTransactions = new CostoEnvioTransaccion();
        }
        [HttpGet(Name = "GetCostoEnvio")]
        public IEnumerable<CostoEnvio> Get()
        {
            List<CostoEnvio> listaCostoEnvio = costoEnvioTransactions.ConsultarTodo();
            return listaCostoEnvio;
        }



        [HttpPost(Name = "InsertarCostoEnvio")]

        public ActionResult Insertar(CostoEnvio costoEnvio)
        {
            costoEnvioTransactions.Insertar(costoEnvio);
            return Ok();
        }



        [HttpPut(Name = "ActualizarCostoEnvio")]

        public ActionResult Actualizar(CostoEnvio costoEnvio)
        {
            costoEnvioTransactions.Actualizar(costoEnvio);

            return Ok();
        }



        [HttpDelete(Name = "EliminarCostoEnvio")]

        public ActionResult Eliminar(int IdCostoEnvio)
        {
            costoEnvioTransactions .Eliminar(IdCostoEnvio);

            return Ok();
        }
    }
    
}
