namespace SistemaShopping.Formularios.Clientes
{
    partial class FrmCompras
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
            this.gridCompras = new System.Windows.Forms.DataGridView();
            this.codTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTipoFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTarj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigoLoc = new SistemaShopping.Clases.TextBoxUsuario();
            this.txtNumeroTarj = new SistemaShopping.Clases.TextBoxUsuario();
            this.cmbTipoFactura = new SistemaShopping.Clases.ComboBox01();
            this.txtNumeroFact = new SistemaShopping.Clases.TextBoxUsuario();
            this.cmbTipoDoc = new SistemaShopping.Clases.ComboBox01();
            this.txtNumeroDoc = new SistemaShopping.Clases.TextBoxUsuario();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCompras
            // 
            this.gridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTipoDoc,
            this.numeroDoc,
            this.codLocal,
            this.codTipoFact,
            this.numeroFact,
            this.numeroTarj});
            this.gridCompras.Location = new System.Drawing.Point(12, 311);
            this.gridCompras.Name = "gridCompras";
            this.gridCompras.Size = new System.Drawing.Size(1060, 233);
            this.gridCompras.TabIndex = 2;
            // 
            // codTipoDoc
            // 
            this.codTipoDoc.HeaderText = "Tipo de documento";
            this.codTipoDoc.Name = "codTipoDoc";
            // 
            // numeroDoc
            // 
            this.numeroDoc.HeaderText = "Número de documento";
            this.numeroDoc.Name = "numeroDoc";
            this.numeroDoc.Width = 200;
            // 
            // codLocal
            // 
            this.codLocal.HeaderText = "Código Local";
            this.codLocal.Name = "codLocal";
            // 
            // codTipoFact
            // 
            this.codTipoFact.HeaderText = "Tipo de Factura";
            this.codTipoFact.Name = "codTipoFact";
            // 
            // numeroFact
            // 
            this.numeroFact.HeaderText = "Número de factura";
            this.numeroFact.Name = "numeroFact";
            this.numeroFact.Width = 250;
            // 
            // numeroTarj
            // 
            this.numeroTarj.HeaderText = "Número de tarjeta";
            this.numeroTarj.Name = "numeroTarj";
            this.numeroTarj.Width = 250;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(788, 236);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 42);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(917, 251);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(72, 24);
            this.chkTodos.TabIndex = 8;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tipo de Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Número de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipo de Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Número de Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Código del Local";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(610, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Número de Tarjeta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(366, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Buscar compras realizadas";
            // 
            // txtCodigoLoc
            // 
            this.txtCodigoLoc.BorderColor = System.Drawing.Color.Blue;
            this.txtCodigoLoc.Location = new System.Drawing.Point(797, 103);
            this.txtCodigoLoc.Name = "txtCodigoLoc";
            this.txtCodigoLoc.PpAdmiteNull = false;
            this.txtCodigoLoc.PpCampoSql = null;
            this.txtCodigoLoc.PpEsDireccion = false;
            this.txtCodigoLoc.PpEsDocumento = false;
            this.txtCodigoLoc.PpEsFechaNacimiento = false;
            this.txtCodigoLoc.PpEsNombreOapellido = false;
            this.txtCodigoLoc.PpEsTextoValido = false;
            this.txtCodigoLoc.PpMensajeError = null;
            this.txtCodigoLoc.PpNombreTabla = "Locales";
            this.txtCodigoLoc.PpNombreTablaGeneral = null;
            this.txtCodigoLoc.Size = new System.Drawing.Size(154, 26);
            this.txtCodigoLoc.TabIndex = 6;
            // 
            // txtNumeroTarj
            // 
            this.txtNumeroTarj.BorderColor = System.Drawing.Color.Blue;
            this.txtNumeroTarj.Location = new System.Drawing.Point(797, 146);
            this.txtNumeroTarj.Name = "txtNumeroTarj";
            this.txtNumeroTarj.PpAdmiteNull = false;
            this.txtNumeroTarj.PpCampoSql = null;
            this.txtNumeroTarj.PpEsDireccion = false;
            this.txtNumeroTarj.PpEsDocumento = false;
            this.txtNumeroTarj.PpEsFechaNacimiento = false;
            this.txtNumeroTarj.PpEsNombreOapellido = false;
            this.txtNumeroTarj.PpEsTextoValido = false;
            this.txtNumeroTarj.PpMensajeError = null;
            this.txtNumeroTarj.PpNombreTabla = "Tarjetas";
            this.txtNumeroTarj.PpNombreTablaGeneral = null;
            this.txtNumeroTarj.Size = new System.Drawing.Size(154, 26);
            this.txtNumeroTarj.TabIndex = 5;
            // 
            // cmbTipoFactura
            // 
            this.cmbTipoFactura.BorderColor = System.Drawing.Color.Blue;
            this.cmbTipoFactura.FormattingEnabled = true;
            this.cmbTipoFactura.Location = new System.Drawing.Point(288, 198);
            this.cmbTipoFactura.Name = "cmbTipoFactura";
            this.cmbTipoFactura.PpCampoTabla = null;
            this.cmbTipoFactura.PpEsCmbValido = false;
            this.cmbTipoFactura.PpMensajeError = null;
            this.cmbTipoFactura.PpNombre = "descripcion";
            this.cmbTipoFactura.PpNombreTabla = "TiposFacturas";
            this.cmbTipoFactura.PpNombreTablaGeneral = null;
            this.cmbTipoFactura.PpPk = "descripcion";
            this.cmbTipoFactura.PpSelectedIndex = 0;
            this.cmbTipoFactura.Size = new System.Drawing.Size(81, 28);
            this.cmbTipoFactura.TabIndex = 4;
            // 
            // txtNumeroFact
            // 
            this.txtNumeroFact.BorderColor = System.Drawing.Color.Blue;
            this.txtNumeroFact.Location = new System.Drawing.Point(288, 249);
            this.txtNumeroFact.Name = "txtNumeroFact";
            this.txtNumeroFact.PpAdmiteNull = false;
            this.txtNumeroFact.PpCampoSql = null;
            this.txtNumeroFact.PpEsDireccion = false;
            this.txtNumeroFact.PpEsDocumento = false;
            this.txtNumeroFact.PpEsFechaNacimiento = false;
            this.txtNumeroFact.PpEsNombreOapellido = false;
            this.txtNumeroFact.PpEsTextoValido = false;
            this.txtNumeroFact.PpMensajeError = null;
            this.txtNumeroFact.PpNombreTabla = "Facturas";
            this.txtNumeroFact.PpNombreTablaGeneral = null;
            this.txtNumeroFact.Size = new System.Drawing.Size(198, 26);
            this.txtNumeroFact.TabIndex = 3;
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.BorderColor = System.Drawing.Color.Blue;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(288, 103);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.PpCampoTabla = null;
            this.cmbTipoDoc.PpEsCmbValido = false;
            this.cmbTipoDoc.PpMensajeError = null;
            this.cmbTipoDoc.PpNombre = "descripcion";
            this.cmbTipoDoc.PpNombreTabla = "TipoDocumento";
            this.cmbTipoDoc.PpNombreTablaGeneral = null;
            this.cmbTipoDoc.PpPk = "codigo";
            this.cmbTipoDoc.PpSelectedIndex = 0;
            this.cmbTipoDoc.Size = new System.Drawing.Size(81, 28);
            this.cmbTipoDoc.TabIndex = 1;
            // 
            // txtNumeroDoc
            // 
            this.txtNumeroDoc.BorderColor = System.Drawing.Color.Blue;
            this.txtNumeroDoc.Location = new System.Drawing.Point(288, 149);
            this.txtNumeroDoc.Name = "txtNumeroDoc";
            this.txtNumeroDoc.PpAdmiteNull = false;
            this.txtNumeroDoc.PpCampoSql = null;
            this.txtNumeroDoc.PpEsDireccion = false;
            this.txtNumeroDoc.PpEsDocumento = true;
            this.txtNumeroDoc.PpEsFechaNacimiento = false;
            this.txtNumeroDoc.PpEsNombreOapellido = false;
            this.txtNumeroDoc.PpEsTextoValido = false;
            this.txtNumeroDoc.PpMensajeError = null;
            this.txtNumeroDoc.PpNombreTabla = "Clientes";
            this.txtNumeroDoc.PpNombreTablaGeneral = null;
            this.txtNumeroDoc.Size = new System.Drawing.Size(198, 26);
            this.txtNumeroDoc.TabIndex = 0;
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.SystemColors.Control;
            this.btnVerDetalle.BackgroundImage = global::SistemaShopping.Properties.Resources.verDetalle;
            this.btnVerDetalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVerDetalle.Location = new System.Drawing.Point(788, 555);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(57, 56);
            this.btnVerDetalle.TabIndex = 16;
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 623);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoLoc);
            this.Controls.Add(this.txtNumeroTarj);
            this.Controls.Add(this.cmbTipoFactura);
            this.Controls.Add(this.txtNumeroFact);
            this.Controls.Add(this.gridCompras);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.txtNumeroDoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCompras";
            this.Text = "Compras realizadas por los clientes";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clases.TextBoxUsuario txtNumeroDoc;
        private Clases.ComboBox01 cmbTipoDoc;
        private System.Windows.Forms.DataGridView gridCompras;
        private Clases.TextBoxUsuario txtNumeroFact;
        private Clases.ComboBox01 cmbTipoFactura;
        private Clases.TextBoxUsuario txtNumeroTarj;
        private Clases.TextBoxUsuario txtCodigoLoc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarj;
        private System.Windows.Forms.Button btnVerDetalle;
    }
}