using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public  class NCliente
    {
        DCliente clientedata = new DCliente();

        public DataTable Mostrar()
        {
            return clientedata.MostrarCliente();
        }

        public void insertarClient(string nombre, string telefono, string correo, string direccion)
        {
            clientedata.InsertarCliente(nombre, telefono, correo, direccion);
        }

        public void edit(int id, string nombre, string telefono, string correo, string direccion)
        {
            clientedata.EditarCliente(id, nombre, telefono, correo, direccion);
        }

        public void delete(int id)
        {
            clientedata.Borrar(id);
        }
    }
}
