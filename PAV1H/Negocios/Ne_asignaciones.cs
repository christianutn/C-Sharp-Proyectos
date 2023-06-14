using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1H.Clases;

namespace PAV1H.Negocios
{
    internal class Ne_asignaciones
    {
        BE_Acceso_Datos_T _BD = new BE_Acceso_Datos_T();
        public EstructuraComboBox datosCombo()
        {
            EstructuraComboBox edc = new EstructuraComboBox();

            //edc.Tabla =;
            edc.Value= "id_asignacion"; // 
            edc.Display = "n_asignacion";
            edc.sql = "SELECT * FROM asignaciones";
            edc.Tabla = _BD.EjecutarSelect(edc.sql);
            return edc;

        }

        public string RecuperarValor(string id)
        {

            return _BD.EjecutarSelect("SELECT monto FROM Asignaciones WHERE id_asignacion = " + id).Rows[0][0].ToString();
        }
    }
}
