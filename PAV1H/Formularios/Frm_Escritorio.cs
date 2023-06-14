using PAV1H.Formularios.Usuarios;
using PAV1H.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1H
{
    public partial class Frm_Escritorio : Form
    {

        // Declaramos 

        // Guardo el el PK es decir ID de usuario para reutilizarlo

        int id_usuario = 0;

        public Frm_Escritorio() // COnstructor de la clase
        {
            InitializeComponent();
        }

        private void Frm_Escritorio_Load(object sender, EventArgs e) // Load: es el primero que se dispara al entrar en funcionamiento el formulario
        {
            Frm_Login login = new Frm_Login(); // Instancio al objeto
            login.ShowDialog(); // Despliego 
            
            NE_usuarios usuario = new NE_usuarios();

            id_usuario = usuario.RecuperarIdUsuario(login.Pp_usuario, login.Pp_contrasenia);

            MessageBox.Show("El id del usuario es: " + id_usuario.ToString());

            login.Dispose();



            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aBMUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_Usuarios frm_ABM_Usuarios = new Frm_ABM_Usuarios();
            frm_ABM_Usuarios.ShowDialog();
        }
    }
}
