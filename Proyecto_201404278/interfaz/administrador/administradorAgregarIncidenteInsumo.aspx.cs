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
    public partial class administradorAgregarIncidenteInsumo : System.Web.UI.Page
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
            if (txtcarnetUsuario.Text=="" || txtcodigoInsumo.Text=="" || txtDescripcion.Text=="" || txtFecha.Text=="" || txtHora.Text=="" || txtQuienRegistra.Text=="")
            {
                MessageBox.Show("HAY CAMPOS VACIOS");
            }
            else
            {
                if (rolUsuario.Value.ToString()=="Instructor")
                {
                    if (bd.validacion_codigo_insumo(Convert.ToInt32(txtcodigoInsumo.Text))>0)
                    {
                        if (bd.validacion_carnetInstructor(txtcarnetUsuario.Text)>0)
                        {
                            if (bd.validacion_carnetAdmin_operador(txtQuienRegistra.Text)>0)
                            {
                                bd.inserta_reporte_intructor_insumo(rolTipo.Value.ToString(), txtDescripcion.Text, rolResuelto.Value.ToString(), txtFecha.Text, txtHora.Text, txtcarnetUsuario.Text, Convert.ToInt32(txtcodigoInsumo.Text), txtQuienRegistra.Text);
                                bd.actualizar_insumo_estadoAindidente(Convert.ToInt32(txtcodigoInsumo.Text));
                                MessageBox.Show("REPORTE AGREGADO CON EXITO");
                            }
                            else
                            {
                                MessageBox.Show("CARNET DE QUIEN REGISTRA NO EXISTE");
                            }
                        }
                        else
                        {
                            MessageBox.Show("INSTRUCTOR NO EXISTE");
                        }
                    }
                    else
                    {
                        MessageBox.Show("INSUMO NO EXISTE");
                    }
                }
                else if (rolUsuario.Value.ToString() == "Estudiante")
                {
                    if (bd.validacion_codigo_insumo(Convert.ToInt32(txtcodigoInsumo.Text)) > 0)
                    {
                        if (bd.validacion_carnetEstudiante(txtcarnetUsuario.Text) > 0)
                        {
                            if (bd.validacion_carnetAdmin_operador(txtQuienRegistra.Text) > 0)
                            {
                                bd.inserta_reporte_estudiante_insumo(rolTipo.Value.ToString(), txtDescripcion.Text, rolResuelto.Value.ToString(), txtFecha.Text, txtHora.Text, txtcarnetUsuario.Text, Convert.ToInt32(txtcodigoInsumo.Text), txtQuienRegistra.Text);
                                bd.actualizar_insumo_estadoAindidente(Convert.ToInt32(txtcodigoInsumo.Text));
                                MessageBox.Show("REPORTE AGREGADO CON EXITO");
                                
                            }
                            else
                            {
                                MessageBox.Show("CARNET DE QUIEN REGISTRA NO EXISTE");
                            }
                        }
                        else
                        {
                            MessageBox.Show("ESTUDIANTE NO EXISTE");
                        }
                    }
                    else
                    {
                        MessageBox.Show("INSUMO NO EXISTE");
                    }
                }
            }
        }
    }
}