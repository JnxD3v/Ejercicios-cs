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
    public class NArticulos
    {
        DAriticulo darticulo = new DAriticulo();
        public DataTable MostrarArticulos()
        {
            return darticulo.Mostrar();
        }

        public void addArticulo(string nombre, decimal precio, int stock)
        {
            darticulo.AddProducto(nombre, precio, stock);
        }

        public void editProd(int id, string nombre, decimal precio, int stock)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El ID del cliente no es valido");
            }

            darticulo.editProduc(id, nombre, precio, stock);
        }

        public void deleteProd(int id) 
        {
            darticulo.eliminanr(id);
        }
            
    }
}
