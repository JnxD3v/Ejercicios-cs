using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Profe_Saimon
{
    public partial class ProfeSaimon : Form
    {
        public ProfeSaimon()
        {
            InitializeComponent();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog Prueba = new OpenFileDialog()
            {
                Title = "Seleccionar archivo",
                Filter = "Seleccionar archivos de extension .txt: |*.txt",
                ShowHelp = true,
            };

            Prueba.HelpRequest += (Sender, r) =>
            {
                MessageBox.Show("Selecciona un archivo de texto:");
            };

            if (Prueba.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = Prueba.FileName;
                string contenidoArchivo = File.ReadAllText(rutaArchivo);


                rtxt_TexboxRico.Text = contenidoArchivo;
            }
        }
    }
}
