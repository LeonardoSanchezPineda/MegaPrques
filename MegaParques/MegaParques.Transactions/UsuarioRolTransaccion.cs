using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaParques.wData.Model;
using Dapper;
using System.Data.SqlClient;



namespace MegaParques.Transactions
{
    public class UsuarioRolTransaccion
    {
        string connection = @"Server=DESKTOP-32AM9PJ\SQLEXPRESS;Initial Catalog=MegaParques;Integrated Security=true;";

        public List<UsuarioRol> ConsultarTodo()
        {
            List<UsuarioRol> ListaUsuarioRol;

            using (var megaParquesDB = new System.Data.SqlClient.SqlConnection(connection))
            {
                string sqlQuery = "SELECT * FROM ";

                ListaUsuarioRol = megaParquesDB.Query<UsuarioRol>(sqlQuery).ToList();
            }

            return ListaUsuarioRol;
        }
        public void Insertar(UsuarioRol nuevoUsuarioRol)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlInsert = "INSERT INTO UsuarioRol VALUES (@UsuarioRol,@IdUsuario,@IdRol)";

                var respuesta = megaParquesDB.Execute(sqlInsert, nuevoUsuarioRol);
            }
        }

        public void Actualizar(UsuarioRol UsuarioRolActualizado)
        {
            using (var megaParqueDB = new SqlConnection(connection)) 
            {
                string sqlEdit = "UPDATE UsuarioRol SET IdUsuarioRol  = @IdUsuarioRol , IdUsuario=@IdUsuario, IdRol=@IdRol WHERE Id = @Id";

                var respuesta = megaParqueDB.Execute(sqlEdit, UsuarioRolActualizado);
            }
        }
        public void Eliminar(int UsuarioRol)
        {
            using (var megaParqueDB = new SqlConnection(connection))
            {
                string sqlDelete = "DELETE  WERE IdUsuarioRol=@IdUsuarioRol";

                var respuesta = megaParqueDB.Execute(sqlDelete, new { Id = UsuarioRol });
            }
        }


    }
}
