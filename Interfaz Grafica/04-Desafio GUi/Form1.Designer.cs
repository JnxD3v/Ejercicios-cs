namespace _04_Desafio_GUi
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
            label1 = new Label();
            cbxNombre = new ComboBox();
            dtgwMinifactura = new DataGridView();
            btnSalir = new Button();
            btnLimpiar = new Button();
            cbxCantidad = new ComboBox();
            lblNombre = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            txtPrecio = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lbl_titulo = new Label();
            btn_guardar = new Button();
            label3 = new Label();
            lbl_Articulos = new Label();
            lbl_totalDeTotales = new Label();
            Nombre = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            Precio_unitario = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgwMinifactura).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(24, 110);
            label1.Name = "label1";
            label1.Size = new Size(105, 22);
            label1.TabIndex = 0;
            label1.Text = "Cantidad: ";
            // 
            // cbxNombre
            // 
            cbxNombre.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxNombre.FormattingEnabled = true;
            cbxNombre.Items.AddRange(new object[] { "Computadora", "Teclado", "Mouse" });
            cbxNombre.Location = new Point(154, 52);
            cbxNombre.Name = "cbxNombre";
            cbxNombre.Size = new Size(121, 23);
            cbxNombre.TabIndex = 1;
            // 
            // dtgwMinifactura
            // 
            dtgwMinifactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgwMinifactura.Columns.AddRange(new DataGridViewColumn[] { Nombre, cantidad, Precio_unitario, Subtotal, Total });
            dtgwMinifactura.GridColor = Color.Black;
            dtgwMinifactura.Location = new Point(24, 267);
            dtgwMinifactura.Name = "dtgwMinifactura";
            dtgwMinifactura.Size = new Size(404, 150);
            dtgwMinifactura.TabIndex = 2;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Blue;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(177, 452);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(98, 42);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Blue;
            btnLimpiar.FlatStyle = FlatStyle.Popup;
            btnLimpiar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(33, 452);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(108, 42);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // cbxCantidad
            // 
            cbxCantidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCantidad.FormattingEnabled = true;
            cbxCantidad.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbxCantidad.Location = new Point(154, 109);
            cbxCantidad.Name = "cbxCantidad";
            cbxCantidad.Size = new Size(121, 23);
            cbxCantidad.TabIndex = 6;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.Control;
            lblNombre.Location = new Point(24, 53);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(90, 22);
            lblNombre.TabIndex = 7;
            lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(24, 170);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 8;
            label2.Text = "Precio:";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Blue;
            btnAgregar.FlatStyle = FlatStyle.Popup;
            btnAgregar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(330, 452);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(98, 42);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(154, 176);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(495, 1);
            button1.Name = "button1";
            button1.Size = new Size(1, 531);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(495, 255);
            button2.Name = "button2";
            button2.Size = new Size(307, 1);
            button2.TabIndex = 13;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Transparent;
            lbl_titulo.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = SystemColors.Control;
            lbl_titulo.Location = new Point(520, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(268, 27);
            lbl_titulo.TabIndex = 14;
            lbl_titulo.Text = "Articulos Seleccionados";
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.Blue;
            btn_guardar.FlatStyle = FlatStyle.Popup;
            btn_guardar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar.ForeColor = SystemColors.ControlLightLight;
            btn_guardar.Location = new Point(680, 452);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(98, 42);
            btn_guardar.TabIndex = 15;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(520, 267);
            label3.Name = "label3";
            label3.Size = new Size(231, 27);
            label3.TabIndex = 16;
            label3.Text = "Totales y sub totales";
            // 
            // lbl_Articulos
            // 
            lbl_Articulos.AutoSize = true;
            lbl_Articulos.BackColor = Color.Transparent;
            lbl_Articulos.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Articulos.ForeColor = SystemColors.ButtonHighlight;
            lbl_Articulos.Location = new Point(546, 73);
            lbl_Articulos.Name = "lbl_Articulos";
            lbl_Articulos.Size = new Size(0, 23);
            lbl_Articulos.TabIndex = 17;
            // 
            // lbl_totalDeTotales
            // 
            lbl_totalDeTotales.AutoSize = true;
            lbl_totalDeTotales.BackColor = Color.Transparent;
            lbl_totalDeTotales.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_totalDeTotales.ForeColor = SystemColors.Control;
            lbl_totalDeTotales.Location = new Point(520, 311);
            lbl_totalDeTotales.Name = "lbl_totalDeTotales";
            lbl_totalDeTotales.Size = new Size(0, 22);
            lbl_totalDeTotales.TabIndex = 18;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.Width = 40;
            // 
            // Precio_unitario
            // 
            Precio_unitario.HeaderText = "Precio_Unitario";
            Precio_unitario.Name = "Precio_unitario";
            Precio_unitario.Width = 70;
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            Subtotal.Width = 70;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.Width = 80;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 532);
            Controls.Add(lbl_totalDeTotales);
            Controls.Add(lbl_Articulos);
            Controls.Add(label3);
            Controls.Add(btn_guardar);
            Controls.Add(lbl_titulo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPrecio);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(cbxCantidad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(dtgwMinifactura);
            Controls.Add(cbxNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Carrito de articulos electronicos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgwMinifactura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbxNombre;
        private DataGridView dtgwMinifactura;
        private Button btnSalir;
        private Button btnLimpiar;
        private ComboBox cbxCantidad;
        private Label lblNombre;
        private Label label2;
        private Button btnAgregar;
        private TextBox txtPrecio;
        private Button button1;
        private Button button2;
        private Label lbl_titulo;
        private Button btn_guardar;
        private Label label3;
        private Label lbl_Articulos;
        private Label lbl_totalDeTotales;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn Precio_unitario;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewTextBoxColumn Total;
    }
}
