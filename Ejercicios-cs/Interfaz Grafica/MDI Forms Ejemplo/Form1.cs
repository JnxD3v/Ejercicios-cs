namespace MDI_Forms_Ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Clientes cliente = new frm_Clientes();
            cliente.MdiParent = this;
            cliente.Show(); 
            Form1 principal = new Form1();
            principal.Close();
        }
    }
}
