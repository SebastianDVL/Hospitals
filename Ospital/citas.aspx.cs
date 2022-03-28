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
    public partial class citas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btIngresarCita.Enabled = false;
        }
        ClsEntCitas oEntCitas = new ClsEntCitas();
        ClsRegCitas oRegCitas = new ClsRegCitas();
        ClsEntMedicos oEntMedicos = new ClsEntMedicos();
        ClsRegMedicos oRegMedicos = new ClsRegMedicos();
        clsEntPaciente oEntPacientes = new clsEntPaciente();
        ClsRegPacientes oRegPacientes = new ClsRegPacientes();

        public void limpiar()
        {
            lblIdPaciente.Text = "ID Paciente: ";
            lblIdMedico.Text = "ID Medico: ";
            lblMsg.Text = "";
            txtCodigo.Text = "";
            txtIdPaciente.Text = "";
            txtIdMedico.Text = "";
            txtAcompañante.Text = "";
            txtDate.Text = "";
            txtTime.Text = "";
            txtValor.Text = "";
            txtDiagnostico.Text = "";
            txtCodigo.Focus();
        }
        public void enable(bool s)
        {
            txtIdPaciente.Enabled = s;
            txtIdMedico.Enabled = s;
            txtAcompañante.Enabled = s;
            txtDate.Enabled = s;
            txtTime.Enabled = s;
            txtValor.Enabled = s;
            txtDiagnostico.Enabled = s;
        }

        protected void btLimpiarCita_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        [Obsolete]
        protected void btConsultarCita_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                lblMsg.Text = "Debes Digitar Algun Valor";
                lblMsg.CssClass = "text-danger";
                txtCodigo.Focus();

            }
            else
            {
                DataSet dsCita = new DataSet();
                oEntCitas.Cod_cita = txtCodigo.Text;
                
                dsCita = oRegCitas.ConsultarCita(oEntCitas);
                if (dsCita.Tables[0].Rows.Count == 0)
                {
                    lblMsg.Text = "Cita Disponible";
                    lblMsg.CssClass = "text-success";
                    lblIdPaciente.Text = "ID Paciente: ";
                    lblIdMedico.Text = "ID Medico: ";
                    txtIdPaciente.Text = "";
                    txtIdMedico.Text = "";
                    txtAcompañante.Text = "";
                    txtDate.Text = "";
                    txtTime.Text = "";
                    txtValor.Text = "";
                    txtDiagnostico.Text = "";
                    txtIdPaciente.Focus();
                    btIngresarCita.Enabled = true;
                    enable(true);

                }
                else
                {
                    DataSet dsMedico = new DataSet();
                    oEntMedicos.Id_medico = txtIdMedico.Text;
                    dsMedico = oRegMedicos.ConsultarMedico(oEntMedicos);

                    DataSet dsPaciente = new DataSet();
                    oEntPacientes.Id_paciente1 = txtIdPaciente.Text;
                    dsPaciente = oRegPacientes.ConsultarPaciente(oEntPacientes);

                    lblMsg.Text = "Cita Encontrada!";
                    lblMsg.CssClass = "text-success";
                    txtIdPaciente.Text = dsCita.Tables[0].Rows[0]["Id_paciente"].ToString();
                    lblIdPaciente.Text += dsPaciente.Tables[0].Rows[0]["nom_paciente"].ToString();
                    txtIdMedico.Text = dsCita.Tables[0].Rows[0]["id_medico"].ToString();
                    lblIdMedico.Text += dsMedico.Tables[0].Rows[0]["nom_medico"].ToString();
                    txtAcompañante.Text = dsCita.Tables[0].Rows[0]["nom_acompanante"].ToString();
                    txtDate.Text = dsCita.Tables[0].Rows[0]["fecha"].ToString();
                    txtTime.Text = dsCita.Tables[0].Rows[0]["hora"].ToString();
                    txtValor.Text = dsCita.Tables[0].Rows[0]["valor"].ToString();
                    txtDiagnostico.Text = dsCita.Tables[0].Rows[0]["diagnostico"].ToString();
                    txtCodigo.Focus();

                    btIngresarCita.Enabled = false;
                    enable(false);
                }
            }
        }

        [Obsolete]
        protected void btIngresarCita_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "" || txtDate.Text == ""|| txtTime.Text == "" || txtIdMedico.Text == "" || txtIdPaciente.Text == ""|| txtValor.Text == "" || txtDiagnostico.Text == "" || txtAcompañante.Text == "")
            {
                lblFinal.Text = "Debes Ingresar Todos Los Datos!";
                lblFinal.CssClass = "text-danger";
            }
            else
            {
                DataSet dsPaciente = new DataSet();
                oEntPacientes.Id_paciente1 = txtIdPaciente.Text;
                dsPaciente = oRegPacientes.ConsultarPaciente(oEntPacientes);

                if (dsPaciente.Tables[0].Rows.Count == 0)
                {
                    lblMsgPaciente.Text = "El Paciente No Existe";
                    btIngresarCita.Enabled = true;
                }
                else
                {

                    lblMsgPaciente.Text = "";
                    DataSet dsMedico = new DataSet();
                    oEntMedicos.Id_medico = txtIdMedico.Text;
                    dsMedico = oRegMedicos.ConsultarMedico(oEntMedicos);
                    if(dsMedico.Tables[0].Rows.Count == 0)
                    {
                        lblMsgMedico.Text = "El Medico No Existe";
                        btIngresarCita.Enabled = true;
                    }
                    else
                    {
                        lblMsgMedico.Text = "";
                        oEntCitas.Cod_cita = txtCodigo.Text;
                        oEntCitas.Fecha = Convert.ToDateTime(txtDate.Text);
                        oEntCitas.Hora = Convert.ToDateTime(txtTime.Text);
                        oEntCitas.Id_medico = txtIdMedico.Text;
                        oEntCitas.Id_paciente1 = txtIdPaciente.Text;
                        oEntCitas.Valor = Convert.ToInt32(txtValor.Text);
                        oEntCitas.Diagnostico = txtDiagnostico.Text;
                        oEntCitas.Nom_acompanante = txtAcompañante.Text;
                        if (oRegCitas.GuardarCita(oEntCitas))
                        {
                            lblFinal.CssClass = "text-success";
                            lblFinal.Text = "Cita Pedida Exitosamente!";
                            limpiar();
                            btIngresarCita.Enabled = false;
                            enable(false);
                        }
                        else
                        {
                            lblFinal.CssClass = "text-danger";
                            lblFinal.Text = "Error Al Guardar Cita";
                            limpiar();
                        }
                    }
                }     
            }
        }
    }
}