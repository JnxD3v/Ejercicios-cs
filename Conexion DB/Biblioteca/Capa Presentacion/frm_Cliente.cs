using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frm_Cliente : Form
    {
        NCliente cliente = new NCliente();
        int idCliente = 0;
        bool Editar = false;
        public frm_Cliente()
        {
            InitializeComponent();
        }

        private void frm_Cliente_Load(object sender, EventArgs e)
        {
            MostrarClient();
        }

        private void LimpiarForm()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El teléfono es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("El correo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccion.Focus();
                return false;
            }

            // Validación de correo
            if (!Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                return false;
            }

            // Validación de teléfono (debe ser solo números y de 10 dígitos)
            if (!Regex.IsMatch(txtTelefono.Text, @"^\d{10}$"))
            {
                MessageBox.Show("El teléfono debe contener 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return false;
            }

            return true; // Todo está correcto
        }

        private void MostrarClient()
        {
            dataGridView1.DataSource = cliente.Mostrar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            if (Editar == false)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea añadir el libro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {

                        string nombre = txtNombre.Text;
                        string telefono  = txtTelefono.Text;
                        string correo = txtCorreo.Text;
                        string direccion = txtDireccion.Text;
                        cliente.insertarClient(nombre, telefono, correo, direccion);


                        MessageBox.Show("Cliente guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarClient();
                        LimpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Operación cancelada.");
                    LimpiarForm();
                }
            }
            else if (Editar == true)
            {
                DialogResult r = MessageBox.Show("¿Está seguro de que desea editar el libro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (r == DialogResult.Yes)
                {
                    try
                    {
                        DataGridViewRow fila = dataGridView1.SelectedRows[0];
                        idCliente = Convert.ToInt32(fila.Cells["ClienteID"].Value);

                        cliente.edit(idCliente, txtNombre.Text, txtTelefono.Text, txtCorreo.Text, txtDireccion.Text);

                        MessageBox.Show("Libro editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Editar = false;
                        MostrarClient();
                        LimpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarForm();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["Direccion"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        idCliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ClienteID"].Value);
                        cliente.delete(Convert.ToInt32(idCliente));
                        MessageBox.Show("Eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarClient();
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

        private void button8_Click(object sender, EventArgs e)
        {
            formularioReporteCliente rpt = new formularioReporteCliente();
            rpt.ShowDialog();
        }
    }
}
