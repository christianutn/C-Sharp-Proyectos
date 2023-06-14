namespace PAV1H.ZonaPrueba
{
    partial class Frm_PruebaTransaccion
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
            this.Grid01 = new System.Windows.Forms.DataGridView();
            this.btn_inicioTransaccio = new System.Windows.Forms.Button();
            this.txt_nombreEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.btn_generarError = new System.Windows.Forms.Button();
            this.btn_finalizarTransaccion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_modificarEstado = new System.Windows.Forms.Button();
            this.txt_ModificarEstado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_borrar = new System.Windows.Forms.TextBox();
            this.btn_borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid01)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid01
            // 
            this.Grid01.AllowUserToAddRows = false;
            this.Grid01.AllowUserToDeleteRows = false;
            this.Grid01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid01.Location = new System.Drawing.Point(3, 333);
            this.Grid01.Name = "Grid01";
            this.Grid01.ReadOnly = true;
            this.Grid01.Size = new System.Drawing.Size(926, 218);
            this.Grid01.TabIndex = 0;
            this.Grid01.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid01_CellDoubleClick);
            // 
            // btn_inicioTransaccio
            // 
            this.btn_inicioTransaccio.Location = new System.Drawing.Point(83, 112);
            this.btn_inicioTransaccio.Name = "btn_inicioTransaccio";
            this.btn_inicioTransaccio.Size = new System.Drawing.Size(171, 83);
            this.btn_inicioTransaccio.TabIndex = 1;
            this.btn_inicioTransaccio.Text = "inicio transaccion";
            this.btn_inicioTransaccio.UseVisualStyleBackColor = true;
            this.btn_inicioTransaccio.Click += new System.EventHandler(this.btn_inicioTransaccio_Click);
            // 
            // txt_nombreEstado
            // 
            this.txt_nombreEstado.Location = new System.Drawing.Point(205, 66);
            this.txt_nombreEstado.Name = "txt_nombreEstado";
            this.txt_nombreEstado.Size = new System.Drawing.Size(182, 26);
            this.txt_nombreEstado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Estado";
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(301, 112);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(158, 83);
            this.btn_insertar.TabIndex = 4;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            // 
            // btn_generarError
            // 
            this.btn_generarError.Location = new System.Drawing.Point(465, 112);
            this.btn_generarError.Name = "btn_generarError";
            this.btn_generarError.Size = new System.Drawing.Size(170, 83);
            this.btn_generarError.TabIndex = 5;
            this.btn_generarError.Text = "Generar Error";
            this.btn_generarError.UseVisualStyleBackColor = true;
            this.btn_generarError.Click += new System.EventHandler(this.btn_generarError_Click);
            // 
            // btn_finalizarTransaccion
            // 
            this.btn_finalizarTransaccion.Location = new System.Drawing.Point(652, 112);
            this.btn_finalizarTransaccion.Name = "btn_finalizarTransaccion";
            this.btn_finalizarTransaccion.Size = new System.Drawing.Size(180, 80);
            this.btn_finalizarTransaccion.TabIndex = 6;
            this.btn_finalizarTransaccion.Text = "Finalizar transaccion";
            this.btn_finalizarTransaccion.UseVisualStyleBackColor = true;
            this.btn_finalizarTransaccion.Click += new System.EventHandler(this.btn_finalizarTransaccion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modificar EStado";
            // 
            // btn_modificarEstado
            // 
            this.btn_modificarEstado.Location = new System.Drawing.Point(465, 223);
            this.btn_modificarEstado.Name = "btn_modificarEstado";
            this.btn_modificarEstado.Size = new System.Drawing.Size(138, 37);
            this.btn_modificarEstado.TabIndex = 7;
            this.btn_modificarEstado.Text = "Modificar Estado";
            this.btn_modificarEstado.UseVisualStyleBackColor = true;
            this.btn_modificarEstado.Click += new System.EventHandler(this.btn_modificarEstado_Click);
            // 
            // txt_ModificarEstado
            // 
            this.txt_ModificarEstado.Location = new System.Drawing.Point(205, 234);
            this.txt_ModificarEstado.Name = "txt_ModificarEstado";
            this.txt_ModificarEstado.Size = new System.Drawing.Size(182, 26);
            this.txt_ModificarEstado.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Modificar EStado";
            // 
            // txt_borrar
            // 
            this.txt_borrar.Location = new System.Drawing.Point(205, 284);
            this.txt_borrar.Name = "txt_borrar";
            this.txt_borrar.Size = new System.Drawing.Size(182, 26);
            this.txt_borrar.TabIndex = 8;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(435, 278);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(179, 39);
            this.btn_borrar.TabIndex = 9;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // Frm_PruebaTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 563);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.txt_borrar);
            this.Controls.Add(this.txt_ModificarEstado);
            this.Controls.Add(this.btn_modificarEstado);
            this.Controls.Add(this.btn_finalizarTransaccion);
            this.Controls.Add(this.btn_generarError);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombreEstado);
            this.Controls.Add(this.btn_inicioTransaccio);
            this.Controls.Add(this.Grid01);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_PruebaTransaccion";
            this.Text = "Frm_PruebaTransaccion";
            this.Load += new System.EventHandler(this.Frm_PruebaTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid01;
        private System.Windows.Forms.Button btn_inicioTransaccio;
        private System.Windows.Forms.TextBox txt_nombreEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.Button btn_generarError;
        private System.Windows.Forms.Button btn_finalizarTransaccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_modificarEstado;
        private System.Windows.Forms.TextBox txt_ModificarEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_borrar;
        private System.Windows.Forms.Button btn_borrar;
    }
}