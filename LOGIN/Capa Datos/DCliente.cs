using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public  class DCliente
    {
          Conexion con = new Conexion();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("listadoCliente", con.AbrirConexion());
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

        public void inserCliente(string nombre, string telefono, string direccion, string correo)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("insertCliente", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new Exception("error al insertar" + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }


        }

        public void editCliente(int id, string nombre, string telefono, string direccion, string correo)
        {
            try
            {
                Conexion con = new Conexion();
                SqlCommand cmd = new SqlCommand("updateCliente", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("error al insertar" + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }


        }
        public void eliminarclient(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("deleteCliente", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
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
