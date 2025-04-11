namespace Profe_John
{
    partial class ProfeJohn
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mDI1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mDI2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(395, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "MenuStrip";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDI1ToolStripMenuItem,
            this.mDI2ToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(66, 20);
            this.windowsMenu.Text = "&Ventanas";
            this.windowsMenu.Click += new System.EventHandler(this.windowsMenu_Click);
            // 
            // mDI1ToolStripMenuItem
            // 
            this.mDI1ToolStripMenuItem.Name = "mDI1ToolStripMenuItem";
            this.mDI1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mDI1ToolStripMenuItem.Text = "MDI 1";
            this.mDI1ToolStripMenuItem.Click += new System.EventHandler(this.mDI1ToolStripMenuItem_Click);
            // 
            // mDI2ToolStripMenuItem
            // 
            this.mDI2ToolStripMenuItem.Name = "mDI2ToolStripMenuItem";
            this.mDI2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mDI2ToolStripMenuItem.Text = "MDI 2";
            this.mDI2ToolStripMenuItem.Click += new System.EventHandler(this.mDI2ToolStripMenuItem_Click);
            // 
            // ProfeJohn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 446);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "ProfeJohn";
            this.Text = "Profe John (MDI)";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem mDI1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mDI2ToolStripMenuItem;
    }
}

