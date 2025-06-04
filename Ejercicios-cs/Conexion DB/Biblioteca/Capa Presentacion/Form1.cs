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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frm_Cliente frm = new frm_Cliente();
            frm.ShowDialog();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            frm_Prestamo frm = new frm_Prestamo();
            frm.ShowDialog(this);
        }

        private void btnLibro_Click(object sender, EventArgs e)
        {
            frm_Libros frm = new frm_Libros();  
            frm.ShowDialog();
      
        }
    }
}
