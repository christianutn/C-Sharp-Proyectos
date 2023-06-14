using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1H.Formularios.LiquidacionSueldo;
using PAV1H.Formularios.Reportes;
using PAV1H.Formularios.Usuarios;
using PAV1H.Negocios;
using PAV1H.ZonaPrueba;


namespace PAV1H
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           
            //Application.Run(new Frm_Escritorio());
            //Application.Run(new Frm_ABM_Usuarios());
            // Application.Run(new Frm_AltasUsuarios());
            //Application.Run(new Frm_PruebaTransaccion());
            //Application.Run(new Frm_liquidacionSueldo());
            Application.Run(new Frm_ReportesSueldo());






        }
    }
}
