using PAV1H.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PAV1H.Negocios
{
    internal class NE_descuentos
    {
        BE_Acceso_Datos_T _BD = new BE_Acceso_Datos_T();
        public EstructuraComboBox datosCombo()
        {
            EstructuraComboBox edc = new EstructuraComboBox();

            //edc.Tabla =;
            edc.Value = "id_descuento"; // 
            edc.Display = "n_descuento";
            edc.sql = "SELECT * FROM Descuentos";
            edc.Tabla = _BD.EjecutarSelect(edc.sql);
            return edc;

        }

        public string RecuperarValor(string id)
        {

            return _BD.EjecutarSelect("SELECT monto FROM Descuentos WHERE id_descuento = " + id).Rows[0][0].ToString();
        }

    }
}
