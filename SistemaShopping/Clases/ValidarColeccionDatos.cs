using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaShopping.Clases
{
    internal class ValidarColeccionDatos
    {


        public enum Resultado { correcto, incorrecto };

        //public static Resultado Validar(Control.ControlCollection control)
        //{


        //    foreach (var item in control)
        //    {

        //        if (((TextBoxUsuario)item).PpEsTextoValido == false)
        //        {
        //            return Resultado.incorrecto;

        //        }

        //        if (((ComboBox01)item).SelectedIndex == -1)
        //        {
        //            return Resultado.incorrecto;

        //        }
        //    }

        //    return Resultado.correcto;


        //} 
        public static Resultado Validar(Control.ControlCollection control)
        {
         

            foreach (var item in control)
            {
                if (item.GetType().Name == "TextBoxUsuario")
                {
                    if (!((TextBoxUsuario)item).PpEsTextoValido) // (((TextBox01)item).Text -> Enmascarar. Como item puede ser cualquier objeto es necesario enmascararlo para que sea reconocido.
                    {
                      
                        ((TextBoxUsuario)item).Focus();
                        return Resultado.incorrecto;
                    }

                    if (((TextBoxUsuario)item).PpCampoSql == "numeroDoc")
                    {
                        if (((TextBoxUsuario)item).Text != "")
                        {
                            //esTxtVacio = false;
                        }
                    }

                }
                else if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).PpNombreTabla == "TipoDocumento" && ((ComboBox01)item).SelectedIndex == -1)
                    {
                        return Resultado.incorrecto;
                    }
                    else if (((ComboBox01)item).PpNombreTabla == "TipoDocumento" && ((ComboBox01)item).SelectedIndex != -1)
                    {
                        //esCmbSeleccionado = true;
                    }

                    if (((ComboBox01)item).Text != "" && ((ComboBox01)item).SelectedValue == null)
                    {
                        return Resultado.incorrecto;
                    }

                }


            }

            //if (esTxtVacio != esCmbSeleccionado)
            //{
            //    return Resultado.incorrecto;
            //}

            return Resultado.correcto;
        }






    }
}
