using Dapper;
using MegaParques.wData.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaParques.Transactions
{
    public class CostoEnvioTransaccion
    {
        private string connection = @"Server=DESKTOP-32AM9PJ\SQLEXPRESS;Initial Catalog=MegaParques;Integrated Security=true;";

        public List<CostoEnvio> ConsultarTodo()
        { 
            List<CostoEnvio> listaCostoEnvio;

            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlQuery = "SELECT * FROM CostoEnvio";

                listaCostoEnvio = megaParquesDB.Query<CostoEnvio>(sqlQuery).ToList();
            }

            return listaCostoEnvio;
        }
        public void Insertar(CostoEnvio nuevoCostoEnvio)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlInsert = "INSERT INTO Componente VALUES (@IdCostoEnvio, @IdTipoMaterial, @Precio, @Ciudad)";

                var respuesta = megaParquesDB.Execute(sqlInsert, nuevoCostoEnvio);
            }
        }

        

        public void Actualizar(CostoEnvio costoEnvioActualizo)
        {
            using (var megaParqueDB = new SqlConnection(connection))
            {
                string sqlEdit = "UPDATE CostoEnvio SET IdCostoEnvio = @IdCostoEnvio, IdTipoMaterial=@IdTipoMaterial , Precio=@Precio, Ciudad=@Ciudad WHERE IdCostoEnvio = @IdCostoEnvio";

                var respuesta = megaParqueDB.Execute(sqlEdit, costoEnvioActualizo);
            }
        }

        public void Eliminar (int idCostoEnvio)
        {
            using (var megaParqueDB = new SqlConnection(connection))
            {
                string sqlDelete = "DELETE CostoEnvio WHERE IdCostoEnvio = @idCostoEnvio";
                var respuesta = megaParqueDB.Execute(sqlDelete, new { IdCostoEnvio = idCostoEnvio });
            }
        }

    }
}
