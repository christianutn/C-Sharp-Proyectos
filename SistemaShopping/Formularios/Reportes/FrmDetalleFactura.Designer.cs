namespace SistemaShopping.Formularios.Clientes
{
    partial class FrmDetalleFactura
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
            this.rptFactura = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sistemaShoppingDataSet = new SistemaShopping.SistemaShoppingDataSet();
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasTableAdapter = new SistemaShopping.SistemaShoppingDataSetTableAdapters.FacturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaShoppingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptFactura
            // 
            this.rptFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_detalleFactura";
            reportDataSource1.Value = this.facturasBindingSource;
            this.rptFactura.LocalReport.DataSources.Add(reportDataSource1);
            this.rptFactura.LocalReport.ReportEmbeddedResource = "SistemaShopping.Formularios.Reportes.informe.rdlc";
            this.rptFactura.Location = new System.Drawing.Point(0, 0);
            this.rptFactura.Name = "rptFactura";
            this.rptFactura.ServerReport.BearerToken = null;
            this.rptFactura.Size = new System.Drawing.Size(838, 512);
            this.rptFactura.TabIndex = 0;
            this.rptFactura.Load += new System.EventHandler(this.rptFactura_Load);
            // 
            // sistemaShoppingDataSet
            // 
            this.sistemaShoppingDataSet.DataSetName = "SistemaShoppingDataSet";
            this.sistemaShoppingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "Facturas";
            this.facturasBindingSource.DataSource = this.sistemaShoppingDataSet;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmDetalleFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 512);
            this.Controls.Add(this.rptFactura);
            this.Name = "FrmDetalleFactura";
            this.Text = "FrmDetalleFactura";
            this.Load += new System.EventHandler(this.FrmDetalleFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaShoppingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptFactura;
        private SistemaShoppingDataSet sistemaShoppingDataSet;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private SistemaShoppingDataSetTableAdapters.FacturasTableAdapter facturasTableAdapter;
    }
}