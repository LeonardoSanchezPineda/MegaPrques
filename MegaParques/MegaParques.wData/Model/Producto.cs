using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaParques.wData.Model
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Medida { get; set; }
        public int IdTipoMaterial { get; set; }
        public string Color { get; set; }
        public int IdComponente { get; set; }

        public Boolean Compuesto { get; set; }

    }
}
