using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using SistemaShopping.Clases;

namespace SistemaShopping.Formularios.Clientes
{
    public partial class FrmDetalleFactura : Form
    {

        public static string PpNumeroTarj { get; set; }

        conexionBD _BD = new conexionBD();
        public FrmDetalleFactura()
        {
            
            InitializeComponent();
        }

        private void FrmDetalleFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaShoppingDataSet.Facturas' Puede moverla o quitarla según sea necesario.


           /* this.facturasTableAdapter.Fill(this.sistemaShoppingDataSet.Facturas);*/ // SE elimina ya que se cargar en el load del reporte

            this.rptFactura.RefreshReport();

        }

        private void rptFactura_Load(object sender, EventArgs e)
        {
            //Creamos una tabla donde guardaremos la información.
            string sqlEncabezado = "SELECT [codLocal], [tipoFactura], [nroFactura], [tipoDoc], [nroDoc], [nroTarjeta]  FROM [dbo].[Facturas]  WHERE nroTarjeta = '" + PpNumeroTarj + "'";
            DataTable dt = new DataTable();

            dt = _BD.EjecutarSelect(sqlEncabezado);

            // Creamos un objeto del tipo DataSource. El cual recibe dos parámetros. En el SEGUNDO le debemos indicar donde esta contenido contenido los datos, y esos
            // datos están en nuestro ejemplo contenidos en la tabla. En el primer parámetro debemos indicar a quien le queremos setear los datos de la tabla, en nuestro ejemplo
            // será a DS_detalleFactura"

            ReportDataSource ds = new ReportDataSource("DS_detalleFactura", dt);

            // Limpiamos al report
            rptFactura.LocalReport.DataSources.Clear();

            // Le cargamos el objeto del tipo ReportDAtaSource ds.
            rptFactura.LocalReport.DataSources.Add(ds);

            // Para que los datos se visualicen colocamos

            rptFactura.LocalReport.Refresh();
            
            
            
            
            this.facturasTableAdapter.Fill(this.sistemaShoppingDataSet.Facturas);
        }
    }
}
