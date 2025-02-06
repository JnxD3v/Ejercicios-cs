using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3__Interfaz_Grafica_
{
    public partial class CalcularImpuestos : Form
    {
        
        public CalcularImpuestos()
        {
            InitializeComponent();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        protected void txt_SueldoHora_TextChanged(object sender, EventArgs e)
        {

            this.txt_SueldoHora.SelectionLength = 0;
            if (string.IsNullOrEmpty(txt_SueldoHora.Text))
            {
                lbl_MensajeSueldoHora.Visible = true;
            }
            else
            {
                lbl_MensajeSueldoHora.Visible = false;
            }
        }

        protected void txt_CantidadHijos_TextChanged(object sender, EventArgs e)
        {
            this.txt_SueldoHora.SelectionLength = 0;
            if (string.IsNullOrEmpty(txt_CantidadHijos.Text))
            {
                lbl_MensajeCantidadHijos.Visible = true;
            }
            else
            {
                lbl_MensajeCantidadHijos.Visible = false;
            }
        }

        private void txt_HorasTrabajadas_TextChanged(object sender, EventArgs e)
        {
            this.txt_SueldoHora.SelectionLength = 0;
            if (string.IsNullOrEmpty(txt_HorasTrabajadas.Text))
            {
                lbl_MensajeHorasTrabajadas.Visible = true;
            }
            else
            {
                lbl_MensajeHorasTrabajadas.Visible = false;
            }
        }
        private void txt_IngreseNombre_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IngreseNombre.Text))
            {
                lbl_IngreseNombreCompleto.Visible = true;
            }
            else
            {
                lbl_IngreseNombreCompleto.Visible = false;
            }
        }

        protected void txt_IngreseSuCargo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_IngreseCargo.Text))
            {
                lbl_IngreseCargoR.Visible = true;
            }
            else
            {
                lbl_IngreseCargoR.Visible = false;
            }
        }

        private void CalcularImpuestos_Load(object sender, EventArgs e)
        {

        }

        private void lbl_IndCantidadHijos_Click(object sender, EventArgs e)
        {

        }

        protected void lbl_MensajeSueldoHora_Click(object sender, EventArgs e)
        {
            txt_SueldoHora.Focus();
        }

        private void lbl_MensajeCantidadHijos_Click(object sender, EventArgs e)
        {
           txt_CantidadHijos.Focus();
        }

        protected void lbl_MensajeHorasTrabajadas_Click(object sender, EventArgs e)
        {
            txt_HorasTrabajadas.Focus();
        }

        protected void txt_IngreseSuCargo_Click(object sender, EventArgs e)
        {
            txt_IngreseCargo.Focus();
        }

        private void btn_HacerCalculo_Click(object sender, EventArgs e)
        {
            HacerCalculos();
        }

        private void lbl_IngreseNombreCompleto_Click(object sender, EventArgs e)
        {
            txt_IngreseNombre.Focus();
        }

        public void HacerCalculos()
        {

            int HorasTrabajadas = Convert.ToInt32(txt_HorasTrabajadas.Text);
            int PagoPorHora = Convert.ToInt32(txt_SueldoHora.Text);
            int CantidadHijos = Convert.ToInt32(txt_CantidadHijos.Text);

            double Bonificacion = CantidadHijos * 500;
            double SueldoBrutoSemanal = HorasTrabajadas * PagoPorHora;
            double SueldoBrutoAnual = SueldoBrutoSemanal * 52;
            
            double AFP = SueldoBrutoSemanal * 0.0287;
            double SFS = SueldoBrutoSemanal * 0.0304;
            double ISR = 0;
            double Otros = 10;

            double TotalDeducciones = AFP + SFS + ISR + Otros;
            double SueldoNetoAnual = (SueldoBrutoAnual - TotalDeducciones) + Bonificacion;

            if (SueldoBrutoAnual < 416220)
            {
                SueldoNetoAnual = SueldoBrutoAnual - TotalDeducciones;
            }
            else if (SueldoBrutoAnual >= 416220 && SueldoBrutoAnual < 624329)
            {
                ISR = (SueldoBrutoAnual - 416220) * 0.15;
                SueldoNetoAnual = SueldoBrutoAnual - TotalDeducciones;
            }
            else if (SueldoBrutoAnual >= 624329 && SueldoBrutoAnual < 867123)
            {
                ISR = 31216 + (SueldoBrutoAnual - 624329) * 0.20;
                SueldoNetoAnual = SueldoBrutoAnual - TotalDeducciones;
            }
            else if (SueldoBrutoAnual >= 867123)
            {
                ISR = 79776 + (SueldoBrutoAnual - 867123) * 0.25;
                SueldoNetoAnual = SueldoBrutoAnual - TotalDeducciones;
            }

            //SueldoNetoAnual = (SueldoBrutoAnual - TotalDeducciones) + Bonificacion;
            double SueldoNetoSemanal;
            SueldoBrutoSemanal += Bonificacion;
            SueldoNetoSemanal = SueldoBrutoSemanal - TotalDeducciones;
            ISR /= 52;


            if (ISR != 0)
            {
                lbl_ISR.Text = " " + ISR.ToString("C2");
            } else
            {
                lbl_ISR.Text = "No aplica para ISR.";
            }

            label1.Text = AFP.ToString("C2");
            lbl_SFS.Text = SFS.ToString("C2");
            lbl_OtrosR.Text = 100.ToString("C2");

            t1.Text = SueldoNetoSemanal.ToString("C2");
            t2.Text = SueldoBrutoSemanal.ToString("C2");
            lbl_BonificacionTexto.Text = Bonificacion.ToString("C2");
            lbl_NombreInfoR.Text = txt_IngreseNombre.Text;
            lbl_CargoInfoR.Text = txt_IngreseCargo.Text;

            txt_SueldoHora.Focus();
        }

        protected void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_SueldoHora.Focus();

            txt_HorasTrabajadas.Clear();
            txt_SueldoHora.Clear();
            txt_CantidadHijos.Clear();
            txt_IngreseCargo.Clear();
            txt_IngreseNombre.Clear();
        }

        protected void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected void Btn_HacerCalculo_MouseEnter(object sender, EventArgs e)
        {
            this.btn_HacerCalculo.FlatAppearance.BorderSize = 1;
            this.btn_HacerCalculo.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#575759");
        }
        protected void Btn_HacerCalculo_MouseLeave(object sender, EventArgs e)
        {
            this.btn_HacerCalculo.FlatAppearance.BorderSize = 0;
        }

        protected void Btn_Salir_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Salir.FlatAppearance.BorderSize = 1;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#575759");
        }
        protected void Btn_Salir_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Salir.FlatAppearance.BorderSize = 0;
        }
        protected void Btn_Limpiar_MouseEnter(object sender, EventArgs e)
        {
            this.btn_Limpiar.FlatAppearance.BorderSize = 1;
            this.btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#575759");
        }
        protected void Btn_Limpiar_MouseLeave(object sender, EventArgs e)
        {
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
        }
    }
}
