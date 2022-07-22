using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaParques.wData.Model
{
    public class DetalleOrdenCompra
    {   
    public int IdDetalleOrdenCompra { get; set; }
    public int IdOrdenCompra { get; set; }
    public int IdProducto { get; set; }
    public string Cantidad { get; set; }
    }
}
