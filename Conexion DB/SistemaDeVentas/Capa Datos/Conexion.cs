using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    class Conexion
    {
        private SqlConnection conexion = new SqlConnection("Server=PC;Database=SistemaVentas;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        public SqlConnection AbrirConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }

        public SqlConnection CerrarConexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
        }

    }
}
