namespace _01_GUI
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
            btnCalcular = new Button();
            labelAfp = new Label();
            labelSFS = new Label();
            IabelSR = new Label();
            lblDescuento = new Label();
            lblOtros = new Label();
            lblAnual = new Label();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblSueldo = new Label();
            lblNombre = new Label();
            lblCargo = new Label();
            lblIngresaNombre = new Label();
            txtNombre = new TextBox();
            lblingresaCargo = new Label();
            txtCargo = new TextBox();
            txtSueldoBruto = new TextBox();
            lblIngresaSueldo = new Label();
            lblIngresaHijos = new Label();
            txtHijos = new TextBox();
            lblInformacion = new Label();
            label8 = new Label();
            txtResultadoAfp = new TextBox();
            txtResultadoSfs = new TextBox();
            txtResultadoISr = new TextBox();
            txtOtrosDescuentos = new TextBox();
            txtDescuentototal = new TextBox();
            txtResultadoNombre = new TextBox();
            txtResultadoCargo = new TextBox();
            txtNeto = new TextBox();
            txtAnual = new TextBox();
            label1 = new Label();
            txtIncentivoHIjos = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Transparent;
            btnCalcular.FlatAppearance.BorderSize = 2;
            btnCalcular.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.MintCream;
            btnCalcular.Location = new Point(73, 459);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(114, 46);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // labelAfp
            // 
            labelAfp.AutoSize = true;
            labelAfp.BackColor = Color.Transparent;
            labelAfp.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAfp.ForeColor = SystemColors.InactiveCaption;
            labelAfp.Location = new Point(492, 78);
            labelAfp.Name = "labelAfp";
            labelAfp.Size = new Size(55, 23);
            labelAfp.TabIndex = 3;
            labelAfp.Text = "AFP: ";
            // 
            // labelSFS
            // 
            labelSFS.AutoSize = true;
            labelSFS.BackColor = Color.Transparent;
            labelSFS.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSFS.ForeColor = SystemColors.InactiveCaption;
            labelSFS.Location = new Point(492, 110);
            labelSFS.Name = "labelSFS";
            labelSFS.Size = new Size(55, 23);
            labelSFS.TabIndex = 4;
            labelSFS.Text = "SFS: ";
            // 
            // IabelSR
            // 
            IabelSR.AutoSize = true;
            IabelSR.BackColor = Color.Transparent;
            IabelSR.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IabelSR.ForeColor = SystemColors.InactiveCaption;
            IabelSR.Location = new Point(492, 144);
            IabelSR.Name = "IabelSR";
            IabelSR.Size = new Size(50, 23);
            IabelSR.TabIndex = 5;
            IabelSR.Text = "ISR: ";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BackColor = Color.Transparent;
            lblDescuento.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.ForeColor = SystemColors.InactiveCaption;
            lblDescuento.Location = new Point(459, 219);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(166, 23);
            lblDescuento.TabIndex = 19;
            lblDescuento.Text = "Descuento total:  ";
            // 
            // lblOtros
            // 
            lblOtros.AutoSize = true;
            lblOtros.BackColor = Color.Transparent;
            lblOtros.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOtros.ForeColor = SystemColors.InactiveCaption;
            lblOtros.Location = new Point(482, 181);
            lblOtros.Name = "lblOtros";
            lblOtros.Size = new Size(82, 23);
            lblOtros.TabIndex = 22;
            lblOtros.Text = "OTROS: ";
            // 
            // lblAnual
            // 
            lblAnual.AutoSize = true;
            lblAnual.BackColor = Color.Transparent;
            lblAnual.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnual.ForeColor = SystemColors.InactiveCaption;
            lblAnual.Location = new Point(489, 521);
            lblAnual.Name = "lblAnual";
            lblAnual.Size = new Size(136, 23);
            lblAnual.TabIndex = 24;
            lblAnual.Text = "Sueldo Anual: ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.MintCream;
            btnLimpiar.Location = new Point(215, 459);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(114, 46);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.MintCream;
            btnSalir.Location = new Point(145, 535);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(114, 46);
            btnSalir.TabIndex = 26;
            btnSalir.Text = "Salir\r\n";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.BackColor = Color.Transparent;
            lblSueldo.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSueldo.ForeColor = SystemColors.InactiveCaption;
            lblSueldo.Location = new Point(489, 482);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(128, 23);
            lblSueldo.TabIndex = 27;
            lblSueldo.Text = "Sueldo Neto: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.InactiveCaption;
            lblNombre.Location = new Point(492, 377);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 23);
            lblNombre.TabIndex = 28;
            lblNombre.Text = "Nombre: ";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.BackColor = Color.Transparent;
            lblCargo.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCargo.ForeColor = SystemColors.InactiveCaption;
            lblCargo.Location = new Point(492, 412);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(72, 23);
            lblCargo.TabIndex = 29;
            lblCargo.Text = "Cargo: ";
            // 
            // lblIngresaNombre
            // 
            lblIngresaNombre.AutoSize = true;
            lblIngresaNombre.BackColor = Color.Transparent;
            lblIngresaNombre.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresaNombre.ForeColor = SystemColors.HighlightText;
            lblIngresaNombre.Location = new Point(64, 78);
            lblIngresaNombre.Name = "lblIngresaNombre";
            lblIngresaNombre.Size = new Size(175, 23);
            lblIngresaNombre.TabIndex = 30;
            lblIngresaNombre.Text = "Ingrese su nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = SystemColors.WindowFrame;
            txtNombre.Location = new Point(36, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(236, 23);
            txtNombre.TabIndex = 31;
            // 
            // lblingresaCargo
            // 
            lblingresaCargo.AutoSize = true;
            lblingresaCargo.BackColor = Color.Transparent;
            lblingresaCargo.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblingresaCargo.ForeColor = SystemColors.HighlightText;
            lblingresaCargo.Location = new Point(64, 171);
            lblingresaCargo.Name = "lblingresaCargo";
            lblingresaCargo.Size = new Size(164, 23);
            lblingresaCargo.TabIndex = 32;
            lblingresaCargo.Text = "Ingrese su cargo ";
            // 
            // txtCargo
            // 
            txtCargo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCargo.ForeColor = SystemColors.WindowFrame;
            txtCargo.Location = new Point(36, 197);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(236, 23);
            txtCargo.TabIndex = 33;
            // 
            // txtSueldoBruto
            // 
            txtSueldoBruto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSueldoBruto.ForeColor = SystemColors.WindowFrame;
            txtSueldoBruto.Location = new Point(36, 277);
            txtSueldoBruto.Name = "txtSueldoBruto";
            txtSueldoBruto.Size = new Size(236, 23);
            txtSueldoBruto.TabIndex = 34;
            // 
            // lblIngresaSueldo
            // 
            lblIngresaSueldo.AutoSize = true;
            lblIngresaSueldo.BackColor = Color.Transparent;
            lblIngresaSueldo.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresaSueldo.ForeColor = SystemColors.HighlightText;
            lblIngresaSueldo.Location = new Point(73, 251);
            lblIngresaSueldo.Name = "lblIngresaSueldo";
            lblIngresaSueldo.Size = new Size(167, 23);
            lblIngresaSueldo.TabIndex = 35;
            lblIngresaSueldo.Text = "Ingrese su sueldo";
            // 
            // lblIngresaHijos
            // 
            lblIngresaHijos.AutoSize = true;
            lblIngresaHijos.BackColor = Color.Transparent;
            lblIngresaHijos.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresaHijos.ForeColor = SystemColors.HighlightText;
            lblIngresaHijos.Location = new Point(23, 340);
            lblIngresaHijos.Name = "lblIngresaHijos";
            lblIngresaHijos.Size = new Size(260, 23);
            lblIngresaHijos.TabIndex = 36;
            lblIngresaHijos.Text = "Ingrese su cantidad de hijos";
            // 
            // txtHijos
            // 
            txtHijos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHijos.ForeColor = SystemColors.WindowFrame;
            txtHijos.Location = new Point(36, 365);
            txtHijos.Name = "txtHijos";
            txtHijos.Size = new Size(236, 23);
            txtHijos.TabIndex = 37;
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.BackColor = Color.Transparent;
            lblInformacion.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            lblInformacion.ForeColor = SystemColors.HighlightText;
            lblInformacion.Location = new Point(492, 340);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(155, 22);
            lblInformacion.TabIndex = 38;
            lblInformacion.Text = "Informaciones: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label8.ForeColor = SystemColors.HighlightText;
            label8.Location = new Point(492, 45);
            label8.Name = "label8";
            label8.Size = new Size(133, 22);
            label8.TabIndex = 39;
            label8.Text = "Descuentos: ";
            // 
            // txtResultadoAfp
            // 
            txtResultadoAfp.BorderStyle = BorderStyle.None;
            txtResultadoAfp.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultadoAfp.Location = new Point(639, 78);
            txtResultadoAfp.Name = "txtResultadoAfp";
            txtResultadoAfp.Size = new Size(100, 14);
            txtResultadoAfp.TabIndex = 40;
            // 
            // txtResultadoSfs
            // 
            txtResultadoSfs.BorderStyle = BorderStyle.None;
            txtResultadoSfs.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultadoSfs.Location = new Point(639, 110);
            txtResultadoSfs.Name = "txtResultadoSfs";
            txtResultadoSfs.Size = new Size(100, 14);
            txtResultadoSfs.TabIndex = 41;
            // 
            // txtResultadoISr
            // 
            txtResultadoISr.BorderStyle = BorderStyle.None;
            txtResultadoISr.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultadoISr.Location = new Point(639, 144);
            txtResultadoISr.Name = "txtResultadoISr";
            txtResultadoISr.Size = new Size(100, 14);
            txtResultadoISr.TabIndex = 42;
            // 
            // txtOtrosDescuentos
            // 
            txtOtrosDescuentos.BorderStyle = BorderStyle.None;
            txtOtrosDescuentos.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOtrosDescuentos.Location = new Point(639, 181);
            txtOtrosDescuentos.Name = "txtOtrosDescuentos";
            txtOtrosDescuentos.Size = new Size(100, 14);
            txtOtrosDescuentos.TabIndex = 43;
            // 
            // txtDescuentototal
            // 
            txtDescuentototal.BorderStyle = BorderStyle.None;
            txtDescuentototal.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescuentototal.Location = new Point(639, 225);
            txtDescuentototal.Name = "txtDescuentototal";
            txtDescuentototal.Size = new Size(100, 14);
            txtDescuentototal.TabIndex = 44;
            // 
            // txtResultadoNombre
            // 
            txtResultadoNombre.BorderStyle = BorderStyle.None;
            txtResultadoNombre.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultadoNombre.Location = new Point(639, 380);
            txtResultadoNombre.Name = "txtResultadoNombre";
            txtResultadoNombre.Size = new Size(100, 14);
            txtResultadoNombre.TabIndex = 45;
            // 
            // txtResultadoCargo
            // 
            txtResultadoCargo.BackColor = Color.White;
            txtResultadoCargo.BorderStyle = BorderStyle.None;
            txtResultadoCargo.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResultadoCargo.Location = new Point(639, 415);
            txtResultadoCargo.Name = "txtResultadoCargo";
            txtResultadoCargo.Size = new Size(100, 14);
            txtResultadoCargo.TabIndex = 46;
            // 
            // txtNeto
            // 
            txtNeto.BorderStyle = BorderStyle.None;
            txtNeto.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNeto.Location = new Point(639, 489);
            txtNeto.Name = "txtNeto";
            txtNeto.Size = new Size(100, 14);
            txtNeto.TabIndex = 47;
            // 
            // txtAnual
            // 
            txtAnual.BorderStyle = BorderStyle.None;
            txtAnual.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAnual.Location = new Point(639, 527);
            txtAnual.Name = "txtAnual";
            txtAnual.Size = new Size(100, 14);
            txtAnual.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.InactiveCaption;
            label1.Location = new Point(491, 449);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 49;
            label1.Text = "Incentivo Hijos";
            // 
            // txtIncentivoHIjos
            // 
            txtIncentivoHIjos.BackColor = Color.White;
            txtIncentivoHIjos.BorderStyle = BorderStyle.None;
            txtIncentivoHIjos.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIncentivoHIjos.Location = new Point(639, 455);
            txtIncentivoHIjos.Name = "txtIncentivoHIjos";
            txtIncentivoHIjos.Size = new Size(100, 14);
            txtIncentivoHIjos.TabIndex = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(751, 602);
            Controls.Add(txtIncentivoHIjos);
            Controls.Add(label1);
            Controls.Add(txtAnual);
            Controls.Add(txtNeto);
            Controls.Add(txtResultadoCargo);
            Controls.Add(txtResultadoNombre);
            Controls.Add(txtDescuentototal);
            Controls.Add(txtOtrosDescuentos);
            Controls.Add(txtResultadoISr);
            Controls.Add(txtResultadoSfs);
            Controls.Add(txtResultadoAfp);
            Controls.Add(label8);
            Controls.Add(lblInformacion);
            Controls.Add(txtHijos);
            Controls.Add(lblIngresaHijos);
            Controls.Add(lblIngresaSueldo);
            Controls.Add(txtSueldoBruto);
            Controls.Add(txtCargo);
            Controls.Add(lblingresaCargo);
            Controls.Add(txtNombre);
            Controls.Add(lblIngresaNombre);
            Controls.Add(lblCargo);
            Controls.Add(lblNombre);
            Controls.Add(lblSueldo);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(lblAnual);
            Controls.Add(lblOtros);
            Controls.Add(lblDescuento);
            Controls.Add(IabelSR);
            Controls.Add(labelSFS);
            Controls.Add(labelAfp);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCalcular;
        private Label labelAfp;
        private Label labelSFS;
        private Label IabelSR;
        private Label lblDescuento;
        private Label lblOtros;
        private Label lblAnual;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblSueldo;
        private Label lblNombre;
        private Label lblCargo;
        private Label lblIngresaNombre;
        private TextBox txtNombre;
        private Label lblingresaCargo;
        private TextBox txtCargo;
        private TextBox txtSueldoBruto;
        private Label lblIngresaSueldo;
        private Label lblIngresaHijos;
        private TextBox txtHijos;
        private Label lblInformacion;
        private Label label8;
        private TextBox txtResultadoAfp;
        private TextBox txtResultadoSfs;
        private TextBox txtResultadoISr;
        private TextBox txtOtrosDescuentos;
        private TextBox txtDescuentototal;
        private TextBox txtResultadoNombre;
        private TextBox txtResultadoCargo;
        private TextBox txtNeto;
        private TextBox txtAnual;
        private Label label1;
        private TextBox txtIncentivoHIjos;
    }
}
