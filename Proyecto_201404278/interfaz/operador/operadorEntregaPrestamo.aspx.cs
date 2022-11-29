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
    public partial class operadorEntregaPrestamo : System.Web.UI.Page
    {
        conexion_metodos bd = new conexion_metodos();

        protected void Page_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
            txtHora.Text = String.Format("{0:G}", DateTime.Now.ToString("hh:mm:hh"));
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtFecha.Text = Calendar1.SelectedDate.Date.ToString("yyyy-MM-dd");
        }

        protected void bttAgregar_Click(object sender, EventArgs e)
        {
            if (txtCodigoPrestamo.Text == "" || txtCodigoInsumo.Text == "" || txtFecha.Text == "" || txtHora.Text == "")
            {
                MessageBox.Show("HAY CAMPOS VACIOS");
            }
            else
            {
                if (rolUsuario.Value.ToString() == "Instructor")
                {
                    if (bd.validacion_prestamo_codigo_Instructor(Convert.ToInt32(txtCodigoPrestamo.Text)) > 0)
                    {
                        if (bd.validacion_codigo_insumo(Convert.ToInt32(txtCodigoInsumo.Text)) > 0)
                        {
                            if (bd.validacion_prestamo_siInsumoPerteneceInstructor(Convert.ToInt32(txtCodigoPrestamo.Text), Convert.ToInt32(txtCodigoInsumo.Text)) > 0)
                            {
                                if (bd.validacion_prestamo_entregadaOnoInstructor(Convert.ToInt32(txtCodigoPrestamo.Text)) > 0)
                                {
                                    MessageBox.Show("INSUMO YA HA SIDO ENTREGADO");
                                }
                                else
                                {
                                    bd.inserta_entrega_prestamo_instructor(txtFecha.Text, txtHora.Text, Convert.ToInt32(txtCodigoPrestamo.Text));
                                    bd.actualizar_insumo_estadoAdisponible(Convert.ToInt32(txtCodigoInsumo.Text));
                                    bd.actualizar_prestamo_entregadoAsi_Instructor(Convert.ToInt32(txtCodigoPrestamo.Text));
                                    MessageBox.Show("ENTREGA REGISTRADA CON EXITO");
                                }
                            }
                            else
                            {
                                MessageBox.Show("INSUMO NO PERTENECE AL PRESTAMO");
                            }
                        }
                        else
                        {
                            MessageBox.Show("NO EXISTE INSUMO");
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO EXISTE EL PRESTAMO");
                    }
                }
                else if (rolUsuario.Value.ToString() == "Estudiante")
                {
                    if (bd.validacion_prestamo_codigo_Estudiante(Convert.ToInt32(txtCodigoPrestamo.Text)) > 0)
                    {
                        if (bd.validacion_codigo_insumo(Convert.ToInt32(txtCodigoInsumo.Text)) > 0)
                        {
                            if (bd.validacion_prestamo_siInsumoPerteneceEstudiante(Convert.ToInt32(txtCodigoPrestamo.Text), Convert.ToInt32(txtCodigoInsumo.Text)) > 0)
                            {
                                if (bd.validacion_prestamo_entregadaOnoEstudiante(Convert.ToInt32(txtCodigoPrestamo.Text)) > 0)
                                {
                                    MessageBox.Show("INSUMO YA HA SIDO ENTREGADO");
                                }
                                else
                                {
                                    bd.inserta_entrega_prestamo_estudiante(txtFecha.Text, txtHora.Text, Convert.ToInt32(txtCodigoPrestamo.Text));
                                    bd.actualizar_insumo_estadoAdisponible(Convert.ToInt32(txtCodigoInsumo.Text));
                                    bd.actualizar_prestamo_entregadoAsi_Estudiante(Convert.ToInt32(txtCodigoPrestamo.Text));
                                    MessageBox.Show("ENTREGA REGISTRADA CON EXITO");
                                }
                            }
                            else
                            {
                                MessageBox.Show("INSUMO NO PERTENECE AL PRESTAMO");
                            }
                        }
                        else
                        {
                            MessageBox.Show("NO EXISTE INSUMO");
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO EXISTE EL PRESTAMO");
                    }
                }
            }
        }
    }
}