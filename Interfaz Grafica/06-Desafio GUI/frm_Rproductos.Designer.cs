namespace _06_Desafio_GUI
{
    partial class frm_Rproductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Rproductos));
            lbl_reps = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_reps
            // 
            lbl_reps.AutoSize = true;
            lbl_reps.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_reps.ForeColor = SystemColors.Control;
            lbl_reps.Location = new Point(231, 35);
            lbl_reps.Name = "lbl_reps";
            lbl_reps.Size = new Size(310, 33);
            lbl_reps.TabIndex = 0;
            lbl_reps.Text = "Reporte de  Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(-5, 96);
            label1.Name = "label1";
            label1.Size = new Size(847, 21);
            label1.TabIndex = 1;
            label1.Text = "---------------------------------------------------------------------------------------------";
            // 
            // frm_Rproductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 29, 85);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lbl_reps);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Rproductos";
            Text = "Reporte de productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_reps;
        private Label label1;
    }
}