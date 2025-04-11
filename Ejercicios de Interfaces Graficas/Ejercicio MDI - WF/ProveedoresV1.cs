using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ejercicio_MDI___WF
{
    public partial class ProveedoresV1 : Form
    {
        private string RNC, Nombre, Direccion, Correo, Ciudad;
        private string ValidacionEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        private void dgw_Proveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = dgw_Proveedores.SelectedRows[0].Index;

            txt_RNC.Text = dgw_Proveedores.Rows[a].Cells[0].Value.ToString();
            txt_Nombre.Text = dgw_Proveedores.Rows[a].Cells[1].Value.ToString();
            txt_Correo.Text = dgw_Proveedores.Rows[a].Cells[2].Value.ToString();
            txt_Direccion.Text = dgw_Proveedores.Rows[a].Cells[3].Value.ToString();
            txt_Ciudad.Text = dgw_Proveedores.Rows[a].Cells[4].Value.ToString();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgw_Proveedores.SelectedRows.Count > 0)
            {
                DialogResult Opcion = MessageBox.Show(
                    "¿Estas seguro/a que quieres eliminar este registro?",
                    "Confirmación",
                    MessageBoxButtons.YesNo);

                if (Opcion == DialogResult.Yes)
                {
                    int filaSeleccionada = dgw_Proveedores.SelectedRows[0].Index;
                    dgw_Proveedores.Rows.RemoveAt(filaSeleccionada);

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

        private int b = 0;
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_RNC.Text) ||
                string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Direccion.Text) ||
                string.IsNullOrWhiteSpace(txt_Correo.Text) ||
                string.IsNullOrWhiteSpace(txt_Correo.Text) ||
                !Regex.IsMatch(txt_Correo.Text, ValidacionEmail)
                )
            {
                MessageBox.Show("Intente de nuevo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Guardado con Exito!", "Acción Completada");
                int b = dgw_Proveedores.Rows.Add();

                dgw_Proveedores.Rows[b].Cells[0].Value = txt_RNC.Text;
                dgw_Proveedores.Rows[b].Cells[1].Value = txt_Nombre.Text;
                dgw_Proveedores.Rows[b].Cells[2].Value = txt_Correo.Text;
                dgw_Proveedores.Rows[b].Cells[3].Value = txt_Direccion.Text;
                dgw_Proveedores.Rows[b].Cells[4].Value = txt_Ciudad.Text;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {

                int i = 0;
                if (string.IsNullOrWhiteSpace(txt_Buscador.Text) //||
                                                                 //int.TryParse(txt_Buscador.Text, out int a))
                )
                {
                    MessageBox.Show("Ingrese un RNC Valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool Encontrado = false;
                    do
                    {
                        if (dgw_Proveedores.Rows[i].Cells[0].Value.ToString().Contains(txt_Buscador.Text))
                        {
                            dgw_Proveedores.Rows[i].Cells[0].Selected = true;
                            MessageBox.Show("ID Encontrado", "Acción completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Encontrado = true;
                        }
                        else { i++; }
                    } while (Encontrado != true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ID no Encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_RNC.Text) ||
                string.IsNullOrWhiteSpace(txt_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Direccion.Text) ||
                string.IsNullOrWhiteSpace(txt_Correo.Text) ||
                string.IsNullOrWhiteSpace(txt_Correo.Text) ||
                !Regex.IsMatch(txt_Correo.Text, ValidacionEmail)
                )
            {
                MessageBox.Show("Intente de nuevo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Guardado con Exito!", "Acción Completada");
                int filaSeleccionada = dgw_Proveedores.SelectedRows[0].Index;

                dgw_Proveedores.Rows[filaSeleccionada].Cells[0].Value = txt_RNC.Text;
                dgw_Proveedores.Rows[filaSeleccionada].Cells[1].Value = txt_Nombre.Text;
                dgw_Proveedores.Rows[filaSeleccionada].Cells[2].Value = txt_Correo.Text;
                dgw_Proveedores.Rows[filaSeleccionada].Cells[3].Value = txt_Direccion.Text;
                dgw_Proveedores.Rows[filaSeleccionada].Cells[4].Value = txt_Ciudad.Text;
            }
        }

        private static ProveedoresV1 Comprovador = null;
        public static ProveedoresV1 Comprobante()
        {
            if (Comprovador == null)
            {
                Comprovador = new ProveedoresV1();
                Comprovador.BringToFront();
                return Comprovador;
            }
            return Comprovador;
        }

        public ProveedoresV1()
        {
            InitializeComponent();
        }
    }
}
