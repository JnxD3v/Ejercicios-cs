using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Desafio_GUI
{

    public partial class frm_proveedores : Form
    {
        public frm_proveedores()
        {
            InitializeComponent();
        }


        private void btn_agregar_Click(object sender, EventArgs e)
        {
            proveedores prov = new proveedores();

            prov.nombre = txt_nombre.Text;

            prov.rnc = txt_Rnc.Text;

            prov.telefono = txt_telefono.Text;

            prov.correo = txt_Correo.Text;

            prov.ciudad = txt_ciudad.Text;

            if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_Rnc.Text) ||
                string.IsNullOrWhiteSpace(txt_telefono.Text) ||
               string.IsNullOrWhiteSpace(txt_direccion.Text) ||
               string.IsNullOrWhiteSpace(txt_ciudad.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Guardado con éxito!", "Acción Completada");


                int fila = dtgw_proveedores.Rows.Add();


                dtgw_proveedores.Rows[fila].Cells[0].Value = fila;
                dtgw_proveedores.Rows[fila].Cells[1].Value = txt_nombre.Text;
                dtgw_proveedores.Rows[fila].Cells[2].Value = txt_Rnc.Text;
                dtgw_proveedores.Rows[fila].Cells[3].Value = txt_telefono.Text;
                dtgw_proveedores.Rows[fila].Cells[4].Value = txt_direccion.Text;
                dtgw_proveedores.Rows[fila].Cells[5].Value = txt_ciudad.Text;


                txt_nombre.Clear();
                txt_Rnc.Clear();
                txt_telefono.Clear();
                txt_direccion.Clear();
                txt_Correo.Clear();
                txt_ciudad.Clear();
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dtgw_proveedores.ReadOnly = false;
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_nombre.Clear();
            txt_Rnc.Clear();
            txt_telefono.Clear();
            txt_direccion.Clear();
            txt_Correo.Clear();
            txt_ciudad.Clear();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_buscar.Text, out int id))
            {
                foreach (DataGridViewRow fila in dtgw_proveedores.Rows)
                {
                    if (fila.Cells["ID"].Value != null && Convert.ToInt32(fila.Cells["ID"].Value) == id)
                    {
                        fila.Selected = true;
                         
                    }
                }

              
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
            }
        }
    }

    class proveedores 
    {
        public string nombre {  get; set; }

        public string rnc { get; set; }

        public string telefono { get; set; }

        public  string direccion { get; set; }

        public string correo { get; set; }

        public string ciudad {  get; set; }

             
    }


}

