namespace Capa_Presentacionn
{
    partial class Factura
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistemaVentasDataSet2 = new Capa_Presentacionn.SistemaVentasDataSet2();
            this.spGenerarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GenerarFacturaTableAdapter = new Capa_Presentacionn.SistemaVentasDataSet2TableAdapters.sp_GenerarFacturaTableAdapter();
            this.sp_GenerarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GenerarFacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Ventas";
            reportDataSource1.Value = this.sp_GenerarFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacionn.factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // sistemaVentasDataSet2
            // 
            this.sistemaVentasDataSet2.DataSetName = "SistemaVentasDataSet2";
            this.sistemaVentasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spGenerarFacturaBindingSource
            // 
            this.spGenerarFacturaBindingSource.DataMember = "sp_GenerarFactura";
            this.spGenerarFacturaBindingSource.DataSource = this.sistemaVentasDataSet2;
            // 
            // sp_GenerarFacturaTableAdapter
            // 
            this.sp_GenerarFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // sp_GenerarFacturaBindingSource
            // 
            this.sp_GenerarFacturaBindingSource.DataMember = "sp_GenerarFactura";
            this.sp_GenerarFacturaBindingSource.DataSource = this.sistemaVentasDataSet2;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGenerarFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GenerarFacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spGenerarFacturaBindingSource;
        private SistemaVentasDataSet2 sistemaVentasDataSet2;
        private SistemaVentasDataSet2TableAdapters.sp_GenerarFacturaTableAdapter sp_GenerarFacturaTableAdapter;
        private System.Windows.Forms.BindingSource sp_GenerarFacturaBindingSource;
    }
}