using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaShopping.Clases
{
   
    public class TextBoxUsuario : TextBox
    {


        public TextBoxUsuario()
        {
            if (this.PpAdmiteNull)
            {
                this.PpEsTextoValido = true;  
            }
        }
        public enum EsValidacion { correcta, incorrecta }

        public string PpMensajeError { get; set; }
        public bool PpEsNombreOapellido { get; set; }
       
        public bool PpEsDocumento { get; set; }

        public bool PpEsDireccion { get; set; }
        public bool PpEsFechaNacimiento { get; set; }
        public bool PpEsTextoValido { get; set; }
        public bool PpAdmiteNull { get; set; }
        public string PpCampoSql { get; set; }
        public string PpNombreTabla { get; set; }
        public string PpNombreTablaGeneral { get; set; } // Nombre de la tabla donde intervienen atributos que se corresponden a otras tablas. 
                                                            // Por ejemplo el campo codTipoDoc pertenece a la tabla TipoDocumento pero a su vez compone la tabla Clientes.
                                                            // LA tabla Clientes en este ejemplo sería el nombre de PpNombreTablaGeneral








        public EsValidacion Validar()
        {
            
            if (this.Text == "")
            {
                return EsValidacion.incorrecta;
            }

            return EsValidacion.correcta;
        }

        const int WM_NCPAINT = 0x85;
        const uint RDW_INVALIDATE = 0x1;
        const uint RDW_IUPDATENOW = 0x100;
        const uint RDW_FRAME = 0x400;
        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, uint flags);
        Color borderColor = Color.Blue;
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                    RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);
            }
            
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCPAINT && BorderColor != Color.Transparent &&
                BorderStyle == System.Windows.Forms.BorderStyle.Fixed3D)
            {
                var hdc = GetWindowDC(this.Handle);
                using (var g = Graphics.FromHdcInternal(hdc))
                using (var p = new Pen(BorderColor))
                    g.DrawRectangle(p, new Rectangle(0, 0, Width - 1, Height - 1));
                ReleaseDC(this.Handle, hdc);
            }
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
                   RDW_FRAME | RDW_IUPDATENOW | RDW_INVALIDATE);

 
        }

        public static void informarToolTip(Control control, string msj)
        {
            ToolTip objToolTip = new ToolTip();
            objToolTip.IsBalloon = true;
            objToolTip.SetToolTip(control, msj);
        }


        public static void ControlarTexto(Control control)
        {
            
            

            if (control.GetType().Name == "TextBoxUsuario" && control.Text.Length > 0)
            {

               



                if (((TextBoxUsuario)control).PpEsNombreOapellido)
                {
                    ControlarLetter(control);

                }
                else if (((TextBoxUsuario)control).PpEsDocumento)
                {
                    ControlarNumero(control);
                }
                else if (((TextBoxUsuario)control).PpEsDireccion)
                {
                    ControlarDireccion(control);
                }
                else if (((TextBoxUsuario)control).PpEsFechaNacimiento)
                {
                    ControlarFechaNacimiento(control);
                }

            }
            else if (control.GetType().Name == "TextBoxUsuario" && control.Text.Length == 0)
            {
                if (!((TextBoxUsuario)control).PpAdmiteNull)
                {
                    ((TextBoxUsuario)control).PpEsTextoValido = false;
                    ((TextBoxUsuario)control).BorderColor = Color.Red;
                    TextBoxUsuario.informarToolTip(control, "No admite campo vacío");
                }
                else
                {
                    ((TextBoxUsuario)control).PpEsTextoValido = true;
                    ((TextBoxUsuario)control).BorderColor = Color.Blue;
                }
                   
            }


            //if (control.GetType().Name == "TextBoxUsuario" && control.Text == string.Empty)
            //{
            //    ((TextBoxUsuario)control).PpEsTextoValido = false;
            //    ((TextBoxUsuario)control).BorderColor = Color.Red;

                //    TextBoxUsuario.informarToolTip(control, "No puede ser cadena vacía");
                //}

        } // Fin control Texto

        static void ControlarLetter(Control control)
        {
            string cadena = control.Text.ToString();
            char nuevoCaracter = cadena[cadena.Length - 1];
            int cant = 0;

            if (!Char.IsLetter(nuevoCaracter) && !Char.IsWhiteSpace(nuevoCaracter))
            {
                ((TextBoxUsuario)control).BorderColor = Color.Red;

                TextBoxUsuario.informarToolTip(control, "Caracter ' " + nuevoCaracter.ToString() + " ' no permitido");

                ((TextBoxUsuario)control).PpEsTextoValido = false;

            }

    

            for (int i = 0; i < cadena.Length; i++)
            {
                //MessageBox.Show("Contol Cadena: " + cadena.ToString() + " - Caracter: " + cadena[i].ToString());
                if (Char.IsLetter(cadena[i]) == false && Char.IsWhiteSpace(cadena[i]) == false)
                {
                    cant++;

                }

            }

            if (cant == 0)
            {

                ((TextBoxUsuario)control).BorderColor = Color.Blue;
                ((TextBoxUsuario)control).PpEsTextoValido = true;
                
            }
            else
            {
                ((TextBoxUsuario)control).BorderColor = Color.Red;

                TextBoxUsuario.informarToolTip(control,"Caracter/es no permitido/s");

                ((TextBoxUsuario)control).PpEsTextoValido = false;

            }
           


            

        }

        static void ControlarNumero(Control control)
        {
            string cadena = control.Text.ToString();
            char nuevoCaracter = cadena[cadena.Length - 1];
            int cant = 0;
            

            if (Char.IsDigit(nuevoCaracter) == false)
            {
                ((TextBoxUsuario)control).BorderColor = Color.Red;

                TextBoxUsuario.informarToolTip(control, "Caracter ' " + nuevoCaracter.ToString() + " ' no permitido");

                ((TextBoxUsuario)control).PpEsTextoValido = false;

            }

            for (int i = 0; i < cadena.Length; i++)
            {
                //MessageBox.Show("Contol Cadena: " + cadena.ToString() + " - Caracter: " + cadena[i].ToString());
                if (Char.IsDigit(cadena[i]) == false)
                {
                    cant++;

                }

            }

            if (cant == 0)
            {

                ((TextBoxUsuario)control).BorderColor = Color.Blue;
                ((TextBoxUsuario)control).PpEsTextoValido = true;

            }
            else
            {
                ((TextBoxUsuario)control).BorderColor = Color.Red;

                TextBoxUsuario.informarToolTip(control, "Caracter/es no permitido/s");

                ((TextBoxUsuario)control).PpEsTextoValido = false;

            }


        }

        static void ControlarDireccion(Control control)
        {
            string cadena = control.Text.ToString();
            char nuevoCaracter = cadena[cadena.Length - 1];
            int cant = 0;

            if (Char.IsLetterOrDigit(nuevoCaracter) == false && Char.IsWhiteSpace(cadena[cadena.Length - 1]) == false)
            {
                ((TextBoxUsuario)control).BorderColor = Color.Red;
               

                TextBoxUsuario.informarToolTip(control, "Caracter ' " + nuevoCaracter.ToString() + " ' no permitido");
                ((TextBoxUsuario)control).PpEsTextoValido = false;



            }

            for (int i = 0; i < cadena.Length; i++)
            {
                //MessageBox.Show("Contol Cadena: " + cadena.ToString() + " - Caracter: " + cadena[i].ToString());
                if (Char.IsLetterOrDigit(cadena[i]) == false && Char.IsWhiteSpace(cadena[i]) == false)
                {
                    cant++;

                }

            }

            if (cant == 0)
            {

                ((TextBoxUsuario)control).BorderColor = Color.Blue;
                ((TextBoxUsuario)control).PpEsTextoValido = true;

            }
            else
            {
                ((TextBoxUsuario)control).BorderColor = Color.Red;

                TextBoxUsuario.informarToolTip(control, "Caracter/es no permitido/s");

                ((TextBoxUsuario)control).PpEsTextoValido = false;

            }
        }

        static void ControlarFechaNacimiento(Control control)
        {
            

            string c = control.Text.ToString();
            int largoCadena = c.Length;
            List<int> listPosDig = new List<int>()
            {
                0, 1, 3, 4, 6, 7, 8, 9, 10
            };

            if (largoCadena == 10)
            {
                if (Char.IsDigit(c[0]) && Char.IsDigit(c[1]) && Char.IsDigit(c[3]) && Char.IsDigit(c[4]) &&
                    Char.IsDigit(c[6]) && Char.IsDigit(c[7]) && Char.IsDigit(c[8]) && Char.IsDigit(c[9]) &&
                    c[2].ToString() == "/" && c[5].ToString() == "/")
                {
                    int dias = int.Parse(c.Substring(0, 2));
                    int mes = int.Parse(c.Substring(3, 2));
                    int anio = int.Parse(c.Substring(6, 4));

                    if (esOkControlDia(dias, mes, anio) || esOkcontrolarAnio(anio) || esOkControlMes(mes))
                    {

                        ((TextBoxUsuario)control).BorderColor = Color.Blue;
                        ((TextBoxUsuario)control).PpEsTextoValido = true;
                    }

                }
            }
            else
            {

                ((TextBoxUsuario)control).BorderColor = Color.Red;

                TextBoxUsuario.informarToolTip(control, "Formato inválido: el formato correcto debe ser dd/mm/aaaa");
                ((TextBoxUsuario)control).PpEsTextoValido = false;
            }


        } // FIN ControlarFechaNacimiento

        static bool esOkcontrolarAnio(int anio)
        {

            if (anio <= DateTime.Today.Year && anio >= 1900)
            {
                return true;
            }

            
            return false;
        }

        static bool esOkControlMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                return true;
            }
            return false;
        }

        static bool esOkControlDia(int dias, int mes, int anio)
        {
            bool esOk = false;

            int cantDiasMes = DateTime.DaysInMonth(anio, mes);

            if (dias > 0 && dias <= cantDiasMes)
            {
                
                esOk = true;

                if (DateTime.IsLeapYear(anio) && mes == 2 && dias > 28)
                {
                    esOk = false;
                }
            }

            return esOk;
        }

        static bool esOkFormatoCadena(string cadena)
        {
            if (Char.IsDigit(cadena[0]) && Char.IsDigit(cadena[1]) && Char.IsDigit(cadena[3]) && Char.IsDigit(cadena[4])
                && Char.IsDigit(cadena[6]) && Char.IsDigit(cadena[7]) && Char.IsDigit(cadena[8]) && Char.IsDigit(cadena[9]))
            {
                return true;
            }
            return false;
        }


      


    }/// Fin TextBoxUsuario
}
