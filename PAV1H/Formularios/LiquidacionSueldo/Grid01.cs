using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1H.Formularios.LiquidacionSueldo
{
    internal class Grid01 : DataGridView
    {
        /// <summary>
        /// Esta funcion permite formartear el objeto tipo DataGrigView. De la siguiente forma (textoCabecera, ancho;...textoCabeceara, ancho)
        /// </summary>
        /// <param name="formato"></param>
        public void Formatear (string formato)
        {

  

            // textoCabecera, ancho; textoCabecero, ancho ....

            string[] datos_columna = formato.Split(';');

            // int cantidadColumna = datos_columna.Length;

            for (int i = 0; i < datos_columna.Length; i++)
            {
                string[] datos = datos_columna[i].Split(',');

                this.Columns.Add("columna" + i.ToString(), datos[0].ToString());

                this.Columns[i].Width = int.Parse(datos[1].ToString());
            }
        }
    }
}
