namespace Capa_Presentacion
{
    partial class formularioReporteCliente
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
            this.clientes = new Capa_Presentacion.Clientes();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obtenerClientesTableAdapter = new Capa_Presentacion.ClientesTableAdapters.ObtenerClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.obtenerClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.reportedeClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // clientes
            // 
            this.clientes.DataSetName = "Clientes";
            this.clientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = this.clientes;
            this.clientesBindingSource.Position = 0;
            // 
            // obtenerClientesBindingSource
            // 
            this.obtenerClientesBindingSource.DataMember = "ObtenerClientes";
            this.obtenerClientesBindingSource.DataSource = this.clientesBindingSource;
            // 
            // obtenerClientesTableAdapter
            // 
            this.obtenerClientesTableAdapter.ClearBeforeFill = true;
            // 
            // formularioReporteCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "formularioReporteCliente";
            this.Text = "formularioReporteCliente";
            this.Load += new System.EventHandler(this.formularioReporteCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Clientes clientes;
        private System.Windows.Forms.BindingSource obtenerClientesBindingSource;
        private ClientesTableAdapters.ObtenerClientesTableAdapter obtenerClientesTableAdapter;
    }
}