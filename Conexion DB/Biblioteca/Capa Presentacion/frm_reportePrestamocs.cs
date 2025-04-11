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
    public partial class frm_reportePrestamocs : Form
    {
        public frm_reportePrestamocs()
        {
            InitializeComponent();
        }

        private void frm_reportePrestamocs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bIBLIOTECADataSet1.ObtenerPrestamosConNombres' Puede moverla o quitarla según sea necesario.
            this.obtenerPrestamosConNombresTableAdapter.Fill(this.bIBLIOTECADataSet1.ObtenerPrestamosConNombres);

            this.reportViewer1.RefreshReport();
        }
    }
}
