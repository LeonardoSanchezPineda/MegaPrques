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
    public class ComponenteTransactions
    {
        private string connection = @"Server=DESKTOP-32AM9PJ\SQLEXPRESS;Initial Catalog=MegaParques;Integrated Security=true;";
       

        public List<Componente> ConsultarTodo()
        {
            List<Componente> listaComponente;

            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlQuery = "SELECT * FROM Componente";

                listaComponente = megaParquesDB.Query<Componente>(sqlQuery).ToList();
            }

            return listaComponente;
        }

        public void Insertar(Componente nuevoComponente)
        {
            using (var megaParquesDB = new SqlConnection(connection))
            {
                string sqlInsert = "INSERT INTO Componente VALUES (@IdComponente, @IdProducto, @NombreParque, @Descripcion)";

                var respuesta = megaParquesDB.Execute(sqlInsert,nuevoComponente);
            }
        }

        public void Actualizar (Componente componenteActualizado)
        {
            using (var megaParqueDB= new SqlConnection(connection))
            {
               string sqlEdit= "UPDATE Componente SET Id = @IdComponente, IdProducto=@IdProducto , NombreParque=@NombreParque, Descripcion=@Descripcion WHERE Id = @IdComponente";

              var respuesta = megaParqueDB.Execute(sqlEdit, componenteActualizado);
            }
        }



        public void Eliminar (int Componente)
        { 
                  using (var megaParqueDB= new SqlConnection(connection))
                  {
                    string sqlDelete = "DELETE Componente WHERE IdComponente=@IdComponente";

                    var respuesta = megaParqueDB.Execute(sqlDelete, new { Id = Componente });
                  }

        }
    }

}
