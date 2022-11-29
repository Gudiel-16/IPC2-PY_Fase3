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
    public partial class operadorModificarIncidente : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttBuscar_Click(object sender, EventArgs e)
        {
            if (txtCodigobuscar.Text == "")
            {
                MessageBox.Show("HAY CAMPOS VACIOS");
            }
            else
            {
                if (rolUsuario.Value.ToString() == "Instructor" && rolTipo.Value.ToString() == "Salon")
                {
                    if (bd.validacion_codigo_incidente_salon(Convert.ToInt32(txtCodigobuscar.Text)) > 0)
                    {
                        bd.llenar_TextBox_incidente_salon(Convert.ToInt32(txtCodigobuscar.Text), txtDescripcion, txtResuelto, txtFecha, txtHora, txtcarnetUsuario, txtCodigoInsumoSalon);
                        txtCodigobuscar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("INCIDENTE NO EXISTE");
                    }
                }
                else if (rolUsuario.Value.ToString() == "Instructor" && rolTipo.Value.ToString() == "Insumo")
                {
                    if (bd.validacion_codigo_incidente_prestamo_instructor(Convert.ToInt32(txtCodigobuscar.Text)) > 0)
                    {
                        bd.llenar_TextBox_incidente_prestamo_instructor(Convert.ToInt32(txtCodigobuscar.Text), txtDescripcion, txtResuelto, txtFecha, txtHora, txtcarnetUsuario, txtCodigoInsumoSalon);
                        txtCodigobuscar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("INCIDENTE NO EXISTE");
                    }
                }
                else if (rolUsuario.Value.ToString() == "Estudiante" && rolTipo.Value.ToString() == "Insumo")
                {
                    if (bd.validacion_codigo_incidente_prestamo_estudiante(Convert.ToInt32(txtCodigobuscar.Text)) > 0)
                    {
                        bd.llenar_TextBox_incidente_prestamo_estudiante(Convert.ToInt32(txtCodigobuscar.Text), txtDescripcion, txtResuelto, txtFecha, txtHora, txtcarnetUsuario, txtCodigoInsumoSalon);
                        txtCodigobuscar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("INCIDENTE NO EXISTE");
                    }
                }
                else if (rolUsuario.Value.ToString() == "Estudiante" && rolTipo.Value.ToString() == "Salon")
                {
                    MessageBox.Show("NO PUEDE SELECCIONAR ESTUDIANTE Y SALON");
                }
            }
        }

        protected void bttModificar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("DEBE INGRESAR DESCRIPCION PARA ACTUALIZAR");
            }
            else
            {
                if (rolUsuario.Value.ToString() == "Instructor" && rolTipo.Value.ToString() == "Salon")
                {
                    bd.actualizar_incidente_salon(Convert.ToInt32(txtCodigobuscar.Text), txtDescripcion.Text, rolResuelto.Value.ToString());
                    txtCodigobuscar.Enabled = true;
                    MessageBox.Show("INCIDENTE MODIFICADO CON EXITO");
                }
                else if (rolUsuario.Value.ToString() == "Instructor" && rolTipo.Value.ToString() == "Insumo")
                {
                    bd.actualizar_incidente_prestamo_instructor(Convert.ToInt32(txtCodigobuscar.Text), txtDescripcion.Text, rolResuelto.Value.ToString());
                    txtCodigobuscar.Enabled = true;
                    MessageBox.Show("INCIDENTE MODIFICADO CON EXITO");
                }
                else if (rolUsuario.Value.ToString() == "Estudiante" && rolTipo.Value.ToString() == "Insumo")
                {
                    bd.actualizar_incidente_prestamo_estudiante(Convert.ToInt32(txtCodigobuscar.Text), txtDescripcion.Text, rolResuelto.Value.ToString());
                    txtCodigobuscar.Enabled = true;
                    MessageBox.Show("INCIDENTE MODIFICADO CON EXITO");
                }
                else if (rolUsuario.Value.ToString() == "Estudiante" && rolTipo.Value.ToString() == "Salon")
                {

                }
            }
        }
    }
}