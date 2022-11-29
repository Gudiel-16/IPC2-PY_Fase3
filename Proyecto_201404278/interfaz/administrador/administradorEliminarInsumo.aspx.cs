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
    public partial class administradorEliminarInsumo : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btteliminar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text=="")
            {
                MessageBox.Show("DEBE INGRESAR CODIGO");
            }
            else
            {
                if (bd.validacion_codigo_insumo(Convert.ToInt32(txtCodigo.Text))>0)
                {
                    bd.eliminar_insumo(Convert.ToInt32(txtCodigo.Text));
                    MessageBox.Show("INSUMO ELIMINADO CON EXITO");
                }
                else
                {
                    MessageBox.Show("EL INSUMO NO EXISTE");
                }

            }


        }
    }
}