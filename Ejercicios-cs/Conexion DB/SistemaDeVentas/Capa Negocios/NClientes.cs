using Capa_Dato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public  class NClientes
    {
        DClientes cliente = new DClientes();

        public DataTable MostrarClientes()
        {
            return cliente.MostrarClientes();
        }

        public void InsertarCliente(string nombre, string direccion, string telefono,string  correo)
        {
            cliente.InsertarCliente(nombre, direccion ,telefono ,correo );
        }

        public void EditarCliente(int id, string nombre, string direccion, string telefono, string correo)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del cliente no es valido");
            }

            cliente.EditarCliente(id, nombre, direccion, telefono, correo);
        }

        public void eliminarCliente(int id)
        {
            cliente.eliminarcliente(id);
        }
    }
}
