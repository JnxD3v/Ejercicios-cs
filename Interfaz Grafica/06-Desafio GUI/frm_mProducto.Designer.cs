namespace _06_Desafio_GUI
{
    partial class frm_mProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mProducto));
            lbl_titulo = new Label();
            lbl_linea = new Label();
            lbl_categoria = new Label();
            lbl_precio = new Label();
            lbl_stock = new Label();
            lbl_nombre = new Label();
            btn_agregar = new Button();
            btn_limpiar = new Button();
            txt_nombre = new TextBox();
            txt_categoria = new TextBox();
            txt_precio = new TextBox();
            txt_stock = new TextBox();
            btn_salir = new Button();
            dtgw_productos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            btn_elimina = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btn_edit = new Button();
            button1 = new Button();
            btn_buscar = new Button();
            txt_buscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgw_productos).BeginInit();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = SystemColors.Control;
            lbl_titulo.Location = new Point(12, 9);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(299, 33);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "Gestion de Productos";
            // 
            // lbl_linea
            // 
            lbl_linea.AutoSize = true;
            lbl_linea.Location = new Point(-3, 55);
            lbl_linea.Name = "lbl_linea";
            lbl_linea.Size = new Size(1157, 15);
            lbl_linea.TabIndex = 1;
            lbl_linea.Text = resources.GetString("lbl_linea.Text");
            // 
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_categoria.ForeColor = SystemColors.Control;
            lbl_categoria.Location = new Point(12, 142);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(111, 25);
            lbl_categoria.TabIndex = 2;
            lbl_categoria.Text = "Categoria";
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_precio.ForeColor = SystemColors.Control;
            lbl_precio.Location = new Point(12, 184);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(78, 25);
            lbl_precio.TabIndex = 3;
            lbl_precio.Text = "Precio";
            // 
            // lbl_stock
            // 
            lbl_stock.AutoSize = true;
            lbl_stock.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_stock.ForeColor = SystemColors.Control;
            lbl_stock.Location = new Point(12, 228);
            lbl_stock.Name = "lbl_stock";
            lbl_stock.Size = new Size(67, 25);
            lbl_stock.TabIndex = 4;
            lbl_stock.Text = "Stock";
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Cascadia Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombre.ForeColor = SystemColors.Control;
            lbl_nombre.Location = new Point(12, 99);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(78, 25);
            lbl_nombre.TabIndex = 5;
            lbl_nombre.Text = "Nombre";
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = SystemColors.ButtonHighlight;
            btn_agregar.FlatStyle = FlatStyle.Flat;
            btn_agregar.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_agregar.Location = new Point(15, 307);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(86, 35);
            btn_agregar.TabIndex = 6;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = SystemColors.ButtonHighlight;
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_limpiar.Location = new Point(137, 307);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(85, 35);
            btn_limpiar.TabIndex = 7;
            btn_limpiar.Text = "Limpiar";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(154, 99);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(118, 23);
            txt_nombre.TabIndex = 8;
            // 
            // txt_categoria
            // 
            txt_categoria.Location = new Point(154, 142);
            txt_categoria.Name = "txt_categoria";
            txt_categoria.Size = new Size(118, 23);
            txt_categoria.TabIndex = 9;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(154, 186);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(118, 23);
            txt_precio.TabIndex = 10;
            // 
            // txt_stock
            // 
            txt_stock.Location = new Point(154, 230);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(118, 23);
            txt_stock.TabIndex = 11;
            // 
            // btn_salir
            // 
            btn_salir.BackColor = SystemColors.ButtonHighlight;
            btn_salir.FlatStyle = FlatStyle.Flat;
            btn_salir.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_salir.Location = new Point(250, 307);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(75, 35);
            btn_salir.TabIndex = 12;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // dtgw_productos
            // 
            dtgw_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgw_productos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Categoria, Precio, Stock });
            dtgw_productos.Location = new Point(407, 142);
            dtgw_productos.Name = "dtgw_productos";
            dtgw_productos.ReadOnly = true;
            dtgw_productos.Size = new Size(408, 164);
            dtgw_productos.TabIndex = 13;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.FillWeight = 90F;
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Width = 80;
            // 
            // Precio
            // 
            Precio.FillWeight = 80F;
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            Precio.Width = 70;
            // 
            // Stock
            // 
            Stock.FillWeight = 70F;
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 65;
            // 
            // btn_elimina
            // 
            btn_elimina.BackColor = SystemColors.ButtonHighlight;
            btn_elimina.FlatStyle = FlatStyle.Flat;
            btn_elimina.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_elimina.Location = new Point(529, 334);
            btn_elimina.Name = "btn_elimina";
            btn_elimina.Size = new Size(93, 35);
            btn_elimina.TabIndex = 14;
            btn_elimina.Text = "Eliminar ";
            btn_elimina.UseVisualStyleBackColor = false;
            btn_elimina.Click += btn_elimina_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = SystemColors.ButtonHighlight;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_edit.Location = new Point(416, 334);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(93, 35);
            btn_edit.TabIndex = 15;
            btn_edit.Text = "Editar";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Location = new Point(368, 63);
            button1.Name = "button1";
            button1.Size = new Size(1, 363);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_buscar
            // 
            btn_buscar.BackColor = SystemColors.ButtonHighlight;
            btn_buscar.FlatStyle = FlatStyle.Flat;
            btn_buscar.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_buscar.Location = new Point(710, 73);
            btn_buscar.Name = "btn_buscar";
            btn_buscar.Size = new Size(90, 32);
            btn_buscar.TabIndex = 17;
            btn_buscar.Text = "Buscar";
            btn_buscar.UseVisualStyleBackColor = false;
            btn_buscar.Click += btn_buscar_Click;
            // 
            // txt_buscar
            // 
            txt_buscar.Location = new Point(500, 82);
            txt_buscar.Name = "txt_buscar";
            txt_buscar.Size = new Size(194, 23);
            txt_buscar.TabIndex = 18;
            txt_buscar.TextChanged += textBox1_TextChanged;
            // 
            // frm_mProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 29, 85);
            ClientSize = new Size(827, 419);
            Controls.Add(txt_buscar);
            Controls.Add(btn_buscar);
            Controls.Add(button1);
            Controls.Add(btn_edit);
            Controls.Add(btn_elimina);
            Controls.Add(dtgw_productos);
            Controls.Add(btn_salir);
            Controls.Add(txt_stock);
            Controls.Add(txt_precio);
            Controls.Add(txt_categoria);
            Controls.Add(txt_nombre);
            Controls.Add(btn_limpiar);
            Controls.Add(btn_agregar);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_stock);
            Controls.Add(lbl_precio);
            Controls.Add(lbl_categoria);
            Controls.Add(lbl_linea);
            Controls.Add(lbl_titulo);
            Name = "frm_mProducto";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)dtgw_productos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Label lbl_linea;
        private Label lbl_categoria;
        private Label lbl_precio;
        private Label lbl_stock;
        private Label lbl_nombre;
        private Button btn_agregar;
        private Button btn_limpiar;
        private TextBox txt_nombre;
        private TextBox txt_categoria;
        private TextBox txt_precio;
        private TextBox txt_stock;
        private Button btn_salir;
        private DataGridView dtgw_productos;
        private Button btn_elimina;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btn_edit;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private Button button1;
        private Button btn_buscar;
        private TextBox txt_buscar;
    }
}