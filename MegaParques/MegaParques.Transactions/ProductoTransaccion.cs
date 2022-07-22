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
    public class ProductoTransaccions
    {
        string connection = @"Server=DESKTOP-32AM9PJ\SQLEXPRESS;Initial Catalog=MegaParques;Integrated Security=true;";

        public List<Producto> ConsultarTodo()
        {
            List<Producto> ListaProducto;

            using (var megaParquesDB = new System.Data.SqlClient.SqlConnection(connection))
            {
                string sqlQuery = "SELECT * FROM Producto";

                ListaProducto = megaParquesDB.Query<Producto>(sqlQuery).ToList();
            }
            return ListaProducto;



        }


        public void Insertar(Producto nuevoProducto)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlInsert = "INSERT INTO Producto VALUES (@Id, @Nombre,@Medida,@IdTipoMaterial,@Color,@IdComponente,@Compuesto)";

                var respuesta = megaParquesDB.Execute(sqlInsert, nuevoProducto);
            }
        }
        public void Actualizar(Producto ProductoActualizado)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlEdit = "UPDATE Producto SET IdProducto  = @IdProducto , Nombre=@Nombre , IdMedida=@IdMedida, IdCostoEnvio=@IdCostoEnvio,Color=@Color,IdComponente=@IdComponente,IdCompuesto=@IdCompuesto WHERE Id = @Id";

                var respuesta = megaParquesDB.Execute(sqlEdit, ProductoActualizado);
            }
        }
        public void Eliminar(int Producto)
        {
            using (var megaParqueDB = new SqlConnection(connection))
            {
                string sqlDelete = "DELETE Producto WHERE IdProducto=@IdProducto";

                var respuesta = megaParqueDB.Execute(sqlDelete, new { Id = Producto });
            }
        }
    }
}
