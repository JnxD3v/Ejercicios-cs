namespace MDI_Forms_Ejemplo
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
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            provedorToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            procesosToolStripMenuItem = new ToolStripMenuItem();
            proceso1ToolStripMenuItem = new ToolStripMenuItem();
            proceso2ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            subProceso1ToolStripMenuItem = new ToolStripMenuItem();
            subProceso2ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            sistemasToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, procesosToolStripMenuItem, reportesToolStripMenuItem, sistemasToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Table;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 119);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, provedorToolStripMenuItem, productosToolStripMenuItem });
            mantenimientoToolStripMenuItem.Image = Properties.Resources._1ed6978ad3c6cc70d3b0440cac58ccc8;
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(117, 20);
            mantenimientoToolStripMenuItem.Text = "mantenimiento";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // provedorToolStripMenuItem
            // 
            provedorToolStripMenuItem.Name = "provedorToolStripMenuItem";
            provedorToolStripMenuItem.Size = new Size(180, 22);
            provedorToolStripMenuItem.Text = "Provedor";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(180, 22);
            productosToolStripMenuItem.Text = "Productos";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { proceso1ToolStripMenuItem, proceso2ToolStripMenuItem, toolStripSeparator1, subProceso1ToolStripMenuItem, subProceso2ToolStripMenuItem, toolStripSeparator2 });
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(66, 19);
            procesosToolStripMenuItem.Text = "Procesos";
            // 
            // proceso1ToolStripMenuItem
            // 
            proceso1ToolStripMenuItem.Name = "proceso1ToolStripMenuItem";
            proceso1ToolStripMenuItem.Size = new Size(151, 22);
            proceso1ToolStripMenuItem.Text = "Proceso 1 ";
            // 
            // proceso2ToolStripMenuItem
            // 
            proceso2ToolStripMenuItem.Name = "proceso2ToolStripMenuItem";
            proceso2ToolStripMenuItem.Size = new Size(151, 22);
            proceso2ToolStripMenuItem.Text = "Proceso 2";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(148, 6);
            // 
            // subProceso1ToolStripMenuItem
            // 
            subProceso1ToolStripMenuItem.Name = "subProceso1ToolStripMenuItem";
            subProceso1ToolStripMenuItem.Size = new Size(151, 22);
            subProceso1ToolStripMenuItem.Text = "Sub Proceso 1 ";
            // 
            // subProceso2ToolStripMenuItem
            // 
            subProceso2ToolStripMenuItem.Name = "subProceso2ToolStripMenuItem";
            subProceso2ToolStripMenuItem.Size = new Size(151, 22);
            subProceso2ToolStripMenuItem.Text = "Sub  Proceso 2";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(148, 6);
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 19);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // sistemasToolStripMenuItem
            // 
            sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            sistemasToolStripMenuItem.Size = new Size(65, 19);
            sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 19);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem provedorToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem proceso1ToolStripMenuItem;
        private ToolStripMenuItem proceso2ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem subProceso1ToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem sistemasToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem subProceso2ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
    }
}
