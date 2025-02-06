using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profe_John
{
    public partial class ProfeJohn : Form
    {
        public ProfeJohn()
        {
            InitializeComponent();
        }


        private void mDI1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_1 SubVentana1 = new MDI_1();
            SubVentana1.Show();
            SubVentana1.BringToFront();
        }

        private void windowsMenu_Click(object sender, EventArgs e)
        {
        }

        private void mDI2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI_2 SubVentana2 = new MDI_2();
            SubVentana2.Show();
            SubVentana2.BringToFront();
        }
    }
}
