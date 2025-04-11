using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicioo_1__Interfaces_Graficas_
{
    public partial class ProyectoEjemplo : Form
    {
        public ProyectoEjemplo()
        {
            InitializeComponent();
        }

        private void rbt_Seleccion2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbt_Seleccion4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
            if (rbt_Seleccion1.Checked)
            {
                pbx_Titulo.Show();
                pbx_Imagen1.Show();
                pbx_Imagen2.Hide();
                pbx_Imagen3.Hide();
                pbx_Imagen4.Hide();
            }
            if (rbt_Seleccion2.Checked)
            {
                pbx_Titulo.Show();
                pbx_Imagen2.Show();
                pbx_Imagen1.Hide();
                pbx_Imagen3.Hide();
                pbx_Imagen4.Hide();
            }
            if (rbt_Seleccion3.Checked)
            {
                pbx_Titulo.Show();
                pbx_Imagen3.Show();
                pbx_Imagen2.Hide();
                pbx_Imagen1.Hide();
                pbx_Imagen4.Hide();
            }
            if (rbt_Seleccion4.Checked)
            {
                pbx_Titulo.Show();
                pbx_Imagen4.Show();
                pbx_Imagen2.Hide();
                pbx_Imagen3.Hide();
                pbx_Imagen1 .Hide();
            }
            if (rbt_SecretOption.Checked)
            {
                pbx_Titulo.Hide();
                pbx_Imagen2.Hide();
                pbx_Imagen1.Hide();
                pbx_Imagen3.Hide();
                pbx_Imagen4.Hide();

            }
        }
    }
}
