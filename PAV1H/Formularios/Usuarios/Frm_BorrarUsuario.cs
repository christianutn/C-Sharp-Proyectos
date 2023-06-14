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
    public partial class Frm_BorrarUsuario : Form
    {

        public string Id_usuario;
        

        public Frm_BorrarUsuario()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

    

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            NE_usuarios usuario = new NE_usuarios();
            usuario.Pp_id_usuario = Id_usuario;

            if (MessageBox.Show("¿Está seguro de borrar el usuario?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                usuario.Borrar();
            }
            

        }

        private void Frm_BorrarUsuario_Load(object sender, EventArgs e)
        {
            DataTable Tabla = new DataTable();

            NE_usuarios usuario = new NE_usuarios();

            Tabla = usuario.RecuperarXidUsuario(Id_usuario);


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
