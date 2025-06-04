namespace _02_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblValor1 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            txtResultadoSuma = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            txtResultadoResta = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtResultadoMulti = new TextBox();
            txtResultadoDividir = new TextBox();
            SuspendLayout();
            // 
            // lblValor1
            // 
            resources.ApplyResources(lblValor1, "lblValor1");
            lblValor1.BackColor = Color.Transparent;
            lblValor1.ForeColor = SystemColors.Control;
            lblValor1.Name = "lblValor1";
            lblValor1.Click += lblValor1_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // txtValor1
            // 
            resources.ApplyResources(txtValor1, "txtValor1");
            txtValor1.Name = "txtValor1";
            txtValor1.TextChanged += textBox1_TextChanged;
            // 
            // txtValor2
            // 
            resources.ApplyResources(txtValor2, "txtValor2");
            txtValor2.Name = "txtValor2";
            txtValor2.TextChanged += textBox2_TextChanged;
            // 
            // txtResultadoSuma
            // 
            resources.ApplyResources(txtResultadoSuma, "txtResultadoSuma");
            txtResultadoSuma.Name = "txtResultadoSuma";
            // 
            // btnCalcular
            // 
            resources.ApplyResources(btnCalcular, "btnCalcular");
            btnCalcular.Name = "btnCalcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            resources.ApplyResources(btnLimpiar, "btnLimpiar");
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            resources.ApplyResources(btnSalir, "btnSalir");
            btnSalir.Name = "btnSalir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtResultadoResta
            // 
            resources.ApplyResources(txtResultadoResta, "txtResultadoResta");
            txtResultadoResta.Name = "txtResultadoResta";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.Control;
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.BackColor = Color.Transparent;
            label5.ForeColor = SystemColors.Control;
            label5.Name = "label5";
            // 
            // txtResultadoMulti
            // 
            resources.ApplyResources(txtResultadoMulti, "txtResultadoMulti");
            txtResultadoMulti.Name = "txtResultadoMulti";
            // 
            // txtResultadoDividir
            // 
            resources.ApplyResources(txtResultadoDividir, "txtResultadoDividir");
            txtResultadoDividir.Name = "txtResultadoDividir";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtResultadoDividir);
            Controls.Add(txtResultadoMulti);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtResultadoResta);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultadoSuma);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblValor1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor1;
        private Label label1;
        private Label label2;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtResultadoSuma;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private TextBox txtResultadoResta;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtResultadoMulti;
        private TextBox txtResultadoDividir;
    }
}
