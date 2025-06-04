using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class LoginBisnes
    {
        LoginData l = new LoginData();

        public (string usuario, string rol) IniciarSesion(string usuario, string contrasena)
        {
            var resultado = l.ValidarLogin(usuario, contrasena);

            if (resultado.usuario != null)
            {
                return (resultado.usuario, resultado.rol);
            }

            return (null, null); 
        }


    }
}
