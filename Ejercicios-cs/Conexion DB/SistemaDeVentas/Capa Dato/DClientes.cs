using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Dato
{
    public class DClientes
    {
        Conexion con = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("ObtenerClientes", con.AbrirConexion());
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

        public void InsertarCliente(string nombre, string Direccion, string telefono, string correo)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("InsertarCliente", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@direccion", Direccion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Al ejecutar el procedimiento de insertar" + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }


        public void EditarCliente(int id, string nombre, string direccion, string telefono, string correo)
        {
            using (SqlConnection conexion = new SqlConnection("Server=PC;Database=SistemaVentas;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("ActualizarCliente", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@id_cliente", id);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void eliminarcliente(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("EliminarCliente", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_cliente", id);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }




    }
}
