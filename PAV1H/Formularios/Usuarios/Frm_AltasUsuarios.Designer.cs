namespace PAV1H.Formularios.Usuarios
{
    partial class Frm_AltasUsuarios
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
            this.Usuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_nombre = new PAV1H.Clases.TextBox01();
            this.txt_cuil = new PAV1H.Clases.TextBox01();
            this.txt_contrasenia = new PAV1H.Clases.TextBox01();
            this.txt_apellido = new PAV1H.Clases.TextBox01();
            this.txt_email = new PAV1H.Clases.TextBox01();
            this.txt_usuario = new PAV1H.Clases.TextBox01();
            this.cmb_estados = new PAV1H.Clases.ComboBox01();
            this.cmb_perfiles = new PAV1H.Clases.ComboBox01();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Alta de usuarios";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(90, 96);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(64, 20);
            this.Usuario.TabIndex = 9;
            this.Usuario.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Perfil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cuil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Estado";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(160, 439);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(69, 32);
            this.btn_aceptar.TabIndex = 8;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(247, 439);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(69, 32);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(160, 243);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_campo = "nombres";
            this.txt_nombre.Pp_mensajeError = "Falta cargar el nombre";
            this.txt_nombre.Pp_tabla = null;
            this.txt_nombre.Pp_validable = true;
            this.txt_nombre.Size = new System.Drawing.Size(244, 26);
            this.txt_nombre.TabIndex = 4;
            // 
            // txt_cuil
            // 
            this.txt_cuil.Location = new System.Drawing.Point(160, 317);
            this.txt_cuil.Name = "txt_cuil";
            this.txt_cuil.Pp_campo = "cuil";
            this.txt_cuil.Pp_mensajeError = "Falta cargar el cuil";
            this.txt_cuil.Pp_tabla = null;
            this.txt_cuil.Pp_validable = true;
            this.txt_cuil.Size = new System.Drawing.Size(156, 26);
            this.txt_cuil.TabIndex = 6;
            // 
            // txt_contrasenia
            // 
            this.txt_contrasenia.Location = new System.Drawing.Point(160, 130);
            this.txt_contrasenia.Name = "txt_contrasenia";
            this.txt_contrasenia.Pp_campo = "contrasenia";
            this.txt_contrasenia.Pp_mensajeError = "Falta cargar la contraseña";
            this.txt_contrasenia.Pp_tabla = null;
            this.txt_contrasenia.Pp_validable = true;
            this.txt_contrasenia.Size = new System.Drawing.Size(156, 26);
            this.txt_contrasenia.TabIndex = 1;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(160, 280);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_campo = "apellido";
            this.txt_apellido.Pp_mensajeError = "Falta cargar el apellido";
            this.txt_apellido.Pp_tabla = null;
            this.txt_apellido.Pp_validable = true;
            this.txt_apellido.Size = new System.Drawing.Size(244, 26);
            this.txt_apellido.TabIndex = 5;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(160, 167);
            this.txt_email.Name = "txt_email";
            this.txt_email.Pp_campo = "email";
            this.txt_email.Pp_mensajeError = "Falta cargar mail";
            this.txt_email.Pp_tabla = null;
            this.txt_email.Pp_validable = true;
            this.txt_email.Size = new System.Drawing.Size(244, 26);
            this.txt_email.TabIndex = 2;
            // 
            // txt_usuario
            // 
            this.txt_usuario.Location = new System.Drawing.Point(160, 93);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Pp_campo = "n_usuario";
            this.txt_usuario.Pp_mensajeError = "Falta cargar el usuario";
            this.txt_usuario.Pp_tabla = null;
            this.txt_usuario.Pp_validable = true;
            this.txt_usuario.Size = new System.Drawing.Size(156, 26);
            this.txt_usuario.TabIndex = 0;
            // 
            // cmb_estados
            // 
            this.cmb_estados.FormattingEnabled = true;
            this.cmb_estados.Location = new System.Drawing.Point(160, 354);
            this.cmb_estados.Name = "cmb_estados";
            this.cmb_estados.Pp_campo = "id_estado";
            this.cmb_estados.Pp_mensajeError = "Se debe seleccionar un estado!!";
            this.cmb_estados.Pp_nombre = "nombre";
            this.cmb_estados.Pp_Pk = "id_estado";
            this.cmb_estados.Pp_tabla = "Estado";
            this.cmb_estados.Pp_validable = true;
            this.cmb_estados.Size = new System.Drawing.Size(113, 28);
            this.cmb_estados.TabIndex = 7;
            // 
            // cmb_perfiles
            // 
            this.cmb_perfiles.FormattingEnabled = true;
            this.cmb_perfiles.Location = new System.Drawing.Point(160, 204);
            this.cmb_perfiles.Name = "cmb_perfiles";
            this.cmb_perfiles.Pp_campo = "id_perfil";
            this.cmb_perfiles.Pp_mensajeError = "Se debe seleccionar un perfil !!";
            this.cmb_perfiles.Pp_nombre = "nombre";
            this.cmb_perfiles.Pp_Pk = "id_Perfil";
            this.cmb_perfiles.Pp_tabla = "Perfiles";
            this.cmb_perfiles.Pp_validable = true;
            this.cmb_perfiles.Size = new System.Drawing.Size(244, 28);
            this.cmb_perfiles.TabIndex = 3;
            // 
            // Frm_AltasUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 518);
            this.ControlBox = false;
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_cuil);
            this.Controls.Add(this.txt_contrasenia);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.cmb_estados);
            this.Controls.Add(this.cmb_perfiles);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AltasUsuarios";
            this.Text = "Alta de Usuarios";
            this.Load += new System.EventHandler(this.Frm_AltasUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private Clases.ComboBox01 cmb_perfiles;
        private Clases.ComboBox01 cmb_estados;
        private Clases.TextBox01 txt_usuario;
        private Clases.TextBox01 txt_email;
        private Clases.TextBox01 txt_apellido;
        private Clases.TextBox01 txt_contrasenia;
        private Clases.TextBox01 txt_nombre;
        private Clases.TextBox01 txt_cuil;
    }
}