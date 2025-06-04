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
    public partial class frm_ReporteLbro : Form
    {
        public frm_ReporteLbro()
        {
            InitializeComponent();
        }

        private void frm_ReporteLbro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bIBLIOTECADataSet.sp_listado_libros' Puede moverla o quitarla según sea necesario.
            this.sp_listado_librosTableAdapter.Fill(this.bIBLIOTECADataSet.sp_listado_libros);

            this.reportViewer1.RefreshReport();
        }
    }
}
