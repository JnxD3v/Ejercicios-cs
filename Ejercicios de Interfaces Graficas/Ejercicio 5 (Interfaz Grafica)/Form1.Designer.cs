namespace Ejercicio_5__Interfaz_Grafica_
{
    partial class Reservaciones
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Linea1 = new System.Windows.Forms.Label();
            this.dtp_FechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaInicial = new System.Windows.Forms.Label();
            this.lbl_FechaFinal = new System.Windows.Forms.Label();
            this.dtp_FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(66, 22);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(272, 28);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "• Gestor de Reservaciones •";
            // 
            // lbl_Linea1
            // 
            this.lbl_Linea1.AutoSize = true;
            this.lbl_Linea1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lbl_Linea1.Location = new System.Drawing.Point(-5, 50);
            this.lbl_Linea1.Name = "lbl_Linea1";
            this.lbl_Linea1.Size = new System.Drawing.Size(409, 13);
            this.lbl_Linea1.TabIndex = 1;
            this.lbl_Linea1.Text = "___________________________________________________________________";
            // 
            // dtp_FechaInicial
            // 
            this.dtp_FechaInicial.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaInicial.Location = new System.Drawing.Point(126, 93);
            this.dtp_FechaInicial.Name = "dtp_FechaInicial";
            this.dtp_FechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaInicial.TabIndex = 2;
            // 
            // lbl_FechaInicial
            // 
            this.lbl_FechaInicial.AutoSize = true;
            this.lbl_FechaInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaInicial.Location = new System.Drawing.Point(21, 96);
            this.lbl_FechaInicial.Name = "lbl_FechaInicial";
            this.lbl_FechaInicial.Size = new System.Drawing.Size(89, 17);
            this.lbl_FechaInicial.TabIndex = 0;
            this.lbl_FechaInicial.Text = "• Fecha Inicial:";
            // 
            // lbl_FechaFinal
            // 
            this.lbl_FechaFinal.AutoSize = true;
            this.lbl_FechaFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FechaFinal.Location = new System.Drawing.Point(21, 132);
            this.lbl_FechaFinal.Name = "lbl_FechaFinal";
            this.lbl_FechaFinal.Size = new System.Drawing.Size(89, 17);
            this.lbl_FechaFinal.TabIndex = 0;
            this.lbl_FechaFinal.Text = "• Fecha Inicial:";
            // 
            // dtp_FechaFinal
            // 
            this.dtp_FechaFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaFinal.Location = new System.Drawing.Point(126, 129);
            this.dtp_FechaFinal.Name = "dtp_FechaFinal";
            this.dtp_FechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaFinal.TabIndex = 2;
            // 
            // Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 475);
            this.Controls.Add(this.dtp_FechaFinal);
            this.Controls.Add(this.dtp_FechaInicial);
            this.Controls.Add(this.lbl_Linea1);
            this.Controls.Add(this.lbl_FechaFinal);
            this.Controls.Add(this.lbl_FechaInicial);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Reservaciones";
            this.Text = "Reservaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Linea1;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicial;
        private System.Windows.Forms.Label lbl_FechaInicial;
        private System.Windows.Forms.Label lbl_FechaFinal;
        private System.Windows.Forms.DateTimePicker dtp_FechaFinal;
    }
}

