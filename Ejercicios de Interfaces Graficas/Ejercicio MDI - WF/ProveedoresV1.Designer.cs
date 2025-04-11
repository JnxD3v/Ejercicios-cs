namespace Ejercicio_MDI___WF
{
    partial class ProveedoresV1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PagAddProveedor = new System.Windows.Forms.TabPage();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.lbl_Ciudad = new System.Windows.Forms.Label();
            this.lbl_Correo = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_RNC = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_RNC = new System.Windows.Forms.TextBox();
            this.txt_Ciudad = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.PagVerProveedores = new System.Windows.Forms.TabPage();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.txt_Buscador = new System.Windows.Forms.TextBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.lbl_Subtitulo = new System.Windows.Forms.Label();
            this.dgw_Proveedores = new System.Windows.Forms.DataGridView();
            this.RNCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correoo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccioon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudadd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.PagAddProveedor.SuspendLayout();
            this.PagVerProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Proveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PagAddProveedor);
            this.tabControl1.Controls.Add(this.PagVerProveedores);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(595, 420);
            this.tabControl1.TabIndex = 0;
            // 
            // PagAddProveedor
            // 
            this.PagAddProveedor.Controls.Add(this.btn_Editar);
            this.PagAddProveedor.Controls.Add(this.btn_Guardar);
            this.PagAddProveedor.Controls.Add(this.lbl_Ciudad);
            this.PagAddProveedor.Controls.Add(this.lbl_Correo);
            this.PagAddProveedor.Controls.Add(this.lbl_Direccion);
            this.PagAddProveedor.Controls.Add(this.lbl_Nombre);
            this.PagAddProveedor.Controls.Add(this.lbl_RNC);
            this.PagAddProveedor.Controls.Add(this.lbl_Titulo);
            this.PagAddProveedor.Controls.Add(this.txt_RNC);
            this.PagAddProveedor.Controls.Add(this.txt_Ciudad);
            this.PagAddProveedor.Controls.Add(this.txt_Correo);
            this.PagAddProveedor.Controls.Add(this.txt_Direccion);
            this.PagAddProveedor.Controls.Add(this.txt_Nombre);
            this.PagAddProveedor.Location = new System.Drawing.Point(4, 25);
            this.PagAddProveedor.Name = "PagAddProveedor";
            this.PagAddProveedor.Padding = new System.Windows.Forms.Padding(3);
            this.PagAddProveedor.Size = new System.Drawing.Size(587, 391);
            this.PagAddProveedor.TabIndex = 0;
            this.PagAddProveedor.Text = "Agregar Proveedor";
            this.PagAddProveedor.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Editar.Location = new System.Drawing.Point(337, 329);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(115, 43);
            this.btn_Editar.TabIndex = 16;
            this.btn_Editar.Text = "EDITAR";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.Location = new System.Drawing.Point(458, 329);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(112, 43);
            this.btn_Guardar.TabIndex = 15;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // lbl_Ciudad
            // 
            this.lbl_Ciudad.AutoSize = true;
            this.lbl_Ciudad.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ciudad.Location = new System.Drawing.Point(151, 261);
            this.lbl_Ciudad.Name = "lbl_Ciudad";
            this.lbl_Ciudad.Size = new System.Drawing.Size(66, 18);
            this.lbl_Ciudad.TabIndex = 10;
            this.lbl_Ciudad.Text = "Ciudad: ";
            // 
            // lbl_Correo
            // 
            this.lbl_Correo.AutoSize = true;
            this.lbl_Correo.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Correo.Location = new System.Drawing.Point(151, 221);
            this.lbl_Correo.Name = "lbl_Correo";
            this.lbl_Correo.Size = new System.Drawing.Size(60, 18);
            this.lbl_Correo.TabIndex = 11;
            this.lbl_Correo.Text = "E-Mail: ";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Direccion.Location = new System.Drawing.Point(151, 181);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(84, 18);
            this.lbl_Direccion.TabIndex = 12;
            this.lbl_Direccion.Text = "Dirección: ";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nombre.Location = new System.Drawing.Point(151, 141);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(72, 18);
            this.lbl_Nombre.TabIndex = 13;
            this.lbl_Nombre.Text = "Nombre: ";
            // 
            // lbl_RNC
            // 
            this.lbl_RNC.AutoSize = true;
            this.lbl_RNC.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RNC.Location = new System.Drawing.Point(151, 101);
            this.lbl_RNC.Name = "lbl_RNC";
            this.lbl_RNC.Size = new System.Drawing.Size(49, 18);
            this.lbl_RNC.TabIndex = 14;
            this.lbl_RNC.Text = "RNC: ";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(107, 32);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(345, 30);
            this.lbl_Titulo.TabIndex = 9;
            this.lbl_Titulo.Text = "• AGREGAR PROVEEDORES •";
            // 
            // txt_RNC
            // 
            this.txt_RNC.Location = new System.Drawing.Point(255, 99);
            this.txt_RNC.Name = "txt_RNC";
            this.txt_RNC.Size = new System.Drawing.Size(152, 22);
            this.txt_RNC.TabIndex = 4;
            // 
            // txt_Ciudad
            // 
            this.txt_Ciudad.Location = new System.Drawing.Point(255, 259);
            this.txt_Ciudad.Name = "txt_Ciudad";
            this.txt_Ciudad.Size = new System.Drawing.Size(152, 22);
            this.txt_Ciudad.TabIndex = 5;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(255, 219);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(152, 22);
            this.txt_Correo.TabIndex = 6;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(255, 179);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(152, 22);
            this.txt_Direccion.TabIndex = 7;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(255, 139);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(152, 22);
            this.txt_Nombre.TabIndex = 8;
            // 
            // PagVerProveedores
            // 
            this.PagVerProveedores.Controls.Add(this.btn_Buscar);
            this.PagVerProveedores.Controls.Add(this.txt_Buscador);
            this.PagVerProveedores.Controls.Add(this.btn_Eliminar);
            this.PagVerProveedores.Controls.Add(this.lbl_Subtitulo);
            this.PagVerProveedores.Controls.Add(this.dgw_Proveedores);
            this.PagVerProveedores.Location = new System.Drawing.Point(4, 25);
            this.PagVerProveedores.Name = "PagVerProveedores";
            this.PagVerProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.PagVerProveedores.Size = new System.Drawing.Size(587, 391);
            this.PagVerProveedores.TabIndex = 1;
            this.PagVerProveedores.Text = "Ver Proveedores";
            this.PagVerProveedores.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Buscar.Location = new System.Drawing.Point(470, 27);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(94, 25);
            this.btn_Buscar.TabIndex = 15;
            this.btn_Buscar.Text = "BUSCAR";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // txt_Buscador
            // 
            this.txt_Buscador.Location = new System.Drawing.Point(364, 30);
            this.txt_Buscador.Name = "txt_Buscador";
            this.txt_Buscador.Size = new System.Drawing.Size(100, 22);
            this.txt_Buscador.TabIndex = 14;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Eliminar.Location = new System.Drawing.Point(22, 334);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(115, 43);
            this.btn_Eliminar.TabIndex = 13;
            this.btn_Eliminar.Text = "ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // lbl_Subtitulo
            // 
            this.lbl_Subtitulo.AutoSize = true;
            this.lbl_Subtitulo.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtitulo.Location = new System.Drawing.Point(37, 18);
            this.lbl_Subtitulo.Name = "lbl_Subtitulo";
            this.lbl_Subtitulo.Size = new System.Drawing.Size(277, 30);
            this.lbl_Subtitulo.TabIndex = 10;
            this.lbl_Subtitulo.Text = "• VER PROVEEDORES •";
            // 
            // dgw_Proveedores
            // 
            this.dgw_Proveedores.AllowUserToAddRows = false;
            this.dgw_Proveedores.AllowUserToDeleteRows = false;
            this.dgw_Proveedores.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgw_Proveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Proveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RNCS,
            this.Nombree,
            this.Correoo,
            this.Direccioon,
            this.Ciudadd});
            this.dgw_Proveedores.Location = new System.Drawing.Point(22, 63);
            this.dgw_Proveedores.Name = "dgw_Proveedores";
            this.dgw_Proveedores.ReadOnly = true;
            this.dgw_Proveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgw_Proveedores.Size = new System.Drawing.Size(542, 265);
            this.dgw_Proveedores.TabIndex = 0;
            this.dgw_Proveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Proveedores_CellContentClick);
            // 
            // RNCS
            // 
            this.RNCS.Frozen = true;
            this.RNCS.HeaderText = "RNC";
            this.RNCS.Name = "RNCS";
            this.RNCS.ReadOnly = true;
            this.RNCS.Width = 80;
            // 
            // Nombree
            // 
            this.Nombree.Frozen = true;
            this.Nombree.HeaderText = "Nombre";
            this.Nombree.Name = "Nombree";
            this.Nombree.ReadOnly = true;
            // 
            // Correoo
            // 
            this.Correoo.Frozen = true;
            this.Correoo.HeaderText = "Correo";
            this.Correoo.Name = "Correoo";
            this.Correoo.ReadOnly = true;
            // 
            // Direccioon
            // 
            this.Direccioon.Frozen = true;
            this.Direccioon.HeaderText = "Direccion";
            this.Direccioon.Name = "Direccioon";
            this.Direccioon.ReadOnly = true;
            this.Direccioon.Width = 120;
            // 
            // Ciudadd
            // 
            this.Ciudadd.Frozen = true;
            this.Ciudadd.HeaderText = "Ciudad";
            this.Ciudadd.Name = "Ciudadd";
            this.Ciudadd.ReadOnly = true;
            // 
            // ProveedoresV1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(595, 420);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProveedoresV1";
            this.Text = "Proveedores";
            this.tabControl1.ResumeLayout(false);
            this.PagAddProveedor.ResumeLayout(false);
            this.PagAddProveedor.PerformLayout();
            this.PagVerProveedores.ResumeLayout(false);
            this.PagVerProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Proveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PagAddProveedor;
        private System.Windows.Forms.TabPage PagVerProveedores;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label lbl_Ciudad;
        private System.Windows.Forms.Label lbl_Correo;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_RNC;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_RNC;
        private System.Windows.Forms.TextBox txt_Ciudad;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label lbl_Subtitulo;
        private System.Windows.Forms.DataGridView dgw_Proveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correoo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccioon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudadd;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.TextBox txt_Buscador;
        private System.Windows.Forms.Button btn_Buscar;
    }
}