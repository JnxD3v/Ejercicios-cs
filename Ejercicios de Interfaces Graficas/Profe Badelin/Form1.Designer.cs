namespace Profe_Badelin
{
    partial class ProfeBadelin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgv_Prueba = new System.Windows.Forms.DataGridView();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_ID_Empleado = new System.Windows.Forms.Label();
            this.cbx_IngresarID = new System.Windows.Forms.TextBox();
            this.cbx_IngresarNombre = new System.Windows.Forms.TextBox();
            this.cbx_IngresarApellido = new System.Windows.Forms.TextBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.lbl_NombreEmpleado = new System.Windows.Forms.Label();
            this.lbl_ApellidoEmpleado = new System.Windows.Forms.Label();
            this.lbl_Linea1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Prueba)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_Prueba
            // 
            this.dtgv_Prueba.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dtgv_Prueba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_Prueba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Empleado,
            this.Nombre,
            this.Apellido});
            this.dtgv_Prueba.Enabled = false;
            this.dtgv_Prueba.Location = new System.Drawing.Point(75, 279);
            this.dtgv_Prueba.Name = "dtgv_Prueba";
            this.dtgv_Prueba.Size = new System.Drawing.Size(344, 150);
            this.dtgv_Prueba.TabIndex = 0;
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.HeaderText = "ID_Empleado";
            this.ID_Empleado.Name = "ID_Empleado";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre_Empleado";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido_Empleado";
            this.Apellido.Name = "Apellido";
            // 
            // lbl_ID_Empleado
            // 
            this.lbl_ID_Empleado.AutoSize = true;
            this.lbl_ID_Empleado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID_Empleado.Location = new System.Drawing.Point(60, 138);
            this.lbl_ID_Empleado.Name = "lbl_ID_Empleado";
            this.lbl_ID_Empleado.Size = new System.Drawing.Size(89, 19);
            this.lbl_ID_Empleado.TabIndex = 1;
            this.lbl_ID_Empleado.Text = "ID_Empleado";
            // 
            // cbx_IngresarID
            // 
            this.cbx_IngresarID.Location = new System.Drawing.Point(206, 140);
            this.cbx_IngresarID.Name = "cbx_IngresarID";
            this.cbx_IngresarID.Size = new System.Drawing.Size(121, 20);
            this.cbx_IngresarID.TabIndex = 2;
            // 
            // cbx_IngresarNombre
            // 
            this.cbx_IngresarNombre.Location = new System.Drawing.Point(206, 179);
            this.cbx_IngresarNombre.Name = "cbx_IngresarNombre";
            this.cbx_IngresarNombre.Size = new System.Drawing.Size(121, 20);
            this.cbx_IngresarNombre.TabIndex = 2;
            // 
            // cbx_IngresarApellido
            // 
            this.cbx_IngresarApellido.Location = new System.Drawing.Point(206, 218);
            this.cbx_IngresarApellido.Name = "cbx_IngresarApellido";
            this.cbx_IngresarApellido.Size = new System.Drawing.Size(121, 20);
            this.cbx_IngresarApellido.TabIndex = 2;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(368, 125);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(90, 46);
            this.btn_Agregar.TabIndex = 3;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.Red;
            this.btn_Borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Borrar.Location = new System.Drawing.Point(368, 201);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(90, 46);
            this.btn_Borrar.TabIndex = 3;
            this.btn_Borrar.Text = "Eliminar";
            this.btn_Borrar.UseVisualStyleBackColor = false;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // lbl_NombreEmpleado
            // 
            this.lbl_NombreEmpleado.AutoSize = true;
            this.lbl_NombreEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreEmpleado.Location = new System.Drawing.Point(60, 177);
            this.lbl_NombreEmpleado.Name = "lbl_NombreEmpleado";
            this.lbl_NombreEmpleado.Size = new System.Drawing.Size(124, 19);
            this.lbl_NombreEmpleado.TabIndex = 1;
            this.lbl_NombreEmpleado.Text = "Nombre Empleado";
            // 
            // lbl_ApellidoEmpleado
            // 
            this.lbl_ApellidoEmpleado.AutoSize = true;
            this.lbl_ApellidoEmpleado.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ApellidoEmpleado.Location = new System.Drawing.Point(60, 214);
            this.lbl_ApellidoEmpleado.Name = "lbl_ApellidoEmpleado";
            this.lbl_ApellidoEmpleado.Size = new System.Drawing.Size(122, 19);
            this.lbl_ApellidoEmpleado.TabIndex = 1;
            this.lbl_ApellidoEmpleado.Text = "Apellido Empleado";
            // 
            // lbl_Linea1
            // 
            this.lbl_Linea1.AutoSize = true;
            this.lbl_Linea1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Linea1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.lbl_Linea1.Location = new System.Drawing.Point(-5, 71);
            this.lbl_Linea1.Name = "lbl_Linea1";
            this.lbl_Linea1.Size = new System.Drawing.Size(657, 19);
            this.lbl_Linea1.TabIndex = 1;
            this.lbl_Linea1.Text = "_________________________________________________________________________________" +
    "___________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(62, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "FORMULARIO SIMPLE CON DATAGRID VIEW";
            // 
            // ProfeBadelin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.cbx_IngresarApellido);
            this.Controls.Add(this.cbx_IngresarNombre);
            this.Controls.Add(this.cbx_IngresarID);
            this.Controls.Add(this.lbl_ApellidoEmpleado);
            this.Controls.Add(this.lbl_NombreEmpleado);
            this.Controls.Add(this.lbl_Linea1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ID_Empleado);
            this.Controls.Add(this.dtgv_Prueba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ProfeBadelin";
            this.Text = "Profe Badelin";
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_Prueba)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_Prueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Label lbl_ID_Empleado;
        private System.Windows.Forms.TextBox cbx_IngresarID;
        private System.Windows.Forms.TextBox cbx_IngresarNombre;
        private System.Windows.Forms.TextBox cbx_IngresarApellido;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Label lbl_NombreEmpleado;
        private System.Windows.Forms.Label lbl_ApellidoEmpleado;
        private System.Windows.Forms.Label lbl_Linea1;
        private System.Windows.Forms.Label label1;
    }
}

