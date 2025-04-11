using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prueba_Ardiente_xd
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void dgw_VerInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaSeleccionada = dgw_VerInfo.SelectedRows[0].Index;

            txt_AFP.Text = "";
            txt_SFS.Text = "";
            txt_ISR.Text = "";
            txt_Otro.Text = "";
            txt_TotalDesc.Text = "";

            lbl_SueldoNetoResultado.Text = "";
            lbl_SueldoTotalResultado.Text = "";

            txt_Nombre.Text = dgw_VerInfo.Rows[filaSeleccionada].Cells[0].Value.ToString();
            cbx_Cargos.Text = dgw_VerInfo.Rows[filaSeleccionada].Cells[1].Value.ToString();
            //txt_SueldoBruto.Text = dgw_VerInfo.Rows[filaSeleccionada].Cells[];
            
            txt_NumeroHijos.Text = dgw_VerInfo.Rows[filaSeleccionada].Cells[2].Value.ToString();

        }

        //private double sueldoAnual, AFP = 0.0304, SFS = 0.0287, ISR = 0, DescHijos,
        //    NumeroHijos, TotalDesc, TotalResultado, SueldoBruto, SueldoNeto;

        private void tabCalculoEmpleado_Click(object sender, EventArgs e)
        {

        }

        private int Fila = 0;
        private double SueldoU;
        private string ruta = @"C:\Users\Micha\Desktop\Empleados.txt";
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string texto = "======================================================================================================================================================================\n"
                         + "|       Nombre       |       Apellido       |       Hijos        |       Sueldo       |       Bono por Hijos       |       Impuestos       |       Sueldo Neto       |\n"
                         + "======================================================================================================================================================================\n";

            using (StreamWriter archivo = new StreamWriter(ruta))
            {
                archivo.WriteLine(texto);
            }

            double sueldoAnual, AFP = 0.0304, SFS = 0.0287, ISR = 0, DescHijos,
            NumeroHijos, TotalDesc, SueldoBruto, SueldoNeto;

            if (string.IsNullOrEmpty(txt_Nombre.Text) ||
                int.TryParse(txt_Nombre.Text, out int l) ||
                cbx_Cargos.SelectedIndex < 0 ||
                string.IsNullOrEmpty(txt_SueldoBruto.Text) ||
                string.IsNullOrEmpty(txt_NumeroHijos.Text) ||
                !double.TryParse(txt_SueldoBruto.Text, out double a) ||
                !int.TryParse(txt_NumeroHijos.Text, out int b))

            {
                MessageBox.Show("Complete todos los campos  para continuar.", "Error!");
            } else
            {
                MessageBox.Show("Guardado con éxito!", "Acción Completada");
                NumeroHijos = b;
                DescHijos = NumeroHijos * 100;
                SueldoBruto = a + DescHijos;

                SueldoU = SueldoBruto - DescHijos;
                AFP *= SueldoBruto;
                SFS *= SueldoBruto;

                sueldoAnual = SueldoBruto * 12;

                if (sueldoAnual < 416220)
                {
                    txt_ISR.ForeColor = System.Drawing.Color.Red;
                    ISR = 0;
                    txt_ISR.Text = "No aplica ISR.";
                }
                else if (sueldoAnual >= 416220 && sueldoAnual < 624329)
                {
                    ISR = (sueldoAnual - 416220) * 0.15;
                    ISR /= 12;
                    txt_ISR.Text = ISR.ToString("C2");
                }

                else if (sueldoAnual >= 624329 && sueldoAnual < 867123)
                {
                    ISR = 31216 + (sueldoAnual - 624329) * 0.20;
                    ISR /= 12;
                    txt_ISR.Text = ISR.ToString("C2");
                }

                else if (sueldoAnual >= 867123)
                {
                    ISR = 79776 + (sueldoAnual - 867123) * 0.25;
                    ISR /= 12;
                    txt_ISR.Text = ISR.ToString("C2");
                }

                TotalDesc = ISR + SFS + AFP;
                SueldoNeto = SueldoBruto - TotalDesc;

                txt_AFP.Text = AFP.ToString("C2");
                txt_SFS.Text = SFS.ToString("C2");
                txt_Otro.Text = DescHijos.ToString("C2");
                txt_TotalDesc.Text = TotalDesc.ToString("C2");
                lbl_SueldoNetoResultado.Text = SueldoNeto.ToString("C2");
                lbl_SueldoTotalResultado.Text = SueldoBruto.ToString("C2");

                Fila = dgw_VerInfo.Rows.Add();
                dgw_VerInfo.Rows[Fila].Cells[0].Value = txt_Nombre.Text;
                dgw_VerInfo.Rows[Fila].Cells[1].Value = cbx_Cargos.Text;
                dgw_VerInfo.Rows[Fila].Cells[2].Value = txt_NumeroHijos.Text;
                dgw_VerInfo.Rows[Fila].Cells[3].Value = SueldoBruto.ToString("C2");
                dgw_VerInfo.Rows[Fila].Cells[4].Value = DescHijos.ToString("C2");
                dgw_VerInfo.Rows[Fila].Cells[5].Value = TotalDesc.ToString("C2");
                dgw_VerInfo.Rows[Fila].Cells[6].Value = SueldoNeto.ToString("C2");

            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Campos limpiados!", "Accion Completada");

            txt_Nombre.Clear();
            cbx_Cargos.SelectedIndex = -1;
            txt_SueldoBruto.Clear();
            txt_NumeroHijos.Clear();

            txt_ISR.Clear();
            txt_AFP.Clear();
            txt_SFS.Clear();
            txt_Otro.Clear();
            txt_TotalDesc.Clear();
            lbl_SueldoNetoResultado.Text = "";
            lbl_SueldoTotalResultado.Text = "";
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgw_VerInfo.SelectedRows.Count > 0)
            {
                DialogResult Opcion = MessageBox.Show(
                    "¿Estas seguro/a que quieres eliminar este registro?", 
                    "Confirmación", 
                    MessageBoxButtons.YesNo);

                if (Opcion == DialogResult.Yes)
                {
                    int filaSeleccionada = dgw_VerInfo.SelectedRows[0].Index;
                    dgw_VerInfo.Rows.RemoveAt(filaSeleccionada);

                    MessageBox.Show("Registro eliminado con exito.", "Acción completada"
                    , MessageBoxButtons.OK,
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

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            double sueldoAnual, AFP = 0.0304, SFS = 0.0287, ISR = 0, DescHijos,
            NumeroHijos, TotalDesc, SueldoBruto, SueldoNeto;

            if (string.IsNullOrEmpty(txt_Nombre.Text) ||
                int.TryParse(txt_Nombre.Text, out int l) ||
                cbx_Cargos.SelectedIndex < 0 ||
                string.IsNullOrEmpty(txt_SueldoBruto.Text) ||
                string.IsNullOrEmpty(txt_NumeroHijos.Text) ||
                !double.TryParse(txt_SueldoBruto.Text, out double a) ||
                !int.TryParse(txt_NumeroHijos.Text, out int b))

            {
                MessageBox.Show("Complete todos los campos para continuar.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                #region Calculos de Editar
                MessageBox.Show("Editado con éxito!", "Acción Completada");
                NumeroHijos = b;
                DescHijos = NumeroHijos * 100;
                SueldoBruto = a + DescHijos;
                AFP *= SueldoBruto;
                SFS *= SueldoBruto;

                sueldoAnual = SueldoBruto * 12;

                if (sueldoAnual < 416220)
                {
                    txt_ISR.ForeColor = System.Drawing.Color.Red;
                    ISR = 0;
                    txt_ISR.Text = "No aplica ISR.";
                }
                else if (sueldoAnual >= 416220 && sueldoAnual < 624329)
                {
                    ISR = (sueldoAnual - 416220) * 0.15;
                    ISR /= 12;
                    txt_ISR.Text = ISR.ToString("C2");
                }

                else if (sueldoAnual >= 624329 && sueldoAnual < 867123)
                {
                    ISR = 31216 + (sueldoAnual - 624329) * 0.20;
                    ISR /= 12;
                    txt_ISR.Text = ISR.ToString("C2");
                }

                else if (sueldoAnual >= 867123)
                {
                    ISR = 79776 + (sueldoAnual - 867123) * 0.25;
                    ISR /= 12;
                    txt_ISR.Text = ISR.ToString("C2");
                }

                TotalDesc = ISR + SFS + AFP;
                SueldoNeto = SueldoBruto - TotalDesc;
                #endregion

                int filaSeleccionada = dgw_VerInfo.SelectedRows[0].Index;

                // Aqui lo esta pasando a la tabla.
                dgw_VerInfo.Rows[filaSeleccionada].Cells[0].Value = txt_Nombre.Text;
                dgw_VerInfo.Rows[filaSeleccionada].Cells[1].Value = cbx_Cargos.Text;
                dgw_VerInfo.Rows[filaSeleccionada].Cells[2].Value = txt_NumeroHijos.Text;
                dgw_VerInfo.Rows[filaSeleccionada].Cells[3].Value = SueldoBruto.ToString("C2");
                dgw_VerInfo.Rows[filaSeleccionada].Cells[4].Value = DescHijos.ToString("C2");
                dgw_VerInfo.Rows[filaSeleccionada].Cells[5].Value = TotalDesc.ToString("C2");
                dgw_VerInfo.Rows[filaSeleccionada].Cells[6].Value = SueldoNeto.ToString("C2");

            }
        }

        int b = 0;
        private void btn_GuardarTXT_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dgw_VerInfo.Rows.Count; i++)
            {
                string
                Celda1 = dgw_VerInfo.Rows[i].Cells[0].Value.ToString(),
                Celda2 = dgw_VerInfo.Rows[i].Cells[1].Value.ToString(),
                Celda3 = dgw_VerInfo.Rows[i].Cells[2].Value.ToString(),
                Celda4 = dgw_VerInfo.Rows[i].Cells[3].Value.ToString(),
                Celda5 = dgw_VerInfo.Rows[i].Cells[4].Value.ToString(),
                Celda6 = dgw_VerInfo.Rows[i].Cells[5].Value.ToString(),
                Celda7 = dgw_VerInfo.Rows[i].Cells[6].Value.ToString();

                string texto = $"|       {Celda1}       |       {Celda2}       |       {Celda3}        |       {Celda4}       |       {Celda5}       |       {Celda6}       |       {Celda7}       |\n"
                             + "____________________________________________________________________________________________________________________________________________________________________";
                
                
                    using (StreamWriter archivo = new StreamWriter(ruta, append: true))
                    {
                        archivo.WriteLine(texto);
                    }
            }

            MessageBox.Show("El archivo se guardó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
