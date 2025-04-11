namespace MDI_Forms_Ejemplo
{
    partial class frm_Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_Mantenimiento = new Label();
            btn_Apagar = new Button();
            SuspendLayout();
            // 
            // lbl_Mantenimiento
            // 
            lbl_Mantenimiento.AutoSize = true;
            lbl_Mantenimiento.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Mantenimiento.ForeColor = Color.MediumOrchid;
            lbl_Mantenimiento.Location = new Point(159, 36);
            lbl_Mantenimiento.Name = "lbl_Mantenimiento";
            lbl_Mantenimiento.Size = new Size(420, 40);
            lbl_Mantenimiento.TabIndex = 0;
            lbl_Mantenimiento.Text = "Mantenimiento de clientes ";
            // 
            // btn_Apagar
            // 
            btn_Apagar.Location = new Point(401, 208);
            btn_Apagar.Name = "btn_Apagar";
            btn_Apagar.Size = new Size(75, 23);
            btn_Apagar.TabIndex = 2;
            btn_Apagar.Text = "button2";
            btn_Apagar.UseVisualStyleBackColor = true;
            btn_Apagar.Click += btn_Apagar_Click;
            // 
            // frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Apagar);
            Controls.Add(lbl_Mantenimiento);
            Name = "frm_Clientes";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Mantenimiento;
        private Button btn_Apagar;
    }
}