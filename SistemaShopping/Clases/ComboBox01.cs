using SistemaShopping.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaShopping.Clases
{
    internal class ComboBox01 : ComboBox
    {
        conexionBD _BD = new conexionBD();
        public string PpPk { get; set; }
        public string PpNombre { get; set; }
        public string PpNombreTabla { get; set; }
        public string PpMensajeError { get; set; }
        public string PpCampoTabla { get; set; }

        public bool PpEsCmbValido { get; set; }
        public string PpNombreTablaGeneral { get; set; } // Nombre de la tabla donde intervienen atributos que se corresponden a otras tablas. 
                                                         // Por ejemplo el campo codTipoDoc pertenece a la tabla TipoDocumento pero a su vez compone la tabla Clientes.
                                                         // LA tabla Clientes en este ejemplo sería el nombre de PpNombreTablaGeneral




        public int PpSelectedIndex { get; set; } // Indice obtenido de una tabla para luego al cargar el combo seleccionemos el indice correcto.


        public void CargarCombo()
        {

            
            string sqlCarga = "SELECT " + PpPk + ", " + PpNombre + " FROM " + PpNombreTabla;

            this.DisplayMember = PpNombre;
            this.ValueMember = PpPk;
            this.DataSource = _BD.EjecutarSelect(sqlCarga);
            this.SelectedIndex = -1;

            

        }

        public void CargarComboLocalidades(string PkProvincia)
        {
            // SObrecarga: Al ingresarse una Pk se obtiene el combo tabulado con respecto a dicha Pk.

            string sqlCarga = "SELECT " + PpPk + ", " + PpNombre + " FROM " + PpNombreTabla + " WHERE codProvincia = " + PkProvincia;
            //MessageBox.Show(sqlCarga);
            this.DisplayMember = PpNombre;
            this.ValueMember = PpPk;
            this.DataSource = _BD.EjecutarSelect(sqlCarga);
            this.SelectedIndex = -1;

        }

        public void CargarComboProvincias(string PkLocalidad)
        {
            // SObrecarga: Al ingresarse una Pk se obtiene el combo tabulado con respecto a dicha Pk.

            //string sqlCarga = "SELECT codProvincia FORM";
            //string cod = "";
            //string codProvincia = _BD.EjecutarSelect("exec pa_obtenerCodProvincia @PkLocalidad, @cod output select @cod", "@PkLocalidad", PkLocalidad, "@cod", cod);
            //MessageBox.Show("EL codigoPRov: " + codProvincia.ToString());


            this.DisplayMember = PpNombre;
            this.ValueMember = PpPk;
            this.DataSource = _BD.EjecutarSelect("SELECT codProvincia, descripcion FROM Provincias");
            this.SelectedIndex = 2;
            



        }



        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;
        Color borderColor = Color.Blue;
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT && DropDownStyle != ComboBoxStyle.Simple)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(BorderColor))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);

                        var d = FlatStyle == FlatStyle.Popup ? 1 : 0;
                        g.DrawLine(p, Width - buttonWidth - d,
                            0, Width - buttonWidth - d, Height);
                    }
                }
            }
        }


        public static void informarToolTip(Control control, string msj)
        {
            ToolTip objToolTip = new ToolTip();
            objToolTip.IsBalloon = true;
            objToolTip.SetToolTip(control, msj);
        }


        public static void ControlarCmb(Control control)
        {
           

            if (control.GetType().Name == "ComboBox01")
            {


                ((ComboBox01)control).BorderColor = Color.Transparent;
                ((ComboBox01)control).PpEsCmbValido = true;


                if (((ComboBox01)control).SelectedValue == null && ((ComboBox01)control).Text != "" && (((ComboBox01)control).PpNombreTabla == "TipoDocumento"))
                {
                    ((ComboBox01)control).PpEsCmbValido = false;
                    ((ComboBox01)control).BorderColor = Color.Red;

                }

            }
        }






    }
}
