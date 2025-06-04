using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public  class NCategoria
    {
        DCategoria categoriaData = new DCategoria();

        public DataTable MostrarCat()
        {
           return  categoriaData.MostrarCategoria();
        }
    }
}
