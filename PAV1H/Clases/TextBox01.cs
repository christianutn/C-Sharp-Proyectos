using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAV1H.Clases
{
    internal class TextBox01 : TextBox
    {

        public string Pp_tabla { get; set; }
        public string Pp_campo { get; set; }
        public bool Pp_validable { get; set; }

        public string Pp_mensajeError { get; set; }



    }
}
