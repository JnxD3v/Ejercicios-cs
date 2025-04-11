using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Windows.Forms;

namespace Ejercicio_MDI___WF
{
    public partial class Productos : Form
    {
        private static Productos Comprovador = null;
        public static Productos Comprobante()
        {
            if (Comprovador == null)
            {
                Comprovador = new Productos();
                Comprovador.BringToFront();
                return Comprovador;
            }
            return Comprovador;
        }
        public Productos()
        {
            InitializeComponent();
        }

        int Fila = 0, p;

        private void btn_Buscar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Buscador.Text) //||
                                                             //int.TryParse(txt_Buscador.Text, out int a))
                )
            {
                MessageBox.Show("Ingrese un RNC Valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int i = 0;
                bool Encontrado = false;
                do
                {
                    dgw_Productos.Rows[i].Cells[0].Selected = false;
                    if (dgw_Productos.Rows[i].Cells[0].Value.ToString().Contains(txt_Buscador.Text))
                    {
                        Encontrado = true;
                    }
                    i++;
                } while (Encontrado != true);

                if (Encontrado == true)
                {
                    i = i - 1;
                    dgw_Productos.Rows[i].Cells[0].Selected = true;
                    MessageBox.Show("ID Encontrado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("ID no Encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Guardar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Categoria.Text) ||
                string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Precio.Text) ||
                string.IsNullOrWhiteSpace(txt_Stock.Text) ||
                !double.TryParse(txt_Precio.Text, out double n) ||
                !int.TryParse(txt_Stock.Text, out int a))
            {
                MessageBox.Show("Intente de nuevo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                MessageBox.Show("Guardado con Exito!", "Acción Completada");
                Fila = dgw_Productos.Rows.Add();

                p++;
                dgw_Productos.Rows[Fila].Cells[0].Value = p.ToString();
                dgw_Productos.Rows[Fila].Cells[1].Value = txt_Nombre.Text;
                dgw_Productos.Rows[Fila].Cells[2].Value = txt_Categoria.Text;
                dgw_Productos.Rows[Fila].Cells[3].Value = n.ToString("F2");
                dgw_Productos.Rows[Fila].Cells[4].Value = txt_Stock.Text;
            }
        }

        private void dgw_Productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dgw_Productos.SelectedRows[0].Index;

            txt_Nombre.Text = dgw_Productos.Rows[a].Cells[1].Value.ToString();
            txt_Categoria.Text = dgw_Productos.Rows[a].Cells[2].Value.ToString();
            txt_Precio.Text = dgw_Productos.Rows[a].Cells[3].Value.ToString();
            txt_Stock.Text = dgw_Productos.Rows[a].Cells[4].Value.ToString();
        }

        private void Productos_Load(object sender, System.EventArgs e)
        {

        }

        private void btn_Editar_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Categoria.Text) ||
                string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Precio.Text) ||
                string.IsNullOrWhiteSpace(txt_Stock.Text) ||
                !double.TryParse(txt_Precio.Text, out double n) ||
                !int.TryParse(txt_Stock.Text, out int a))
            {
                MessageBox.Show("Intente de nuevo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Guardado con Exito!", "Acción Completada");
                int filaSeleccionada = dgw_Productos.SelectedRows[0].Index;

                dgw_Productos.Rows[filaSeleccionada].Cells[0].Value = p.ToString();
                dgw_Productos.Rows[filaSeleccionada].Cells[1].Value = txt_Nombre.Text;
                dgw_Productos.Rows[filaSeleccionada].Cells[2].Value = txt_Categoria.Text;
                dgw_Productos.Rows[filaSeleccionada].Cells[3].Value = n.ToString("F2");
                dgw_Productos.Rows[filaSeleccionada].Cells[4].Value = txt_Stock.Text;
            }

        }

        private void btn_Linea_Click(object sender, System.EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, System.EventArgs e)
        {
            if (dgw_Productos.SelectedRows.Count > 0)
            {
                DialogResult Opcion = MessageBox.Show(
                    "¿Estas seguro/a que quieres eliminar este registro?",
                    "Confirmación",
                    MessageBoxButtons.YesNo);

                if (Opcion == DialogResult.Yes)
                {
                    int filaSeleccionada = dgw_Productos.SelectedRows[0].Index;
                    dgw_Productos.Rows.RemoveAt(filaSeleccionada);

                    MessageBox.Show("Registro eliminado con exito.",
                    "Acción completada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Confirmacion cancelada.",
                        "Acción cancelada.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show(
                    "Seleccion una fila para eliminar.",
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
