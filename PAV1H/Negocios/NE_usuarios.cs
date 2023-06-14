using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using PAV1H.Clases;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace PAV1H.Negocios
{
    internal class NE_usuarios
    {

        public string Pp_n_usuario { get; set; }
        public string Pp_contrasenia { get; set; }
        public string Pp_email { get; set; }
        public string Pp_perfil { get; set; }
        public string Pp_nombre { get; set; }
        public string Pp_apellido { get; set; }
        public string Pp_cuil { get; set; }
        public string Pp_estado { get; set; }

        public string Pp_id_usuario { get; set; }


        public enum ResultadoValidacion { existe, no_existe}
        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        BE_Acceso_Datos_T _BDT = new BE_Acceso_Datos_T();

        public ResultadoValidacion ValidarUsuario (string usuario, string password)
        {
            // String que tengo que pasarle a la clase BE_Acceso_Datos la cual la ejecutará como comando 
            string sql = "SELECT * FROM Usuarios WHERE n_usuario='" + usuario + "' AND contrasenia='" + password + "'"; 

            BE_Acceso_Datos _BD = new BE_Acceso_Datos ();
            DataTable tabla = new DataTable ();

            tabla = _BD.Ejecutar_select(sql);

            if(tabla.Rows.Count == 1)
            {
                return ResultadoValidacion.existe;
            }
            else
            {
                return ResultadoValidacion.no_existe;
            }
        }

        public int  RecuperarIdUsuario(string usuario, string password)
        {
            string sql = "SELECT id_usuario FROM Usuarios WHERE n_usuario='" + usuario + "' AND contrasenia='" + password + "'";

            // BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            DataTable tabla = new DataTable();
            tabla = _BD.Ejecutar_select(sql);

             return int.Parse(tabla.Rows[0][0].ToString());

        }


        public DataTable RecuperarTodos()
        {
            string sql = "select n_usuario, email, Perfiles.nombre, id_usuario from Usuarios join Perfiles on  Usuarios.id_perfil=Perfiles.id_perfil";
            // BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            return _BD.Ejecutar_select(sql);
        }

        public DataTable Recuperar_x_perfiles(string id_perfil)
        {
            string sql = "select n_usuario, email, Perfiles.nombre, id_usuario from Usuarios join Perfiles on  Usuarios.id_perfil=Perfiles.id_perfil WHERE Usuarios.id_perfil=" + id_perfil;
            // BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            return _BD.Ejecutar_select(sql);
        }

        public DataTable Recuperar_x_patron(string patron)
        {
            string sql = "select n_usuario, email, Perfiles.nombre, id_usuario from Usuarios join Perfiles on Usuarios.id_perfil = Perfiles.id_perfil where n_usuario like '%" + patron.Trim() + "%'";
            return _BD.Ejecutar_select(sql);
        }

        public void Insertar()
        {
            string sqlInsertar = "INSERT INTO Usuarios(n_usuario, contrasenia, email, id_perfil, nombres, apellido, cuil, id_estado) VALUES ('"
                +Pp_n_usuario + "', '" + Pp_contrasenia + "', '" + Pp_email + "', '" + Pp_perfil + "', '"+ Pp_nombre + "', '" + Pp_apellido + "', '" + Pp_cuil + "', '" + Pp_estado + "');";
            _BD.insertar(sqlInsertar);
            
        }

        public void Insertar(Control.ControlCollection controles)
        {
            Tratamientos_especiales tratamientos = new Tratamientos_especiales();
            _BD.insertar(tratamientos.ConstructurInsert("Usuarios", controles));
        }

        public DataTable RecuperarXidUsuario(string idUsuario)
        {
            string sql = @"SELECT id_usuario, n_usuario, contrasenia, email, apellido, nombres, cuil, Perfiles.nombre as perfil , Estado.nombre as estado, Perfiles.id_perfil, Estado.id_estado FROM "
                        + "Usuarios JOIN Perfiles on Usuarios.id_perfil=Perfiles.id_perfil JOIN Estado on Usuarios.id_estado=Estado.id_estado" +
                        " WHERE id_usuario = " + idUsuario;


            return _BD.Ejecutar_select(sql);
        }

        public void Modificar()
        {

            string sqlModificar = @"UPDATE Usuarios SET id_perfil = " + Pp_perfil + ", contrasenia = '" + Pp_contrasenia + "',"
                + " email = '" + Pp_email + "', apellido = '" + Pp_apellido + "', nombres = '" + Pp_nombre + "', cuil = '" + Pp_cuil + "', id_estado= " + Pp_estado
                + " WHERE id_usuario = " + Pp_id_usuario;


            _BD.modificar(sqlModificar);

        }

        public void Borrar()
        {
            string sqlBorrar = "DELETE FROM Usuarios WHERE id_usuario = " + Pp_id_usuario;
            _BD.borrar(sqlBorrar);
        }

        public DataTable ReportesUsuariosXtodos()
        {
            string sql = "SELECT id_usuario, n_usuario, nombres, apellido FROM Usuarios";
            return _BDT.EjecutarSelect(sql);
        }

        public DataTable ReportesUsuariosInicieLetra(string letra)
        {
            string sql = "SELECT id_usuario, n_usuario, nombres, apellido FROM Usuarios WHERE apellido LIKE '" + letra.Trim() + "%'";
            return _BDT.EjecutarSelect(sql);
        }

        public DataTable ReportesUsuariosConLetra(string letra)
        {
            string sql = "SELECT id_usuario, n_usuario, nombres, apellido FROM Usuarios WHERE apellido LIKE '%" + letra.Trim() + "%'";
            return _BDT.EjecutarSelect(sql);
        }



    }
}
