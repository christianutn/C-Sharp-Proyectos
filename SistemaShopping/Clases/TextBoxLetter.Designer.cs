namespace SistemaShopping.Clases
{
    partial class TextBoxLetter
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsuario1 = new SistemaShopping.Clases.TextBoxUsuario();
            this.SuspendLayout();
            // 
            // textBoxUsuario1
            // 
            this.textBoxUsuario1.BorderColor = System.Drawing.Color.Blue;
            this.textBoxUsuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUsuario1.Enabled = false;
            this.textBoxUsuario1.Location = new System.Drawing.Point(5, 5);
            this.textBoxUsuario1.Name = "textBoxUsuario1";
            this.textBoxUsuario1.PpEsDireccion = false;
            this.textBoxUsuario1.PpEsDocumento = false;
            this.textBoxUsuario1.PpEsFechaNacimiento = false;
            this.textBoxUsuario1.PpEsNombreOapellido = false;
            this.textBoxUsuario1.PpMensajeError = null;
            this.textBoxUsuario1.Size = new System.Drawing.Size(196, 26);
            this.textBoxUsuario1.TabIndex = 0;
            // 
            // TextBoxLetter
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBoxUsuario1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TextBoxLetter";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(206, 38);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBoxUsuario textBoxUsuario1;
    }
}
