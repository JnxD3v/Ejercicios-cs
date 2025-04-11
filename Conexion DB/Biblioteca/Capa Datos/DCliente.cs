using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public  class DCliente
    {
        Conxexion conexion = new Conxexion();
      
        public DataTable MostrarCliente()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("ObtenerClientes", conexion.AbrirConexion());
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

        public void InsertarCliente(string nombre, string telefono, string correo, string direccion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarCliente", conexion.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Correo", correo);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Al ejecutar el procedimiento de insertar" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void EditarCliente(int id, string nombre, string telefono, string correo, string direccion)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=PC;Database=BIBLIOTECA;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("ActualizarCliente",  conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteID", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Direccion", direccion);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error Al ejecutar el procedimiento de insertar" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public void Borrar(int id) 
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=PC;Database=BIBLIOTECA;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("BorrarCliente", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ClienteID", id);
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error Al ejecutar el procedimiento de insertar" + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }

        }
    }
}
