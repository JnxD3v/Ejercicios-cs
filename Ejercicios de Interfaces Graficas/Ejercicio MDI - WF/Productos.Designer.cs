namespace Ejercicio_MDI___WF
{
    partial class Productos
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
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dgw_Productos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Linea = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(68, 99);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(150, 25);
            this.txt_Nombre.TabIndex = 0;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Yu Gothic UI", 10.25F);
            this.lbl_Nombre.Location = new System.Drawing.Point(64, 76);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(148, 19);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre del Producto: ";
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.Location = new System.Drawing.Point(68, 169);
            this.txt_Categoria.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.Size = new System.Drawing.Size(150, 25);
            this.txt_Categoria.TabIndex = 0;
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Font = new System.Drawing.Font("Yu Gothic UI", 10.25F);
            this.lbl_Categoria.Location = new System.Drawing.Point(64, 146);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(75, 19);
            this.lbl_Categoria.TabIndex = 1;
            this.lbl_Categoria.Text = "Categoría: ";
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(68, 239);
            this.txt_Precio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(150, 25);
            this.txt_Precio.TabIndex = 0;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Yu Gothic UI", 10.25F);
            this.lbl_Precio.Location = new System.Drawing.Point(64, 216);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(53, 19);
            this.lbl_Precio.TabIndex = 1;
            this.lbl_Precio.Text = "Precio: ";
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(68, 309);
            this.txt_Stock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(150, 25);
            this.txt_Stock.TabIndex = 0;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Yu Gothic UI", 10.25F);
            this.lbl_Stock.Location = new System.Drawing.Point(64, 286);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(119, 19);
            this.lbl_Stock.TabIndex = 1;
            this.lbl_Stock.Text = "Stock o Existencia:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(63, 22);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(317, 30);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "• AGREGAR PRODUCTOS •";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Guardar.Location = new System.Drawing.Point(82, 358);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(115, 43);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // dgw_Productos
            // 
            this.dgw_Productos.AllowUserToAddRows = false;
            this.dgw_Productos.AllowUserToDeleteRows = false;
            this.dgw_Productos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgw_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Categoria,
            this.Precio,
            this.Stock});
            this.dgw_Productos.Location = new System.Drawing.Point(324, 111);
            this.dgw_Productos.Name = "dgw_Productos";
            this.dgw_Productos.ReadOnly = true;
            this.dgw_Productos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgw_Productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_Productos.Size = new System.Drawing.Size(428, 234);
            this.dgw_Productos.TabIndex = 3;
            this.dgw_Productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Productos_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 105;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 90;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 90;
            // 
            // btn_Linea
            // 
            this.btn_Linea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.btn_Linea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Linea.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Linea.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btn_Linea.Location = new System.Drawing.Point(284, 76);
            this.btn_Linea.Name = "btn_Linea";
            this.btn_Linea.Size = new System.Drawing.Size(1, 351);
            this.btn_Linea.TabIndex = 2;
            this.btn_Linea.UseVisualStyleBackColor = false;
            this.btn_Linea.Click += new System.EventHandler(this.btn_Linea_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Eliminar.Location = new System.Drawing.Point(445, 358);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(115, 43);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Editar.Location = new System.Drawing.Point(324, 358);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(115, 43);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Buscar.Location = new System.Drawing.Point(658, 70);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(94, 25);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.Location = new System.Drawing.Point(501, 70);
            this.txt_Buscador.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(150, 25);
            this.txt_Buscador.TabIndex = 0;
            // 
            // Productos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(795, 420);
            this.ControlBox = false;
            this.Controls.Add(this.dgw_Productos);
            this.Controls.Add(this.btn_Linea);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Categoria);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Buscador);
            this.Controls.Add(this.txt_Nombre);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox txt_Categoria;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView dgw_Productos;
        private System.Windows.Forms.Button btn_Linea;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}