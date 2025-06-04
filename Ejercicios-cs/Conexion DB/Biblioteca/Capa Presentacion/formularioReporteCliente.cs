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
    public partial class formularioReporteCliente : Form
    {
        public formularioReporteCliente()
        {
            InitializeComponent();
        }

        private void formularioReporteCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientes.ObtenerClientes' Puede moverla o quitarla según sea necesario.
            this.obtenerClientesTableAdapter.Fill(this.clientes.ObtenerClientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
