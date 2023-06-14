using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAV1H.Clases
{
    internal class EstructuraComboBox
    {
        public string Display { get; set; }
        public string Value { get; set; }
        public string sql { get; set; }
        public DataTable Tabla { get; set; }
    }
}
