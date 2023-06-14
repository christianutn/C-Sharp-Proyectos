using SistemaShopping.Clases;
using SistemaShopping.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SistemaShopping.Formularios.Clientes
{
    public partial class FrmBuscarClientes : Form
    {
        public FrmBuscarClientes()
        {
            InitializeComponent();
        }

        private void FrmBuscarClientes_Load(object sender, EventArgs e)
        {
           

            cmbTipoDoc.CargarCombo();
            cmbTipoDoc.SelectedIndex = -1;
           
          

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            GrillaClientes.Cargar(BuscarFiltros.Buscar(cmbTipoDoc.Text.ToString(), 
                txtNroDoc.Text.ToString(), txtNombres.Text.ToString(), txtApellido.Text.ToString()), gridClientes);



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarClientes agregarCliente = new FrmAgregarClientes();
            agregarCliente.ShowDialog();
        }

        private void gridClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmModificarCliente modificarCliente = new FrmModificarCliente();

            
            string nroDocCliente = gridClientes.CurrentRow.Cells["numeroDoc"].Value.ToString();
            string codTipoDoc = gridClientes.CurrentRow.Cells["codTipoDoc"].Value.ToString();
            //MessageBox.Show("PRobandp " + gridClientes.CurrentRow.Cells["codTipoDoc"]);
            


            NegocioUsuario.CargarFormulario(nroDocCliente, "Clientes", modificarCliente.Controls);

            modificarCliente.ShowDialog();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {


            FrmEliminarCliente eliminarCliente = new FrmEliminarCliente();


            string nroDocCliente = gridClientes.CurrentRow.Cells["numeroDoc"].Value.ToString();
            string codTipoDoc = gridClientes.CurrentRow.Cells["codTipoDoc"].Value.ToString();
            //MessageBox.Show("PRobandp " + gridClientes.CurrentRow.Cells["codTipoDoc"]);



            NegocioUsuario.CargarFormulario(nroDocCliente, "Clientes", eliminarCliente.Controls);

            eliminarCliente.ShowDialog();
        }
    }
}
