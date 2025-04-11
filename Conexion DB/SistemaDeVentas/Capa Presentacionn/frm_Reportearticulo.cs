using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacionn
{
    public partial class frm_Reportearticulo : Form
    {
        public frm_Reportearticulo()
        {
            InitializeComponent();
        }

        private void frm_Reportearticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaVentasDataSet.ObtenerArticulos' Puede moverla o quitarla según sea necesario.
            this.obtenerArticulosTableAdapter.Fill(this.sistemaVentasDataSet.ObtenerArticulos);

            this.reportViewer1.RefreshReport();
        }
    }
}
