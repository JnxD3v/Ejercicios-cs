namespace _06_Desafio_GUI
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_proveedores frm_Proveedores = new frm_proveedores();
            frm_Proveedores.ShowDialog();
            frm_Proveedores.Parent = this;

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_mProducto producto = new frm_mProducto();
            producto.ShowDialog();
            producto.Parent = this;
        }
    }
}
