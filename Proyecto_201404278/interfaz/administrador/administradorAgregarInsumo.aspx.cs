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
    public partial class administradorAgregarInsumo : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttbuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text!="")
            {
                bd.insertar_insumo(txtNombre.Text, rolEstado.Value.ToString());
                MessageBox.Show("INSUMO AGREGADO CON EXITO");
            }
            else
            {
                MessageBox.Show("Debe Agregar Nombre");
            }
        }
    }
}