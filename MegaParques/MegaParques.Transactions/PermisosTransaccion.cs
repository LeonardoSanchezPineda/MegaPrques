using MegaParques.wData.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace MegaParques.Transaccion
{
    public class PermisosTansaccion
    {
        private string connection = @"Server=DESKTOP-32AM9PJ\SQLEXPRESS;Initial Catalog=MegaParques;Integrated Security=true;";


        public List<Permiso> ConsultarTodo()
        {
            List<Permiso> listaPermisos;

            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlQuery = "SELECT * FROM ";

                listaPermisos = megaParquesDB.Query<Permiso>(sqlQuery).ToList();

            }
            return listaPermisos;
        }
        public void Insertar(Permiso nuevoPermiso)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlInsert = "INSERT INTO Permisos VALUES (@Id, @NombrePermiso,@NombreTabla, @AccionTabla)";
                var respuesta = megaParquesDB.Execute(sqlInsert, nuevoPermiso);

            }
        }
        public void Actualizar(Permiso PermisoActualizado)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlEdit = "UPDATE Permisos SET Id = @Id, NombrePermiso=@NombrePermiso , NombreTabla=@NombreTabla, AccionTabla=@AccionTabla WHERE Id = @Id";
                var respuesta = megaParquesDB.Execute(sqlEdit, PermisoActualizado);
            }
        }

        public void Eliminar(int Permisos)
        {
            using (var megaParqueDB = new SqlConnection(connection))
            {
                string sqlDelete = "DELETE Permisos WHERE Id=@Id";

                var respuesta = megaParqueDB.Execute(sqlDelete, new { Id = Permisos });
            }
        }
    }
}

