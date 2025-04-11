using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profe_Badelin
{
    public partial class ProfeBadelin : Form
    {

        public ProfeBadelin()
        {
            InitializeComponent();
        }

        private int v = 0;
        
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            v = dtgv_Prueba.Rows.Add();
            dtgv_Prueba.Rows[v].Cells[0].Value = cbx_IngresarID.Text;
            dtgv_Prueba.Rows[v].Cells[1].Value = cbx_IngresarNombre.Text;
            dtgv_Prueba.Rows[v].Cells[2].Value = cbx_IngresarApellido.Text;
           
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            dtgv_Prueba.Rows.Clear();
        }

    }
}
