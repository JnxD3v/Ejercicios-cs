using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public  class RegistroData
    {
        Conexion con = new Conexion();

        public void Registro(string nombre, string contra, int id)
        {
            SqlCommand cmd = new SqlCommand("spRegistro", con.AbrirConexion());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre",nombre);
            cmd.Parameters.AddWithValue("@contraseña", contra);
            cmd.Parameters.AddWithValue("@idRol", id);
            cmd.ExecuteNonQuery(); 


        }

        public bool validetUser(string user)
        {
            SqlCommand cmd = new SqlCommand("sp_validarUser", con.AbrirConexion());
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", user);

            int result = (int)cmd.ExecuteScalar();

            return result > 0;
        }


        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("mostrarRoles", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                tabla.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
            return tabla;

        }

    }
}
