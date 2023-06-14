using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1H.Clases;
using static PAV1H.Clases.BE_Acceso_Datos_T;

namespace PAV1H.ZonaPrueba
{
    public partial class Frm_PruebaTransaccion : Form
    {
        public Frm_PruebaTransaccion()
        {
            InitializeComponent();
        }
        BE_Acceso_Datos_T _BD = new BE_Acceso_Datos_T();
        private void CargarGrilla()
        {
            Grid01.DataSource = _BD.EjecutarSelect("SELECT * FROM Estado");

        }

        private void Frm_PruebaTransaccion_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btn_inicioTransaccio_Click(object sender, EventArgs e)
        {
            _BD.InicioTransaccion();

            // inicio de transacción:

            //ControlTransaccion = EstadoTransaccion.correcto;

            //ControlConexion = TipoConexion.transaccion;

            CargarGrilla();
        }

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO Estado (nombre) VALUES ('" + txt_nombreEstado.Text + "')";

            _BD.Insertar(sqlInsert);
            CargarGrilla();

        }

        private void btn_generarError_Click(object sender, EventArgs e)
        {
            string sqlInsert = "INSERT INTO Estado (id_estado, nombre) VALUES (" + "1, '"  + txt_nombreEstado.Text + "')";

            _BD.Insertar(sqlInsert);
            CargarGrilla();

        }

        private void btn_finalizarTransaccion_Click(object sender, EventArgs e)
        {
            _BD.FinalTransaccion();
            CargarGrilla();
        }

        private void btn_modificarEstado_Click(object sender, EventArgs e)
        {
            string sqlModificar = "UPDATE Estado SET nombre='" + txt_ModificarEstado.Text + "' WHERE id_estado=" + Grid01.CurrentRow.Cells[0].Value.ToString();
            _BD.Modificar(sqlModificar);
            CargarGrilla();

        }

        private void Grid01_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ModificarEstado.Text = Grid01.CurrentRow.Cells[1].Value.ToString();
            txt_borrar.Text = Grid01.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            string sqlBorrar = "DELETE FROM Estado WHERE id_estado = " + Grid01.CurrentRow.Cells[0].Value.ToString();
            _BD.Borrar(sqlBorrar);
            CargarGrilla();
        }
    }
}
