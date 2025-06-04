using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Capa_Dato
{
    public  class Dfacturacion
    {
        Conexion con = new Conexion();

        public void obtenerCliente(int id)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("sp_ClienteporID", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

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

        public DataTable obtenerPrecioProd(int idArticulo)
        {
            try
            {
                string storedProcedure = "sp_ProductoporID";
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection("Server=PC;Database=SistemaVentas;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", idArticulo);
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

        public void InsertarFactura (DateTime fecha, int idCliente)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("InsertarFactura", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha",fecha );
                cmd.Parameters.AddWithValue("@id_cliente",idCliente );

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

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_ObtenerFacturas", con.AbrirConexion());
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

        public void insertDetalle(int idFactura, int idArticulo, int cantidad, decimal precio)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("InsertarDetalle", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_factura", idFactura);
                cmd.Parameters.AddWithValue("@id_articulo", idArticulo);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@precio", precio);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();


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

        public DataTable obtenerDetalle(int idFac)
        {
            try
            {
                string storedProcedure = "ObtenerDetallesFactura";
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection("Server=PC;Database=SistemaVentas;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;"))
                {
                    using (SqlCommand cmd = new SqlCommand(storedProcedure, conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdFactura", idFac);
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

        public void guardarfac(int idFac)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("sp_ActualizarTotalFactura", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdFactura",idFac);

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

       
            

    }
}
