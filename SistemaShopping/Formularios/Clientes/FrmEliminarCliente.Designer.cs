﻿namespace SistemaShopping.Formularios.Clientes
{
    partial class FrmEliminarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbEstadosCiviles = new SistemaShopping.Clases.ComboBox01();
            this.cmbSexos = new SistemaShopping.Clases.ComboBox01();
            this.cmbLocalidades = new SistemaShopping.Clases.ComboBox01();
            this.cmbProvincias = new SistemaShopping.Clases.ComboBox01();
            this.cmbTipoDoc = new SistemaShopping.Clases.ComboBox01();
            this.txtFechaNacimiento = new SistemaShopping.Clases.TextBoxUsuario();
            this.txtDireccion = new SistemaShopping.Clases.TextBoxUsuario();
            this.txtNroDoc = new SistemaShopping.Clases.TextBoxUsuario();
            this.txtApellido = new SistemaShopping.Clases.TextBoxUsuario();
            this.txtNombres = new SistemaShopping.Clases.TextBoxUsuario();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Número de Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Provincia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Localidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(130, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sexo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 461);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Estado Civil";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Fecha de Nacimiento";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(187, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 25);
            this.label11.TabIndex = 20;
            this.label11.Text = "Eliminar Cliente";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(222, 587);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 33);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbEstadosCiviles
            // 
            this.cmbEstadosCiviles.BorderColor = System.Drawing.Color.Transparent;
            this.cmbEstadosCiviles.Enabled = false;
            this.cmbEstadosCiviles.FormattingEnabled = true;
            this.cmbEstadosCiviles.Location = new System.Drawing.Point(232, 458);
            this.cmbEstadosCiviles.Name = "cmbEstadosCiviles";
            this.cmbEstadosCiviles.PpCampoTabla = "codEstadoCivil";
            this.cmbEstadosCiviles.PpEsCmbValido = false;
            this.cmbEstadosCiviles.PpMensajeError = null;
            this.cmbEstadosCiviles.PpNombre = "descripcion";
            this.cmbEstadosCiviles.PpNombreTabla = "EstadosCiviles";
            this.cmbEstadosCiviles.PpPk = "codigo";
            this.cmbEstadosCiviles.PpSelectedIndex = 0;
            this.cmbEstadosCiviles.Size = new System.Drawing.Size(150, 28);
            this.cmbEstadosCiviles.TabIndex = 8;
            this.cmbEstadosCiviles.TextChanged += new System.EventHandler(this.cmbTipoDoc_TextChanged);
            // 
            // cmbSexos
            // 
            this.cmbSexos.BorderColor = System.Drawing.Color.Transparent;
            this.cmbSexos.Enabled = false;
            this.cmbSexos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbSexos.FormattingEnabled = true;
            this.cmbSexos.Location = new System.Drawing.Point(232, 410);
            this.cmbSexos.Name = "cmbSexos";
            this.cmbSexos.PpCampoTabla = "codSexo";
            this.cmbSexos.PpEsCmbValido = false;
            this.cmbSexos.PpMensajeError = null;
            this.cmbSexos.PpNombre = "descripcion";
            this.cmbSexos.PpNombreTabla = "Sexos";
            this.cmbSexos.PpPk = "codigo";
            this.cmbSexos.PpSelectedIndex = 0;
            this.cmbSexos.Size = new System.Drawing.Size(150, 28);
            this.cmbSexos.TabIndex = 7;
            this.cmbSexos.TextChanged += new System.EventHandler(this.cmbTipoDoc_TextChanged);
            // 
            // cmbLocalidades
            // 
            this.cmbLocalidades.BorderColor = System.Drawing.Color.Transparent;
            this.cmbLocalidades.Enabled = false;
            this.cmbLocalidades.FormattingEnabled = true;
            this.cmbLocalidades.Location = new System.Drawing.Point(232, 316);
            this.cmbLocalidades.Name = "cmbLocalidades";
            this.cmbLocalidades.PpCampoTabla = "codLocalidad";
            this.cmbLocalidades.PpEsCmbValido = false;
            this.cmbLocalidades.PpMensajeError = null;
            this.cmbLocalidades.PpNombre = "descripcion";
            this.cmbLocalidades.PpNombreTabla = "Localidades";
            this.cmbLocalidades.PpPk = "codPostal";
            this.cmbLocalidades.PpSelectedIndex = 0;
            this.cmbLocalidades.Size = new System.Drawing.Size(203, 28);
            this.cmbLocalidades.TabIndex = 5;
            this.cmbLocalidades.TextChanged += new System.EventHandler(this.cmbTipoDoc_TextChanged);
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProvincias.BorderColor = System.Drawing.Color.Transparent;
            this.cmbProvincias.Enabled = false;
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(232, 268);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.PpCampoTabla = "codProvincia";
            this.cmbProvincias.PpEsCmbValido = false;
            this.cmbProvincias.PpMensajeError = null;
            this.cmbProvincias.PpNombre = "descripcion";
            this.cmbProvincias.PpNombreTabla = "Provincias";
            this.cmbProvincias.PpPk = "codProvincia";
            this.cmbProvincias.PpSelectedIndex = 0;
            this.cmbProvincias.Size = new System.Drawing.Size(203, 28);
            this.cmbProvincias.TabIndex = 4;
            this.cmbProvincias.SelectedIndexChanged += new System.EventHandler(this.cmbProvincias_SelectedIndexChanged);
            this.cmbProvincias.TextChanged += new System.EventHandler(this.cmbTipoDoc_TextChanged);
            // 
            // cmbTipoDoc
            // 
            this.cmbTipoDoc.BorderColor = System.Drawing.Color.Transparent;
            this.cmbTipoDoc.Enabled = false;
            this.cmbTipoDoc.FormattingEnabled = true;
            this.cmbTipoDoc.Location = new System.Drawing.Point(232, 174);
            this.cmbTipoDoc.Name = "cmbTipoDoc";
            this.cmbTipoDoc.PpCampoTabla = "codTipoDoc";
            this.cmbTipoDoc.PpEsCmbValido = false;
            this.cmbTipoDoc.PpMensajeError = null;
            this.cmbTipoDoc.PpNombre = "descripcion";
            this.cmbTipoDoc.PpNombreTabla = "TipoDocumento";
            this.cmbTipoDoc.PpPk = "codigo";
            this.cmbTipoDoc.PpSelectedIndex = 0;
            this.cmbTipoDoc.Size = new System.Drawing.Size(121, 28);
            this.cmbTipoDoc.TabIndex = 2;
            this.cmbTipoDoc.TextChanged += new System.EventHandler(this.cmbTipoDoc_TextChanged);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.BorderColor = System.Drawing.Color.Transparent;
            this.txtFechaNacimiento.Enabled = false;
            this.txtFechaNacimiento.Location = new System.Drawing.Point(232, 506);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.PpAdmiteNull = true;
            this.txtFechaNacimiento.PpCampoSql = "fechaNacimiento";
            this.txtFechaNacimiento.PpEsDireccion = false;
            this.txtFechaNacimiento.PpEsDocumento = false;
            this.txtFechaNacimiento.PpEsFechaNacimiento = true;
            this.txtFechaNacimiento.PpEsNombreOapellido = false;
            this.txtFechaNacimiento.PpEsTextoValido = false;
            this.txtFechaNacimiento.PpMensajeError = "Formato fecha de nacimiento incorrecto!!";
            this.txtFechaNacimiento.PpNombreTabla = "Clientes";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(203, 26);
            this.txtFechaNacimiento.TabIndex = 9;
            this.txtFechaNacimiento.TextChanged += new System.EventHandler(this.txtGeneral_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderColor = System.Drawing.Color.Transparent;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(232, 364);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PpAdmiteNull = true;
            this.txtDireccion.PpCampoSql = "domicilio";
            this.txtDireccion.PpEsDireccion = true;
            this.txtDireccion.PpEsDocumento = false;
            this.txtDireccion.PpEsFechaNacimiento = false;
            this.txtDireccion.PpEsNombreOapellido = false;
            this.txtDireccion.PpEsTextoValido = false;
            this.txtDireccion.PpMensajeError = "Formato de dirección incorrecto!!";
            this.txtDireccion.PpNombreTabla = "Clientes";
            this.txtDireccion.Size = new System.Drawing.Size(203, 26);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtGeneral_TextChanged);
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.BorderColor = System.Drawing.Color.Transparent;
            this.txtNroDoc.Enabled = false;
            this.txtNroDoc.Location = new System.Drawing.Point(232, 222);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.PpAdmiteNull = false;
            this.txtNroDoc.PpCampoSql = "numeroDoc";
            this.txtNroDoc.PpEsDireccion = false;
            this.txtNroDoc.PpEsDocumento = true;
            this.txtNroDoc.PpEsFechaNacimiento = false;
            this.txtNroDoc.PpEsNombreOapellido = false;
            this.txtNroDoc.PpEsTextoValido = false;
            this.txtNroDoc.PpMensajeError = "Formato número de documento incorrecto!!";
            this.txtNroDoc.PpNombreTabla = "Clientes";
            this.txtNroDoc.Size = new System.Drawing.Size(203, 26);
            this.txtNroDoc.TabIndex = 3;
            this.txtNroDoc.TextChanged += new System.EventHandler(this.txtGeneral_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.BorderColor = System.Drawing.Color.Transparent;
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(232, 128);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PpAdmiteNull = false;
            this.txtApellido.PpCampoSql = "apellido";
            this.txtApellido.PpEsDireccion = false;
            this.txtApellido.PpEsDocumento = false;
            this.txtApellido.PpEsFechaNacimiento = false;
            this.txtApellido.PpEsNombreOapellido = true;
            this.txtApellido.PpEsTextoValido = false;
            this.txtApellido.PpMensajeError = "Formato de apellido incorrecto!!";
            this.txtApellido.PpNombreTabla = "Clientes";
            this.txtApellido.Size = new System.Drawing.Size(203, 26);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtGeneral_TextChanged);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.BorderColor = System.Drawing.Color.Transparent;
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(232, 82);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PpAdmiteNull = false;
            this.txtNombres.PpCampoSql = "nombres";
            this.txtNombres.PpEsDireccion = false;
            this.txtNombres.PpEsDocumento = false;
            this.txtNombres.PpEsFechaNacimiento = false;
            this.txtNombres.PpEsNombreOapellido = true;
            this.txtNombres.PpEsTextoValido = false;
            this.txtNombres.PpMensajeError = "Formato de nombre incorrecto!!";
            this.txtNombres.PpNombreTabla = "Clientes";
            this.txtNombres.Size = new System.Drawing.Size(203, 26);
            this.txtNombres.TabIndex = 0;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtGeneral_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 33);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmEliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 675);
            this.Controls.Add(this.cmbEstadosCiviles);
            this.Controls.Add(this.cmbSexos);
            this.Controls.Add(this.cmbLocalidades);
            this.Controls.Add(this.cmbProvincias);
            this.Controls.Add(this.cmbTipoDoc);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEliminarCliente";
            this.Text = "Eliminar Cliente";
            this.Load += new System.EventHandler(this.FrmAgregarClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEliminar;
        private Clases.TextBoxUsuario txtNombres;
        private Clases.TextBoxUsuario txtApellido;
        private Clases.TextBoxUsuario txtNroDoc;
        private Clases.TextBoxUsuario txtDireccion;
        private Clases.TextBoxUsuario txtFechaNacimiento;
        private Clases.ComboBox01 cmbTipoDoc;
        private Clases.ComboBox01 cmbProvincias;
        private Clases.ComboBox01 cmbLocalidades;
        private Clases.ComboBox01 cmbSexos;
        private Clases.ComboBox01 cmbEstadosCiviles;
        private System.Windows.Forms.Button btnCancelar;
    }
}