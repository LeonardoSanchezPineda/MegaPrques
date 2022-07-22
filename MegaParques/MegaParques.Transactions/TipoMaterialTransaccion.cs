using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MegaParques.wData.Model;

namespace MegaParques.Transactions
{
    public class TipoMaterialTransaccion

    {
        string connection = @"Server=DESKTOP-32AM9PJ\SQLEXPRESS;Initial Catalog=MegaParques;Integrated Security=true;";

        public List<TipoMaterial> ConsultarTodo()
        {
            List<TipoMaterial> ListaTipoMaterial;

            using (var megaParquesDB = new SqlConnection(connection)) 

            {
                string sqlQuery = "SELECT * FROM ";

                ListaTipoMaterial = megaParquesDB.Query<TipoMaterial>(sqlQuery).ToList();
          
            }
            return ListaTipoMaterial;
        }

        public void Insertar(TipoMaterial nuevoTipoMaterial)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlInsert = "INSERT INTO Componente VALUES (@IdTipoMaterial, @Nombre,@Calibre)";
                var respuesta = megaParquesDB.Execute(sqlInsert, nuevoTipoMaterial);
            }
        }
        public void Actualizar(TipoMaterial TipoMaterialActualizado)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlEdit = "UPDATE TipoMaterial SET IdTipoMaterial = @IdTipoMateria, Nombre=@Nombre , Calibre=@Calibre WHERE Id = @Id";
                var respuesta = megaParquesDB.Execute(sqlEdit, TipoMaterialActualizado);
            }
        }
        public void Eliminar(int TipoMaterial)
        {
            using (var megaParqueDB = new SqlConnection(connection))
            {
                string sqlDelete = "DELETE TipoMaterial WERE IdTipoMaterial=@IdTipoMaterial";

                var respuesta = megaParqueDB.Execute(sqlDelete, new { Id = TipoMaterial });
            }
        }
    }

}
