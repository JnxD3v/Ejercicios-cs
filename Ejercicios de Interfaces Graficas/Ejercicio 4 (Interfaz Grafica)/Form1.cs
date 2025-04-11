using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4__Interfaz_Grafica_
{
    public partial class RegistroDeCalificaciones : Form
    {
        public RegistroDeCalificaciones()
        {
            InitializeComponent();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void linea1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_Curso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbtn_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private double nota1, nota2, nota3, nota4, Promedio;

        private void RegistroDeCalificaciones_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Curso_Click(object sender, EventArgs e)
        {

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nota1.Clear();
            txt_Nota2.Clear();
            txt_Nota3.Clear();
            txt_Nota4.Clear();
            txt_Nombre.Clear();
            txt_Nombre.Focus();

            cmb_Area.SelectedIndex = -1;
            cmb_Curso.SelectedIndex = -1;
            cmb_Seccion.SelectedIndex = -1;
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            nota1 = Convert.ToDouble(txt_Nota1.Text); 
            nota2 = Convert.ToDouble(txt_Nota2.Text); 
            nota3 = Convert.ToDouble(txt_Nota3.Text); 
            nota4 = Convert.ToDouble(txt_Nota4.Text);

            Promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            lbl_Promedio.Text = "• PROMEDIO: " + Promedio;

            if (Promedio >= 70)
            {
                lbl_StatusR.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl_StatusR.ForeColor = Color.Green;
                lbl_StatusR.Text = "APROVADO";
            } else
            {
                lbl_StatusR.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl_StatusR.ForeColor = Color.Red;
                lbl_StatusR.Text = "REPROVADO";
            }
        }
    }
}
