using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1H.Clases
{
    internal class Tratamientos_especiales
    {
        public enum Resultado { correcto, error }

        public Resultado Validar(Control.ControlCollection control)
        {
            foreach (var item in control)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).Text == "") // (((TextBox01)item).Text -> Enmascarar. Como item puede ser cualquier objeto es necesario enmascararlo para que sea reconocido.
                    {
                        MessageBox.Show(((TextBox01)item).Pp_mensajeError);
                        ((TextBox01)item).Focus();
                        return Resultado.error;
                    }
                }

                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).SelectedIndex == -1)
                    {
                        MessageBox.Show(((ComboBox01)item).Pp_mensajeError);
                        ((ComboBox01)item).Focus();
                        return Resultado.error;

                    }
                }
            }
            return Resultado.correcto;
        }

        public string ConstructurInsert(string nombreTabla, Control.ControlCollection controles)
        {
            string sql = "";
            string columna = "";
            string tipoDatoColumna = "";
            string valorColumna = "";
            string paqueteColumnas = "";
            string paqueteValores = "";
            DataTable estructura = new DataTable();

            estructura = BuscarEstructuraTabla(nombreTabla);

            for (int i = 0; i < estructura.Columns.Count; i++)
            {
                columna = estructura.Columns[i].Caption; // nombre campo de la tabla ej n_usuarios para Usuarios
                tipoDatoColumna = estructura.Columns[i].DataType.Name;
                valorColumna = BuscarColumnaEnControles(columna, controles);

                if (valorColumna != String.Empty)
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);

                    if(paqueteColumnas=="")
                    {
                        paqueteColumnas = columna;
                        paqueteValores = valorColumna;
                    }
                else
                    {
                        paqueteColumnas += ", " + columna;
                        paqueteValores += ", " + valorColumna;
                    }
                }
                
                // paqueteColumnas.Remove(-2, 2); Probar como alternativa
            }
            sql = "INSERT INTO " + nombreTabla + "(" + paqueteColumnas + ") VALUES (" + paqueteValores + ")";

            MessageBox.Show(sql);

            return sql;

        }




        private DataTable BuscarEstructuraTabla(string nombreTabla)
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();
            return _BD.Ejecutar_select("SELECT TOP 1 * FROM " + nombreTabla);
        }

        private string BuscarColumnaEnControles(string campo, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).Pp_campo == campo)
                    {
                        return ((TextBox01)item).Text;
                    }
                }

                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).Pp_campo == campo)
                    {
                        return ((ComboBox01)item).SelectedValue.ToString();

                    }
                }
            }
            return "";
        }

        private string FormatearDato(string valorColumna, string tipoDatoColumna)
        {
            switch (tipoDatoColumna)
            {
                case "String":
                    return "'" + valorColumna + "'";
                case "Int16":
                case "Int32":
                case "Int64":
                    return valorColumna;
                default:
                    return valorColumna;
            }

        }

        public string RecuperarFecha()
        {
            BE_Acceso_Datos _BD = new BE_Acceso_Datos();



            return _BD.Ejecutar_select("SELECT CONVERT (CHAR(10), GETDATE(), 103)").Rows[0][0].ToString();
        }



    }
}
