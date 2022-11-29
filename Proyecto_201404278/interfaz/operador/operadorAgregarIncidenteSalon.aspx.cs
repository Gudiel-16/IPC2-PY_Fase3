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
    public partial class operadorAgregarIncidenteSalon : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();

        protected void Page_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
            txtHora.Text = String.Format("{0:G}", DateTime.Now.ToString("hh:mm:hh"));
        }

        protected void bttAgregar_Click(object sender, EventArgs e)
        {
            if (txtCarnetInstructor.Text == "" || txtCodigoSalon.Text == "" || txtDescripcion.Text == "" || txtFecha.Text == "" || txtHora.Text == "" || txtQuienRegistra.Text == "")
            {
                MessageBox.Show("HAY CAMPOS VACIOS");
            }
            else
            {
                if (bd.validacion_salon_codigo(Convert.ToInt32(txtCodigoSalon.Text)) > 0)
                {
                    if (bd.validacion_carnetInstructor(txtCarnetInstructor.Text) > 0)
                    {
                        if (bd.validacion_carnetAdmin_operador(txtQuienRegistra.Text) > 0)
                        {
                            bd.inserta_reporte_intructor_salon(rolTipo.Value.ToString(), txtDescripcion.Text, rolResuelto.Value.ToString(), txtFecha.Text, txtHora.Text, txtCarnetInstructor.Text, Convert.ToInt32(txtCodigoSalon.Text), txtQuienRegistra.Text);
                            bd.actualizar_salon_estadodebaja(Convert.ToInt32(txtCodigoSalon.Text));
                            MessageBox.Show("REPORTE REGISTRADO CON EXITO");
                        }
                        else
                        {
                            MessageBox.Show("CARNET QUIEN REGISTRA NO EXISTE");
                        }
                    }
                    else
                    {
                        MessageBox.Show("EL INSTRUCTOR NO EXISTE");
                    }
                }
                else
                {
                    MessageBox.Show("EL SALON NO EXISTE");
                }
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtFecha.Text = Calendar1.SelectedDate.Date.ToString("yyyy-MM-dd");
        }
    }
}