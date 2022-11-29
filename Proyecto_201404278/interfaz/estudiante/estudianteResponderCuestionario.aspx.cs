using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_201404278.base_de_datos; //llamada de la clase conexion 
using System.Windows.Forms;

namespace Proyecto_201404278.interfaz
{
    public partial class estudianteResponderCuestionario : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos(); //se crea un objeto de la clase conexion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttBuscar_Click(object sender, EventArgs e)//evento del boton buscar
        {
            if (txtCodigoCurso.Text=="")//si hay campos vacios
            {
                MessageBox.Show("INGRESE CODIGO DE CURSO");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtCodigoCurso.Text)>0)//para validar que el curso exista
                {
                    bd.llenar_label_cuestionario(txtCodigoCurso.Text, Label1, Label2, Label3, Label4, Label5);//me llena los label con las preguntas
                }
                else
                {
                    MessageBox.Show("CURSO NO EXISTE");

                }
            }
        }

        protected void bttRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCurso.Text == "")
            {
                MessageBox.Show("INGRESE CODIGO DE CURSO");
            }
            else
            {
                if (bd.validacion_codigo_curso(txtCodigoCurso.Text) > 0)
                {
                    bd.insertar_respuesta_cuestionario(txtCodigoCurso.Text, txtpregunta1.Text, txtpregunta2.Text, txtpregunta3.Text, txtpregunta4.Text, txtpregunta5.Text, Session["Login"].ToString());
                }
                else
                {
                    MessageBox.Show("CURSO NO EXISTE");
                }
            }
        }
    }
}