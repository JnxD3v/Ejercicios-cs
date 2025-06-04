
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class LoginData
    {
        Conexion con = new Conexion();


        public (string usuario, string rol) ValidarLogin(string usuario, string contrasena)
        {
            SqlCommand cmd = new SqlCommand("sp_LoginConPermisos", con.AbrirConexion());
            SqlDataReader reader = null;

            string usuarioEncontrado = null;
            string rolEncontrado = null;

            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Contrasena", contrasena);

                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuarioEncontrado = reader.GetString(1); 
                    rolEncontrado = reader.GetString(2);     
                }
            }
            catch (Exception ex)
            {
                // Puedes registrar o lanzar la excepción
                throw new Exception("Error al validar el login: " + ex.Message);
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                {
                    reader.Close();
                }
                con.CerrarConexion();
            }

            return (usuarioEncontrado, rolEncontrado);
        }
    }
}
