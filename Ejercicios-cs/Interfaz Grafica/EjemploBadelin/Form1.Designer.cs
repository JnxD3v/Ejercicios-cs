namespace EjemploBadelin
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
            dtgw_Alimentos = new DataGridView();
            ID_Codigo = new DataGridViewTextBoxColumn();
            Alimento = new DataGridViewTextBoxColumn();
            Comestible = new DataGridViewTextBoxColumn();
            lblID_Codigo = new Label();
            lblAlimento = new Label();
            lblComestible = new Label();
            cmbCodigo = new ComboBox();
            cmbComestible = new ComboBox();
            cmbAlimento = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgw_Alimentos).BeginInit();
            SuspendLayout();
            // 
            // dtgw_Alimentos
            // 
            dtgw_Alimentos.BackgroundColor = Color.Lavender;
            dtgw_Alimentos.BorderStyle = BorderStyle.Fixed3D;
            dtgw_Alimentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgw_Alimentos.Columns.AddRange(new DataGridViewColumn[] { ID_Codigo, Alimento, Comestible });
            dtgw_Alimentos.GridColor = SystemColors.MenuText;
            dtgw_Alimentos.Location = new Point(157, 284);
            dtgw_Alimentos.Name = "dtgw_Alimentos";
            dtgw_Alimentos.Size = new Size(343, 88);
            dtgw_Alimentos.TabIndex = 0;
            dtgw_Alimentos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID_Codigo
            // 
            ID_Codigo.HeaderText = "ID_Codigo";
            ID_Codigo.Name = "ID_Codigo";
            // 
            // Alimento
            // 
            Alimento.HeaderText = "Alimento";
            Alimento.Name = "Alimento";
            // 
            // Comestible
            // 
            Comestible.HeaderText = "Comestible";
            Comestible.Name = "Comestible";
            // 
            // lblID_Codigo
            // 
            lblID_Codigo.AutoSize = true;
            lblID_Codigo.Location = new Point(53, 45);
            lblID_Codigo.Name = "lblID_Codigo";
            lblID_Codigo.Size = new Size(62, 15);
            lblID_Codigo.TabIndex = 1;
            lblID_Codigo.Text = "ID_Codigo";
            // 
            // lblAlimento
            // 
            lblAlimento.AutoSize = true;
            lblAlimento.Location = new Point(53, 106);
            lblAlimento.Name = "lblAlimento";
            lblAlimento.Size = new Size(56, 15);
            lblAlimento.TabIndex = 2;
            lblAlimento.Text = "Alimento";
            // 
            // lblComestible
            // 
            lblComestible.AutoSize = true;
            lblComestible.Location = new Point(53, 162);
            lblComestible.Name = "lblComestible";
            lblComestible.Size = new Size(67, 15);
            lblComestible.TabIndex = 3;
            lblComestible.Text = "Comestible";
            // 
            // cmbCodigo
            // 
            cmbCodigo.FormattingEnabled = true;
            cmbCodigo.Location = new Point(157, 45);
            cmbCodigo.Name = "cmbCodigo";
            cmbCodigo.Size = new Size(121, 23);
            cmbCodigo.TabIndex = 4;
            // 
            // cmbComestible
            // 
            cmbComestible.FormattingEnabled = true;
            cmbComestible.Location = new Point(157, 162);
            cmbComestible.Name = "cmbComestible";
            cmbComestible.Size = new Size(121, 23);
            cmbComestible.TabIndex = 5;
            // 
            // cmbAlimento
            // 
            cmbAlimento.FormattingEnabled = true;
            cmbAlimento.Location = new Point(157, 103);
            cmbAlimento.Name = "cmbAlimento";
            cmbAlimento.Size = new Size(121, 23);
            cmbAlimento.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(609, 95);
            button1.Name = "button1";
            button1.Size = new Size(83, 36);
            button1.TabIndex = 7;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(609, 145);
            button2.Name = "button2";
            button2.Size = new Size(83, 32);
            button2.TabIndex = 8;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cmbAlimento);
            Controls.Add(cmbComestible);
            Controls.Add(cmbCodigo);
            Controls.Add(lblComestible);
            Controls.Add(lblAlimento);
            Controls.Add(lblID_Codigo);
            Controls.Add(dtgw_Alimentos);
            Name = "Form1";
            Text = "Gestion de no se que";
            ((System.ComponentModel.ISupportInitialize)dtgw_Alimentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgw_Alimentos;
        private Label lblID_Codigo;
        private Label lblAlimento;
        private Label lblComestible;
        private DataGridViewTextBoxColumn ID_Codigo;
        private DataGridViewTextBoxColumn Alimento;
        private DataGridViewTextBoxColumn Comestible;
        private ComboBox cmbCodigo;
        private ComboBox cmbComestible;
        private ComboBox cmbAlimento;
        private Button button1;
        private Button button2;
    }
}
