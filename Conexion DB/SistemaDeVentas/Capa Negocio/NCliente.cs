using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class NCliente
    {
        DCliente cliente = new DCliente();

        public DataTable MostrarCliente()
        {
            return cliente.MostrarClientes();
        }
     
    }
}
