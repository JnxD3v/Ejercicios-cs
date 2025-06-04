namespace Capa_Presentacion
{
    partial class frm_reportePrestamocs
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
            this.bIBLIOTECADataSet1 = new Capa_Presentacion.BIBLIOTECADataSet1();
            this.bIBLIOTECADataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerPrestamosConNombresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerPrestamosConNombresTableAdapter = new Capa_Presentacion.BIBLIOTECADataSet1TableAdapters.ObtenerPrestamosConNombresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerPrestamosConNombresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ReportPrestamo";
            reportDataSource1.Value = this.obtenerPrestamosConNombresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.reportePrestamos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bIBLIOTECADataSet1
            // 
            this.bIBLIOTECADataSet1.DataSetName = "BIBLIOTECADataSet1";
            this.bIBLIOTECADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bIBLIOTECADataSet1BindingSource
            // 
            this.bIBLIOTECADataSet1BindingSource.DataSource = this.bIBLIOTECADataSet1;
            this.bIBLIOTECADataSet1BindingSource.Position = 0;
            // 
            // obtenerPrestamosConNombresBindingSource
            // 
            this.obtenerPrestamosConNombresBindingSource.DataMember = "ObtenerPrestamosConNombres";
            this.obtenerPrestamosConNombresBindingSource.DataSource = this.bIBLIOTECADataSet1BindingSource;
            // 
            // obtenerPrestamosConNombresTableAdapter
            // 
            this.obtenerPrestamosConNombresTableAdapter.ClearBeforeFill = true;
            // 
            // frm_reportePrestamocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_reportePrestamocs";
            this.Text = "frm_reportePrestamocs";
            this.Load += new System.EventHandler(this.frm_reportePrestamocs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerPrestamosConNombresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BIBLIOTECADataSet1 bIBLIOTECADataSet1;
        private System.Windows.Forms.BindingSource bIBLIOTECADataSet1BindingSource;
        private System.Windows.Forms.BindingSource obtenerPrestamosConNombresBindingSource;
        private BIBLIOTECADataSet1TableAdapters.ObtenerPrestamosConNombresTableAdapter obtenerPrestamosConNombresTableAdapter;
    }
}