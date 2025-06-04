using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }
        
        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void AbrirForm(object formhijo)
        {
            if (this.PanelFormulario.Controls.Count > 0)
                this.PanelFormulario.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelFormulario.Controls.Add(fh);
            this.PanelFormulario.Tag = fh;
            fh.Show();
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
            AbrirForm(new login());
        }

      
      

        
    }
}
