using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CapaEntidad;
using CapaReglas;

namespace Ospital
{
    public partial class medicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btIngresarMedico.Enabled = false;
            enable(false);
        }
        ClsEntMedicos oEntMedicos = new ClsEntMedicos();
        ClsRegMedicos oRegMedicos = new ClsRegMedicos();
        public void limpiar()
        {
         
            txtEspecialidad.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtIdMedico.Focus();
        }

        public void enable(bool s)
        {

            txtEspecialidad.Enabled = s;
            txtNombre.Enabled = s;
            txtTelefono.Enabled = s;
        }

        protected void btLimpiarMedico_Click(object sender, EventArgs e)
        {
            txtIdMedico.Text = "";
            limpiar();
        }
        [Obsolete]
        protected void btIngresarMedico_Click(object sender, EventArgs e)
        {
            if(txtIdMedico.Text == "" || txtEspecialidad.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "")
            {
                lblLast.Text = "Todos Los Datos Son Requeridos!";
                lblLast.CssClass = "text-danger";
            }
            else
            {
                oEntMedicos.Id_medico = txtIdMedico.Text;
                DataSet dsMedico = new DataSet();

                dsMedico = oRegMedicos.ConsultarMedico(oEntMedicos);
                if(dsMedico.Tables[0].Rows.Count == 0)
                {
                    oEntMedicos.Id_medico = txtIdMedico.Text;
                    oEntMedicos.Nom_medico = txtNombre.Text;
                    oEntMedicos.Especialidad = txtEspecialidad.Text;
                    oEntMedicos.Tel_medico = txtTelefono.Text;

                    if (oRegMedicos.guardarMedico(oEntMedicos))
                    {
                        lblLast.Text = "Medico Registrado Exitosamente!";
                        lblLast.CssClass = "text-success";
                    }
                    else
                    {
                        lblLast.Text = "No Se Pudo Registrar Al Medico!";
                    }
                }
                else
                {
                    lblLast.Text = "";
                    lblLast.CssClass = "text-danger";
                }

            }
        }

        [Obsolete]
        protected void btConsultarMedico_Click(object sender, EventArgs e)
        {
            if(txtIdMedico.Text == "")
            {
                lblIdent.Text = "Debes Ingresar Un Numero De Identificacion!";
                lblIdent.CssClass = "text-danger";
                txtIdMedico.Focus();
            }
            else
            {
                oEntMedicos.Id_medico = txtIdMedico.Text;
                DataSet dsMedico = new DataSet();
                dsMedico = oRegMedicos.ConsultarMedico(oEntMedicos);

                if(dsMedico.Tables[0].Rows.Count == 0)
                {
                    lblIdent.Text = "El Medico Con Identificacion " + txtIdMedico.Text + " No Existe En la Base De Datos";
                    lblIdent.CssClass = "text-primary";
                    limpiar();
                    txtNombre.Focus();
                    enable(true);
                    btIngresarMedico.Enabled = true;

                }
                else
                {
                    txtNombre.Text = dsMedico.Tables[0].Rows[0]["nom_medico"].ToString();
                    txtEspecialidad.Text = dsMedico.Tables[0].Rows[0]["especialidad"].ToString();
                    txtTelefono.Text = dsMedico.Tables[0].Rows[0]["tel_medico"].ToString();

                    btIngresarMedico.Enabled = false;
                    enable(false);
                }
            }
        }
    }
}