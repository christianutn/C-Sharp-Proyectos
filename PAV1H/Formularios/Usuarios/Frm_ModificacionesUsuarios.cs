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

namespace PAV1H.Formularios.Usuarios
{
    public partial class Frm_ModificacionesUsuarios : Form
    {

        public string Id_usuario;
        

        public Frm_ModificacionesUsuarios()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_AltasUsuarios_Load(object sender, EventArgs e)
        {
            cmb_perfiles.CargarCombo();
            
            cmb_estados.CargarCombo();
           


            NE_usuarios usuarios = new NE_usuarios();

            MostrarDatos(usuarios.RecuperarXidUsuario(Id_usuario));

        }

        private void MostrarDatos(DataTable Tabla)
        {
            MessageBox.Show(Tabla.Rows.Count.ToString());
            cmb_perfiles.SelectedValue = int.Parse(Tabla.Rows[0]["id_perfil"].ToString());
            txt_usuario.Text = Tabla.Rows[0]["n_usuario"].ToString();
            txt_contrasenia.Text = Tabla.Rows[0]["contrasenia"].ToString();
            txt_apellido.Text = Tabla.Rows[0]["apellido"].ToString();
            txt_email.Text = Tabla.Rows[0]["email"].ToString();
            txt_nombre.Text = Tabla.Rows[0]["nombres"].ToString();
            txt_cuil.Text = Tabla.Rows[0]["cuil"].ToString();
            cmb_estados.Text = Tabla.Rows[0]["id_estado"].ToString();



        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            Tratamientos_especiales tratamiento = new Tratamientos_especiales();

            if(tratamiento.Validar(this.Controls) == Tratamientos_especiales.Resultado.correcto)
            {
                NE_usuarios usuario = new NE_usuarios();

                usuario.Pp_n_usuario = txt_nombre.Text;
                usuario.Pp_contrasenia = txt_contrasenia.Text;
                usuario.Pp_email = txt_email.Text;
                usuario.Pp_perfil = cmb_perfiles.SelectedValue.ToString();
                usuario.Pp_nombre = txt_nombre.Text;
                usuario.Pp_apellido = txt_apellido.Text;
                usuario.Pp_cuil = txt_cuil.Text;
                usuario.Pp_estado = cmb_estados.SelectedValue.ToString();
                usuario.Pp_id_usuario = Id_usuario;

                usuario.Modificar();


            }
            else
            {

            }

            this.Close();
            

        }


    }
}
