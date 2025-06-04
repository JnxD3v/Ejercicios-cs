using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public  class DCitas
    {

        public DataTable MostrarClientes()
        {
            Conexion con = new Conexion();
            DataTable tabla = new DataTable();
            try
            {

                SqlCommand cmd = new SqlCommand("sp_ConsultarCitas", con.AbrirConexion());
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


        public void InsertarCita(int idCliente, DateTime fechaHora, string motivo)
        {
            Conexion con = new Conexion();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarCita", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@FechaHora", fechaHora);
                cmd.Parameters.AddWithValue("@Motivo", motivo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la cita: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }


        public void ActualizarCita(int idCita,  DateTime fechaHora, string motivo)
        {
            Conexion con = new Conexion();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarCita", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCita", idCita);
                cmd.Parameters.AddWithValue("@FechaHora", fechaHora);
                cmd.Parameters.AddWithValue("@Motivo", motivo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la cita: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }


        public void EliminarCita(int idCita)
        {
            Conexion con = new Conexion();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarCita", con.AbrirConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCita", idCita);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la cita: " + ex.Message);
            }
            finally
            {
                con.CerrarConexion();
            }
        }






    }
}
