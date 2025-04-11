using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profe_Francisco
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label2.Text = "Tu genero es: Hombre";
            }
            if (checkBox2.Checked == true)
            {
                label2.Text = "Tu genero es: Mujer";
            }
        }
    }
}
