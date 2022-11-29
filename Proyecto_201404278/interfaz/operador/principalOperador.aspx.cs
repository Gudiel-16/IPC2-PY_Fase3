using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_201404278.base_de_datos;

namespace Proyecto_201404278.interfaz
{
    public partial class principalOperador1 : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            bd.mostrar_reservas_principal_admin_operador_general(GridView1, Session["Login"].ToString());
            lblCarnet.Text = Session["Login"].ToString();
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Calendar1.SelectedDate.Date.ToString("yyyy-MM-dd"));
            bd.mostrar_reservas_principal_admin_operador_por_fecha(GridView1, Calendar1.SelectedDate.Date.ToString("yyyy-MM-dd"));
        }

    }
}