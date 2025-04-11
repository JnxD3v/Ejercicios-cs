using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_MDI___WF
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Cerrar = MessageBox.Show("¿Seguro quieres salir?","Confirmar",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Cerrar == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Accion cancelada.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(600, 450);
            ProveedoresV1 ventanaProveedores = ProveedoresV1.Comprobante();
            ventanaProveedores.MdiParent = this;
            ventanaProveedores.Show();
            ventanaProveedores.Location = new Point(0, 0);
            this.StartPosition = FormStartPosition.CenterScreen;

            Productos ventanaProductos = Productos.Comprobante();
            if (ventanaProductos.Visible)
            {
                ventanaProductos.Hide();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            Productos ventanaProductos = Productos.Comprobante();
            ventanaProductos.MdiParent = this;
            ventanaProductos.Show();
            ventanaProductos.Location = new Point(0, 0);

            ProveedoresV1 ventanaProveedores = ProveedoresV1.Comprobante();
            if (ventanaProveedores.Visible)
            {
                ventanaProveedores.Hide();
            }
        }

        private void IniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.CenterToScreen();
            this.pnl_Fondo.Hide();

            OpcionesToolStripMenuItem.Visible = true;
            salirToolStripMenuItem.Visible = true;
            IniciarToolStripMenuItem.Visible = false;
        }
    }
}
