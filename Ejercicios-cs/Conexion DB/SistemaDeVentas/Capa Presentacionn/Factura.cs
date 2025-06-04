using Capa_Negocios;
using Microsoft.Reporting.WinForms;
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
    public partial class Factura : Form
    {
        int idFactura;
        factura f = new factura();
        public Factura(int idFactura)
        {
            InitializeComponent();
            this.idFactura = idFactura;
        }


        private void Factura_Load(object sender, EventArgs e)
        {
            
            this.sp_GenerarFacturaTableAdapter.Fill(this.sistemaVentasDataSet2.sp_GenerarFactura, this.idFactura);

            // Agregar el origen de datos al ReportViewer
            ReportDataSource reportDataSource = new ReportDataSource("Ventas", this.sistemaVentasDataSet2.sp_GenerarFactura.AsEnumerable());
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            // Refrescar el reporte
            this.reportViewer1.RefreshReport();
        }


        public void cargarreporte()
        {
            DataTable dtFactura = f.Mostrar(idFactura);

            if (dtFactura.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para la factura " + idFactura, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Muestra los datos en la consola (solo para pruebas)
            foreach (DataRow row in dtFactura.Rows)
            {
                Console.WriteLine("Artículo: " + row["Nombre_Articulo"] + " - Cantidad: " + row["Cantidad"]);
            }

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("SistemasVentasDataSet2", dtFactura));

            reportViewer1.RefreshReport();
        }

        

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
