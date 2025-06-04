using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public  class Ncitas
    {
        DCitas cita = new DCitas();


        public DataTable MostrarClientes()
        {
            return cita.MostrarClientes();
        }


        public void ActualizarCita(int idCita,  DateTime fechaHora, string motivo)
        {
            cita.ActualizarCita(idCita,   fechaHora, motivo);
        }


        public void InsertarCita(int idCliente, DateTime fechaHora, string motivo)
        {
            cita.InsertarCita(idCliente, fechaHora, motivo);
        }






        public void EliminarCita(int idCita)
        {
            cita.EliminarCita(idCita);
        }
    }
}
