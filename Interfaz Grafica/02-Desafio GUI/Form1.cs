namespace _02_Desafio_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEstudiante.Text;




            double nota1;
            double nota2;
            double nota3;
            double nota4;
            double Promedio;

            nota1 = int.Parse(txtNota1.Text);

            nota2 = int.Parse(txtNota2.Text);

            nota3 = int.Parse(txtNota3.Text);

            nota4 = int.Parse(txtNota4.Text);

            Promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            txtPromedio.Text = Promedio.ToString();

            if (Promedio >= 70)
            {
                txtStatus.BackColor = Color.GreenYellow;
                txtStatus.Text = "el estudiante: " + nombre + "ah sido aprovado";
            }
            else
            {
                txtStatus.BackColor = Color.Red;
                txtStatus.Text = "el estudiante: " + nombre + "ah sido reprovado";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
