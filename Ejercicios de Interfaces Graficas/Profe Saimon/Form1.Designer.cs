namespace Profe_Saimon
{
    partial class ProfeSaimon
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
            this.rtxt_TexboxRico = new System.Windows.Forms.RichTextBox();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxt_TexboxRico
            // 
            this.rtxt_TexboxRico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.rtxt_TexboxRico.Location = new System.Drawing.Point(12, 68);
            this.rtxt_TexboxRico.Name = "rtxt_TexboxRico";
            this.rtxt_TexboxRico.Size = new System.Drawing.Size(332, 218);
            this.rtxt_TexboxRico.TabIndex = 0;
            this.rtxt_TexboxRico.Text = "";
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abrir.Location = new System.Drawing.Point(116, 318);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(119, 47);
            this.btn_Abrir.TabIndex = 1;
            this.btn_Abrir.Text = "Abrir Archivo";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(86, 23);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(180, 25);
            this.lbl_Titulo.TabIndex = 2;
            this.lbl_Titulo.Text = "Abrir Archivos (.txt)";
            // 
            // ProfeSaimon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 399);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.btn_Abrir);
            this.Controls.Add(this.rtxt_TexboxRico);
            this.Name = "ProfeSaimon";
            this.Text = "Profe Saimon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_TexboxRico;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}

