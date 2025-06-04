namespace Gestion_de_Reservas
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            lblCliente = new Label();
            lblPrecio = new Label();
            dtpFechadesde = new DateTimePicker();
            lbl_desde = new Label();
            txtCliente = new TextBox();
            cmbTipoHab = new ComboBox();
            lblTipo_hab = new Label();
            txtPrecio = new TextBox();
            lblF_Hasta = new Label();
            DtpFechaHasta = new DateTimePicker();
            btnAgregar = new Button();
            btnlEliminar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            bindingSource1 = new BindingSource(components);
            ltb_reserva = new ListBox();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(156, 28);
            label1.Name = "label1";
            label1.Size = new Size(254, 29);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Reservas";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = SystemColors.ButtonFace;
            lblCliente.Location = new Point(18, 116);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 20);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente :";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = SystemColors.ButtonFace;
            lblPrecio.Location = new Point(26, 298);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(59, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio :";
            // 
            // dtpFechadesde
            // 
            dtpFechadesde.Format = DateTimePickerFormat.Short;
            dtpFechadesde.Location = new Point(97, 162);
            dtpFechadesde.Name = "dtpFechadesde";
            dtpFechadesde.Size = new Size(121, 23);
            dtpFechadesde.TabIndex = 3;
            dtpFechadesde.Value = new DateTime(2024, 11, 25, 8, 9, 32, 0);
            dtpFechadesde.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lbl_desde
            // 
            lbl_desde.AutoSize = true;
            lbl_desde.BackColor = Color.Transparent;
            lbl_desde.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_desde.ForeColor = SystemColors.ButtonFace;
            lbl_desde.Location = new Point(12, 165);
            lbl_desde.Name = "lbl_desde";
            lbl_desde.Size = new Size(71, 20);
            lbl_desde.TabIndex = 4;
            lbl_desde.Text = "F_desde :";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(97, 113);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(121, 23);
            txtCliente.TabIndex = 5;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // cmbTipoHab
            // 
            cmbTipoHab.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoHab.FormattingEnabled = true;
            cmbTipoHab.Items.AddRange(new object[] { "Habitacion estandar : 50", "Habitacion Doble : 100", "Habitacion Suite : 150" });
            cmbTipoHab.Location = new Point(97, 252);
            cmbTipoHab.Name = "cmbTipoHab";
            cmbTipoHab.Size = new Size(121, 23);
            cmbTipoHab.TabIndex = 6;
            // 
            // lblTipo_hab
            // 
            lblTipo_hab.AutoSize = true;
            lblTipo_hab.BackColor = Color.Transparent;
            lblTipo_hab.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTipo_hab.ForeColor = SystemColors.ButtonFace;
            lblTipo_hab.Location = new Point(4, 255);
            lblTipo_hab.Name = "lblTipo_hab";
            lblTipo_hab.Size = new Size(81, 20);
            lblTipo_hab.TabIndex = 7;
            lblTipo_hab.Text = "Tipo_Hab :";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(97, 299);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 8;
            // 
            // lblF_Hasta
            // 
            lblF_Hasta.AutoSize = true;
            lblF_Hasta.BackColor = Color.Transparent;
            lblF_Hasta.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblF_Hasta.ForeColor = SystemColors.ButtonFace;
            lblF_Hasta.Location = new Point(14, 212);
            lblF_Hasta.Name = "lblF_Hasta";
            lblF_Hasta.Size = new Size(71, 20);
            lblF_Hasta.TabIndex = 9;
            lblF_Hasta.Text = "F_Hasta :";
            // 
            // DtpFechaHasta
            // 
            DtpFechaHasta.Format = DateTimePickerFormat.Short;
            DtpFechaHasta.Location = new Point(97, 210);
            DtpFechaHasta.Name = "DtpFechaHasta";
            DtpFechaHasta.Size = new Size(121, 23);
            DtpFechaHasta.TabIndex = 10;
            DtpFechaHasta.Value = new DateTime(2024, 11, 25, 0, 0, 0, 0);
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(426, 181);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(64, 26);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnlEliminar
            // 
            btnlEliminar.Location = new Point(425, 223);
            btnlEliminar.Name = "btnlEliminar";
            btnlEliminar.Size = new Size(65, 26);
            btnlEliminar.TabIndex = 12;
            btnlEliminar.Text = "Eliminar";
            btnlEliminar.UseVisualStyleBackColor = true;
            btnlEliminar.Click += btnlEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(425, 255);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(65, 28);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button3_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(426, 295);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(65, 29);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ltb_reserva
            // 
            ltb_reserva.FormattingEnabled = true;
            ltb_reserva.ItemHeight = 15;
            ltb_reserva.Location = new Point(82, 376);
            ltb_reserva.Name = "ltb_reserva";
            ltb_reserva.Size = new Size(198, 124);
            ltb_reserva.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Spiderman_FV_de_Alix;
            ClientSize = new Size(551, 528);
            Controls.Add(ltb_reserva);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnlEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(DtpFechaHasta);
            Controls.Add(lblF_Hasta);
            Controls.Add(txtPrecio);
            Controls.Add(lblTipo_hab);
            Controls.Add(cmbTipoHab);
            Controls.Add(txtCliente);
            Controls.Add(lbl_desde);
            Controls.Add(dtpFechadesde);
            Controls.Add(lblPrecio);
            Controls.Add(lblCliente);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblCliente;
        private Label lblPrecio;
        private DateTimePicker dtpFechadesde;
        private Label lbl_desde;
        private TextBox txtCliente;
        private ComboBox cmbTipoHab;
        private Label lblTipo_hab;
        private TextBox txtPrecio;
        private Label lblF_Hasta;
        private DateTimePicker DtpFechaHasta;
        private Button btnAgregar;
        private Button btnlEliminar;
        private Button btnLimpiar;
        private Button btnSalir;
        private BindingSource bindingSource1;
        private ListBox ltb_reserva;
    }
}
