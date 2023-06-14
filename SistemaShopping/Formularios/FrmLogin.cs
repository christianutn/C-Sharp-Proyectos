using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaShopping.Clases;
using SistemaShopping.Negocio;

namespace SistemaShopping.Formularios
{
    public partial class FrmLogin : Form
    {

        NegocioUsuario usuario = new NegocioUsuario();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Validar() == TextBoxUsuario.EsValidacion.incorrecta)
            {
                MessageBox.Show(txtUsuario.PpMensajeError);
                txtUsuario.Focus();
                return;
            }

            if (txtContrasenia.Validar() == TextBoxUsuario.EsValidacion.incorrecta)
            {
                MessageBox.Show(txtContrasenia.PpMensajeError);
                txtContrasenia.Focus();
                return;
            }

            if (usuario.ValidarLogin(txtUsuario.Text, txtContrasenia.Text) == NegocioUsuario.ResultadoLogin.noValido)
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos!!");
                txtUsuario.Clear();
                txtContrasenia.Clear();
                txtUsuario.Focus();
                return;
            }

            MessageBox.Show("Usuario y contraseña correctos!!");
            this.Dispose();

            // conexionBD _BD = new conexionBD();

            // DataTable clientes = _BD.EjecutarSelect("SELECT * FROM CLIENTES");
            // string tipoDoc;
            // string numeroDoc;
            // string codLocal;
            // string tipoFactura;
            // List<string> lista = new List<string>();
            // lista.Add("A");
            // lista.Add("B");
            // lista.Add("C");
            // string numeroFact;
            // string numeroTarjeta;
            // string numeroTarjeta1;
            // string numeroTarjeta2;
            // string numeroTarjeta3;
            // string numeroTarjeta4;
            // string sql;

            // Random random = new Random();

            //for (int i = 0; i < clientes.Rows.Count; i++)
            // {
            //     tipoDoc = clientes.Rows[i]["codTipoDoc"].ToString();
            //     numeroDoc = clientes.Rows[i]["numeroDoc"].ToString();
            //     codLocal = random.Next(11).ToString();
            //     tipoFactura = lista[random.Next(3)].ToString();
            //     numeroFact = random.Next(10000, 99999).ToString();
            //     numeroTarjeta1 = random.Next(1000, 9999).ToString();
            //     numeroTarjeta2 = random.Next(1000, 9999).ToString();
            //     numeroTarjeta3 = random.Next(1000, 9999).ToString();
            //     numeroTarjeta4 = random.Next(1000, 9999).ToString();
            //     numeroTarjeta = numeroTarjeta1 + numeroTarjeta2 + numeroTarjeta3 + numeroTarjeta4;


            //     sql = "INSERT INTO Facturas(codLocal, tipoFactura, nroFactura, tipoDoc, nroDoc, nroTarjeta) VALUES ('" + codLocal + "', '" + tipoFactura + "', '" + numeroFact + "', '" + tipoDoc + "', '" + numeroDoc + "', '" + numeroTarjeta + "')";

            //     _BD.Insertar(sql);
            // }






        }
    }
}
