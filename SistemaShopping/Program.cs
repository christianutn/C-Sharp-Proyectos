using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaShopping.Clases;
using SistemaShopping.Formularios;
using SistemaShopping.Formularios.Clientes;

namespace SistemaShopping
{
    internal static class Program
    {
        
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmPrincipal());

            //Application.Run(new FrmLogin());

            //Application.Run(new FrmBuscarClientes());
            //Application.Run(new FrmAgregarClientes
            Application.Run(new FrmCompras());

        }








    }



}
