using System.Configuration;
using System.Windows.Forms;

namespace _04_Desafio_GUi
{
    public partial class Form1 : Form
    {
        int Fila = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double total = 0;

            double precioUnitario = 0;


            double precio = 0;

            if (cbxNombre.SelectedIndex == 0)
            {
                precioUnitario = 5000;

                if (cbxCantidad.SelectedIndex == 0)
                {
                    precio = precioUnitario;
                }

                else if (cbxCantidad.SelectedIndex == 1)
                {
                    precio = precioUnitario * 2;
                }

                else if (cbxCantidad.SelectedIndex == 2)
                {
                    precio = precioUnitario * 3;
                }

                else if (cbxCantidad.SelectedIndex == 3)
                {
                    precio = precioUnitario * 4;
                }

            }




            else if (cbxNombre.SelectedIndex == 1)
            {
                precioUnitario = 50;
                if (cbxCantidad.SelectedIndex == 0)
                {
                    precio = precioUnitario;
                }

                else if (cbxCantidad.SelectedIndex == 1)
                {
                    precio = precioUnitario * 2;
                }

                else if (cbxCantidad.SelectedIndex == 2)
                {
                    precio = precioUnitario * 3;
                }

                else if (cbxCantidad.SelectedIndex == 3)
                {
                    precio = precioUnitario * 4;
                }
            }

            else if (cbxNombre.SelectedIndex == 2)
            {
                precioUnitario = 25;

                if (cbxCantidad.SelectedIndex == 0)
                {
                    precio = precioUnitario;
                }

                else if (cbxCantidad.SelectedIndex == 1)
                {
                    precio = precioUnitario * 2;
                }

                else if (cbxCantidad.SelectedIndex == 2)
                {
                    precio = precioUnitario * 3;
                }

                else if (cbxCantidad.SelectedIndex == 3)
                {
                    precio = precioUnitario * 4;
                }
            }
            txtPrecio.Text = precio.ToString();

            Fila = dtgwMinifactura.Rows.Add();

            dtgwMinifactura.Rows[Fila].Cells[0].Value = cbxNombre.Text;
            dtgwMinifactura.Rows[Fila].Cells[1].Value = cbxCantidad.Text;
            dtgwMinifactura.Rows[Fila].Cells[2].Value = precioUnitario.ToString();
            dtgwMinifactura.Rows[Fila].Cells[3].Value = precio.ToString();



            foreach (DataGridViewRow row in dtgwMinifactura.Rows)
            {

                if (!row.IsNewRow && row.Cells[3].Value != null)
                {
                    // Suma el valor de la columna específica
                    total += Convert.ToDouble(row.Cells[3].Value);
                }



            }

            dtgwMinifactura.Rows[Fila].Cells[4].Value = total.ToString();

            lbl_totalDeTotales.Text = total.ToString();




            lbl_Articulos.Text = cbxNombre.Text;








        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            cbxCantidad.SelectedIndex = -1;
            cbxNombre.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rutaArchivo = @"C:\Users\JUNIOR\Desktop\Factura.txt";

            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                // Encabezado
                writer.WriteLine("==========================");
                writer.WriteLine("          FACTURA");
                writer.WriteLine("==========================");
                writer.WriteLine($"Fecha: {DateTime.Now:dd/MM/yyyy}");
                writer.WriteLine();
                writer.WriteLine("==========================");
                writer.WriteLine("Productos");
                writer.WriteLine("==========================");
                writer.WriteLine("Nombre       Cantidad    Precio Unit.    Subtotal    Total");
                writer.WriteLine("----------------------------------------------------------");

                decimal granTotal = 0;

                // Escribir cada producto
                foreach (DataGridViewRow row in dtgwMinifactura.Rows)
                {
                    if (row.Cells["Nombre"].Value != null &&
                        row.Cells["Cantidad"].Value != null &&
                        row.Cells["Precio_Unit"].Value != null &&
                        row.Cells["Subtotal"].Value != null &&
                        row.Cells["Total"].Value != null)
                    {
                        string nombre = row.Cells[0].Value.ToString();
                        int cantidad = Convert.ToInt32(row.Cells[1].Value);
                        decimal precioUnitario = Convert.ToDecimal(row.Cells[2].Value);
                        decimal subtotal = Convert.ToDecimal(row.Cells[3].Value);
                        decimal total = Convert.ToDecimal(row.Cells[4].Value);

                        writer.WriteLine($"{nombre,-12} {cantidad,-10} {precioUnitario,12:C} {subtotal,12:C} {total,12:C}");

                        granTotal += total;
                    }
                }

                // Totales finales
                writer.WriteLine("----------------------------------------------------------");
                writer.WriteLine($"Gran Total: {granTotal,46:C}");
                writer.WriteLine("==========================");
                writer.WriteLine("Gracias por su compra.");
                writer.WriteLine("==========================");
            }

            // Confirmar éxito
            MessageBox.Show($"Factura generada con éxito en: {rutaArchivo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
