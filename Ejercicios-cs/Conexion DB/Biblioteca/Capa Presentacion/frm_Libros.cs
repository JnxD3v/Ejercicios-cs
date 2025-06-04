using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frm_Libros : Form
    {
        private NLibro NLibros = new NLibro();
        private NCategoria Ncategorias = new NCategoria();
        private int idLibro;
        bool Editar = false;

        public frm_Libros()
        {
            InitializeComponent();

        }

        public void LimpiarForm()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        public void MostrarLibros()
        {
           dataGridView1.DataSource = NLibros.MostrasLibros();
        }

        public void MostrarCat()
        {
            DataTable categorias = Ncategorias.MostrarCat();

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "ID";
        }

        private void frm_libros_Load(object sender, EventArgs e)
        {
            MostrarLibros();
            MostrarCat();
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre del libro es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show("Seleccione una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero no negativo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void frm_Libros_Load_1(object sender, EventArgs e)
        {
            MostrarCat();
            MostrarLibros();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                cmbCategoria.SelectedValue = dataGridView1.CurrentRow.Cells["ID_categoria"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnGuardar_Click_1(object sender, EventArgs e)
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

                        string nombreLibro = txtNombre.Text;
                        int idCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);
                        decimal precio = Convert.ToDecimal(txtPrecio.Text);
                        int stock = Convert.ToInt32(txtStock.Text);

                        NLibros.InsertarLibro(nombreLibro, idCategoria, precio, stock);

                        MessageBox.Show("Producto guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarLibros();
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
                        idLibro = Convert.ToInt32(fila.Cells["ID"].Value);

                        NLibros.EditarLibro(idLibro, txtNombre.Text,
                        Convert.ToInt32(cmbCategoria.SelectedValue), Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtStock.Text));

                        MessageBox.Show("Libro editado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Editar = false;
                        MostrarLibros();
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

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar el registro?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        idLibro = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ClienteID"].Value);
                        NLibros.EliminarLibro(Convert.ToInt32(idLibro));
                        MessageBox.Show("Eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarLibros();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
           frm_ReporteLbro rpt = new frm_ReporteLbro();
          rpt.ShowDialog();
        }
    }
}
