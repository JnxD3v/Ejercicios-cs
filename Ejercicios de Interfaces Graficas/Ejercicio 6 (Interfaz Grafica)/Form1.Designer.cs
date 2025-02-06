using System.Windows.Forms;

namespace Ejercicio_5__Interfaz_Grafica_
{
    partial class Ejercicio5
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
            this.linea1 = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.dtw_Carrito = new System.Windows.Forms.DataGridView();
            this.NombreP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.lbl_Carrito = new System.Windows.Forms.Label();
            this.cbx_SeleccionProductos = new System.Windows.Forms.ComboBox();
            this.lbl_ProductosDisponibles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtw_Carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // linea1
            // 
            this.linea1.AutoSize = true;
            this.linea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linea1.ForeColor = System.Drawing.Color.Silver;
            this.linea1.Location = new System.Drawing.Point(34, 62);
            this.linea1.Name = "linea1";
            this.linea1.Size = new System.Drawing.Size(103, 13);
            this.linea1.TabIndex = 0;
            this.linea1.Text = "--------------------------------";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(32, 33);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(224, 27);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Tienda: La Fantansía";
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.CustomFormat = "dd/mm/yyyy";
            this.dtp_Fecha.Enabled = false;
            this.dtp_Fecha.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Fecha.Location = new System.Drawing.Point(341, 33);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(96, 25);
            this.dtp_Fecha.TabIndex = 2;
            // 
            // dtw_Carrito
            // 
            this.dtw_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtw_Carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreP,
            this.PrecioP,
            this.CantidadP});
            this.dtw_Carrito.Location = new System.Drawing.Point(28, 259);
            this.dtw_Carrito.Name = "dtw_Carrito";
            this.dtw_Carrito.Size = new System.Drawing.Size(393, 243);
            this.dtw_Carrito.TabIndex = 3;
            // 
            // NombreP
            // 
            this.NombreP.HeaderText = "Nombre Producto";
            this.NombreP.Name = "NombreP";
            this.NombreP.ReadOnly = true;
            this.NombreP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NombreP.Width = 150;
            // 
            // PrecioP
            // 
            this.PrecioP.HeaderText = "Precio";
            this.PrecioP.Name = "PrecioP";
            this.PrecioP.ReadOnly = true;
            // 
            // CantidadP
            // 
            this.CantidadP.HeaderText = "Cantidad";
            this.CantidadP.Name = "CantidadP";
            this.CantidadP.ReadOnly = true;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(35, 153);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(147, 48);
            this.btn_Agregar.TabIndex = 5;
            this.btn_Agregar.Text = "Agregar al Carrito";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // lbl_Carrito
            // 
            this.lbl_Carrito.AutoSize = true;
            this.lbl_Carrito.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Carrito.Location = new System.Drawing.Point(32, 222);
            this.lbl_Carrito.Name = "lbl_Carrito";
            this.lbl_Carrito.Size = new System.Drawing.Size(74, 25);
            this.lbl_Carrito.TabIndex = 1;
            this.lbl_Carrito.Text = "Carrito";
            // 
            // cbx_SeleccionProductos
            // 
            this.cbx_SeleccionProductos.FormattingEnabled = true;
            this.cbx_SeleccionProductos.Location = new System.Drawing.Point(35, 116);
            this.cbx_SeleccionProductos.Name = "cbx_SeleccionProductos";
            this.cbx_SeleccionProductos.Size = new System.Drawing.Size(167, 21);
            this.cbx_SeleccionProductos.TabIndex = 6;
            // 
            // lbl_ProductosDisponibles
            // 
            this.lbl_ProductosDisponibles.AutoSize = true;
            this.lbl_ProductosDisponibles.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProductosDisponibles.Location = new System.Drawing.Point(32, 86);
            this.lbl_ProductosDisponibles.Name = "lbl_ProductosDisponibles";
            this.lbl_ProductosDisponibles.Size = new System.Drawing.Size(170, 17);
            this.lbl_ProductosDisponibles.TabIndex = 1;
            this.lbl_ProductosDisponibles.Text = "• Productos Disponibles: ";
            // 
            // Ejercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(452, 530);
            this.Controls.Add(this.cbx_SeleccionProductos);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dtw_Carrito);
            this.Controls.Add(this.dtp_Fecha);
            this.Controls.Add(this.lbl_Carrito);
            this.Controls.Add(this.lbl_ProductosDisponibles);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.linea1);
            this.Name = "Ejercicio5";
            this.Text = "Sistema de Facturacion (No DB)";
            ((System.ComponentModel.ISupportInitialize)(this.dtw_Carrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label linea1;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private DataGridView dtw_Carrito;
        private DataGridViewTextBoxColumn NombreP;
        private DataGridViewTextBoxColumn PrecioP;
        private DataGridViewTextBoxColumn CantidadP;
        private Button btn_Agregar;
        private Label lbl_Carrito;
        private ComboBox cbx_SeleccionProductos;
        private Label lbl_ProductosDisponibles;
    }
}

