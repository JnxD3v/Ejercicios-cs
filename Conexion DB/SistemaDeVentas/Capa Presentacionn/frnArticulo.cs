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

namespace Capa_Presentacionn
{
    public partial class frnArticulo : Form
    {
        NArticulos narticulos = new NArticulos();
        private bool Editar = false;
        private int idarticulo;
        
        public frnArticulo()
        {
            InitializeComponent();
        }

        private void frnArticulo_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        public void Mostrar()
        {
            dataGridView1.DataSource = narticulos.MostrarArticulos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea añadir el  Producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {

                        string nombre = txNombre.Text;
                        decimal precio = decimal.Parse(txtPrecio.Text);
                        int telefono =int.Parse(txtstock.Text);
                     


                        narticulos.addArticulo(nombre, precio, telefono);

                        MessageBox.Show("Producto guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();

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
                DialogResult resultado = MessageBox.Show("Ta seguro de que desea editar el Producto", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        narticulos.editProd(idarticulo, txNombre.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtstock.Text));

                        MessageBox.Show("Cliente editado correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Editar = false;
                        Mostrar();
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


        private void buttonRound1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];

                if (fila.Cells["Id_articulo"].Value == null || string.IsNullOrEmpty(fila.Cells["Id_articulo"].Value.ToString()))
                {
                    MessageBox.Show("Error: La fila seleccionada no tiene un ID valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Editar = true;
                idarticulo = Convert.ToInt32(fila.Cells["Id_articulo"].Value);

                txNombre.Text = fila.Cells["Nombre_Articulo"].Value.ToString();
                txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                txtstock.Text = fila.Cells["Stock"].Value.ToString();
               
            }
            else
            {
                MessageBox.Show("Seleccione una fila, por favor", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("estas seguro de eliminar", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes) 
            {
                DataGridViewRow fila = dataGridView1.SelectedRows[0];
                idarticulo = Convert.ToInt32(fila.Cells["Id_articulo"].Value);
                narticulos.deleteProd(idarticulo);
                Mostrar();
            }
            else if(resultado == DialogResult.No)
            {
                MessageBox.Show("Operacion cancelada", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRound2_Click(object sender, EventArgs e)
        {
            frm_Reportearticulo frm = new frm_Reportearticulo();

            frm.ShowDialog();
        }
    }
}
