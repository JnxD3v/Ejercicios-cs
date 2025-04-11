using System.ComponentModel;

namespace _02_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblValor1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtValor1.Text);

            double num2 = double.Parse(txtValor2.Text);

            double suma, resta, multiplicacion, division;

            suma = num1 + num2;

            resta = num1 - num2;

            multiplicacion = num1 * num2;

            division = num1 / num2;

            txtResultadoSuma.Text = suma.ToString();

            txtResultadoDividir.Text = division.ToString();

            txtResultadoMulti.Text = multiplicacion.ToString();

            txtResultadoResta.Text = resta.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor2.Clear();

            txtValor1.Clear();

            txtResultadoSuma.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
