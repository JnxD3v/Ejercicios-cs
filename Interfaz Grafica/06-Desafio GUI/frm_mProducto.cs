using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Desafio_GUI
{
    public partial class frm_mProducto : Form
    {
        int Fila = 0;
        public frm_mProducto()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_categoria.Clear();
            txt_nombre.Clear();
            txt_precio.Clear();
            txt_stock.Clear();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.nombre = txt_nombre.Text;

            producto.categoria = txt_categoria.Text;

            producto.precio = int.Parse(txt_precio.Text);

            producto.stock = int.Parse(txt_stock.Text);



            if (string.IsNullOrWhiteSpace(txt_categoria.Text) ||
                string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_precio.Text) ||
                string.IsNullOrWhiteSpace(txt_stock.Text) ||
                !double.TryParse(txt_precio.Text, out double n) ||
                !int.TryParse(txt_stock.Text, out int a))
            {
                MessageBox.Show("Intente de nuevo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Guardado con Exito!", "Acción Completada");
                Fila = dtgw_productos.Rows.Add();

                dtgw_productos.Rows[Fila].Cells[0].Value = txt_nombre.Text;
                dtgw_productos.Rows[Fila].Cells[1].Value = txt_categoria.Text;
                dtgw_productos.Rows[Fila].Cells[2].Value = n.ToString("C2");
                dtgw_productos.Rows[Fila].Cells[3].Value = txt_stock.Text;
            }




        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dtgw_productos.ReadOnly = false;
        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (dtgw_productos.SelectedRows.Count > 0)
            {

                DialogResult = MessageBox.Show("Estas seguro de que deseas eliminar", "advertencia", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    dtgw_productos.Rows.RemoveAt(dtgw_productos.SelectedRows[0].Index);
                    MessageBox.Show("Registro eliminado con exito");
                }
                else if (DialogResult == DialogResult.No)
                {
                    MessageBox.Show("De acuerdo");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_buscar.Text, out int id))
            {
                foreach (DataGridViewRow fila in dtgw_productos.Rows)
                {
                    if (fila.Cells["ID"].Value != null && Convert.ToInt32(fila.Cells["ID"].Value) == id)
                    {
                        fila.Selected = true;
                    
                    }
                }

               
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class Producto
    {
        public string categoria { get; set; }

        public string nombre { get; set; }

        public double  precio {  get; set; }

        public int  stock { get; set; }
    }
}
