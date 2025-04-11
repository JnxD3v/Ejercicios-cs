using System.Windows.Forms;
using System.Drawing;


namespace Ejercicioo_1__Interfaces_Graficas_
{
    partial class ProyectoEjemplo
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
            this.cbx_Opcion1 = new System.Windows.Forms.CheckBox();
            this.cbx_Opcion2 = new System.Windows.Forms.CheckBox();
            this.cbx_Opcion3 = new System.Windows.Forms.CheckBox();
            this.cbx_Opcion4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbx_Opcion1
            // 
            this.cbx_Opcion1.AutoSize = true;
            this.cbx_Opcion1.Location = new System.Drawing.Point(57, 38);
            this.cbx_Opcion1.Name = "cbx_Opcion1";
            this.cbx_Opcion1.Size = new System.Drawing.Size(80, 17);
            this.cbx_Opcion1.TabIndex = 0;
            this.cbx_Opcion1.Text = "cbx_Opcion1";
            this.cbx_Opcion1.UseVisualStyleBackColor = true;
            // 
            // cbx_Opcion2
            // 
            this.cbx_Opcion2.AutoSize = true;
            this.cbx_Opcion2.Location = new System.Drawing.Point(209, 38);
            this.cbx_Opcion2.Name = "cbx_Opcion2";
            this.cbx_Opcion2.Size = new System.Drawing.Size(80, 17);
            this.cbx_Opcion2.TabIndex = 1;
            this.cbx_Opcion2.Text = "cbx_Opcion2";
            this.cbx_Opcion2.UseVisualStyleBackColor = true;
            // 
            // cbx_Opcion3
            // 
            this.cbx_Opcion3.AutoSize = true;
            this.cbx_Opcion3.Location = new System.Drawing.Point(57, 97);
            this.cbx_Opcion3.Name = "cbx_Opcion3";
            this.cbx_Opcion3.Size = new System.Drawing.Size(80, 17);
            this.cbx_Opcion3.TabIndex = 2;
            this.cbx_Opcion3.Text = "cbx_Opcion3";
            this.cbx_Opcion3.UseVisualStyleBackColor = true;
            // 
            // cbx_Opcion4
            // 
            this.cbx_Opcion4.AutoSize = true;
            this.cbx_Opcion4.Location = new System.Drawing.Point(209, 97);
            this.cbx_Opcion4.Name = "cbx_Opcion4";
            this.cbx_Opcion4.Size = new System.Drawing.Size(80, 17);
            this.cbx_Opcion4.TabIndex = 3;
            this.cbx_Opcion4.Text = "cbx_Opcion4";
            this.cbx_Opcion4.UseVisualStyleBackColor = true;
            // 
            // ProyectoEjemplo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(373, 461);
            this.Controls.Add(this.cbx_Opcion4);
            this.Controls.Add(this.cbx_Opcion3);
            this.Controls.Add(this.cbx_Opcion2);
            this.Controls.Add(this.cbx_Opcion1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProyectoEjemplo";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Proyecto de Ejemplo (CheckBox)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox cbx_Opcion1;
        private CheckBox cbx_Opcion2;
        private CheckBox cbx_Opcion3;
        private CheckBox cbx_Opcion4;
    }
}

