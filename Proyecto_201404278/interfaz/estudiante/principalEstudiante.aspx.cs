using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Proyecto_201404278.base_de_datos;

namespace Proyecto_201404278.interfaz
{
    public partial class principalEstudiante : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            bd.mostrar_cursos_matriculados(GridView1, Session["Login"].ToString());
            lblCarnet.Text = Session["Login"].ToString();

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Calendar1.SelectedDate.Date.ToString("yyyy-MM-dd"));
        }
    }
}