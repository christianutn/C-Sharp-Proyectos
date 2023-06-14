using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; // Lo agrego para poder heredar de la clase FORM

namespace PAV1H.Clases
{
    internal class ComboBox01 : ComboBox // heredo las propiedades de ComboBox(Clase que se utiliza para la creación de los ComboBox)
    {
        public string Pp_Pk { get; set; }
        public string Pp_nombre { get; set; }
        public string Pp_tabla { get; set; }

        public bool Pp_validable { get; set; }

        public string Pp_mensajeError { get; set; }

        public string Pp_campo { get; set; }

        BE_Acceso_Datos _BD = new BE_Acceso_Datos();

        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_Pk + ", " + Pp_nombre + " FROM " + Pp_tabla;

            this.DisplayMember = Pp_nombre;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.Ejecutar_select(sql);
        }

        public void CargarCombo(EstructuraComboBox edc)
        {
            this.DisplayMember = edc.Display;
            this.ValueMember = edc.Value;
            this.DataSource = edc.Tabla;
        }
    }
}
