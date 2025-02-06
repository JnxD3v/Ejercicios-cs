namespace Ejercicio_MDI___WF
{
    partial class Formulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario));
            this.msp_Menu = new System.Windows.Forms.MenuStrip();
            this.IniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Fondo = new System.Windows.Forms.Panel();
            this.lbl_RNC = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.msp_Menu.SuspendLayout();
            this.pnl_Fondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // msp_Menu
            // 
            this.msp_Menu.BackColor = System.Drawing.Color.White;
            this.msp_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IniciarToolStripMenuItem,
            this.OpcionesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.msp_Menu.Location = new System.Drawing.Point(0, 0);
            this.msp_Menu.Name = "msp_Menu";
            this.msp_Menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msp_Menu.Size = new System.Drawing.Size(357, 24);
            this.msp_Menu.TabIndex = 3;
            this.msp_Menu.Text = "msp_Menu";
            // 
            // IniciarToolStripMenuItem
            // 
            this.IniciarToolStripMenuItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarToolStripMenuItem.Name = "IniciarToolStripMenuItem";
            this.IniciarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.IniciarToolStripMenuItem.Text = "INICIAR";
            this.IniciarToolStripMenuItem.Click += new System.EventHandler(this.IniciarToolStripMenuItem_Click);
            // 
            // OpcionesToolStripMenuItem
            // 
            this.OpcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.OpcionesToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem";
            this.OpcionesToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.OpcionesToolStripMenuItem.Text = "Mantenimiento";
            this.OpcionesToolStripMenuItem.Visible = false;
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.proveedoresToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Visible = false;
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pnl_Fondo
            // 
            this.pnl_Fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pnl_Fondo.Controls.Add(this.lbl_RNC);
            this.pnl_Fondo.Controls.Add(this.lbl_Titulo);
            this.pnl_Fondo.Location = new System.Drawing.Point(0, 25);
            this.pnl_Fondo.Name = "pnl_Fondo";
            this.pnl_Fondo.Size = new System.Drawing.Size(357, 230);
            this.pnl_Fondo.TabIndex = 5;
            // 
            // lbl_RNC
            // 
            this.lbl_RNC.AutoSize = true;
            this.lbl_RNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RNC.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbl_RNC.Location = new System.Drawing.Point(266, 204);
            this.lbl_RNC.Name = "lbl_RNC";
            this.lbl_RNC.Size = new System.Drawing.Size(88, 13);
            this.lbl_RNC.TabIndex = 1;
            this.lbl_RNC.Text = "by @michael.frito";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Titulo.Location = new System.Drawing.Point(27, 88);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(309, 30);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "SISTEMA DE INVENTARIO";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Formulario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(357, 251);
            this.Controls.Add(this.msp_Menu);
            this.Controls.Add(this.pnl_Fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario";
            this.msp_Menu.ResumeLayout(false);
            this.msp_Menu.PerformLayout();
            this.pnl_Fondo.ResumeLayout(false);
            this.pnl_Fondo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msp_Menu;
        private System.Windows.Forms.ToolStripMenuItem OpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Fondo;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_RNC;
        private System.Windows.Forms.ToolStripMenuItem IniciarToolStripMenuItem;
    }
}

