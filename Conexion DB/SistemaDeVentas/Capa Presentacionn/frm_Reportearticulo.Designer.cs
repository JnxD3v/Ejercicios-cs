namespace Capa_Presentacionn
{
    partial class frm_Reportearticulo
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
            this.sistemaVentasDataSet = new Capa_Presentacionn.SistemaVentasDataSet();
            this.sistemaVentasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ObtenerArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerArticulosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerArticulosTableAdapter = new Capa_Presentacionn.SistemaVentasDataSetTableAdapters.ObtenerArticulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerArticulosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "sistemventas";
            reportDataSource1.Value = this.obtenerArticulosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacionn.informe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(526, 420);
            this.reportViewer1.TabIndex = 0;
            // 
            // sistemaVentasDataSet
            // 
            this.sistemaVentasDataSet.DataSetName = "SistemaVentasDataSet";
            this.sistemaVentasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sistemaVentasDataSetBindingSource
            // 
            this.sistemaVentasDataSetBindingSource.DataSource = this.sistemaVentasDataSet;
            this.sistemaVentasDataSetBindingSource.Position = 0;
            // 
            // ObtenerArticulosBindingSource
            // 
            this.ObtenerArticulosBindingSource.DataMember = "ObtenerArticulos";
            this.ObtenerArticulosBindingSource.DataSource = this.sistemaVentasDataSet;
            // 
            // obtenerArticulosBindingSource1
            // 
            this.obtenerArticulosBindingSource1.DataMember = "ObtenerArticulos";
            this.obtenerArticulosBindingSource1.DataSource = this.sistemaVentasDataSet;
            // 
            // obtenerArticulosTableAdapter
            // 
            this.obtenerArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Reportearticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 420);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_Reportearticulo";
            this.Text = "frm_Reportearticulo";
            this.Load += new System.EventHandler(this.frm_Reportearticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaVentasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObtenerArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerArticulosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sistemaVentasDataSetBindingSource;
        private SistemaVentasDataSet sistemaVentasDataSet;
        private System.Windows.Forms.BindingSource ObtenerArticulosBindingSource;
        private System.Windows.Forms.BindingSource obtenerArticulosBindingSource1;
        private SistemaVentasDataSetTableAdapters.ObtenerArticulosTableAdapter obtenerArticulosTableAdapter;
    }
}