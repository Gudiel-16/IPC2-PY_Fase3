﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto_201404278.base_de_datos;

namespace Proyecto_201404278.interfaz
{
    public partial class estudianteIncidenteSiResuelto : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {
            bd.mostrar_incidentesInsumo_en_estudiante_si_resuelto(gvestudianteInsumo, Session["Login"].ToString());
        }
    }
}