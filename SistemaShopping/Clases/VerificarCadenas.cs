using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaShopping.Clases
{
    internal class VerificarCadenas
    {
      
        public enum Resultado { correcto, incorrecto }


      


        public static (Resultado, object) Validar(Object item)
        {


            if (((TextBoxUsuario)item).GetType().Name == "TextBoxUsuario")
                if (item.GetType().Name == "TextBoxUsuario")
                {
                    //if (((TextBoxUsuario)item).PpEsNombreOapellido == true)
                    string cadena = ((TextBoxUsuario)item).Text.ToString().Trim();

                    for (int i = 0; i < cadena.Length; i++)
                    {
                        if (((TextBoxUsuario)item).PpEsNombreOapellido == true)
                        {
                            //if (Char.IsLetter(cadena[i]) == false && cadena[i].ToString() != " ")
                            if (Char.IsLetter(cadena, i) == false && Char.IsWhiteSpace(cadena, i) == false)
                            {
                                return (Resultado.incorrecto, item);
                            }
                        }
                        else if (((TextBoxUsuario)item).PpEsDocumento == true)
                        {
                            if (Char.IsDigit(cadena[i]) == false)
                            {
                                return (Resultado.incorrecto, item);
                            }
                        }
                        else if (((TextBoxUsuario)item).PpEsDireccion == true)
                        {
                            if (Char.IsLetterOrDigit(cadena[i]) == false && Char.IsWhiteSpace(cadena, i) == false)
                            {
                                return (Resultado.incorrecto, item);
                            }
                        }
                    }

                } /// Fin if TextBox



            return (Resultado.incorrecto, item);
        }
    }
}
            





