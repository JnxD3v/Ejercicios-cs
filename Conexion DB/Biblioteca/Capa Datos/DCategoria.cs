using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class DCategoria
    {
        private Conxexion conexion = new Conxexion();

        public DataTable MostrarCategoria()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_listado_categoria", conexion.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
            return tabla;


        }
    }
}
