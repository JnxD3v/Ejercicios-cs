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
    public  class NLibro
    {
        private DLibro dLibros = new DLibro();

        public DataTable MostrasLibros()
        {

            return dLibros.MostrarLibros();
        }

        public void InsertarLibro(string nombre, int idCategoria, decimal precio, int stock)
        {
            dLibros.InsertarLibro(nombre, idCategoria, precio.ToString(), stock.ToString());
        }

        public void EditarLibro(int idLibro, string nombre, int idCategoria, decimal precio, int stock)
        {
            if (idLibro <= 0)
            {
                throw new ArgumentException("El ID del libro no es válido");
            }

           dLibros.EditarLibro(idLibro, nombre, idCategoria, precio, stock);
        }


        public void EliminarLibro(int id)
        {
            dLibros.EliminarLibro(id);
        }

      
    }
}
