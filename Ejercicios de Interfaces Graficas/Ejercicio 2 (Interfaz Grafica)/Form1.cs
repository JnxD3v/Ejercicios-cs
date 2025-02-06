using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2__Interfaz_Grafica_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Numero1.Text = string.Empty;
            Numero2.Text = string.Empty;
        }

        private double n1, n2;
        private void btn_Calcular_Click (object sender, EventArgs e)
        {
            n1 = Convert.ToInt32(Numero1.Text);
            n2 = Convert.ToInt32(Numero2.Text);

            lbl_Suma.Text = " " + (n1 + n2);
            lbl_Resta.Text = " " + (n1 - n2);
            lbl_Multi.Text = " " + (n1 * n2);
            lbl_Division.Text = " " + (n1 / n2);
        }
    }
}
