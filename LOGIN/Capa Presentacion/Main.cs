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
    public partial class Main : Form
    {
        private string usuarioActual;
        private string rolActual;

        public Main(string usuario, string rol)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.rolActual = rol;
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnPets_Click(object sender, EventArgs e)
        {
            AbrirForm(new Pets(rolActual));
        }

        private void AbrirForm(object formhijo)
        {
            if (this.panelForm.Controls.Count > 0)
                this.panelForm.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelForm.Controls.Add(fh);
            this.panelForm.Tag = fh;
            fh.Show();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AbrirForm(new Principal());

            confirmarRoles();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new Register());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new customers(rolActual));
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Principal());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AbrirForm(new Pets(rolActual));
        }

        private void confirmarRoles()
        {
            if (rolActual == "Administrador")
            {
                btnAddUser.Enabled = true;
                btnCita.Enabled = true;
                btnClientes.Enabled = true;
            }
            else if (rolActual == "Recepcionista")
            {
                btnClientes.Enabled = true;
                btnAddUser.Enabled = false;
                btnAddUser.Visible = false;
                btnCita.Enabled = true;
                btnCita.Visible = true;
            }
            else if(rolActual == "Asistente")
            {
                btnClientes.Enabled = false;
                btnClientes.Visible= false;
                btnAddUser.Enabled = false;
                btnAddUser.Visible = false;
                btnCita.Enabled = true;
                btnCita.Visible = true;
            }
            else if(rolActual == "Supervisor de Clientes")
            {
                btnClientes.Enabled = true;
                btnClientes.Visible = true;
                btnAddUser.Enabled = false;
                btnAddUser.Visible = false;
                btnCita.Enabled = false; 
                btnCita.Visible = false;
            }


        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
