using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Capa_Dato
{
    public  class DAriticulo
    {
        Conexion con = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("ObtenerArticulos", con.AbrirConexion());
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

        public void AddProducto(string nombre, decimal precio, int stock)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("InsertarArticulo", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.Parameters.AddWithValue("@stock", stock);
               
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

        public void editProduc(int id, string nombre, decimal precio, int stock)
        {
            using (SqlConnection conexion = new SqlConnection("Server=PC;Database=SistemaVentas;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("ActualizarArticulo", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@id_articulo", id);
                    cmd.Parameters.AddWithValue("@nombre_articulo", nombre);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stock", stock);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void eliminanr(int id) 
        {
            try
            {
                SqlCommand cmd = new SqlCommand("EliminarArticulo", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_articulo", id);

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

