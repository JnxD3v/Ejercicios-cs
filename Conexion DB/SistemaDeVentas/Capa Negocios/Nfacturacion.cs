using Capa_Dato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public  class Nfacturacion
    {
        Dfacturacion fac = new Dfacturacion();
        Dfacturacion f = new Dfacturacion();

    

        public DataTable productoporID(int id)
        {
            return fac.obtenerPrecioProd(id);
        }

        public void  Insertarfac (DateTime fecha, int id)
        {
            fac.InsertarFactura(fecha, id);
        }

        public DataTable MostrarFac()
        {
            return fac.Mostrar();
        }

        public void addDetalle(int idfac, int idProd, int cantida, decimal precio)
        {
            fac.insertDetalle(idfac, idProd, cantida, precio);
        }

        public DataTable mostrardetalle(int fac)
        {
            return f.obtenerDetalle(fac);
        }

        public void total(int Factura)
        {
            fac.guardarfac(Factura);
        }

        
    }
}
