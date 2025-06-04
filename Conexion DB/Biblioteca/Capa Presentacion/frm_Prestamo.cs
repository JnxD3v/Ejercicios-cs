using Capa_Negocio;
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
    public partial class frm_Prestamo : Form
    {

        NCliente cliente = new NCliente();
        NLibro libro = new NLibro();
        NPrestamo prestamo = new NPrestamo();
        int idPrestamo;
        bool Editar = false;
        public frm_Prestamo()
        {
            InitializeComponent();
        }

        private void frm_Prestamo_Load(object sender, EventArgs e)
        {
            LlenarCombo();
            MostrarDatos();
          
        }

        private void MostrarDatos()
        {
            dataGridView1.DataSource = prestamo.Mostrar();
        }

        private void LlenarCombo()
        {
            cmbCliente.DataSource = cliente.Mostrar();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "ClienteID";

            cmbLibro.DataSource = libro.MostrasLibros();
            cmbLibro.DisplayMember = "Nombre";
            cmbLibro.ValueMember = "ID";

        }

        private void BtnSalirr_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            if (Editar == false)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea añadir el libro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {

                        int idCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                        int idLibro = Convert.ToInt32(cmbLibro.SelectedValue);
                        DateTime fechaInicial = dtpInicial.Value;
                        DateTime fechaEntrega = dtpEntrega.Value;
                        string estado = txtEstado.Text;

                        prestamo.InsertarPrestamo(idCliente, idLibro, fechaInicial, fechaEntrega, estado);

                        MessageBox.Show("Prestamo guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarDatos();
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Operación cancelada.");
                    
                }
            }
            else if (Editar == true)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                DialogResult r = MessageBox.Show("¿Está seguro de que desea editar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                       

                      
                        int idCliente = Convert.ToInt32(cmbCliente.SelectedValue);
                        int idLibro = Convert.ToInt32(cmbLibro.SelectedValue);
                        DateTime fechaInicial = dtpInicial.Value;
                        DateTime fechaEntrega = dtpEntrega.Value;
                        string estado = txtEstado.Text;

                        
                        idPrestamo = Convert.ToInt32(fila.Cells["PrestamoID"].Value);

                        prestamo.EditPrestamo(idPrestamo,idCliente, idLibro, fechaInicial, fechaEntrega, estado);

                        MessageBox.Show("Registro editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Editar = false;
                        MostrarDatos(); 
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                
                cmbCliente.SelectedValue = dataGridView1.CurrentRow.Cells["ClienteID"].Value.ToString();
                cmbLibro.SelectedValue = dataGridView1.CurrentRow.Cells["LibroID"].Value.ToString();
                dtpInicial.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["FechaPrestamo"].Value);
                dtpEntrega.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["FechaDevolucion"].Value);
                txtEstado.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Editar = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmbCliente.SelectedIndex = -1;
            cmbLibro.SelectedIndex = -1;
            txtEstado.Clear();
           
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        idPrestamo = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PrestamoID"].Value);
                        prestamo.borrar(idPrestamo);
                        MessageBox.Show("Eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarDatos(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            frm_reportePrestamocs rpt = new frm_reportePrestamocs();
            rpt.ShowDialog();
        }
    }
    
    
}
