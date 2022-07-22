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
    public class OrdenCompraTransactions
    {
        private string connection = @"Server=DESKTOP-32AM9PJ\SQLEXPRESS;Initial Catalog=MegaParques;Integrated Security=true;"; 
        public List<OrdenCompra> ConsultarTodo()
        {
            List<OrdenCompra> listaDeOrdenesDeCompra;

            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlQuery = "SELECT * FROM OrdenCompra";

                listaDeOrdenesDeCompra = megaParquesDB.Query<OrdenCompra>(sqlQuery).ToList();
            }

            return listaDeOrdenesDeCompra;
        }

        public void Insertar(OrdenCompra nuevaOrdenCompra)
        {
            using (SqlConnection megaParquesDB = new SqlConnection(connection))
            {
                string sqlInsert = "INSERT INTO OrdenCompra VALUES (@Id, @IdUsuario, @FechaCompra, @FechaInstalacion, @Direccion)";

                int respuesta = megaParquesDB.Execute(sqlInsert, nuevaOrdenCompra);
            }
        }

        public void Actualizar(OrdenCompra ordenCompraActualizada)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlEdit = "UPDATE OrdenCompra SET IdUsuario=@IdUsuario, FechaCompra=@FechaCompra, FechaInstalacion=@FechaInstalacion, Direccion=@Direccion WHERE Id=@Id";
                
                int respuesta = megaParquesDB.Execute(sqlEdit, ordenCompraActualizada);
            }

        }

        public void Eliminar(int OrdenCompra)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlDelete = "DELETE OrdenCompra WHERE Id=@Id ";
                var respuesta = megaParquesDB.Execute(sqlDelete, new { Id = OrdenCompra });
            }
        }
    }
}
