using SistemaShopping.Clases;
using SistemaShopping.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaShopping.Formularios.Clientes
{
    public partial class FrmCompras : Form
    {
        
        public FrmCompras()
        {
            InitializeComponent();
        }

        

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            
            if (cmbTipoFactura.SelectedValue == null)
            {
                NegocioUsuario.PpCodTipoFact = "";
            }
            else
            {
                NegocioUsuario.PpCodTipoFact = cmbTipoFactura.SelectedValue.ToString();
            }
            if (cmbTipoDoc.SelectedValue == null)
            {
                NegocioUsuario.PpCodTipoDoc = "";
            }
            else
            {
                NegocioUsuario.PpCodTipoDoc = cmbTipoDoc.SelectedValue.ToString();
            }

            NegocioUsuario.PpNumeroFact = txtNumeroFact.Text;
          
            NegocioUsuario.PpNroDoc = txtNumeroDoc.Text;
            NegocioUsuario.PpCodLocal = txtCodigoLoc.Text;
            NegocioUsuario.PpNumeroTarj = txtNumeroTarj.Text;

            NegocioUsuario.CompletarGrillaFrmCompras(gridCompras);

        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.CargarCombo();
            cmbTipoFactura.CargarCombo();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {

            NegocioUsuario.PpCodTipoFact = "";

            NegocioUsuario.PpCodTipoFact = "";

            NegocioUsuario.PpCodTipoDoc = "";
            NegocioUsuario.PpNumeroFact = "";

            NegocioUsuario.PpNroDoc = "";
            NegocioUsuario.PpCodLocal = "";
            NegocioUsuario.PpNumeroTarj = "";
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            FrmDetalleFactura rpt = new FrmDetalleFactura();

            string numeroTarjeta = "";
          

            if (gridCompras.RowCount > 0)
            {
                numeroTarjeta = gridCompras.CurrentRow.Cells["numeroTarj"].Value.ToString();
                gridCompras.CurrentRow.Cells[5].Value.ToString();
            }
            

            FrmDetalleFactura.PpNumeroTarj = numeroTarjeta;

            rpt.ShowDialog();
        }
    }
}
