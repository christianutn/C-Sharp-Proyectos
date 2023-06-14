using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SistemaShopping.Clases;
using SistemaShopping.Formularios.Clientes;

namespace SistemaShopping.Negocio
{
    public class NegocioUsuario
    {

        public static  string PpCodTipoDoc { get; set; }
        public static string PpNroDoc { get; set; }
        public static string PpNombres { get; set; }
        public static string PpApellido { get; set; }

        public static string PpCodProvincia { get; set; }
        public static string PpCodPostal { get; set; }
        public static string PpCodSexo { get; set; }
        public static string PpCodEstadoCivil { get; set; }
        public static string PpDireccion { get; set; }
        public static string PpFechaNacimiento { get; set; }

        public static string PpNumeroFact { get; set; }
        public static string PpCodTipoFact { get; set; }
        public static string PpCodLocal { get; set; }
        public static string PpNumeroTarj { get; set; }


        static conexionBD _BD = new conexionBD();
        
        public enum ResultadoLogin { valido, noValido}

        public enum ResultadoAgregar { valido,noValido}

        public enum Resultado { correcto, incorrecto}

        public ResultadoLogin ValidarLogin(string nombreUsuario, string contrasenia)
        {
           
            

            string slqConsultar = "SELECT * FROM Usuarios WHERE nombreUsuario = '" + nombreUsuario + "' AND contrasenia = '" + contrasenia + "'";

            if(_BD.EjecutarSelect(slqConsultar).Rows.Count == 0)
            {
                return ResultadoLogin.noValido;
            }

            return ResultadoLogin.valido;

        }

        public static ResultadoAgregar insertar(Control.ControlCollection controles, string nombreTabla)
        {

            string formatoCamposTabla = "";
            string formatoValores = "";
            string valorColumnaName;
            string valorDelCampo;
            string sql = "";

            DataTable estructura = BuscarEstructuraTabla(nombreTabla);


          foreach(DataColumn c in estructura.Columns)
            {
                valorColumnaName = c.ColumnName;
                valorDelCampo = BuscarValorDelCampo(c.ColumnName, controles);

                if (valorDelCampo != null && valorDelCampo != string.Empty)
                {
                    formatoCamposTabla += valorColumnaName + ", ";
                    formatoValores += "'" + valorDelCampo + "'" + ", ";
                }
            }

            formatoValores = formatoValores.Remove(formatoValores.Length - 2);
            formatoCamposTabla = formatoCamposTabla.Remove(formatoCamposTabla.Length - 2);

            sql = "INSERT INTO " + nombreTabla + "(" + formatoCamposTabla + ")" + " VALUES (" + formatoValores + ")";

            if (_BD.Insertar(sql) == conexionBD.EstadoTransaccion.correcto)
            {
                return ResultadoAgregar.valido;
            }

         

          return ResultadoAgregar.noValido;
        }

        public static DataTable BuscarEstructuraTabla(string nombreTabla)
        {
            return _BD.EjecutarSelect("SELECT TOP 1 * FROM " + nombreTabla);
        }

