using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Text;
using System.Drawing;


namespace Ejercicio_3__Interfaz_Grafica_
{
 
    partial class CalcularImpuestos
    {
              
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalcularImpuestos));
            this.Titulo = new System.Windows.Forms.Label();
            this.txt_SueldoHora = new System.Windows.Forms.TextBox();
            this.lbl_MensajeSueldoHora = new System.Windows.Forms.Label();
            this.txt_CantidadHijos = new System.Windows.Forms.TextBox();
            this.lbl_MensajeCantidadHijos = new System.Windows.Forms.Label();
            this.lbl_IndCantidadHijos = new System.Windows.Forms.Label();
            this.btn_linea = new System.Windows.Forms.Button();
            this.btn_linea2 = new System.Windows.Forms.Button();
            this.lbl_IndSueldoHora = new System.Windows.Forms.Label();
            this.lbl_TotalDeduciones = new System.Windows.Forms.Label();
            this.lbl_IndHorasTrabajadas = new System.Windows.Forms.Label();
            this.txt_HorasTrabajadas = new System.Windows.Forms.TextBox();
            this.lbl_MensajeHorasTrabajadas = new System.Windows.Forms.Label();
            this.btn_HacerCalculo = new System.Windows.Forms.Button();
            this.lbl_AFP_Texto = new System.Windows.Forms.Label();
            this.lbl_SFS_Texto = new System.Windows.Forms.Label();
            this.lbl_ISR_Texto = new System.Windows.Forms.Label();
            this.lbl_ISR = new System.Windows.Forms.Label();
            this.lbl_TituloSueldos = new System.Windows.Forms.Label();
            this.lbl_SueldoNetoSemanal = new System.Windows.Forms.Label();
            this.lbl_SueldoBrutoSemanal = new System.Windows.Forms.Label();
            this.lbl_SFS = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Label();
            this.t2 = new System.Windows.Forms.Label();
            this.lbl_Bonificacion = new System.Windows.Forms.Label();
            this.lbl_BonificacionTexto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_NombreInfo = new System.Windows.Forms.Label();
            this.lbl_NombreInfoR = new System.Windows.Forms.Label();
            this.lbl_CargoInfo = new System.Windows.Forms.Label();
            this.lbl_CargoInfoR = new System.Windows.Forms.Label();
            this.lbl_Otros = new System.Windows.Forms.Label();
            this.lbl_OtrosR = new System.Windows.Forms.Label();
            this.lbl_IngreseNombre = new System.Windows.Forms.Label();
            this.txt_IngreseNombre = new System.Windows.Forms.TextBox();
            this.lbl_IngreseNombreCompleto = new System.Windows.Forms.Label();
            this.lbl_IngreseCargo = new System.Windows.Forms.Label();
            this.txt_IngreseCargo = new System.Windows.Forms.TextBox();
            this.lbl_IngreseCargoR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Titulo.Location = new System.Drawing.Point(177, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(242, 30);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "CALCULAR SUELDO";
            // 
            // txt_SueldoHora
            // 
            this.txt_SueldoHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.txt_SueldoHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_SueldoHora.Location = new System.Drawing.Point(53, 219);
            this.txt_SueldoHora.Name = "txt_SueldoHora";
            this.txt_SueldoHora.Size = new System.Drawing.Size(198, 20);
            this.txt_SueldoHora.TabIndex = 1;
            this.txt_SueldoHora.TextChanged += new System.EventHandler(this.txt_SueldoHora_TextChanged);
            // 
            // lbl_MensajeSueldoHora
            // 
            this.lbl_MensajeSueldoHora.AutoSize = true;
            this.lbl_MensajeSueldoHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.lbl_MensajeSueldoHora.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_MensajeSueldoHora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MensajeSueldoHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbl_MensajeSueldoHora.Location = new System.Drawing.Point(71, 221);
            this.lbl_MensajeSueldoHora.Name = "lbl_MensajeSueldoHora";
            this.lbl_MensajeSueldoHora.Size = new System.Drawing.Size(162, 15);
            this.lbl_MensajeSueldoHora.TabIndex = 0;
            this.lbl_MensajeSueldoHora.Text = "Ingrese su sueldo por hora..";
            this.lbl_MensajeSueldoHora.Click += new System.EventHandler(this.lbl_MensajeSueldoHora_Click);
            // 
            // txt_CantidadHijos
            // 
            this.txt_CantidadHijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.txt_CantidadHijos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_CantidadHijos.Location = new System.Drawing.Point(53, 343);
            this.txt_CantidadHijos.Name = "txt_CantidadHijos";
            this.txt_CantidadHijos.Size = new System.Drawing.Size(198, 20);
            this.txt_CantidadHijos.TabIndex = 1;
            this.txt_CantidadHijos.TextChanged += new System.EventHandler(this.txt_CantidadHijos_TextChanged);
            // 
            // lbl_MensajeCantidadHijos
            // 
            this.lbl_MensajeCantidadHijos.AutoSize = true;
            this.lbl_MensajeCantidadHijos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.lbl_MensajeCantidadHijos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_MensajeCantidadHijos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MensajeCantidadHijos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbl_MensajeCantidadHijos.Location = new System.Drawing.Point(71, 345);
            this.lbl_MensajeCantidadHijos.Name = "lbl_MensajeCantidadHijos";
            this.lbl_MensajeCantidadHijos.Size = new System.Drawing.Size(162, 15);
            this.lbl_MensajeCantidadHijos.TabIndex = 0;
            this.lbl_MensajeCantidadHijos.Text = "Ingrese cuantos hijos tiene..";
            this.lbl_MensajeCantidadHijos.Click += new System.EventHandler(this.lbl_MensajeCantidadHijos_Click);
            // 
            // lbl_IndCantidadHijos
            // 
            this.lbl_IndCantidadHijos.AutoSize = true;
            this.lbl_IndCantidadHijos.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IndCantidadHijos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_IndCantidadHijos.Location = new System.Drawing.Point(73, 330);
            this.lbl_IndCantidadHijos.Name = "lbl_IndCantidadHijos";
            this.lbl_IndCantidadHijos.Size = new System.Drawing.Size(164, 15);
            this.lbl_IndCantidadHijos.TabIndex = 0;
            this.lbl_IndCantidadHijos.Text = "¿CUÁNTOS HIJOS TIENE?";
            this.lbl_IndCantidadHijos.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // btn_linea
            // 
            this.btn_linea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_linea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_linea.Location = new System.Drawing.Point(-5, 64);
            this.btn_linea.Name = "btn_linea";
            this.btn_linea.Size = new System.Drawing.Size(1535, 1);
            this.btn_linea.TabIndex = 2;
            this.btn_linea.UseVisualStyleBackColor = false;
            // 
            // btn_linea2
            // 
            this.btn_linea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btn_linea2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_linea2.Location = new System.Drawing.Point(295, 63);
            this.btn_linea2.Name = "btn_linea2";
            this.btn_linea2.Size = new System.Drawing.Size(1, 1520);
            this.btn_linea2.TabIndex = 2;
            this.btn_linea2.UseVisualStyleBackColor = false;
            // 
            // lbl_IndSueldoHora
            // 
            this.lbl_IndSueldoHora.AutoSize = true;
            this.lbl_IndSueldoHora.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IndSueldoHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_IndSueldoHora.Location = new System.Drawing.Point(50, 201);
            this.lbl_IndSueldoHora.Name = "lbl_IndSueldoHora";
            this.lbl_IndSueldoHora.Size = new System.Drawing.Size(207, 15);
            this.lbl_IndSueldoHora.TabIndex = 0;
            this.lbl_IndSueldoHora.Text = "INGRESE SU SUELDO POR HORA";
            this.lbl_IndSueldoHora.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_TotalDeduciones
            // 
            this.lbl_TotalDeduciones.AutoSize = true;
            this.lbl_TotalDeduciones.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalDeduciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_TotalDeduciones.Location = new System.Drawing.Point(308, 83);
            this.lbl_TotalDeduciones.Name = "lbl_TotalDeduciones";
            this.lbl_TotalDeduciones.Size = new System.Drawing.Size(204, 38);
            this.lbl_TotalDeduciones.TabIndex = 0;
            this.lbl_TotalDeduciones.Text = "• TOTAL DEDUCCIONES •\n (Semanal)";
            this.lbl_TotalDeduciones.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_IndHorasTrabajadas
            // 
            this.lbl_IndHorasTrabajadas.AutoSize = true;
            this.lbl_IndHorasTrabajadas.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IndHorasTrabajadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_IndHorasTrabajadas.Location = new System.Drawing.Point(34, 261);
            this.lbl_IndHorasTrabajadas.Name = "lbl_IndHorasTrabajadas";
            this.lbl_IndHorasTrabajadas.Size = new System.Drawing.Size(233, 30);
            this.lbl_IndHorasTrabajadas.TabIndex = 0;
            this.lbl_IndHorasTrabajadas.Text = "INGRESE SUS HORAS TRABAJADAS \n(Semanales)";
            this.lbl_IndHorasTrabajadas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_IndHorasTrabajadas.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // txt_HorasTrabajadas
            // 
            this.txt_HorasTrabajadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.txt_HorasTrabajadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_HorasTrabajadas.Location = new System.Drawing.Point(51, 289);
            this.txt_HorasTrabajadas.Name = "txt_HorasTrabajadas";
            this.txt_HorasTrabajadas.Size = new System.Drawing.Size(198, 20);
            this.txt_HorasTrabajadas.TabIndex = 1;
            this.txt_HorasTrabajadas.TextChanged += new System.EventHandler(this.txt_HorasTrabajadas_TextChanged);
            // 
            // lbl_MensajeHorasTrabajadas
            // 
            this.lbl_MensajeHorasTrabajadas.AutoSize = true;
            this.lbl_MensajeHorasTrabajadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.lbl_MensajeHorasTrabajadas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_MensajeHorasTrabajadas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MensajeHorasTrabajadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbl_MensajeHorasTrabajadas.Location = new System.Drawing.Point(69, 291);
            this.lbl_MensajeHorasTrabajadas.Name = "lbl_MensajeHorasTrabajadas";
            this.lbl_MensajeHorasTrabajadas.Size = new System.Drawing.Size(176, 15);
            this.lbl_MensajeHorasTrabajadas.TabIndex = 0;
            this.lbl_MensajeHorasTrabajadas.Text = "Ingrese sus horas trabajadas..";
            this.lbl_MensajeHorasTrabajadas.Click += new System.EventHandler(this.lbl_MensajeHorasTrabajadas_Click);
            // 
            // btn_HacerCalculo
            // 
            this.btn_HacerCalculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btn_HacerCalculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HacerCalculo.FlatAppearance.BorderSize = 0;
            this.btn_HacerCalculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btn_HacerCalculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btn_HacerCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HacerCalculo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HacerCalculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_HacerCalculo.Location = new System.Drawing.Point(45, 399);
            this.btn_HacerCalculo.Name = "btn_HacerCalculo";
            this.btn_HacerCalculo.Size = new System.Drawing.Size(102, 35);
            this.btn_HacerCalculo.TabIndex = 3;
            this.btn_HacerCalculo.Text = "Hacer Calculo";
            this.btn_HacerCalculo.UseVisualStyleBackColor = false;
            this.btn_HacerCalculo.Click += new System.EventHandler(this.btn_HacerCalculo_Click);
            this.btn_HacerCalculo.MouseEnter += new System.EventHandler(this.Btn_HacerCalculo_MouseEnter);
            this.btn_HacerCalculo.MouseLeave += new System.EventHandler(this.Btn_HacerCalculo_MouseLeave);
            // 
            // lbl_AFP_Texto
            // 
            this.lbl_AFP_Texto.AutoSize = true;
            this.lbl_AFP_Texto.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AFP_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_AFP_Texto.Location = new System.Drawing.Point(317, 131);
            this.lbl_AFP_Texto.Name = "lbl_AFP_Texto";
            this.lbl_AFP_Texto.Size = new System.Drawing.Size(35, 15);
            this.lbl_AFP_Texto.TabIndex = 0;
            this.lbl_AFP_Texto.Text = "AFP:";
            this.lbl_AFP_Texto.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_SFS_Texto
            // 
            this.lbl_SFS_Texto.AutoSize = true;
            this.lbl_SFS_Texto.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SFS_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_SFS_Texto.Location = new System.Drawing.Point(318, 171);
            this.lbl_SFS_Texto.Name = "lbl_SFS_Texto";
            this.lbl_SFS_Texto.Size = new System.Drawing.Size(34, 15);
            this.lbl_SFS_Texto.TabIndex = 0;
            this.lbl_SFS_Texto.Text = "SFS:";
            this.lbl_SFS_Texto.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_ISR_Texto
            // 
            this.lbl_ISR_Texto.AutoSize = true;
            this.lbl_ISR_Texto.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ISR_Texto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_ISR_Texto.Location = new System.Drawing.Point(317, 151);
            this.lbl_ISR_Texto.Name = "lbl_ISR_Texto";
            this.lbl_ISR_Texto.Size = new System.Drawing.Size(32, 15);
            this.lbl_ISR_Texto.TabIndex = 0;
            this.lbl_ISR_Texto.Text = "ISR:";
            this.lbl_ISR_Texto.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_ISR
            // 
            this.lbl_ISR.AutoSize = true;
            this.lbl_ISR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lbl_ISR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_ISR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ISR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.lbl_ISR.Location = new System.Drawing.Point(357, 151);
            this.lbl_ISR.Name = "lbl_ISR";
            this.lbl_ISR.Size = new System.Drawing.Size(10, 15);
            this.lbl_ISR.TabIndex = 0;
            this.lbl_ISR.Text = " ";
            this.lbl_ISR.Click += new System.EventHandler(this.lbl_MensajeHorasTrabajadas_Click);
            // 
            // lbl_TituloSueldos
            // 
            this.lbl_TituloSueldos.AutoSize = true;
            this.lbl_TituloSueldos.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloSueldos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_TituloSueldos.Location = new System.Drawing.Point(308, 259);
            this.lbl_TituloSueldos.Name = "lbl_TituloSueldos";
            this.lbl_TituloSueldos.Size = new System.Drawing.Size(146, 19);
            this.lbl_TituloSueldos.TabIndex = 0;
            this.lbl_TituloSueldos.Text = "• INFORMACIÓN •";
            this.lbl_TituloSueldos.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_SueldoNetoSemanal
            // 
            this.lbl_SueldoNetoSemanal.AutoSize = true;
            this.lbl_SueldoNetoSemanal.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SueldoNetoSemanal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_SueldoNetoSemanal.Location = new System.Drawing.Point(318, 330);
            this.lbl_SueldoNetoSemanal.Name = "lbl_SueldoNetoSemanal";
            this.lbl_SueldoNetoSemanal.Size = new System.Drawing.Size(166, 15);
            this.lbl_SueldoNetoSemanal.TabIndex = 0;
            this.lbl_SueldoNetoSemanal.Text = " SUELDO NETO (Semanal):";
            this.lbl_SueldoNetoSemanal.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_SueldoBrutoSemanal
            // 
            this.lbl_SueldoBrutoSemanal.AutoSize = true;
            this.lbl_SueldoBrutoSemanal.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SueldoBrutoSemanal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_SueldoBrutoSemanal.Location = new System.Drawing.Point(318, 350);
            this.lbl_SueldoBrutoSemanal.Name = "lbl_SueldoBrutoSemanal";
            this.lbl_SueldoBrutoSemanal.Size = new System.Drawing.Size(176, 15);
            this.lbl_SueldoBrutoSemanal.TabIndex = 0;
            this.lbl_SueldoBrutoSemanal.Text = " SUELDO BRUTO (Semanal):";
            this.lbl_SueldoBrutoSemanal.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_SFS
            // 
            this.lbl_SFS.AutoSize = true;
            this.lbl_SFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lbl_SFS.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_SFS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.lbl_SFS.Location = new System.Drawing.Point(357, 170);
            this.lbl_SFS.Name = "lbl_SFS";
            this.lbl_SFS.Size = new System.Drawing.Size(10, 15);
            this.lbl_SFS.TabIndex = 0;
            this.lbl_SFS.Text = " ";
            this.lbl_SFS.Click += new System.EventHandler(this.lbl_MensajeHorasTrabajadas_Click);
            // 
            // t1
            // 
            this.t1.AutoSize = true;
            this.t1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.ForeColor = System.Drawing.Color.Silver;
            this.t1.Location = new System.Drawing.Point(500, 330);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(10, 15);
            this.t1.TabIndex = 0;
            this.t1.Text = " ";
            this.t1.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // t2
            // 
            this.t2.AutoSize = true;
            this.t2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.ForeColor = System.Drawing.Color.Silver;
            this.t2.Location = new System.Drawing.Point(500, 348);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(10, 15);
            this.t2.TabIndex = 0;
            this.t2.Text = " ";
            this.t2.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_Bonificacion
            // 
            this.lbl_Bonificacion.AutoSize = true;
            this.lbl_Bonificacion.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bonificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_Bonificacion.Location = new System.Drawing.Point(318, 211);
            this.lbl_Bonificacion.Name = "lbl_Bonificacion";
            this.lbl_Bonificacion.Size = new System.Drawing.Size(143, 15);
            this.lbl_Bonificacion.TabIndex = 0;
            this.lbl_Bonificacion.Text = "Bonificación por Hijos:";
            this.lbl_Bonificacion.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_BonificacionTexto
            // 
            this.lbl_BonificacionTexto.AutoSize = true;
            this.lbl_BonificacionTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lbl_BonificacionTexto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_BonificacionTexto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BonificacionTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.lbl_BonificacionTexto.Location = new System.Drawing.Point(467, 211);
            this.lbl_BonificacionTexto.Name = "lbl_BonificacionTexto";
            this.lbl_BonificacionTexto.Size = new System.Drawing.Size(10, 15);
            this.lbl_BonificacionTexto.TabIndex = 0;
            this.lbl_BonificacionTexto.Text = " ";
            this.lbl_BonificacionTexto.Click += new System.EventHandler(this.lbl_MensajeHorasTrabajadas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(357, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            this.label1.Click += new System.EventHandler(this.lbl_MensajeHorasTrabajadas_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btn_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.btn_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btn_Limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Limpiar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Limpiar.Location = new System.Drawing.Point(161, 399);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(102, 35);
            this.btn_Limpiar.TabIndex = 3;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            this.btn_Limpiar.MouseEnter += new System.EventHandler(this.Btn_Limpiar_MouseEnter);
            this.btn_Limpiar.MouseLeave += new System.EventHandler(this.Btn_Limpiar_MouseLeave);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(29)))), ((int)(((byte)(34)))));
            this.btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.btn_Salir.Location = new System.Drawing.Point(102, 451);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(102, 35);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            this.btn_Salir.MouseEnter += new System.EventHandler(this.Btn_Salir_MouseEnter);
            this.btn_Salir.MouseLeave += new System.EventHandler(this.Btn_Salir_MouseLeave);
            // 
            // lbl_NombreInfo
            // 
            this.lbl_NombreInfo.AutoSize = true;
            this.lbl_NombreInfo.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_NombreInfo.Location = new System.Drawing.Point(321, 290);
            this.lbl_NombreInfo.Name = "lbl_NombreInfo";
            this.lbl_NombreInfo.Size = new System.Drawing.Size(69, 15);
            this.lbl_NombreInfo.TabIndex = 0;
            this.lbl_NombreInfo.Text = "NOMBRE: ";
            this.lbl_NombreInfo.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_NombreInfoR
            // 
            this.lbl_NombreInfoR.AutoSize = true;
            this.lbl_NombreInfoR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreInfoR.ForeColor = System.Drawing.Color.Silver;
            this.lbl_NombreInfoR.Location = new System.Drawing.Point(397, 289);
            this.lbl_NombreInfoR.Name = "lbl_NombreInfoR";
            this.lbl_NombreInfoR.Size = new System.Drawing.Size(10, 15);
            this.lbl_NombreInfoR.TabIndex = 0;
            this.lbl_NombreInfoR.Text = " ";
            this.lbl_NombreInfoR.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_CargoInfo
            // 
            this.lbl_CargoInfo.AutoSize = true;
            this.lbl_CargoInfo.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CargoInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_CargoInfo.Location = new System.Drawing.Point(321, 310);
            this.lbl_CargoInfo.Name = "lbl_CargoInfo";
            this.lbl_CargoInfo.Size = new System.Drawing.Size(60, 15);
            this.lbl_CargoInfo.TabIndex = 0;
            this.lbl_CargoInfo.Text = "CARGO: ";
            this.lbl_CargoInfo.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_CargoInfoR
            // 
            this.lbl_CargoInfoR.AutoSize = true;
            this.lbl_CargoInfoR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CargoInfoR.ForeColor = System.Drawing.Color.Silver;
            this.lbl_CargoInfoR.Location = new System.Drawing.Point(397, 310);
            this.lbl_CargoInfoR.Name = "lbl_CargoInfoR";
            this.lbl_CargoInfoR.Size = new System.Drawing.Size(10, 15);
            this.lbl_CargoInfoR.TabIndex = 0;
            this.lbl_CargoInfoR.Text = " ";
            this.lbl_CargoInfoR.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_Otros
            // 
            this.lbl_Otros.AutoSize = true;
            this.lbl_Otros.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Otros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_Otros.Location = new System.Drawing.Point(317, 191);
            this.lbl_Otros.Name = "lbl_Otros";
            this.lbl_Otros.Size = new System.Drawing.Size(54, 15);
            this.lbl_Otros.TabIndex = 0;
            this.lbl_Otros.Text = "OTROS:";
            this.lbl_Otros.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // lbl_OtrosR
            // 
            this.lbl_OtrosR.AutoSize = true;
            this.lbl_OtrosR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lbl_OtrosR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_OtrosR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OtrosR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.lbl_OtrosR.Location = new System.Drawing.Point(377, 191);
            this.lbl_OtrosR.Name = "lbl_OtrosR";
            this.lbl_OtrosR.Size = new System.Drawing.Size(10, 15);
            this.lbl_OtrosR.TabIndex = 0;
            this.lbl_OtrosR.Text = " ";
            this.lbl_OtrosR.Click += new System.EventHandler(this.lbl_MensajeHorasTrabajadas_Click);
            // 
            // lbl_IngreseNombre
            // 
            this.lbl_IngreseNombre.AutoSize = true;
            this.lbl_IngreseNombre.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IngreseNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_IngreseNombre.Location = new System.Drawing.Point(84, 86);
            this.lbl_IngreseNombre.Name = "lbl_IngreseNombre";
            this.lbl_IngreseNombre.Size = new System.Drawing.Size(145, 15);
            this.lbl_IngreseNombre.TabIndex = 0;
            this.lbl_IngreseNombre.Text = "INGRESE SU NOMBRE:";
            this.lbl_IngreseNombre.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // txt_IngreseNombre
            // 
            this.txt_IngreseNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.txt_IngreseNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_IngreseNombre.Location = new System.Drawing.Point(51, 104);
            this.txt_IngreseNombre.Name = "txt_IngreseNombre";
            this.txt_IngreseNombre.Size = new System.Drawing.Size(198, 20);
            this.txt_IngreseNombre.TabIndex = 1;
            this.txt_IngreseNombre.TextChanged += new System.EventHandler(this.txt_IngreseNombre_TextChanged);
            // 
            // lbl_IngreseNombreCompleto
            // 
            this.lbl_IngreseNombreCompleto.AutoSize = true;
            this.lbl_IngreseNombreCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.lbl_IngreseNombreCompleto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_IngreseNombreCompleto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IngreseNombreCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbl_IngreseNombreCompleto.Location = new System.Drawing.Point(69, 106);
            this.lbl_IngreseNombreCompleto.Name = "lbl_IngreseNombreCompleto";
            this.lbl_IngreseNombreCompleto.Size = new System.Drawing.Size(172, 15);
            this.lbl_IngreseNombreCompleto.TabIndex = 0;
            this.lbl_IngreseNombreCompleto.Text = "Ingrese su nombre completo..";
            this.lbl_IngreseNombreCompleto.Click += new System.EventHandler(this.lbl_IngreseNombreCompleto_Click);
            // 
            // lbl_IngreseCargo
            // 
            this.lbl_IngreseCargo.AutoSize = true;
            this.lbl_IngreseCargo.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IngreseCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.lbl_IngreseCargo.Location = new System.Drawing.Point(78, 140);
            this.lbl_IngreseCargo.Name = "lbl_IngreseCargo";
            this.lbl_IngreseCargo.Size = new System.Drawing.Size(140, 15);
            this.lbl_IngreseCargo.TabIndex = 0;
            this.lbl_IngreseCargo.Text = "INGRESE SU CARGO: ";
            this.lbl_IngreseCargo.Click += new System.EventHandler(this.lbl_IndCantidadHijos_Click);
            // 
            // txt_IngreseCargo
            // 
            this.txt_IngreseCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.txt_IngreseCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_IngreseCargo.Location = new System.Drawing.Point(51, 162);
            this.txt_IngreseCargo.Name = "txt_IngreseCargo";
            this.txt_IngreseCargo.Size = new System.Drawing.Size(198, 20);
            this.txt_IngreseCargo.TabIndex = 1;
            this.txt_IngreseCargo.TextChanged += new System.EventHandler(this.txt_IngreseSuCargo_TextChanged);
            // 
            // lbl_IngreseCargoR
            // 
            this.lbl_IngreseCargoR.AutoSize = true;
            this.lbl_IngreseCargoR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.lbl_IngreseCargoR.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lbl_IngreseCargoR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IngreseCargoR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lbl_IngreseCargoR.Location = new System.Drawing.Point(84, 164);
            this.lbl_IngreseCargoR.Name = "lbl_IngreseCargoR";
            this.lbl_IngreseCargoR.Size = new System.Drawing.Size(142, 15);
            this.lbl_IngreseCargoR.TabIndex = 0;
            this.lbl_IngreseCargoR.Text = "Cargo en el que trabaja..";
            this.lbl_IngreseCargoR.Click += new System.EventHandler(this.txt_IngreseSuCargo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(467, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "by michael.frito";
            // 
            // CalcularImpuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(599, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_HacerCalculo);
            this.Controls.Add(this.lbl_BonificacionTexto);
            this.Controls.Add(this.lbl_ISR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_OtrosR);
            this.Controls.Add(this.lbl_SFS);
            this.Controls.Add(this.lbl_MensajeHorasTrabajadas);
            this.Controls.Add(this.lbl_IngreseCargoR);
            this.Controls.Add(this.lbl_IngreseNombreCompleto);
            this.Controls.Add(this.txt_IngreseCargo);
            this.Controls.Add(this.lbl_MensajeCantidadHijos);
            this.Controls.Add(this.txt_IngreseNombre);
            this.Controls.Add(this.txt_HorasTrabajadas);
            this.Controls.Add(this.txt_CantidadHijos);
            this.Controls.Add(this.lbl_MensajeSueldoHora);
            this.Controls.Add(this.txt_SueldoHora);
            this.Controls.Add(this.lbl_TituloSueldos);
            this.Controls.Add(this.lbl_TotalDeduciones);
            this.Controls.Add(this.lbl_CargoInfoR);
            this.Controls.Add(this.lbl_NombreInfoR);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.lbl_SueldoBrutoSemanal);
            this.Controls.Add(this.lbl_Bonificacion);
            this.Controls.Add(this.lbl_ISR_Texto);
            this.Controls.Add(this.lbl_Otros);
            this.Controls.Add(this.lbl_SFS_Texto);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.lbl_CargoInfo);
            this.Controls.Add(this.lbl_NombreInfo);
            this.Controls.Add(this.lbl_SueldoNetoSemanal);
            this.Controls.Add(this.lbl_AFP_Texto);
            this.Controls.Add(this.lbl_IngreseCargo);
            this.Controls.Add(this.lbl_IndSueldoHora);
            this.Controls.Add(this.lbl_IngreseNombre);
            this.Controls.Add(this.lbl_IndHorasTrabajadas);
            this.Controls.Add(this.lbl_IndCantidadHijos);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.btn_linea2);
            this.Controls.Add(this.btn_linea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalcularImpuestos";
            this.Text = "Calcular Impuestos 1.2";
            this.Load += new System.EventHandler(this.CalcularImpuestos_Load);
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion


        #region Campos de clase / Variables

        private Label Titulo;
        private TextBox txt_SueldoHora;
        private Label lbl_MensajeSueldoHora;
        private TextBox txt_CantidadHijos;
        private Label lbl_MensajeCantidadHijos;
        private Label lbl_IndCantidadHijos;
        private Button btn_linea;
        private Label lbl_IndSueldoHora;
        private Button btn_linea2;
        private Label lbl_TotalDeduciones;
        private Label lbl_IndHorasTrabajadas;
        private TextBox txt_HorasTrabajadas;
        private Label lbl_MensajeHorasTrabajadas;
        private Button btn_HacerCalculo;
        #endregion

        private Label lbl_AFP_Texto;
        private Label lbl_SFS_Texto;
        private Label lbl_ISR_Texto;
        private Label lbl_ISR;
        private Label lbl_TituloSueldos;
        private Label lbl_SueldoNetoSemanal;
        private Label lbl_SueldoBrutoSemanal;
        private Label lbl_SFS;
        private Label t1;
        private Label t2;
        private Label lbl_Bonificacion;
        private Label lbl_BonificacionTexto;
        private Label label1;
        private Button btn_Limpiar;
        private Button btn_Salir;
        private Label lbl_NombreInfo;
        private Label lbl_NombreInfoR;
        private Label lbl_CargoInfo;
        private Label lbl_CargoInfoR;
        private Label lbl_Otros;
        private Label lbl_OtrosR;
        private Label lbl_IngreseNombre;
        private TextBox txt_IngreseNombre;
        private Label lbl_IngreseNombreCompleto;
        private Label lbl_IngreseCargo;
        private TextBox txt_IngreseCargo;
        private Label lbl_IngreseCargoR;
        private Label label2;
    }
}

