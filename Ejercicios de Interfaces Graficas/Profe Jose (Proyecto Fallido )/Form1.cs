using System;
using System.IO;
using System.Windows.Forms;

namespace Profe_Jose
{
    public partial class Inscripciones : Form
    {
        int Enfermeria = 0;
        int Informatica = 0;
        int Gastronomia = 0;
        int Contabilidad = 0;
        int Electricidad = 0;

        public Inscripciones()
        {
            InitializeComponent();
        }

        private void btn_Inscribirse_Click(object sender, EventArgs e)
        {
            if (cbx_Enfermeria.Checked)
            {
                listBox1.Items.Add("Enfermería");
                cbx_Contabilidad.Enabled = false;
                cbx_Electricidad.Enabled = false;
                cbx_Gastronomia.Enabled = false;
                cbx_Informatica.Enabled = false;
                btn_Inscribirse.Enabled = false;
                cbx_Enfermeria.Enabled = false;

                Enfermeria++;
                string texto = $"Enfermería: {Enfermeria}";
                using (StreamWriter archivo = new StreamWriter(@"C:\Users\Micha\source\repos\Ejercicios de Interfaces Graficas\Profe Jose (Proyecto Fallido )\ArchivoCreado\txtEnfermeria.txt"))
                {
                    archivo.WriteLine(texto);
                }
            }
            else if (cbx_Informatica.Checked)
            {
                listBox1.Items.Add("Informática");
                cbx_Contabilidad.Enabled = false;
                cbx_Electricidad.Enabled = false;
                cbx_Gastronomia.Enabled = false;
                cbx_Informatica.Enabled = false;
                btn_Inscribirse.Enabled = false;
                cbx_Enfermeria.Enabled = false;

                Informatica++;
                string texto = $"Informática: {Informatica}";
                using (StreamWriter archivo = new StreamWriter(@"C:\Users\Micha\source\repos\Ejercicios de Interfaces Graficas\Profe Jose (Proyecto Fallido )\ArchivoCreado\txtInformatica.txt"))
                {
                    archivo.WriteLine(texto);
                }
            }
            else if (cbx_Gastronomia.Checked)
            {
                listBox1.Items.Add("Gastronomía");
                cbx_Contabilidad.Enabled = false;
                cbx_Electricidad.Enabled = false;
                cbx_Gastronomia.Enabled = false;
                cbx_Informatica.Enabled = false;
                btn_Inscribirse.Enabled = false;
                cbx_Enfermeria.Enabled = false;

                Gastronomia++;
                string texto = $"Gastronomía: {Gastronomia}";
                using (StreamWriter archivo = new StreamWriter(@"C:\Users\Micha\source\repos\Ejercicios de Interfaces Graficas\Profe Jose (Proyecto Fallido )\ArchivoCreado\txtGastronomia.txt"))
                {
                    archivo.WriteLine(texto);
                }
            }
            else if (cbx_Contabilidad.Checked)
            {
                listBox1.Items.Add("Contabilidad");
                cbx_Contabilidad.Enabled = false;
                cbx_Electricidad.Enabled = false;
                cbx_Gastronomia.Enabled = false;
                cbx_Informatica.Enabled = false;
                btn_Inscribirse.Enabled = false;
                cbx_Enfermeria.Enabled = false;

                Contabilidad++;
                string texto = $"Contabilidad: {Contabilidad}";
                using (StreamWriter archivo = new StreamWriter(@"C:\Users\Micha\source\repos\Ejercicios de Interfaces Graficas\Profe Jose (Proyecto Fallido )\ArchivoCreado\txtContabilidad.txt"))
                {
                    archivo.WriteLine(texto);
                }
            }
            else if (cbx_Electricidad.Checked)
            {
                listBox1.Items.Add("Electricidad");
                cbx_Contabilidad.Enabled = false;
                cbx_Electricidad.Enabled = false;
                cbx_Gastronomia.Enabled = false;
                cbx_Informatica.Enabled = false;
                btn_Inscribirse.Enabled = false;
                cbx_Enfermeria.Enabled = false;

                Electricidad++;
                string texto = $"Electricidad: {Electricidad}";
                using (StreamWriter archivo = new StreamWriter(@"C:\Users\Micha\source\repos\Ejercicios de Interfaces Graficas\Profe Jose (Proyecto Fallido )\ArchivoCreado\txtElectricidad.txt"))
                {
                    archivo.WriteLine(texto);
                }
            }
        }

        private void btn_NuevaInscripcion_Click(object sender, EventArgs e)
        {
            cbx_Contabilidad.Enabled = true;
            cbx_Electricidad.Enabled = true;
            cbx_Gastronomia.Enabled = true;
            cbx_Informatica.Enabled = true;
            btn_Inscribirse.Enabled = true;
            cbx_Enfermeria.Enabled = true;
        }
    }
}
