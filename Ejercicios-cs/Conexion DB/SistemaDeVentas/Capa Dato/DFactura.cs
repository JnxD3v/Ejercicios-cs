using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dato
{
    public  class DFactura
    {
        Conexion con = new Conexion();

        public DataTable verfactura(int idFactura)
        {
            
            
             try
                {
                    string storedProcedure = "sp_GenerarFactura";
                    DataTable dt = new DataTable();

                    using (SqlConnection conn = new SqlConnection("Server=PC;Database=SistemaVentas;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
                    {
                        using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@IdFactura", idFactura);
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                        }
                    }

                    return dt;

                }

                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            
        }
    }
}
