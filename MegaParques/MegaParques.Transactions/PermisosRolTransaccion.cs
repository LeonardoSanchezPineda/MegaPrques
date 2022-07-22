using MegaParques.wData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace MegaParques.Transactions
{
    public class PermisosRolTransaccion
    {
        string connection = @"Server=DESKTOP-32AM9PJ\SQLEXPRESS;Initial Catalog=MegaParques;Integrated Security=true;";

        public List<PermisosRol> ConsultarTodo()
        {
            List<PermisosRol> ListaPermisosRol;

            using (var megaParquesDB = new SqlConnection(connection)) 
            {
                string sqlQuery = "SELECT * FROM PermisosRol ";

                ListaPermisosRol = megaParquesDB.Query<PermisosRol>(sqlQuery).ToList();
            }
            return ListaPermisosRol;
        }


        public void Insertar(PermisosRol nuevoPermisosRol)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlInsert = "INSERT INTO PermisosRol VALUES (@Id,@IdRol,@IdPermiso)";

                var respuesta = megaParquesDB.Execute(sqlInsert, nuevoPermisosRol);
            }
        }
        public void Actualizar(PermisosRol PermisosRolActualizado)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlEdit = "UPDATE PermisosRol SET  IdRol=@IdRol , IdPermiso=@IdPermiso WHERE Id = @Id";

                var respuesta = megaParquesDB.Execute(sqlEdit, PermisosRolActualizado);
            }
        }
        public void Eliminar(int PermisosRol)
        {
            using (var megaParqueDB = new SqlConnection(connection))
            {
                string sqlDelete = "DELETE PermisosRol WERE IdPermisosRol=@IdPermisosRoll";

                var respuesta = megaParqueDB.Execute(sqlDelete, new { Id = PermisosRol });
            }
        }
    }   
}
