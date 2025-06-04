using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class login : Form
    {
        LoginBisnes l = new LoginBisnes();
        public login()
        {
            InitializeComponent();
        }
        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
           
                txtcontra.PasswordChar = guna2CustomCheckBox1.Checked ? '\0' : '●';
            
        }

        private void btnInciarSesion_Click(object sender, EventArgs e)   
        {
            
            LoginBisnes serviciosUsuario = new LoginBisnes();

            string username = guna2TextBox1.Text;
            string password = txtcontra.Text;

            (string usuarioEncontrado, string rolUsuario) = serviciosUsuario.IniciarSesion(username, password);

            if (usuarioEncontrado != null)
            {
                
                Main main = new Main(usuarioEncontrado, rolUsuario);
                main.Show();
                this.Hide();

          
            }
            else
            {
                MessageBox.Show("Credenciales inválidas. Inicio de sesión fallido.");

                
            }
        }

        private void Eliminarmensaje()
        {
            if (guna2TextBox1.Text.Length > 0 || txtcontra.Text.Length > 0)
            {
                lblPasword.Text = "";
            }
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            Eliminarmensaje();
        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {
            Eliminarmensaje();
        }
    }
}
