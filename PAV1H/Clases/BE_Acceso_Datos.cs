using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar nuevas librerías para conectarse a la base de datos
using System.Data;            
using System.Data.SqlClient;

namespace PAV1H.Clases
{
    internal class BE_Acceso_Datos
    {
        SqlConnection conexion = new SqlConnection(); // creo un objeto del tipo conexion. El que me permite habilitar el canal por le cual se conecta la App con SQL.

        SqlCommand cmd = new SqlCommand(); // Instancio un objeto de la clase SQlComand. Este objeto tendrá los atributos para cargar los comandos.

        // DataTable tabla = new DataTable();  Instancio un objeto de la clase DATA TABLE el cual me permite guardar los datos que se extraen de SQL

        // Creo método del tipo procedual privado para conectar



        private void conectar()
        {
            conexion.ConnectionString = "Data Source=DESKTOP-J78AN4H\\SQLEXPRESS;Initial Catalog=sistemaDeGestion;Integrated Security=True";
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }

        private void desconectar()
        {
            conexion.Close();
        }

        public DataTable Ejecutar_select(string txtSql)
        {
            DataTable tabla = new DataTable();
            conectar();
            cmd.CommandText = txtSql;
            tabla.Load(cmd.ExecuteReader()); // ExecuteReader() ejecución de una lectura. SELECT 
            desconectar();
            return tabla;

        }

        public void insertar (string sqlInsertar)
        {
            
            conectar();
            cmd.CommandText = sqlInsertar;
            cmd.ExecuteNonQuery(); // ExecuteNonQuery() Ejecución de un comando del tipo no consulta. SOn del tipo DELETE INSERT UPDATE
            desconectar();
            
            
        }

        public void modificar (string sqlModificar)
        {
            conectar();
            cmd.CommandText = sqlModificar;
            cmd.ExecuteNonQuery(); // ExecuteNonQuery() Ejecución de un comando del tipo no consulta. SOn del tipo DELETE INSERT UPDATE
            desconectar();
        }

        public void borrar(string sqlBorrar)
        {
            conectar();
            cmd.CommandText = sqlBorrar;
            cmd.ExecuteNonQuery(); // ExecuteNonQuery() Ejecución de un comando del tipo no consulta. SOn del tipo DELETE INSERT UPDATE
            desconectar();
        }


    }
}
