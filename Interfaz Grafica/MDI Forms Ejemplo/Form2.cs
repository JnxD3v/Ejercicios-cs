using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Forms_Ejemplo
{
    public partial class frm_Clientes : Form
    {
        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
        }
    }
}
