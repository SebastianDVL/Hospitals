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
    public partial class pacientes : System.Web.UI.Page
    {
        clsEntPaciente oEntPaciente = new clsEntPaciente();
        ClsRegPacientes oRegPaciente = new ClsRegPacientes();

        protected void Page_Load(object sender, EventArgs e)
        {
            btIngresarPaciente.Enabled = false;
            enable(false);
        }
        public void limpiar()
        {
            txtCelular.Text = "";
            txtDir.Text = "";
            txtNombrePaciente.Text = "";
            txtTipo.Text = "";
            txtTelefono.Text = "";
        }

        public void enable(bool s)
        {
            txtCelular.Enabled = s;
            txtDir.Enabled = s;
            txtNombrePaciente.Enabled = s;
            txtTipo.Enabled = s;
            txtTelefono.Enabled = s;
        }
        protected void btLimpiarPaciente_Click(object sender, EventArgs e)
        {
            txtIdPaciente.Text = "";
            limpiar();
        }

        [Obsolete]
        protected void btConsultarPaciente_Click(object sender, EventArgs e)
        {
            if(txtIdPaciente.Text == "")
            {
                lblPac.Text = "Debes Ingresar Un Numero De Identificacion!";
                lblPac.CssClass = "text-danger";
                txtIdPaciente.Focus();
            }
            else
            {
                oEntPaciente.Id_paciente1 = txtIdPaciente.Text;
                DataSet dsPaciente = new DataSet();
                dsPaciente = oRegPaciente.ConsultarPaciente(oEntPaciente);
                if(dsPaciente.Tables[0].Rows.Count == 0)
                {
                    lblPac.Text = "Paciente Con Identificacion " + txtIdPaciente.Text + " No Existe!";
                    lblPac.CssClass = "text-primary";
                    txtTipo.Focus();
                    limpiar();
                    btIngresarPaciente.Enabled = true;
                }
                else
                {
                    txtTipo.Text = dsPaciente.Tables[0].Rows[0]["tip_doc"].ToString();
                    txtTelefono.Text = dsPaciente.Tables[0].Rows[0]["tel_paciente"].ToString();
                    txtNombrePaciente.Text = dsPaciente.Tables[0].Rows[0]["nom_paciente"].ToString();
                    txtCelular.Text = dsPaciente.Tables[0].Rows[0]["cel_paciente"].ToString();
                    txtDir.Text = dsPaciente.Tables[0].Rows[0]["dir_paciente"].ToString();

                    btIngresarPaciente.Enabled = false;
                    enable(false);
                }
            }
        }

        protected void btIngresarPaciente_Click(object sender, EventArgs e)
        {

        }
    }
}