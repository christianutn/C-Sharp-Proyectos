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
    public partial class FrmAgregarClientes : Form
    {
        public FrmAgregarClientes()
        {
            InitializeComponent();
        }

        private void FrmAgregarClientes_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.CargarCombo();

            cmbProvincias.CargarCombo();
            
            
            cmbSexos.CargarCombo();

            cmbEstadosCiviles.CargarCombo();
   
        }

      

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarColeccionDatos.Validar(this.Controls) == ValidarColeccionDatos.Resultado.correcto)
            {

               
                if (NegocioUsuario.insertar(this.Controls, "Clientes") == NegocioUsuario.ResultadoAgregar.valido)
                {
                    MessageBox.Show("Cliente agregado de forma exitosa!!");
                }
                else
                {
                    MessageBox.Show("!!");
                }
                
                
               
                
            }
            else
            {
                MessageBox.Show("Campos incorrectos");
            }

            
        } // Fin btnAgregar

        private void txtGeneral_TextChanged(object sender, EventArgs e)
        {

            TextBoxUsuario.ControlarTexto(txtNombres);
            TextBoxUsuario.ControlarTexto(txtApellido);
            TextBoxUsuario.ControlarTexto(txtNroDoc);
            TextBoxUsuario.ControlarTexto(txtDireccion);
            TextBoxUsuario.ControlarTexto(txtFechaNacimiento);

         
        }

        private void cmbProvincias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbProvincias.SelectedIndex != -1)
            {
                cmbLocalidades.CargarComboLocalidades(cmbProvincias.SelectedValue.ToString());

            }

            ComboBox01.ControlarCmb(cmbProvincias);


        }

        private void cmbProvincias_TextChanged(object sender, EventArgs e)
        {
            ComboBox01.ControlarCmb(cmbProvincias);
            ComboBox01.ControlarCmb(cmbLocalidades);
            ComboBox01.ControlarCmb(cmbEstadosCiviles);
            ComboBox01.ControlarCmb(cmbSexos);
            ComboBox01.ControlarCmb(cmbTipoDoc);
        }
    }  
       
}
