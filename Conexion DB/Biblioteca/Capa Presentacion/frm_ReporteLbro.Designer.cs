namespace Capa_Presentacion
{
    partial class frm_ReporteLbro
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
            this.bIBLIOTECADataSet = new Capa_Presentacion.BIBLIOTECADataSet();
            this.bIBLIOTECADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splistadolibrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_listado_librosTableAdapter = new Capa_Presentacion.BIBLIOTECADataSetTableAdapters.sp_listado_librosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistadolibrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "spLibros";
            reportDataSource1.Value = this.splistadolibrosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.ReporteLibros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(787, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // bIBLIOTECADataSet
            // 
            this.bIBLIOTECADataSet.DataSetName = "BIBLIOTECADataSet";
            this.bIBLIOTECADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bIBLIOTECADataSetBindingSource
            // 
            this.bIBLIOTECADataSetBindingSource.DataSource = this.bIBLIOTECADataSet;
            this.bIBLIOTECADataSetBindingSource.Position = 0;
            // 
            // splistadolibrosBindingSource
            // 
            this.splistadolibrosBindingSource.DataMember = "sp_listado_libros";
            this.splistadolibrosBindingSource.DataSource = this.bIBLIOTECADataSetBindingSource;
            // 
            // sp_listado_librosTableAdapter
            // 
            this.sp_listado_librosTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ReporteLbro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 514);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_ReporteLbro";
            this.Text = "frm_ReporteLbro";
            this.Load += new System.EventHandler(this.frm_ReporteLbro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bIBLIOTECADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splistadolibrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BIBLIOTECADataSet bIBLIOTECADataSet;
        private System.Windows.Forms.BindingSource bIBLIOTECADataSetBindingSource;
        private System.Windows.Forms.BindingSource splistadolibrosBindingSource;
        private BIBLIOTECADataSetTableAdapters.sp_listado_librosTableAdapter sp_listado_librosTableAdapter;
    }
}