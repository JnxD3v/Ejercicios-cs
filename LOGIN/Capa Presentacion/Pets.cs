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
    public partial class Pets : Form
    {
        int id = 0;
        bool Editar = false;
        Ncitas cita = new Ncitas();
        NCliente cliente = new NCliente();
        private string rolActual;
        public Pets(string rol)
        {
            InitializeComponent();
            this.rolActual = rol;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Llenardatos( )
        {
            cmbCliente.DataSource = cliente.mostrar();
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.SelectedIndex = -1;
            cmbCliente.ValueMember = "ID";


        }

        private void Datagrid() 
        {
            guna2DataGridView1.DataSource = cita.MostrarClientes();

        }

        private void Pets_Load(object sender, EventArgs e)
        {
            Datagrid();
            Llenardatos();
            Restricciones();
        }

        private void Restricciones()
        {
            if (rolActual == "Recepcionista")
            {
                btnELiminar.Enabled = false;
                btnELiminar.Visible = false;
            }
            else if(rolActual == "Asistente")
            {
                btnELiminar.Enabled = false;
                btnELiminar .Visible = false;
                btnActu.Enabled = false;
                btnActu .Visible = false;
            }


        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = guna2DataGridView1.SelectedRows[0];

                if (fila.Cells["IdCita"].Value == null || string.IsNullOrEmpty(fila.Cells["IdCita"].Value.ToString()))
                {
                    MessageBox.Show("Error: La fila seleccionada no tiene un ID valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Editar = true;
                id = Convert.ToInt32(fila.Cells["IdCita"].Value);


                string nombreCliente = guna2DataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                cmbCliente.SelectedIndex = cmbCliente.FindStringExact(nombreCliente);
                DateTime fecha = Convert.ToDateTime(guna2DataGridView1.CurrentRow.Cells[2].Value); // Por ejemplo columna 2
                dtpfecha.Value = fecha;
                txtMotivo.Text = fila.Cells["Motivo"].Value?.ToString() ?? "";
               
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea añadir el cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {

                        cita.InsertarCita(Convert.ToInt32(cmbCliente.SelectedValue), dtpfecha.Value, txtMotivo.Text);

                        MessageBox.Show("Cliente guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Datagrid();
                        
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
            if (Editar == true)
            {
                DialogResult resultado = MessageBox.Show("Ta seguro de que desea editar el cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow fila = guna2DataGridView1.SelectedRows[0];
                        id = Convert.ToInt32(fila.Cells["IdCita"].Value);
                        cita.ActualizarCita(id, dtpfecha.Value, txtMotivo.Text);
                        MessageBox.Show("Cliente editado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Editar = false;
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al editar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Operaciin cancelada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este registro? Esta acción no se puede deshacer.",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    DataGridViewRow fila = guna2DataGridView1.SelectedRows[0];
                    id = Convert.ToInt32(fila.Cells["IdCita"].Value);
                    cita.EliminarCita(id);
                    MessageBox.Show("Registro eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
