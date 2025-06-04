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
    public partial class Register : Form
    {
        RegisterBisnes r = new RegisterBisnes();
        public Register()
        {
            InitializeComponent();
        }

        private void llenarcmb()
        {
            guna2ComboBox1.DataSource = r.roles();
            guna2ComboBox1.DisplayMember = "Nombre";
            guna2ComboBox1.ValueMember = "Id";
        }

         

        private void btnInciarSesion_Click(object sender, EventArgs e)
        {
            bool noexiste = r.ValidarUsuario(txtUser.Text);
            if (noexiste)
            {
                MessageBox.Show("El nombre de usuario ya esta registrado por favor usar otro", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = MessageBox.Show("Estas seguro que deseas registrarte", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);



                if (DialogResult == DialogResult.Yes)
                {

                    r.Registro(txtUser.Text, txtPass.Text, Convert.ToInt32(guna2ComboBox1.SelectedValue));
                    MessageBox.Show("Usuario Registrado con Exito");
                    txtPass.Clear();
                    txtUser.Clear();
                }
                else
                {
                    MessageBox.Show("Operacion Cancelada");
                    txtPass.Clear();
                    txtUser.Clear();
                }
            }
            
        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
           txtPass.PasswordChar = guna2CustomCheckBox1.Checked ? '\0' : '●';
        }

        private void Register_Load(object sender, EventArgs e)
        {
            llenarcmb();
            guna2ComboBox1.SelectedIndex = -1;
        }
    }
}
