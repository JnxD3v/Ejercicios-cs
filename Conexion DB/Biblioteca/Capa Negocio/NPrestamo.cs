using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public  class NPrestamo
    {
        DPrestamo prestamoData = new DPrestamo();

        public DataTable Mostrar()
        {
            return prestamoData.Mostrar();
        }

        public void InsertarPrestamo(int idCliente, int idLibro, DateTime fechaPrestamo, DateTime fechaEntrega, string estado)
        {
            prestamoData.InsertarPrestamo(idCliente, idLibro, fechaPrestamo, fechaEntrega, estado);
        }

        public void EditPrestamo( int idPrestamo, int idCliente, int idLibro, DateTime fechaPrestamo, DateTime fechaEntrega, string estado)
        {
            prestamoData.Editar(idPrestamo, idCliente, idLibro, fechaPrestamo, fechaEntrega, estado);
        }

        public void borrar(int id)
        {
            prestamoData.Borrar(id);
        }
    }
}
