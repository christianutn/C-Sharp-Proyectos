using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1H.Clases;
using PAV1H.Negocios;

namespace PAV1H.Formularios.Usuarios
{
    public partial class Frm_AltasUsuarios : Form
    {
        

        public Frm_AltasUsuarios()
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
            cmb_perfiles.SelectedIndex = -1;
            cmb_estados.CargarCombo();
            cmb_estados.SelectedIndex = -1;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Tratamientos_especiales tratamiento = new Tratamientos_especiales();

            if (tratamiento.Validar(this.Controls) == Tratamientos_especiales.Resultado.correcto)
            {
               NE_usuarios _usuarios = new NE_usuarios();

               //_usuarios.Pp_n_usuario = txt_nombre.Text;
               // _usuarios.Pp_contrasenia = txt_contrasenia.Text;
               // _usuarios.Pp_email = txt_email.Text;
               // _usuarios.Pp_perfil = cmb_perfiles.SelectedValue.ToString();
               // _usuarios.Pp_nombre = txt_nombre.Text;
               // _usuarios.Pp_apellido = txt_apellido.Text;
               // _usuarios.Pp_cuil = txt_cuil.Text;
               // _usuarios.Pp_estado = cmb_estados.SelectedValue.ToString();

                _usuarios.Insertar(this.Controls);
                
                this.Close();

            }
        }
    }
}
