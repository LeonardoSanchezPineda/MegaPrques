using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaParques.wData.Model
{
    public class OrdenCompra
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaInstalacion { get; set; }
        public string Direccion { get; set; }
    }
}
