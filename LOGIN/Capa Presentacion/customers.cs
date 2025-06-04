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
    public partial class customers : Form
    {
        NCliente cliente = new NCliente();
        bool Editar = false;
        int idcliente;
        private string rolActual;
        public customers(string rol)
        {
            InitializeComponent();
            this.rolActual = rol;
        }

        private void customers_Load(object sender, EventArgs e)
        {
            cargardatos();
            restrincciones();
            
        }

        private void restrincciones()
        {
            if (rolActual == "Recepcionista")
            {
                btnELiminar.Visible = false;
                btnELiminar.Enabled = false;
            }
            else if(rolActual == "Supervisor de Clientes")
            {
                btnELiminar.Visible = false;
                btnReporte.Visible = false;
            }
        }

        private void cargardatos()
        {
            guna2DataGridView1.DataSource = cliente.mostrar();
        }

        private void limpiarform()
        {
            txtTelefono.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();  
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rolActual == "Administrador" || rolActual == "Recepcionista")
            {

                

                if (Editar == false)
                {
                    DialogResult resultado = MessageBox.Show("¿Está seguro de que desea añadir el cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.Yes)
                    {
                        try
                        {

                            string nombre = txtNombre.Text;
                            string direccion = txtDireccion.Text;
                            string telefono = txtTelefono.Text;
                            string correo = txtCorreo.Text;



                            cliente.inserCliente(nombre, telefono, direccion, correo);

                            MessageBox.Show("Cliente guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargardatos();
                            limpiarform();
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
            }
            else
            {
                MessageBox.Show("Lo siento pero no puedes acceder a esta operacion");
            }


            if (Editar == true)
            {
                DialogResult resultado = MessageBox.Show("Ta seguro de que desea editar el cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        cliente.editCliente(idcliente, txtNombre.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
                        MessageBox.Show("Cliente editado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Editar = false;
                        cargardatos();
                        limpiarform();
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            limpiarform();
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            if(guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = guna2DataGridView1.SelectedRows[0];

                if (fila.Cells["ID"].Value == null || string.IsNullOrEmpty(fila.Cells["ID"].Value.ToString()))
                {
                    MessageBox.Show("Error: La fila seleccionada no tiene un ID valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Editar = true;
                idcliente = Convert.ToInt32(fila.Cells["ID"].Value);

                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtDireccion.Text = fila.Cells["direccion"].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["Telefono"].Value?.ToString() ?? "";
                txtCorreo.Text = fila.Cells["correo"].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnELiminar_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow fila = guna2DataGridView1.SelectedRows[0];

                if (fila.Cells["ID"].Value == null || string.IsNullOrEmpty(fila.Cells["ID"].Value.ToString()))
                {
                    MessageBox.Show("Error: La fila seleccionada no tiene un ID valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult = MessageBox.Show("¿Estas seguro de desactivar este cliente?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult == DialogResult.Yes) 
                {
                    idcliente = Convert.ToInt32(fila.Cells["ID"].Value);
                    cliente.deleted(idcliente);
                    MessageBox.Show("Cliente eliminado(desactivado)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargardatos();


                }

                else
                {
                    MessageBox.Show("Operacion cancelada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

