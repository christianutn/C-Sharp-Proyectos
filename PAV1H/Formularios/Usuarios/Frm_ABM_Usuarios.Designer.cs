namespace PAV1H.Formularios.Usuarios
{
    partial class Frm_ABM_Usuarios
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
            this.Filtros = new System.Windows.Forms.GroupBox();
            this.grid_usuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.cmb_perfiles = new PAV1H.Clases.ComboBox01();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_patron = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_alta = new System.Windows.Forms.Button();
            this.Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtros
            // 
            this.Filtros.Controls.Add(this.grid_usuarios);
            this.Filtros.Controls.Add(this.button1);
            this.Filtros.Controls.Add(this.btn_consulta);
            this.Filtros.Controls.Add(this.chk_todos);
            this.Filtros.Controls.Add(this.cmb_perfiles);
            this.Filtros.Controls.Add(this.label2);
            this.Filtros.Controls.Add(this.label1);
            this.Filtros.Controls.Add(this.txt_patron);
            this.Filtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtros.Location = new System.Drawing.Point(37, 33);
            this.Filtros.Margin = new System.Windows.Forms.Padding(4);
            this.Filtros.Name = "Filtros";
            this.Filtros.Padding = new System.Windows.Forms.Padding(4);
            this.Filtros.Size = new System.Drawing.Size(659, 463);
            this.Filtros.TabIndex = 0;
            this.Filtros.TabStop = false;
            this.Filtros.Text = "Filtros";
            this.toolTip1.SetToolTip(this.Filtros, "Restablece la selección de perfiles");
            // 
            // grid_usuarios
            // 
            this.grid_usuarios.AllowUserToAddRows = false;
            this.grid_usuarios.AllowUserToDeleteRows = false;
            this.grid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.id_usuario});
            this.grid_usuarios.Location = new System.Drawing.Point(7, 201);
            this.grid_usuarios.Name = "grid_usuarios";
            this.grid_usuarios.ReadOnly = true;
            this.grid_usuarios.Size = new System.Drawing.Size(645, 255);
            this.grid_usuarios.TabIndex = 5;
            this.grid_usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_usuarios_CellClick);
            this.grid_usuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_usuarios_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de Usuario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Email";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 190;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Perfil";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 190;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "id_usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.BackgroundImage = global::PAV1H.Properties.Resources.tresPuntos;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(468, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 25);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_consulta
            // 
            this.btn_consulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consulta.Location = new System.Drawing.Point(507, 141);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(83, 31);
            this.btn_consulta.TabIndex = 4;
            this.btn_consulta.Text = "Consulta";
            this.toolTip1.SetToolTip(this.btn_consulta, "Dispara la consulta para recuperar los datos");
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.btn_consulta_Click);
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_todos.Location = new System.Drawing.Point(234, 145);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(72, 24);
            this.chk_todos.TabIndex = 3;
            this.chk_todos.Text = "Todos";
            this.toolTip1.SetToolTip(this.chk_todos, "Busca todos los registros de la tabla");
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // cmb_perfiles
            // 
            this.cmb_perfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_perfiles.FormattingEnabled = true;
            this.cmb_perfiles.Location = new System.Drawing.Point(234, 91);
            this.cmb_perfiles.Name = "cmb_perfiles";
            this.cmb_perfiles.Pp_campo = null;
            this.cmb_perfiles.Pp_mensajeError = null;
            this.cmb_perfiles.Pp_nombre = "nombre";
            this.cmb_perfiles.Pp_Pk = "id_perfil";
            this.cmb_perfiles.Pp_tabla = "Perfiles";
            this.cmb_perfiles.Pp_validable = false;
            this.cmb_perfiles.Size = new System.Drawing.Size(228, 28);
            this.cmb_perfiles.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Perfiles";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patrones";
            // 
            // txt_patron
            // 
            this.txt_patron.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patron.Location = new System.Drawing.Point(234, 41);
            this.txt_patron.Name = "txt_patron";
            this.txt_patron.Size = new System.Drawing.Size(228, 26);
            this.txt_patron.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_patron, "Ingrese texto completo o porción de este.");
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 20;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_eliminar.BackgroundImage = global::PAV1H.Properties.Resources.eliminaru;
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Location = new System.Drawing.Point(187, 503);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(66, 65);
            this.btn_eliminar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_eliminar, "Eliminar usuario");
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.SystemColors.Window;
            this.btn_modificar.BackgroundImage = global::PAV1H.Properties.Resources.mod;
            this.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_modificar.Location = new System.Drawing.Point(112, 503);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(69, 65);
            this.btn_modificar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_modificar, "Modificar usuario");
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_alta
            // 
            this.btn_alta.BackColor = System.Drawing.SystemColors.Window;
            this.btn_alta.BackgroundImage = global::PAV1H.Properties.Resources._227_2271024_transparent_usuario_png_icono_agregar_usuarios_png_png;
            this.btn_alta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alta.Location = new System.Drawing.Point(37, 503);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(69, 65);
            this.btn_alta.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_alta, "Dar alta a usuario");
            this.btn_alta.UseVisualStyleBackColor = false;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // Frm_ABM_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 589);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.Filtros);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ABM_Usuarios";
            this.Text = "Frm_ABM_Usuarios";
            this.Load += new System.EventHandler(this.Frm_ABM_Usuarios_Load);
            this.Filtros.ResumeLayout(false);
            this.Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Filtros;
        private System.Windows.Forms.TextBox txt_patron;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clases.ComboBox01 cmb_perfiles;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid_usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
    }
}