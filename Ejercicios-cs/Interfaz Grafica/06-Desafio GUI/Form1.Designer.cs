namespace _06_Desafio_GUI
{
    partial class frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principal));
            pl_Principio = new Panel();
            lbl_Principal = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ms_principal = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            proveedoresToolStripMenuItem1 = new ToolStripMenuItem();
            productosToolStripMenuItem1 = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            pl_Principio.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ms_principal.SuspendLayout();
            SuspendLayout();
            // 
            // pl_Principio
            // 
            pl_Principio.Controls.Add(lbl_Principal);
            pl_Principio.Controls.Add(flowLayoutPanel1);
            pl_Principio.Location = new Point(-2, 1);
            pl_Principio.Name = "pl_Principio";
            pl_Principio.Size = new Size(801, 448);
            pl_Principio.TabIndex = 5;
            // 
            // lbl_Principal
            // 
            lbl_Principal.AutoSize = true;
            lbl_Principal.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Principal.ForeColor = SystemColors.ControlLightLight;
            lbl_Principal.Location = new Point(267, 159);
            lbl_Principal.Name = "lbl_Principal";
            lbl_Principal.Size = new Size(305, 33);
            lbl_Principal.TabIndex = 1;
            lbl_Principal.Text = "Gestion de  Inventario";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(ms_principal);
            flowLayoutPanel1.Location = new Point(3, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(145, 448);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ms_principal
            // 
            ms_principal.BackColor = Color.Transparent;
            ms_principal.Dock = DockStyle.Left;
            ms_principal.Font = new Font("Cascadia Code SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ms_principal.ForeColor = Color.White;
            ms_principal.GripMargin = new Padding(0, 5, 0, 10);
            ms_principal.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, reportesToolStripMenuItem, salirToolStripMenuItem });
            ms_principal.Location = new Point(0, 0);
            ms_principal.Margin = new Padding(0, 0, 0, 10);
            ms_principal.Name = "ms_principal";
            ms_principal.Size = new Size(143, 125);
            ms_principal.TabIndex = 0;
            ms_principal.Text = "menuStrip1";
            ms_principal.ItemClicked += menuStrip1_ItemClicked;
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem, productosToolStripMenuItem });
            mantenimientoToolStripMenuItem.Margin = new Padding(-1, 0, 0, 10);
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(131, 24);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // proveedoresToolStripMenuItem
            // 
            proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            proveedoresToolStripMenuItem.Size = new Size(180, 24);
            proveedoresToolStripMenuItem.Text = "Proveedores";
            proveedoresToolStripMenuItem.Click += proveedoresToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(180, 24);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proveedoresToolStripMenuItem1, productosToolStripMenuItem1 });
            reportesToolStripMenuItem.Margin = new Padding(-1, 0, 5, 10);
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(126, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // proveedoresToolStripMenuItem1
            // 
            proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            proveedoresToolStripMenuItem1.Size = new Size(177, 24);
            proveedoresToolStripMenuItem1.Text = "Proveedores";
            // 
            // productosToolStripMenuItem1
            // 
            productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            productosToolStripMenuItem1.Size = new Size(177, 24);
            productosToolStripMenuItem1.Text = "Productos";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salirToolStripMenuItem.Margin = new Padding(0, 0, 0, 10);
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(130, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 29, 85);
            ClientSize = new Size(800, 450);
            Controls.Add(pl_Principio);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = ms_principal;
            Name = "frm_Principal";
            Text = "Gestion de Inventario";
            pl_Principio.ResumeLayout(false);
            pl_Principio.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ms_principal.ResumeLayout(false);
            ms_principal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pl_Principio;
        private FlowLayoutPanel flowLayoutPanel1;
        private MenuStrip ms_principal;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem proveedoresToolStripMenuItem1;
        private ToolStripMenuItem productosToolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label lbl_Principal;
    }
}
