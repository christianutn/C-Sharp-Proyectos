using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaShopping.Clases
{
    public class BuscarFiltros
    {

        //public static DataTable Buscar()
        //{

        //    conexionBD _BD = new conexionBD();
        //    string sqlSelect = "SELECT * FROM Clientes";
        //    DataTable tabla = new DataTable();

        //    tabla = _BD.EjecutarSelect(sqlSelect);

        //    return tabla;

        //}


        //public static DataTable Buscar(string nombre)
        //{

        //    conexionBD _BD = new conexionBD();
        //    string sqlSelect = @"SELECT *, TipoDocumento.descripcion as descTipoDoc, Sexos.descripcion as descSexo, EstadosCiviles.descripcion as descEstadoCivil" +
        //                       @" FROM Clientes JOIN TipoDocumento on codTipoDoc = TipoDocumento.codigo JOIN Sexos on codSexo = Sexos.codigo " +
        //                        "JOIN EstadosCiviles on codEstadoCivil = EstadosCiviles.codigo WHERE nombres LIKE '%" + nombre + "%'";



        //    DataTable tabla = new DataTable();

        //    tabla = _BD.EjecutarSelect(sqlSelect);

        //    return tabla;

        //}

        //public static DataTable Buscar(string nombre, string apellido)
        //{

        //    conexionBD _BD = new conexionBD();
        //    string sqlSelect = @"SELECT *, TipoDocumento.descripcion as descTipoDoc, Sexos.descripcion as descSexo, EstadosCiviles.descripcion as descEstadoCivil" +
        //                       @" FROM Clientes JOIN TipoDocumento on codTipoDoc = TipoDocumento.codigo JOIN Sexos on codSexo = Sexos.codigo " +
        //                       @"JOIN EstadosCiviles on codEstadoCivil = EstadosCiviles.codigo WHERE nombres LIKE '%" + nombre + "%'" +
        //                       "AND apellido LIKE '%" + apellido + "%'";



        //    DataTable tabla = new DataTable();

        //    tabla = _BD.EjecutarSelect(sqlSelect);

        //    return tabla;

        //}
        

        public static DataTable Buscar(string descTipoDoc, string numeroDoc, string nombres, string apellido)
        {
            //if (descTipoDoc == null) { descTipoDoc = ""; }
            //if (numeroDoc == null) { numeroDoc = ""; }
            //if (nombres == null) { nombres = ""; }
            //if (apellido == null) { apellido = ""; }


            conexionBD _BD = new conexionBD();
            //string sqlSelect = @"SELECT *, TipoDocumento.descripcion as descTipoDoc, Sexos.descripcion as descSexo, EstadosCiviles.descripcion as descEstadoCivil" +
            //                   @" FROM Clientes LEFT JOIN TipoDocumento on codTipoDoc = TipoDocumento.codigo LEFT JOIN Sexos on codSexo = Sexos.codigo " +
            //                   @" LEFT JOIN EstadosCiviles on codEstadoCivil = EstadosCiviles.codigo WHERE TipoDocumento.descripcion LIKE '%" + descTipoDoc + "%'" +
            //                   "AND numeroDoc LIKE '%" + numeroDoc + "%' AND nombres LIKE '%" + nombres + "%' " + " AND apellido LIKE '%" + apellido + "%'";


            string sqlSelect = "EXEC pa_consultar_clientes '" + descTipoDoc + "' , '" + numeroDoc + "', '" + nombres + "', '" + apellido + "'";


            //cmd.Parameters.Add("@idNombre", SqlDbType.Int);

            DataTable tabla = new DataTable();

            tabla = _BD.EjecutarSelect(sqlSelect);

            MessageBox.Show(tabla.Rows.Count.ToString());
            

            return tabla;

        }
    }
}
