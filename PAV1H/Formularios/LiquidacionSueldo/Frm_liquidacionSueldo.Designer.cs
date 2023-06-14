namespace PAV1H.Formularios.LiquidacionSueldo
{
    partial class Frm_liquidacionSueldo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valorAsignaciones = new System.Windows.Forms.MaskedTextBox();
            this.cantidad = new System.Windows.Forms.Label();
            this.txt_cantidadAsigna = new System.Windows.Forms.MaskedTextBox();
            this.btn_agregarAsigna = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_valorDescuentos = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AgregarDescuentos = new System.Windows.Forms.Button();
            this.txt_id_usuario = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_n_usuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_cuil = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_perfil = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_sueldBruto = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_guardarFormulario = new System.Windows.Forms.Button();
            this.btn_buscarFormulario = new System.Windows.Forms.Button();
            this.btn_agregarFormulario = new System.Windows.Forms.Button();
            this.btn_fecha = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.txt_sueldoNeto = new System.Windows.Forms.MaskedTextBox();
            this.txt_cantidadDescuento = new System.Windows.Forms.MaskedTextBox();
            this.cmb_descuentos = new PAV1H.Clases.ComboBox01();
            this.cmb_asignaciones = new PAV1H.Clases.ComboBox01();
            this.grid_asignaciones = new PAV1H.Formularios.LiquidacionSueldo.Grid01();
            this.grid_descuentos = new PAV1H.Formularios.LiquidacionSueldo.Grid01();
            ((System.ComponentModel.ISupportInitialize)(this.grid_asignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_descuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liquidación de Sueldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor";
            // 
            // txt_valorAsignaciones
            // 
            this.txt_valorAsignaciones.Location = new System.Drawing.Point(593, 55);
            this.txt_valorAsignaciones.Mask = "999999,99";
            this.txt_valorAsignaciones.Name = "txt_valorAsignaciones";
            this.txt_valorAsignaciones.Size = new System.Drawing.Size(89, 26);
            this.txt_valorAsignaciones.TabIndex = 5;
            // 
            // cantidad
            // 
            this.cantidad.AutoSize = true;
            this.cantidad.Location = new System.Drawing.Point(725, 58);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(73, 20);
            this.cantidad.TabIndex = 6;
            this.cantidad.Text = "Cantidad";
            // 
            // txt_cantidadAsigna
            // 
            this.txt_cantidadAsigna.Location = new System.Drawing.Point(804, 55);
            this.txt_cantidadAsigna.Mask = "99";
            this.txt_cantidadAsigna.Name = "txt_cantidadAsigna";
            this.txt_cantidadAsigna.Size = new System.Drawing.Size(29, 26);
            this.txt_cantidadAsigna.TabIndex = 7;
            this.txt_cantidadAsigna.ValidatingType = typeof(int);
            // 
            // btn_agregarAsigna
            // 
            this.btn_agregarAsigna.Location = new System.Drawing.Point(854, 53);
            this.btn_agregarAsigna.Name = "btn_agregarAsigna";
            this.btn_agregarAsigna.Size = new System.Drawing.Size(88, 31);
            this.btn_agregarAsigna.TabIndex = 8;
            this.btn_agregarAsigna.Text = "Agregar";
            this.btn_agregarAsigna.UseVisualStyleBackColor = true;
            this.btn_agregarAsigna.Click += new System.EventHandler(this.btn_agregarAsigna_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Asignaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor";
            // 
            // txt_valorDescuentos
            // 
            this.txt_valorDescuentos.Location = new System.Drawing.Point(591, 355);
            this.txt_valorDescuentos.Mask = "999999,99";
            this.txt_valorDescuentos.Name = "txt_valorDescuentos";
            this.txt_valorDescuentos.Size = new System.Drawing.Size(91, 26);
            this.txt_valorDescuentos.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(723, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cantidad";
            // 
            // btn_AgregarDescuentos
            // 
            this.btn_AgregarDescuentos.Location = new System.Drawing.Point(854, 353);
            this.btn_AgregarDescuentos.Name = "btn_AgregarDescuentos";
            this.btn_AgregarDescuentos.Size = new System.Drawing.Size(88, 31);
            this.btn_AgregarDescuentos.TabIndex = 8;
            this.btn_AgregarDescuentos.Text = "Agregar";
            this.btn_AgregarDescuentos.UseVisualStyleBackColor = true;
            this.btn_AgregarDescuentos.Click += new System.EventHandler(this.btn_AgregarDescuentos_Click);
            // 
            // txt_id_usuario
            // 
            this.txt_id_usuario.Location = new System.Drawing.Point(248, 100);
            this.txt_id_usuario.Mask = "999";
            this.txt_id_usuario.Name = "txt_id_usuario";
            this.txt_id_usuario.Size = new System.Drawing.Size(33, 26);
            this.txt_id_usuario.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID Usuario";
            // 
            // txt_n_usuario
            // 
            this.txt_n_usuario.Location = new System.Drawing.Point(248, 148);
            this.txt_n_usuario.Name = "txt_n_usuario";
            this.txt_n_usuario.Size = new System.Drawing.Size(188, 26);
            this.txt_n_usuario.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nombre de Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Apellido";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(248, 196);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(188, 26);
            this.txt_nombres.TabIndex = 16;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(248, 247);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(188, 26);
            this.txt_apellido.TabIndex = 17;
            // 
            // txt_cuil
            // 
            this.txt_cuil.Enabled = false;
            this.txt_cuil.Location = new System.Drawing.Point(248, 295);
            this.txt_cuil.Mask = "99-99999999-9";
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Size = new System.Drawing.Size(123, 26);
            this.txt_cuil.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Cuil";
            // 
            // txt_perfil
            // 
            this.txt_perfil.Enabled = false;
            this.txt_perfil.Location = new System.Drawing.Point(248, 340);
            this.txt_perfil.Name = "txt_perfil";
            this.txt_perfil.Size = new System.Drawing.Size(188, 26);
            this.txt_perfil.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Perfil";
            // 
            // txt_sueldBruto
            // 
            this.txt_sueldBruto.Enabled = false;
            this.txt_sueldBruto.Location = new System.Drawing.Point(248, 388);
            this.txt_sueldBruto.Mask = "9999,99";
            this.txt_sueldBruto.Name = "txt_sueldBruto";
            this.txt_sueldBruto.Size = new System.Drawing.Size(69, 26);
            this.txt_sueldBruto.TabIndex = 22;
            this.txt_sueldBruto.Text = "1000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Sueldo Bruto";
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(248, 436);
            this.txt_fecha.Mask = "00/00/0000";
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(87, 26);
            this.txt_fecha.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(88, 442);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Fecha Liquidación";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(488, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "Descuentos";
            // 
            // btn_guardarFormulario
            // 
            this.btn_guardarFormulario.BackgroundImage = global::PAV1H.Properties.Resources.guardar2;
            this.btn_guardarFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardarFormulario.Location = new System.Drawing.Point(303, 545);
            this.btn_guardarFormulario.Name = "btn_guardarFormulario";
            this.btn_guardarFormulario.Size = new System.Drawing.Size(49, 39);
            this.btn_guardarFormulario.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btn_guardarFormulario, "Guardar Formulario");
            this.btn_guardarFormulario.UseVisualStyleBackColor = true;
            // 
            // btn_buscarFormulario
            // 
            this.btn_buscarFormulario.BackgroundImage = global::PAV1H.Properties.Resources.buscar;
            this.btn_buscarFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarFormulario.Location = new System.Drawing.Point(358, 545);
            this.btn_buscarFormulario.Name = "btn_buscarFormulario";
            this.btn_buscarFormulario.Size = new System.Drawing.Size(49, 39);
            this.btn_buscarFormulario.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btn_buscarFormulario, "Buscar Empleado");
            this.btn_buscarFormulario.UseVisualStyleBackColor = true;
            this.btn_buscarFormulario.Click += new System.EventHandler(this.btn_buscarFormulario_Click);
            // 
            // btn_agregarFormulario
            // 
            this.btn_agregarFormulario.BackgroundImage = global::PAV1H.Properties.Resources.agregar;
            this.btn_agregarFormulario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregarFormulario.Location = new System.Drawing.Point(248, 545);
            this.btn_agregarFormulario.Name = "btn_agregarFormulario";
            this.btn_agregarFormulario.Size = new System.Drawing.Size(49, 39);
            this.btn_agregarFormulario.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btn_agregarFormulario, "Agregar nuevo formulario");
            this.btn_agregarFormulario.UseVisualStyleBackColor = true;
            // 
            // btn_fecha
            // 
            this.btn_fecha.BackgroundImage = global::PAV1H.Properties.Resources.tresPuntos;
            this.btn_fecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fecha.Location = new System.Drawing.Point(341, 436);
            this.btn_fecha.Name = "btn_fecha";
            this.btn_fecha.Size = new System.Drawing.Size(76, 26);
            this.btn_fecha.TabIndex = 25;
            this.btn_fecha.UseVisualStyleBackColor = true;
            this.btn_fecha.Click += new System.EventHandler(this.btn_fecha_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(88, 493);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Sueldo Neto";
            // 
            // txt_sueldoNeto
            // 
            this.txt_sueldoNeto.Enabled = false;
            this.txt_sueldoNeto.Location = new System.Drawing.Point(248, 487);
            this.txt_sueldoNeto.Mask = "9999,99";
            this.txt_sueldoNeto.Name = "txt_sueldoNeto";
            this.txt_sueldoNeto.Size = new System.Drawing.Size(69, 26);
            this.txt_sueldoNeto.TabIndex = 30;
            // 
            // txt_cantidadDescuento
            // 
            this.txt_cantidadDescuento.Location = new System.Drawing.Point(802, 353);
            this.txt_cantidadDescuento.Mask = "99";
            this.txt_cantidadDescuento.Name = "txt_cantidadDescuento";
            this.txt_cantidadDescuento.Size = new System.Drawing.Size(31, 26);
            this.txt_cantidadDescuento.TabIndex = 31;
            this.txt_cantidadDescuento.ValidatingType = typeof(int);
            // 
            // cmb_descuentos
            // 
            this.cmb_descuentos.FormattingEnabled = true;
            this.cmb_descuentos.Location = new System.Drawing.Point(591, 307);
            this.cmb_descuentos.Name = "cmb_descuentos";
            this.cmb_descuentos.Pp_campo = null;
            this.cmb_descuentos.Pp_mensajeError = null;
            this.cmb_descuentos.Pp_nombre = null;
            this.cmb_descuentos.Pp_Pk = null;
            this.cmb_descuentos.Pp_tabla = null;
            this.cmb_descuentos.Pp_validable = false;
            this.cmb_descuentos.Size = new System.Drawing.Size(351, 28);
            this.cmb_descuentos.TabIndex = 3;
            this.cmb_descuentos.SelectionChangeCommitted += new System.EventHandler(this.cmb_descuentos_SelectionChangeCommitted);
            // 
            // cmb_asignaciones
            // 
            this.cmb_asignaciones.FormattingEnabled = true;
            this.cmb_asignaciones.Location = new System.Drawing.Point(591, 18);
            this.cmb_asignaciones.Name = "cmb_asignaciones";
            this.cmb_asignaciones.Pp_campo = null;
            this.cmb_asignaciones.Pp_mensajeError = null;
            this.cmb_asignaciones.Pp_nombre = null;
            this.cmb_asignaciones.Pp_Pk = null;
            this.cmb_asignaciones.Pp_tabla = null;
            this.cmb_asignaciones.Pp_validable = false;
            this.cmb_asignaciones.Size = new System.Drawing.Size(351, 28);
            this.cmb_asignaciones.TabIndex = 2;
            this.cmb_asignaciones.SelectionChangeCommitted += new System.EventHandler(this.cmb_asignaciones_SelectionChangeCommitted);
            // 
            // grid_asignaciones
            // 
            this.grid_asignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_asignaciones.Location = new System.Drawing.Point(459, 106);
            this.grid_asignaciones.Name = "grid_asignaciones";
            this.grid_asignaciones.Size = new System.Drawing.Size(483, 185);
            this.grid_asignaciones.TabIndex = 1;
            // 
            // grid_descuentos
            // 
            this.grid_descuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_descuentos.Location = new System.Drawing.Point(459, 399);
            this.grid_descuentos.Name = "grid_descuentos";
            this.grid_descuentos.Size = new System.Drawing.Size(483, 185);
            this.grid_descuentos.TabIndex = 1;
            // 
            // Frm_liquidacionSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 620);
            this.Controls.Add(this.txt_cantidadDescuento);
            this.Controls.Add(this.txt_sueldoNeto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_guardarFormulario);
            this.Controls.Add(this.btn_buscarFormulario);
            this.Controls.Add(this.btn_agregarFormulario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_fecha);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_sueldBruto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_perfil);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_cuil);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombres);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_n_usuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_id_usuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_AgregarDescuentos);
            this.Controls.Add(this.btn_agregarAsigna);
            this.Controls.Add(this.txt_cantidadAsigna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.txt_valorDescuentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_valorAsignaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_descuentos);
            this.Controls.Add(this.cmb_asignaciones);
            this.Controls.Add(this.grid_asignaciones);
            this.Controls.Add(this.grid_descuentos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_liquidacionSueldo";
            this.Text = "Frm_liquidacionSueldo";
            this.Load += new System.EventHandler(this.Frm_liquidacionSueldo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_asignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_descuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Grid01 grid_descuentos;
        private Clases.ComboBox01 cmb_asignaciones;
        private Clases.ComboBox01 cmb_descuentos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_valorAsignaciones;
        private System.Windows.Forms.Label cantidad;
        private System.Windows.Forms.MaskedTextBox txt_cantidadAsigna;
        private System.Windows.Forms.Button btn_agregarAsigna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txt_valorDescuentos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AgregarDescuentos;
        private System.Windows.Forms.MaskedTextBox txt_id_usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_n_usuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.MaskedTextBox txt_cuil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_perfil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_sueldBruto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txt_fecha;
        private System.Windows.Forms.Button btn_fecha;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_agregarFormulario;
        private System.Windows.Forms.Button btn_buscarFormulario;
        private System.Windows.Forms.Button btn_guardarFormulario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txt_sueldoNeto;
        private System.Windows.Forms.MaskedTextBox txt_cantidadDescuento;
        private Grid01 grid_asignaciones;
    }
}