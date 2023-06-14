using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using PAV1H.Negocios;

namespace PAV1H
{
    public partial class Frm_Login : Form
    {


        public string Pp_usuario
        {
            get { return txt_usuario.Text; }
            set { txt_usuario.Text = value; }
        }

        public string Pp_contrasenia
        {
            get { return txt_contrasenia.Text; }
            set { txt_contrasenia.Text = value; }
        }
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                MessageBox.Show("No es posible ingresar un usuario vacío!!!");
                txt_usuario.Focus();
                return;

            }
            if (txt_contrasenia.Text == "")
            {
                MessageBox.Show("Contraseña vacía!!!");
                txt_contrasenia.Focus();
                return;
            }   

            NE_usuarios usuario = new NE_usuarios();

            if (usuario.ValidarUsuario(txt_usuario.Text, txt_contrasenia.Text) == NE_usuarios.ResultadoValidacion.existe)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto/s!!");
                txt_usuario.Clear();
                txt_contrasenia.Clear();
                txt_usuario.Focus();
            }


        }
    }
}
