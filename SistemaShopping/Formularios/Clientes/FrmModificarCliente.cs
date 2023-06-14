using SistemaShopping.Clases;
using SistemaShopping.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SistemaShopping.Formularios.Clientes
{
    public partial class FrmModificarCliente : Form
    {
        public FrmModificarCliente()
        {
            InitializeComponent();
        }

        private void FrmAgregarClientes_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.CargarCombo();
            cmbTipoDoc.SelectedValue = cmbTipoDoc.PpSelectedIndex;

            cmbProvincias.CargarCombo();
            cmbProvincias.SelectedValue = NegocioUsuario.BuscarCodProvincia(cmbLocalidades.PpSelectedIndex.ToString());
            cmbLocalidades.SelectedValue = cmbLocalidades.PpSelectedIndex;



            cmbSexos.CargarCombo();
            cmbSexos.SelectedValue = cmbSexos.PpSelectedIndex;
            

            cmbEstadosCiviles.CargarCombo();
            cmbEstadosCiviles.SelectedValue = cmbEstadosCiviles.PpSelectedIndex;

        }

        private void cmbProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProvincias.SelectedIndex != -1)
            {
                cmbLocalidades.CargarComboLocalidades(cmbProvincias.SelectedValue.ToString());

            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {

        } // Fin btnAgregar

        private void txtGeneral_TextChanged(object sender, EventArgs e)
        {

            TextBoxUsuario.ControlarTexto(txtNombres);
            TextBoxUsuario.ControlarTexto(txtApellido);
            TextBoxUsuario.ControlarTexto(txtNroDoc);
            TextBoxUsuario.ControlarTexto(txtDireccion);
            TextBoxUsuario.ControlarTexto(txtFechaNacimiento);

        }

        private void cmbTipoDoc_TextChanged(object sender, EventArgs e)
        {
            ComboBox01.ControlarCmb(cmbProvincias);
            ComboBox01.ControlarCmb(cmbLocalidades);
            ComboBox01.ControlarCmb(cmbEstadosCiviles);
            ComboBox01.ControlarCmb(cmbSexos);
            ComboBox01.ControlarCmb(cmbTipoDoc);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            

            NegocioUsuario.PpCodTipoDoc = cmbTipoDoc.SelectedValue.ToString();
            NegocioUsuario.PpNroDoc = txtNroDoc.Text;
            NegocioUsuario.PpNombres = txtNombres.Text;
            NegocioUsuario.PpApellido = txtApellido.Text;
            NegocioUsuario.PpCodProvincia = cmbProvincias.SelectedValue.ToString();
            NegocioUsuario.PpCodPostal = cmbLocalidades.SelectedValue.ToString();
            NegocioUsuario.PpCodSexo = cmbSexos.SelectedValue.ToString();
            NegocioUsuario.PpCodEstadoCivil = cmbEstadosCiviles.SelectedValue.ToString();
            NegocioUsuario.PpDireccion = txtDireccion.Text;


            if (NegocioUsuario.ModificarDatosClientes() == NegocioUsuario.Resultado.correcto)
            {
                MessageBox.Show("Los datos fueron modificados con éxito!!!");
                this.Dispose();
            }


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            //FrmModificarCliente frm = new FrmModificarCliente();    
            //frm.ShowDialog();
        }
    }  
       
}
