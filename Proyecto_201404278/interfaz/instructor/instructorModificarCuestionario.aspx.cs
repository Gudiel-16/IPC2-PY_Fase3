using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_201404278.base_de_datos;
using System.Windows.Forms;

namespace Proyecto_201404278.interfaz
{
    public partial class instructorModificarCuestionario : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void bttBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigobuscar.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO A BUSCAR");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtCodigobuscar.Text)>0)
                {
                    bd.llenar_TextBox_cuestionario(txtCodigobuscar.Text, txtpregunta1, txtpregunta2, txtpregunta3, txtpregunta4, txtpregunta5);
                }
                else
                {
                    MessageBox.Show("CURSO NO EXISTE");
                }
            }
        }

        protected void bttmodificar_Click(object sender, EventArgs e)
        {
            if (txtCodigobuscar.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO A BUSCAR");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtCodigobuscar.Text) > 0)
                {
                    bd.actualizar_cuestionario(txtCodigobuscar.Text, txtpregunta1.Text, txtpregunta2.Text, txtpregunta3.Text, txtpregunta4.Text, txtpregunta5.Text);
                    MessageBox.Show("CUESTIONARIO ACTUALIZADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("CURSO NO EXISTE");
                }
            }
        }

        protected void btteliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigobuscar.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO A BUSCAR");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtCodigobuscar.Text) > 0)
                {
                    bd.eliminar_cuestionario(txtCodigobuscar.Text);
                    MessageBox.Show("CUESTIONARIO ELIMINADO CON EXITO");

                }
                else
                {
                    MessageBox.Show("CURSO NO EXISTE");
                }
            }
        }

    }
}