using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public  class DPrestamo
    {
        Conxexion con = new Conxexion();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("ObtenerPrestamosConNombres", con.AbrirConexion());
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

        public void InsertarPrestamo(int idCliente, int idLibro, DateTime fechaPrestamo, DateTime fechaEntrega, string estado)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("InsertarPrestamo", con.AbrirConexion());
                cmd.Parameters.AddWithValue("@ClienteID", idCliente);
                cmd.Parameters.AddWithValue("@LibroID", idLibro);
                cmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                cmd.Parameters.AddWithValue("@FechaDevolucion", fechaEntrega);
                cmd.Parameters.AddWithValue("@Estado", estado);
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        public void Editar( int idPrestamo, int idCliente, int idLibro, DateTime fechaPrestamo, DateTime fechaEntrega, string estado)
        {
            try
            {

                using (SqlConnection conexion = new SqlConnection("Server=PC;Database=BIBLIOTECA;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("ActualizarPrestamo", conexion))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PrestamoID", idPrestamo);
                        cmd.Parameters.AddWithValue("@ClienteID", idCliente);
                        cmd.Parameters.AddWithValue("@LibroID", idLibro);
                        cmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                        cmd.Parameters.AddWithValue("@FechaDevolucion", fechaEntrega);
                        cmd.Parameters.AddWithValue("@Estado", estado);
                        cmd.ExecuteNonQuery();
                    }
                 }
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }

        public void Borrar(int id)
        {
            try
            {
                using (SqlConnection conexion = new SqlConnection("Server=PC;Database=BIBLIOTECA;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand("BorrarPrestamo", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PrestamoID", id);
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
                con.CerrarConexion();
            }

        }

    }
}