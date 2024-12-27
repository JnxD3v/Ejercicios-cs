namespace _02_Desafio_GUI
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
            lblNombre = new Label();
            lblCursoo = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombreEstudiante = new TextBox();
            cmbCurso = new ComboBox();
            cmbSeccion = new ComboBox();
            cmbArea = new ComboBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            btnSalir = new Button();
            label4 = new Label();
            label5 = new Label();
            rdbMasculino = new RadioButton();
            rdbFemenino = new RadioButton();
            lblNotas = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblPromedio = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            txtPromedio = new TextBox();
            label1 = new Label();
            txtStatus = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(25, 59);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(80, 18);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            // 
            // lblCursoo
            // 
            lblCursoo.AutoSize = true;
            lblCursoo.BackColor = Color.Transparent;
            lblCursoo.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCursoo.ForeColor = SystemColors.ButtonHighlight;
            lblCursoo.Location = new Point(25, 98);
            lblCursoo.Name = "lblCursoo";
            lblCursoo.Size = new Size(65, 18);
            lblCursoo.TabIndex = 1;
            lblCursoo.Text = "Curso: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(25, 141);
            label2.Name = "label2";
            label2.Size = new Size(82, 18);
            label2.TabIndex = 2;
            label2.Text = "Seccion: ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 179);
            label3.Name = "label3";
            label3.Size = new Size(52, 18);
            label3.TabIndex = 3;
            label3.Text = "Area:";
            // 
            // txtNombreEstudiante
            // 
            txtNombreEstudiante.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEstudiante.Location = new Point(143, 51);
            txtNombreEstudiante.Name = "txtNombreEstudiante";
            txtNombreEstudiante.Size = new Size(177, 26);
            txtNombreEstudiante.TabIndex = 4;
            // 
            // cmbCurso
            // 
            cmbCurso.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Items.AddRange(new object[] { "Curso", "4to", "5to", "6to" });
            cmbCurso.Location = new Point(143, 93);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(177, 26);
            cmbCurso.TabIndex = 5;
            cmbCurso.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbSeccion
            // 
            cmbSeccion.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSeccion.FormattingEnabled = true;
            cmbSeccion.Items.AddRange(new object[] { "A-1", "A-2", "A-3", "A-4", "B", "C-1", "C-2", "D-1", "D-2", "E" });
            cmbSeccion.Location = new Point(142, 136);
            cmbSeccion.Name = "cmbSeccion";
            cmbSeccion.Size = new Size(177, 26);
            cmbSeccion.TabIndex = 6;
            // 
            // cmbArea
            // 
            cmbArea.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbArea.FormattingEnabled = true;
            cmbArea.Items.AddRange(new object[] { "Enfermeria", "Contabilidad", "Gastronomia", "Informatica", "Electrecidad" });
            cmbArea.Location = new Point(143, 174);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(177, 26);
            cmbArea.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(20, 604);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(77, 32);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "L";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button1_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(131, 604);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(74, 32);
            btnCalcular.TabIndex = 20;
            btnCalcular.Text = "C";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button2_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(244, 604);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 32);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "S";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(33, 9);
            label4.Name = "label4";
            label4.Size = new Size(291, 27);
            label4.TabIndex = 22;
            label4.Text = "STATUS DE ESTUDIANTES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(25, 238);
            label5.Name = "label5";
            label5.Size = new Size(47, 18);
            label5.TabIndex = 23;
            label5.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.BackColor = Color.Transparent;
            rdbMasculino.ForeColor = Color.White;
            rdbMasculino.Location = new Point(142, 239);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(36, 19);
            rdbMasculino.TabIndex = 24;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "M";
            rdbMasculino.UseVisualStyleBackColor = false;
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.BackColor = Color.Transparent;
            rdbFemenino.ForeColor = SystemColors.ControlLightLight;
            rdbFemenino.Location = new Point(224, 237);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(31, 19);
            rdbFemenino.TabIndex = 25;
            rdbFemenino.TabStop = true;
            rdbFemenino.Text = "F";
            rdbFemenino.UseVisualStyleBackColor = false;
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.BackColor = Color.Transparent;
            lblNotas.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNotas.ForeColor = Color.White;
            lblNotas.Location = new Point(23, 306);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(74, 27);
            lblNotas.TabIndex = 26;
            lblNotas.Text = "Notas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(25, 387);
            label7.Name = "label7";
            label7.Size = new Size(69, 18);
            label7.TabIndex = 27;
            label7.Text = "Nota 2: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(25, 353);
            label8.Name = "label8";
            label8.Size = new Size(73, 18);
            label8.TabIndex = 28;
            label8.Text = "Nota 1:  ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Transparent;
            label9.Location = new Point(23, 422);
            label9.Name = "label9";
            label9.Size = new Size(69, 18);
            label9.TabIndex = 29;
            label9.Text = "Nota 3: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(25, 453);
            label10.Name = "label10";
            label10.Size = new Size(69, 18);
            label10.TabIndex = 30;
            label10.Text = "Nota 4: ";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.BackColor = Color.Transparent;
            lblPromedio.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPromedio.ForeColor = Color.White;
            lblPromedio.Location = new Point(23, 501);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(93, 18);
            lblPromedio.TabIndex = 31;
            lblPromedio.Text = "Promedio: ";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(142, 348);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(63, 23);
            txtNota1.TabIndex = 32;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(143, 382);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(62, 23);
            txtNota2.TabIndex = 33;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(142, 417);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(63, 23);
            txtNota3.TabIndex = 34;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(142, 453);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(63, 23);
            txtNota4.TabIndex = 35;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(142, 496);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(63, 23);
            txtPromedio.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 551);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 37;
            label1.Text = "Status: ";
            // 
            // txtStatus
            // 
            txtStatus.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new Point(131, 551);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(285, 26);
            txtStatus.TabIndex = 38;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(428, 665);
            Controls.Add(txtStatus);
            Controls.Add(label1);
            Controls.Add(txtPromedio);
            Controls.Add(txtNota4);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblPromedio);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblNotas);
            Controls.Add(rdbFemenino);
            Controls.Add(rdbMasculino);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSalir);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(cmbArea);
            Controls.Add(cmbSeccion);
            Controls.Add(cmbCurso);
            Controls.Add(txtNombreEstudiante);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCursoo);
            Controls.Add(lblNombre);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblCursoo;
        private Label label2;
        private Label label3;
        private TextBox txtNombreEstudiante;
        private ComboBox cmbCurso;
        private ComboBox cmbSeccion;
        private ComboBox cmbArea;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Button btnSalir;
        private Label label4;
        private Label label5;
        private RadioButton rdbMasculino;
        private RadioButton rdbFemenino;
        private Label lblNotas;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblPromedio;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private TextBox txtPromedio;
        private Label label1;
        private TextBox txtStatus;
    }
}
