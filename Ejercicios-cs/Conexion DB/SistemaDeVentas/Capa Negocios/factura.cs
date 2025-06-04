using Capa_Dato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public  class factura
    {
        DFactura f = new DFactura();

        public DataTable Mostrar(int fac)
        {
            return f.verfactura (fac);
        }
    }
}
