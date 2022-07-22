using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MegaParques.wData.Model;
using System.Data.SqlClient;

namespace MegaParques.Transactions
{
    public class UsuarioTransaccion
    {
        string connection = @"Server=DESKTOP-32AM9PJ\SQLEXPRESS;Initial Catalog=MegaParques;Integrated Security=true;";

        public List<Usuario> ConsultarTodo()
        {
            List<Usuario> ListaUsuario;

            using (var megaParquesDB = new System.Data.SqlClient.SqlConnection(connection))
            {
                string sqlQuery = "SELECT * FROM ";

                ListaUsuario = megaParquesDB.Query<Usuario>(sqlQuery).ToList();
            }
            return ListaUsuario;
        }
        public void Insertar(Usuario nuevoUsuario)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlInsert = "INSERT INTO Usuario VALUES (@Usuario,@Identificacion,@Nombre,@Telefono,@ClaveAcceso)";

                var respuesta = megaParquesDB.Execute(sqlInsert, nuevoUsuario);
            }

        }
        public void Actualizar(Usuario UsuarioActualizado)
        {
            using (var megaParqueDB = new SqlConnection(connection))
            {
                string sqlEdit = "UPDATE Usuario SET IdUsuario  = @IdUsuario , Identificacion=@Identificacion, Nombre=@Nombre,Telefono=@Telefono,ClaveAcceso=@ClaveAcceso WHERE Id = @Id";

                var respuesta = megaParqueDB.Execute(sqlEdit, UsuarioActualizado);
            }

        }
        public void Eliminar(int Usuario)
        {
            using (var megaParqueDB = new SqlConnection(connection))
            {
                string sqlDelete = "DELETE  WERE IdUsuario=@IdUsuario";

                var respuesta = megaParqueDB.Execute(sqlDelete, new { Id = Usuario });
            }
        }
    }
}
