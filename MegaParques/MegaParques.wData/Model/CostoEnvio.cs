using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaParques.wData.Model
{
    public class CostoEnvio
    {
        public int IdcostoEnvio { get; set; }
        public int IdTipoMaterial { get; set; }
        public string Precio { get; set; }
        public string Ciudad { get; set; }

    }
}
