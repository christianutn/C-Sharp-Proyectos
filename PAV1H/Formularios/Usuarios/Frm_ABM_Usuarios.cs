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

using PAV1H.Clases; // Para poder comunicarme con BE_Acceso_Datos para poder conectarme a la base de datos

using PAV1H.Negocios; 

namespace PAV1H.Formularios.Usuarios
{
    public partial class Frm_ABM_Usuarios : Form
    {

        public string idGrid_usuario { get; set; }

        public Frm_ABM_Usuarios()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Usuarios_Load(object sender, EventArgs e)
        {
            //BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            //DataTable tabla = new DataTable();
            //string sql;

            //sql = "SELECT id_perfil, nombre FROM Perfiles";

            //tabla = _BD.Ejecutar_select(sql);

            //cmb_perfiles.DisplayMember = "nombre"; // Se guarda el nombre de la columna que se va a mostrar
            //cmb_perfiles.ValueMember = "id_perfiles"; // Para evitar errores debe ingresarse el PK por el cual se buscará en la base de datos. Para evitar que se repita.
            //cmb_perfiles.DataSource = tabla; // Se carga la información en el objeto tabla.

            // Una vez implementado estas líneas en la clase ComboBox01 Simplemente modificamos las propiedades directamente desde la opcion propiedades
            // ingresando Pp_nombre, Pp_descripcion, Pp_tabla. Por último solo solicitamos cargar comboBox como a lo haremos a continuación

            cmb_perfiles.CargarCombo();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmb_perfiles.SelectedIndex = -1;
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            NE_usuarios usuario = new NE_usuarios();

            if (chk_todos.Checked == true) // Si la opción "Todos" del formulacrio Frm_ABM_Usuarios está marcado
            {
                DataTable tabla = new DataTable();
                tabla = usuario.RecuperarTodos();
                CargarGrilla(tabla);
                return; // Sale del blocke btn_consulta_Click
            }

            if (cmb_perfiles.SelectedIndex != -1) // Es decir si tiene seleccionado algo del comboBox
            {
                CargarGrilla(usuario.Recuperar_x_perfiles(cmb_perfiles.SelectedValue.ToString()));
                return;
            }

            if (txt_patron.Text!="")
            {
                CargarGrilla(usuario.Recuperar_x_patron(txt_patron.Text));
              
            }
        }

        private void CargarGrilla(DataTable tabla)
        {
            grid_usuarios.Rows.Clear();
           
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_usuarios.Rows.Add();
                grid_usuarios.Rows[i].Cells[0].Value = tabla.Rows[i]["n_usuario"].ToString(); // tabla.Rows[i]["n_usuario"].ToString() -> busca en la tabla de Usuarios que obtuve desde
                                                                                              // sql por fila y columna, devolviendo dicho valor.
                grid_usuarios.Rows[i].Cells[1].Value = tabla.Rows[i]["email"].ToString();
                grid_usuarios.Rows[i].Cells[2].Value = tabla.Rows[i]["nombre"].ToString(); // "nombre" es el nombre de perfil
                grid_usuarios.Rows[i].Cells[3].Value = tabla.Rows[i]["id_usuario"].ToString();

            }
          
        }

        private void grid_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idGrid_usuario = grid_usuarios.CurrentRow.Cells["id_usuario"].Value.ToString();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (idGrid_usuario == "")
            {
                Frm_ModificacionesUsuarios modificar = new Frm_ModificacionesUsuarios();
                modificar.Id_usuario = idGrid_usuario;
                modificar.ShowDialog();
            }
            

        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            Frm_AltasUsuarios altaUsuarios = new Frm_AltasUsuarios();

            altaUsuarios.ShowDialog();
            altaUsuarios.Close();
        }

        private void grid_usuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_MostrarUsuario mostrarUsuario = new Frm_MostrarUsuario();

            mostrarUsuario.Id_usuario = grid_usuarios.CurrentRow.Cells["id_usuario"].Value.ToString();
            
            mostrarUsuario.ShowDialog();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Frm_BorrarUsuario borrar = new Frm_BorrarUsuario();
            borrar.Id_usuario = idGrid_usuario;
            borrar.ShowDialog();

        }
    }
}
