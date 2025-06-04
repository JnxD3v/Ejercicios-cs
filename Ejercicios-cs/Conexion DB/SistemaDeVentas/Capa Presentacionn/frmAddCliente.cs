using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacionn
{
    public partial class frmAddCliente : Form
    {
      NClientes cliente = new NClientes();
      bool Editar;
        int idcliente = 0;
      
        public frmAddCliente()
        {
            InitializeComponent();
        }


        public void  MostrarClientes()
        {
            dataGridView1.DataSource = cliente.MostrarClientes();
        }
       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {


                idcliente = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id_Cliente"].Value);
                cliente.eliminarCliente(idcliente);

                MostrarClientes();
            }
        }

        private void frmAddCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea añadir el libro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {

                        string nombre = txtNombre.Text;
                        string direccion = txtDireccion.Text;
                        string telefono = txttelofono.Text;
                        string correo = txtCorreo.Text;
                                             


                        cliente.InsertarCliente(nombre, direccion, telefono, correo);

                        MessageBox.Show("Producto guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarClientes();

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
                        cliente.EditarCliente(idcliente, txtNombre.Text, txtDireccion.Text, txttelofono.Text, txtCorreo.Text);

                        MessageBox.Show("Cliente editado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Editar = false;
                        MostrarClientes(); 
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


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                if (fila.Cells["Id_Cliente"].Value == null || string.IsNullOrEmpty(fila.Cells["Id_Cliente"].Value.ToString()))
                {
                    MessageBox.Show("Error: La fila seleccionada no tiene un ID valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Editar = true;
                idcliente = Convert.ToInt32(fila.Cells["Id_Cliente"].Value);

                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString() ?? "";
                txttelofono.Text = fila.Cells["Telefono"].Value?.ToString() ?? "";
                txtCorreo.Text = fila.Cells["Correo"].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRound3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
    }
