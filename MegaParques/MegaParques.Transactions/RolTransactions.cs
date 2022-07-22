using Dapper;
using MegaParques.wData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MegaParques.Transactions
{
    public class RolTransactions
    {
        string connection = @"Server=DESKTOP-32AM9PJ\SQLEXPRESS;Initial Catalog=MegaParques;Integrated Security=true;";

        public List<Rol> ConsultarTodo()
        {
            List<Rol> ListaRol;

            using (var megaParquesDB = new System.Data.SqlClient.SqlConnection(connection))
            {
                string sqlQuery = "SELECT * FROM ";

                ListaRol = megaParquesDB.Query<Rol>(sqlQuery).ToList();
            }
            return ListaRol ;
        }
        public void Insertar(Rol nuevoRol)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlInsert = "INSERT INTO Rol VALUES (@IdRol,IdNombre)";

                var respuesta = megaParquesDB.Execute(sqlInsert, nuevoRol);
            }
        }
        public void Actualizar(Rol RolActualizado)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlEdit = "UPDATE Rol SET IdRol  = @IdRol , Nombre=@Nombre,WHERE Id = @Id";

                var respuesta = megaParquesDB.Execute(sqlEdit, RolActualizado);
            }
        }
        public void Eliminar(int Rol)
        {
            using (var megaParqueDB = new SqlConnection(connection))
            {
                string sqlDelete = "DELETE Producto WERE IdRol=@IdRol";

                var respuesta = megaParqueDB.Execute(sqlDelete, new { Id = Rol });
            }
        }
    }
}
