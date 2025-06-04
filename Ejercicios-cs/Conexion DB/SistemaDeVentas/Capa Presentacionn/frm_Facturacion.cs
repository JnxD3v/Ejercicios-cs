using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Presentacionn
{
    public partial class frm_Facturacion : Form
    {
        double precio = 0;
        NClientes cliente = new NClientes();
        NArticulos articulo = new NArticulos();
        Nfacturacion fac = new Nfacturacion();
        
        public frm_Facturacion()
        {
            InitializeComponent();
        }

         public void MostrarDetalle()
         {
            
            dataGridView1.DataSource = fac.mostrardetalle((int)cmbElegirFac.SelectedValue);
            AplicarEstiloDataGridView(dataGridView1);
             
         }
         
        private void frm_Facturacion_Load(object sender, EventArgs e)
        {
            LlenarCombobox();
            MostrarDetalle();
            dataGridView1.CurrentCell = null;
        }

        private void LlenarCombobox()
        {
            //Cliente
            cmbCliente.DataSource = cliente.MostrarClientes();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id_Cliente";
            cmbCliente.SelectedIndex = -1;


            //Productos
            cmbProd.DataSource = articulo.MostrarArticulos();
            cmbProd.DisplayMember = "Nombre_Articulo";
            cmbProd.ValueMember = "Id_articulo";
            cmbProd.SelectedIndex = -1;

            cmbElegirFac.DataSource = fac.MostrarFac();
            cmbElegirFac.DisplayMember = "Cliente";
            cmbElegirFac.ValueMember = "Id_Factura";
            

        }

        private void buttonRound1_Click(object sender, EventArgs e)
        {
            double cantidad = double.Parse(txtCantidad.Text);
            double precio = Convert.ToDouble(txtUnitario.Text);
            txtsubTotal.Text = (cantidad * precio).ToString();
            txtUnitario.Text = precio.ToString();
            MessageBox.Show("Precio/Importe Calculado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        
            if (cmbProd.SelectedIndex > 0)  
            {
                int idArticulo = Convert.ToInt32(cmbProd.SelectedValue);
                MostrarPrecio(idArticulo);
            }
        }

        private void MostrarPrecio(int idArticulo)
        {
           
            DataTable dt = fac.productoporID(idArticulo);

            if (dt.Rows.Count > 0)  
            {
                DataRow row = dt.Rows[0];
                txtUnitario.Text = row["Precio"].ToString();  
            }
            else
            {
                txtUnitario.Text = "";  
            }
        }

        private void MostrarDetalleFactura(int IdFactura)
        {
            DataTable dt = fac.mostrardetalle(IdFactura);
            if (dt.Rows.Count > 0)
            {
                
                dataGridView1.DataSource = dt;
            }
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            DialogResult newf = MessageBox.Show("Estas seguro de que desea crear la factura", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (newf == DialogResult.Yes)
            {

                DateTime fehca = dateTimePicker1.Value;
                fac.Insertarfac(fehca, Convert.ToInt32(cmbCliente.SelectedValue));
                MessageBox.Show("Factura creada con exito", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                LlenarCombobox();

            }
            else if (newf == DialogResult.No) 
            {
                MessageBox.Show("Operacion Cancel", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

              
        }

        private void buttonRound2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Estas Seguro de añadir el aritculo a la factura", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                fac.addDetalle(Convert.ToInt32(cmbElegirFac.SelectedValue), Convert.ToInt32(cmbProd.SelectedValue), Convert.ToInt32(txtCantidad.Text), Convert.ToDecimal(txtsubTotal.Text));
                DataRowView filaSeleccionada = cmbElegirFac.SelectedItem as DataRowView;
                int clienteId = Convert.ToInt32(filaSeleccionada["Id_Factura"]);
                MostrarDetalleFactura(clienteId);
            }
            else
            {
                MessageBox.Show("Operacion Cancelada", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void AplicarEstiloDataGridView(DataGridView dataGridView)
        {
           
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial ", 12, FontStyle.Bold);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke; 
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumSlateBlue; 
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; 

    
            dataGridView.DefaultCellStyle.Font = new Font("Century Gothic", 8);
            dataGridView.DefaultCellStyle.ForeColor = Color.Black; 
            dataGridView.DefaultCellStyle.BackColor = Color.DarkGoldenrod; 
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

           
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

          
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkGoldenrod;

        }

        private void cmbElegirFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView filaSeleccionada = cmbElegirFac.SelectedItem as DataRowView;
            if (filaSeleccionada != null)
            {
                int clienteId = Convert.ToInt32(filaSeleccionada["Id_Factura"]); 
                MostrarDetalleFactura(clienteId);
                dataGridView1.CurrentCell = null;
                
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult newf = MessageBox.Show("Estas seguro de que desea guardar la factura", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (newf == DialogResult.Yes)
            {

                DataRowView filaSeleccionada = cmbElegirFac.SelectedItem as DataRowView;
                int clienteId = Convert.ToInt32(filaSeleccionada["Id_Factura"]);
                fac.total(clienteId);
                MessageBox.Show("Factura guardada con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Operacion Cancel", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenReporte_Click(object sender, EventArgs e)
        {
            DataRowView filaSeleccionada = cmbElegirFac.SelectedItem as DataRowView;
            int clienteId = Convert.ToInt32(filaSeleccionada["Id_Factura"]);
            Factura rpt = new Factura(clienteId);
            rpt.ShowDialog();
        }
    }
}
