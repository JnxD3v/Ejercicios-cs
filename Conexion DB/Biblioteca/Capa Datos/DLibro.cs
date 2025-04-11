using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public  class DLibro
    {

        private Conxexion conexion = new Conxexion();

        public DataTable MostrarLibros()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_listado_libros", conexion.AbrirConexion());
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

        public void BuscarLibro(string nombre)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("filtro", conexion.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error" + ex.Message);
            }

        }

        public void InsertarLibro(string nombre, int idCategoria, string precio, string stock)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("sp_insertarLibro", conexion.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre_Libro", nombre);
                cmd.Parameters.AddWithValue("@ID_Categoria", idCategoria);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);
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

        public void EditarLibro(int idLibro, string nombre, int idCategoria, decimal precio, int stock)
        {
            using (SqlConnection conexion = new SqlConnection("Server=PC;Database=BIBLIOTECA;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("sp_ActualizarLibro", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_Libro", idLibro);
                    cmd.Parameters.AddWithValue("@Nombre_Libro", nombre);
                    cmd.Parameters.AddWithValue("@ID_Categoria", idCategoria);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Stock", stock);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void EliminarLibro(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarLibroLogicamente", conexion.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_Libro", id);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

    }
}
