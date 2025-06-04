using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class RegisterBisnes
    {
       RegistroData registro = new RegistroData();  

        public void Registro(string name, string c, int id)
        {
            registro.Registro(name, c, id);
        }

        public bool ValidarUsuario(string nombre)
        {

            if (string.IsNullOrEmpty(nombre))
            {
                throw new Exception("El nombre");
            }
            return registro.validetUser(nombre);
        }

        public DataTable roles() 
        {
          return   registro.Mostrar();

        }

    }
}
