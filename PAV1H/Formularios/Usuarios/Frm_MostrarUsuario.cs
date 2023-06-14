using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1H.Clases;
using PAV1H.Negocios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAV1H.Formularios.Usuarios
{
    public partial class Frm_MostrarUsuario : Form
    {

        public string Id_usuario;
        

        public Frm_MostrarUsuario()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

    

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

          this.Close();
            

        }

        private void Frm_MostrarUsuario_Load(object sender, EventArgs e)
        {

            NE_usuarios usuario = new NE_usuarios();

            DataTable dt = new DataTable();

            dt = usuario.RecuperarXidUsuario(Id_usuario);

            MostrarDatos(dt);

            


        }

        private void MostrarDatos(DataTable Tabla)
        {
            cmb_perfiles.Text = Tabla.Rows[0]["perfil"].ToString();
            txt_usuario.Text = Tabla.Rows[0]["n_usuario"].ToString();
            txt_contrasenia.Text = Tabla.Rows[0]["contrasenia"].ToString();
            txt_apellido.Text = Tabla.Rows[0]["apellido"].ToString();
            txt_email.Text = Tabla.Rows[0]["email"].ToString();
            txt_nombre.Text = Tabla.Rows[0]["nombres"].ToString();
            txt_cuil.Text = Tabla.Rows[0]["cuil"].ToString();
            cmb_estados.Text = Tabla.Rows[0]["estado"].ToString();



        }




    }
}
