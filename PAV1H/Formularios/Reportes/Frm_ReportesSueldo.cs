using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PAV1H.Negocios;

namespace PAV1H.Formularios.Reportes
{
    public partial class Frm_ReportesSueldo : Form
    {
        public Frm_ReportesSueldo()
        {
            InitializeComponent();
            
        }

        private void Frm_ReportesSueldo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.Rv03.RefreshReport();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            CalcularDatosUsuarios();
        }

        private void CalcularDatosUsuarios()
        {
            DataTable tabla = new DataTable();
            NE_usuarios usuarios = new NE_usuarios();

            if (rbInicieLetra.Checked == true)
            {
                tabla = usuarios.ReportesUsuariosInicieLetra(txt_letras.Text);
                ArmarReporteUsuario01(tabla);
            }
            
            if (rbTodos.Checked == true)
            {
                tabla = usuarios.ReportesUsuariosXtodos();
                ArmarReporteUsuario01(tabla);
                
            }

            if (rbContengaLetra.Checked == true)
            {
                tabla = usuarios.ReportesUsuariosConLetra(txt_letras.Text);
                ArmarReporteUsuario01(tabla);
            }
        }

        private void ArmarReporteUsuario01(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla) ;
            Rv03.LocalReport.ReportEmbeddedResource = "PAV1H.Formularios.Reportes.ReporteUsuario02.rdlc";
            Rv03.LocalReport.DataSources.Clear();
            Rv03.LocalReport.DataSources.Add(PaqueteDatos);
            Rv03.RefreshReport();
        }
    }
}
