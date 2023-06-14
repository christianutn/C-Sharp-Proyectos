using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PAV1H.Clases
{
    internal class BE_Acceso_Datos_T
    {
        // Acceso a datos TRANSACCIONAL

        public enum EstadoTransaccion { error, correcto}
        public enum TipoConexion { simple, transaccion} // Conexion simple: Como el definido BE_Acceso_Datos

        string cadenaConexion = "Data Source=DESKTOP-J78AN4H\\SQLEXPRESS;Initial Catalog=sistemaDeGestion;Integrated Security=True";

        SqlConnection conexion = new SqlConnection(); 

        SqlCommand cmd = new SqlCommand();

        SqlTransaction transaccion; // Se realiza una reserva del nombre transacción. El objeto se debe instanciar al momento de utilizarse. 

        EstadoTransaccion ControlTransaccion = EstadoTransaccion.correcto;
        TipoConexion ControlConexion = TipoConexion.simple;

        // Declaro para ver donde comienza y donde termina una transacción.

        public void InicioTransaccion()
        {
            ControlTransaccion = EstadoTransaccion.correcto;

            ControlConexion = TipoConexion.transaccion;
        }


        public EstadoTransaccion FinalTransaccion()
        {
            if (ControlConexion == TipoConexion.transaccion)
            {
                if (ControlTransaccion == EstadoTransaccion.correcto)
                {
                    transaccion.Commit();
                }
                else
                {
                    transaccion.Rollback();
                }
            }
            ControlConexion = TipoConexion.simple;
            Desconectar();

            return ControlTransaccion;
        }
        private void Conectar()
        {
            if (conexion.State != ConnectionState.Open) // El estado de la conexión es distinto a abierto. Es decir está cerrado.
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                cmd.Connection = conexion; // Se le indica a cmd con quien se conecta
                cmd.CommandType = CommandType.Text;

                if (ControlConexion == TipoConexion.transaccion)
                {
                    transaccion = conexion.BeginTransaction(IsolationLevel.ReadCommitted);  // IsolationLevel.ReadCommitted ->  permite poder visualizar los datos de la tabla y lo que 
                    // en tiempo de transacción ( lo cual esta en el buffer). Es un manejador de la transacción.

                    cmd.Transaction = transaccion;
                }

            }

        }
        
        private void Desconectar()
        {
            if (ControlConexion == TipoConexion.simple)
            {
                conexion.Close();
            }
            
        }


        public DataTable EjecutarSelect(string sql)
        {
            Conectar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();

            try
            {
                tabla.Load(cmd.ExecuteReader()); // Punto donde se puede generar un error
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error en la consulta \n"
                                + sql + "\n"
                                + "El mensaje de error es: \n"
                                + e.Message);
            }
            
            Desconectar();
            return tabla; // Si la transaccion da error se devuelve la tabla vacía

        }

        private EstadoTransaccion InsModBorrar(string sql)
        {
            Conectar();
            cmd.CommandText = sql;
            DataTable tabla = new DataTable();

            try
            {
                cmd.ExecuteNonQuery(); // ExecuteNonQuery() Ejecución de un comando del tipo no consulta. SOn del tipo DELETE INSERT UPDATE
            }
            catch (Exception e)
            {
                ControlTransaccion = EstadoTransaccion.error;
                MessageBox.Show("Error en la consulta \n"
                                + sql + "\n"
                                + "El mensaje de error es: \n"
                + e.Message);
            }

            Desconectar();

            return ControlTransaccion;
        }

        public EstadoTransaccion Insertar (string sqlInsertar)
        {
            return InsModBorrar(sqlInsertar);
        }
        public EstadoTransaccion Modificar(string sqlModificar)
        {
            return InsModBorrar(sqlModificar);
        }

        public EstadoTransaccion Borrar(string sqlBorrar)
        {
            return InsModBorrar(sqlBorrar);
        }
    }

}
