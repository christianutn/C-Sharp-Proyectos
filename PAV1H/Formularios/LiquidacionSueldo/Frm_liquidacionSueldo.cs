using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1H.Negocios;
using PAV1H.Clases;

namespace PAV1H.Formularios.LiquidacionSueldo
{
    public partial class Frm_liquidacionSueldo : Form
    {

        Ne_asignaciones asigna = new Ne_asignaciones();
        NE_descuentos desc = new NE_descuentos();
        NE_usuarios usuarios = new NE_usuarios();
        public Frm_liquidacionSueldo()
        {
            InitializeComponent();
        }

        private void Frm_liquidacionSueldo_Load(object sender, EventArgs e)
        {
            grid_asignaciones.Formatear("Id,50;Nombre,200;Cantidad,75;Valor,100");

            grid_descuentos.Formatear("Id,50;Nombre,200;Cantidad,75;Valor,100");

            cmb_asignaciones.CargarCombo(asigna.datosCombo());

            cmb_descuentos.CargarCombo(desc.datosCombo());

            
        }

        private void btn_agregarAsigna_Click(object sender, EventArgs e)
        {
            grid_asignaciones.Rows.Add(
            cmb_asignaciones.SelectedValue.ToString(),
            cmb_asignaciones.Text,
            txt_cantidadAsigna.Text,
            asigna.RecuperarValor(cmb_asignaciones.SelectedValue.ToString()));
            //txt_sueldoNeto.Text = CalcularNeto();
            //MessageBox.Show(grid_asignaciones.Rows[0].Cells[3].Value.ToString());
            //MessageBox.Show(grid_asignaciones.Rows[0].Cells[2].Value.ToString());

            //float a = float.Parse(grid_asignaciones.Rows[0].Cells[3].Value.ToString());
            ////int b = int.Parse(grid_asignaciones.Rows[0].Cells[2].Value.ToString());
            //float b = float.Parse(grid_asignaciones.Rows[0].Cells[2].Value.ToString());
            //MessageBox.Show((a * b).ToString());

            txt_sueldoNeto.Text = CalcularNeto();


        }

        private void cmb_asignaciones_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // txt_valorAsigna.Text = CompletarNumero(asigna.RecuperarValor(cmb_asignaciones.SelectedValue.ToString()), "999999,99");
            txt_valorAsignaciones.Text = asigna.RecuperarValor(cmb_asignaciones.SelectedValue.ToString()).PadLeft(9, ' ');


        }

        // mascara = 999999,99
        // numero = 999,9
        //public string CompletarNumero (string numero, string mascara)
        //{
        //    int comaNumero = numero.IndexOf(',', 0);
        //    int comaMascara = mascara.IndexOf(',', 0);
        //    //string numeroDevolver = "";

        //    if (comaMascara > comaNumero)
        //    {
        //        //for (int i = 0; i < (comaMascara-comaNumero); i++)
        //        //{
        //        //    numeroDevolver += "0";
        //        //}
        //        numero = numero.PadLeft(comaMascara+3, ' ');

        //    }

        //    return numero;
        //}

        private void btn_AgregarDescuentos_Click(object sender, EventArgs e)
        {
            //grid_descuentos.Rows.Add(
            //cmb_descuentos.SelectedValue.ToString(),
            //cmb_descuentos.Text,
            //txt_cantidadDescuento,
            //desc.RecuperarValor(cmb_descuentos.SelectedValue.ToString()));

            grid_descuentos.Rows.Add(
            cmb_descuentos.SelectedValue.ToString(),
            cmb_descuentos.Text,
            txt_cantidadDescuento.Text,
            desc.RecuperarValor(cmb_descuentos.SelectedValue.ToString()));

            //MessageBox.Show(grid_descuentos.Rows[0].Cells[3].Value.ToString());
            //MessageBox.Show(grid_descuentos.Rows[0].Cells[2].Value.ToString());

            //float a = float.Parse(grid_descuentos.Rows[0].Cells[3].Value.ToString());
            ////int b = int.Parse(grid_asignaciones.Rows[0].Cells[2].Value.ToString());
            //float b = float.Parse(grid_descuentos.Rows[0].Cells[2].Value.ToString());
            //MessageBox.Show((a * b).ToString());

            txt_sueldoNeto.Text = CalcularNeto();



        }

        private void cmb_descuentos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_valorDescuentos.Text = asigna.RecuperarValor(cmb_asignaciones.SelectedValue.ToString()).PadLeft(9, ' ');
        }

        private void btn_buscarFormulario_Click(object sender, EventArgs e)
        {
            if (txt_id_usuario.Text != "")
            {
                DataTable tabla = new DataTable();

                tabla = usuarios.RecuperarXidUsuario(txt_id_usuario.Text);
                LlenarDatosPantalla(tabla);
                
            }
        }

        private void LlenarDatosPantalla (DataTable tabla)
        {
            txt_id_usuario.Text = tabla.Rows[0]["id_usuario"].ToString();
            txt_n_usuario.Text = tabla.Rows[0]["n_usuario"].ToString();
            txt_perfil.Text = tabla.Rows[0]["perfil"].ToString();
            txt_nombres.Text = tabla.Rows[0]["nombres"].ToString();
            txt_apellido.Text = tabla.Rows[0]["apellido"].ToString();
            txt_cuil.Text = tabla.Rows[0]["cuil"].ToString();


        }

        private void btn_fecha_Click(object sender, EventArgs e)
        {
            Tratamientos_especiales fecha = new Tratamientos_especiales();

            txt_fecha.Text = fecha.RecuperarFecha();
        }

        private string CalcularNeto()
        {
            double calculo = double.Parse("0");
            

            for (int i = 1; i < grid_asignaciones.Rows.Count; i++)
            {
                //MessageBox.Show(grid_asignaciones.Rows[0].Cells[3].Value.ToString());
                //MessageBox.Show(grid_asignaciones.Rows[0].Cells[2].Value.ToString());

               
                //string valor = grid_asignaciones.Rows[i-1].Cells[2].Value.ToString();
                
                //string cantidad = grid_asignaciones.Rows[i-1].Cells[3].Value.ToString();

                calculo += double.Parse(grid_asignaciones.Rows[i-1].Cells[2].Value.ToString()) *
                           double.Parse(grid_asignaciones.Rows[i-1].Cells[3].Value.ToString());

            }

            for (int i = 1; i < grid_descuentos.Rows.Count; i++)
            {
                
                calculo -= double.Parse(grid_descuentos.Rows[i - 1].Cells[2].Value.ToString()) *
                           double.Parse(grid_descuentos.Rows[i - 1].Cells[3].Value.ToString());
            }

            return (calculo + double.Parse(txt_sueldBruto.Text)).ToString();
        }
    }
}
