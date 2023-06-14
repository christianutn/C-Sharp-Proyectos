using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaShopping.Clases
{
    internal class GrillaClientes
    {
        public static void Cargar(DataTable tabla, DataGridView nombreGrilla)
        {
            nombreGrilla.Rows.Clear();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                nombreGrilla.Rows.Add();
                nombreGrilla.Rows[i].Cells[0].Value = tabla.Rows[i]["descTipoDoc"].ToString();
                nombreGrilla.Rows[i].Cells[1].Value = tabla.Rows[i]["numeroDoc"].ToString();
                nombreGrilla.Rows[i].Cells[2].Value = tabla.Rows[i]["nombres"].ToString();
                nombreGrilla.Rows[i].Cells[3].Value = tabla.Rows[i]["apellido"].ToString();
                nombreGrilla.Rows[i].Cells[4].Value = tabla.Rows[i]["descSexo"].ToString();
                nombreGrilla.Rows[i].Cells[5].Value = tabla.Rows[i]["descEstadoCivil"].ToString();
            }
           
           
        }
        
        
    }
}
