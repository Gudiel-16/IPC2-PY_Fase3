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
    public partial class instructorCrearCuestionario : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttRegistrar_Click(object sender, EventArgs e)
        {
            if (txtcodigocurso.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO DE CURSO!");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtcodigocurso.Text)>0)
                {
                    bd.insertar_cuestionario(txtcodigocurso.Text, txtpregunta1.Text, txtpregunta2.Text, txtpregunta3.Text, txtpregunta4.Text, txtpregunta5.Text);
                }
                else
                {
                    MessageBox.Show("CURSO NO EXISTE!");
                }
            }
        }
    }
}