namespace EjemploBadelin
{
    public partial class Form1 : Form
    {
        private int y = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            y = dtgw_Alimentos.Rows.Add();

            dtgw_Alimentos.Rows[y].Cells[0].Value = cmbCodigo.Text;
            dtgw_Alimentos.Rows[y].Cells[1].Value = cmbAlimento.Text;
            dtgw_Alimentos.Rows[y].Cells[2].Value = cmbComestible.Text;


            cmbCodigo.Text = "";
            cmbAlimento.Text = "";
            cmbComestible.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
    }
}
