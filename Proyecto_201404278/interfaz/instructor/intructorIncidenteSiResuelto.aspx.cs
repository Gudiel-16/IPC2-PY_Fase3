using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_201404278.base_de_datos;

namespace Proyecto_201404278.interfaz
{
    public partial class intructorIncidenteSiResuelto : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            bd.mostrar_incidentesInsumo_siResuelto_en_instructor(gvInsumo, Session["Login"].ToString());
            bd.mostrar_incidentesSalon_siResuelto_en_instructor(gvSalon, Session["Login"].ToString());
        }
    }
}