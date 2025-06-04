using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public  class NCliente
    {
        DCliente clienteData = new DCliente();  

        public DataTable mostrar()
        {
            return clienteData.MostrarClientes();
        }

        public void inserCliente(string nombre, string telefono, string direccion, string correo)
        {
            clienteData.inserCliente(nombre, telefono, direccion, correo);
        }

        public void editCliente(int id, string nombre, string telefono, string direccion, string correo)
        {
            clienteData.editCliente(id, nombre, telefono,direccion, correo);
        }
        
        public void deleted(int id)
        {
            clienteData.eliminarclient(id);
        }

        
    }
}
