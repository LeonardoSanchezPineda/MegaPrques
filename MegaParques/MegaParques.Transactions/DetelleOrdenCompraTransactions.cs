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
    public class DetalleOrdenCompraTransaction
    {
         string connection = @"Server=DESKTOP-32AM9PJ\SQLEXPRESS;Initial Catalog=MegaParques;Integrated Security=true;";

        public List<DetalleOrdenCompra> ConsultarTodo()

        {
            List<DetalleOrdenCompra> listaDetalleOrdenCompra;

            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlQuery = "SELECT * FROM DetalleOrdenCompra";
                listaDetalleOrdenCompra = megaParquesDB.Query<DetalleOrdenCompra>(sqlQuery).ToList();
              
            }
            return listaDetalleOrdenCompra;
        }
        public void Insertar(DetalleOrdenCompra nuevoDetalleOrdenCompra)
        { 
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlInsert = "INSERT INTO DetalleOrdenCompra VALUES (@IdDetalleOrdenCompra, @IdOrdenCompra,@IdProducto, @Cantidad)";
                var respuesta= megaParquesDB.Execute(sqlInsert,nuevoDetalleOrdenCompra);
            }
        } 
            public void Actualizar(DetalleOrdenCompra DetalleOrdenCompraActualizado)
            {  
                using (var megaParquesDB = new SqlConnection(connection))
                {
                    string sqlEdit = "UPDATE DetalleOrdenCompra SET IdDetalleOrdenCompra = @IdDetalleOrdenCompra, IdOrdenCompra=@IdOrdenCompra , IdProducto=@IdProducto, Cantidad=@Cantidad WHERE IdDetalleOrdenCompra = @IdDetalleOrdenCompra";
                    var respuesta = megaParquesDB.Execute(sqlEdit, DetalleOrdenCompraActualizado);                    
                }
            }   
            



   
           public void Eliminar(int idDetalleOrdenCompra)
           {

               using (var megaParqueDB = new SqlConnection(connection))
               {
                    string sqlDelete = "DELETE DetalleOrdenCompra WHERE IdDetalleOrdenCompra=@idDetalleOrdenCompra";
                    var respuesta= megaParqueDB.Execute(sqlDelete, new { IdOrdenCompra = idDetalleOrdenCompra });
               }
           }
}   }      