        static string BuscarValorDelCampo(string nombreCampo, Control.ControlCollection controles)
        {
            
            foreach(Control c in controles)
            {
                
                if(c.GetType().Name == "TextBoxUsuario")
                {
                    if (((TextBoxUsuario)c).PpCampoSql == nombreCampo)
                    {
                        if (((TextBoxUsuario)c).PpCampoSql == "fechaNacimiento" && c.Text != string.Empty)
                        {
                            return DateTime.Parse(c.Text).ToString().Remove(DateTime.Parse(c.Text).ToString().Length - 9);
                        }

                        return c.Text;

                    }
                }
                else if (c.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)c).PpCampoTabla == nombreCampo)
                    {
                        if (((ComboBox01)c).SelectedIndex != -1)
                        {
                            MessageBox.Show("Selected Value: " + ((ComboBox01)c).SelectedValue.ToString());
                            return ((ComboBox01)c).SelectedValue.ToString();


                        }
                        else
                        {
                            return "";
                        }
                    }

                }
            }

            return null;

        } // FIN buscar valor del campo


        public static void CargarFormulario(string nroDoc, string nombreTabla, Control.ControlCollection controles)
        {
            DataTable camposTabla = BuscarXNroDocYTipoDoc(nroDoc);
            string nombreColumna = "";
            string valor = "";
      



            for (int i = 0; i < camposTabla.Columns.Count; i++)   
            {
                nombreColumna = camposTabla.Columns[i].ColumnName;
                valor = camposTabla.Rows[0][i].ToString();
              
                nombreTabla = camposTabla.TableName;
            

                foreach (Control control in controles)
                {
                    if(control.GetType().Name == "TextBoxUsuario")
                    {
                        if(((TextBoxUsuario)control).PpCampoSql == nombreColumna)
                        {
                            if (nombreColumna == "fechaNacimiento" && valor.Length > 9)
                            {
                                control.Text = valor.Remove(valor.Length - 9);
                            }
                            else
                            {
                                control.Text = valor;
                            }

                        }
                    }
                    else if (control.GetType().Name == "ComboBox01")
                    {
                        if (((ComboBox01)control).PpCampoTabla == nombreColumna)
                        {
                            if (valor != "")
                            {
  
                                ((ComboBox01)control).PpSelectedIndex = int.Parse(valor.ToString());
                            }
                            


                        }
                    }


                }

            }// Vin for nmbre columna




        }


        static DataTable BuscarXNroDocYTipoDoc(string nroDoc)
        {
            return _BD.EjecutarSelect("SELECT * FROM Clientes WHERE numeroDoc = " + nroDoc);
        }

        public static int BuscarCodProvincia (string codPostal)
        {
            if (codPostal == null || codPostal != string.Empty)
            {
                DataTable dt = _BD.EjecutarSelect("SELECT TOP 1 codProvincia FROM Localidades WHERE codPostal = " + codPostal);
                if (dt.Rows.Count > 0)
                {
                    int resultado = int.Parse(dt.Rows[0][0].ToString());
                    return resultado;
                }
                

                
            }

            return -1;
        }

        public static string BuscarDescProvXcodProv(string codProvincia)
        {
            string  sql = "SELECT TOP 1 descripcion FROM Provincias WHERE codProvincia = " + codProvincia;
            
            string resultado = "";

            DataTable dt = new DataTable();

            dt = _BD.EjecutarSelect(sql);
            

          
            

            if (dt.Rows.Count > 0)
            {
                resultado = dt.Rows[0][0].ToString();
            }

            return resultado;
            
        }


        public static Resultado ModificarDatosClientes()
        {
            string sql = @"UPDATE Clientes SET nombres = '" + PpNombres + "', apellido = '" + PpApellido +
                          "', codLocalidad = '" + PpCodPostal + "', domicilio = '" + PpDireccion + "', codSexo = '" + PpCodSexo + "', codEstadoCivil = '" + PpCodEstadoCivil +
                          "', fechaNacimiento = '" + PpFechaNacimiento + "' WHERE codTipoDoc = '" + PpCodTipoDoc + "' AND numeroDoc = '" + PpNroDoc + "'";

            if (_BD.Modificar(sql) == conexionBD.EstadoTransaccion.correcto)
            {
                return Resultado.correcto;

            }
            else
            {
                return Resultado.incorrecto;
            }
        }

        public static void CargarPp(Control.ControlCollection controles)
        {
            foreach (Control c in controles)
            {
               if (c.GetType().Name == "TextBoxUsuario")
                {
                    if(((TextBoxUsuario)c).PpCampoSql == "nombres")
                    {
                        ((TextBoxUsuario)c).Text = PpNombres;
                    }
                    else if (((TextBoxUsuario)c).PpCampoSql == "apellido")
                    {
                        ((TextBoxUsuario)c).Text = PpApellido;
                    }
                    else if (((TextBoxUsuario)c).PpCampoSql == "domicilio")
                    {
                        ((TextBoxUsuario)c).Text = PpDireccion;
                    }
                    else if (((TextBoxUsuario)c).PpCampoSql == "fechaNacimiento")
                    {
                        ((TextBoxUsuario)c).Text = PpFechaNacimiento;
                    }
                    else if (((TextBoxUsuario)c).PpCampoSql == "numeroDoc")
                    {
                        ((TextBoxUsuario)c).Text = PpNroDoc;
                    }
                }
               else if (c.GetType().Name == "ComboBox01")
                {
                    if(((ComboBox01)c).PpCampoTabla == "codTipoDoc")
                    {
                        ((ComboBox01)c).Text = PpCodTipoDoc;
                    }
                    else if (((ComboBox01)c).PpCampoTabla == "codProvincia")
                    {
                        ((ComboBox01)c).Text = PpCodProvincia;
                    }
                    else if (((ComboBox01)c).PpCampoTabla == "codLocalidad")
                    {
                        ((ComboBox01)c).Text = PpCodPostal;
                    }
                    else if (((ComboBox01)c).PpCampoTabla == "codSexo")
                    {
                        ((ComboBox01)c).Text = PpCodSexo;
                    }
                    else if (((ComboBox01)c).PpCampoTabla == "codEstadoCivil")
                    {
                        ((ComboBox01)c).Text = PpCodEstadoCivil;
                    }
                }


            } // FIN foreach




        }// FIN cargar formulario


        public static Resultado EliminarCliente(string codTipoDoc, string numeroDoc)
        {

            string sql = "DELETE FROM Clientes WHERE codTipoDoc = " + codTipoDoc + " AND numeroDoc = " + numeroDoc;

            if (_BD.Borrar(sql) == conexionBD.EstadoTransaccion.correcto)
            {
                return Resultado.correcto;

            }
            else
            {
                return Resultado.incorrecto;
            }
        }


        public static void CompletarGrillaFrmCompras(DataGridView gridCompras)
        {
            gridCompras.Rows.Clear();
            string sql = @"SELECT codLocal, tipoFactura, nroFactura, tipoDoc, nroDoc, nroTarjeta FROM Facturas WHERE " +
                           "codLocal LIKE '%" + PpCodLocal + "%' AND tipoFactura LIKE '%" + PpCodTipoFact + "%' AND nroFactura LIKE '%" + PpNumeroFact + "%' AND tipoDoc LIKE '%" +
                           PpCodTipoDoc + "%' AND nroTarjeta LIKE '%" + PpNumeroTarj + "%'" + " AND nroDoc LIKE '%" + PpNroDoc + "%'";

            DataTable dt = _BD.EjecutarSelect(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                gridCompras.Rows.Add();
                gridCompras.Rows[i].Cells["codLocal"].Value = dt.Rows[i]["codLocal"].ToString();
                gridCompras.Rows[i].Cells["codTipoFact"].Value = dt.Rows[i]["tipoFactura"].ToString();
                gridCompras.Rows[i].Cells["numeroFact"].Value = dt.Rows[i]["nroFactura"].ToString();
                gridCompras.Rows[i].Cells["codTipoDoc"].Value = dt.Rows[i]["tipoDoc"].ToString();
                gridCompras.Rows[i].Cells["numeroDoc"].Value = dt.Rows[i]["nroDoc"].ToString();
                gridCompras.Rows[i].Cells["numeroTarj"].Value = dt.Rows[i]["nroTarjeta"].ToString();

            }

        }



        public static void ArmarReporteFactura()
        {
            string sql = "SELECT [codLocal], [tipoFactura], [nroFactura], [tipoDoc], [nroDoc], [nroTarjeta]  FROM [dbo].[Facturas]  WHERE nroTarjeta = '5014407540041643'";

            DataTable dt = new DataTable();

            ReportDataSource Datos = new ReportDataSource("DS_detalleFactura", dt);
          
        }
    }
}
