using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidad;
namespace CapaDatos
{
    public class ClsDatCitas
    {
        ClsConexion oConexcion = new ClsConexion();
        SqlCommand cmd = new SqlCommand();

        [Obsolete]
        public DataSet consultarCita(ClsEntCitas oCitas)
        {
            try
            {
                cmd.Connection = oConexcion.conectar("Hospital");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_consultar_citas";
                cmd.Parameters.Add("@pcod_cita", oCitas.Cod_cita);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        [Obsolete]
        public bool guardarCita(ClsEntCitas oCitas)
        {
            try
            {
                cmd.Connection = oConexcion.conectar("Hospital");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_guardar_citas";
                cmd.Parameters.Add("@pcod_cita", oCitas.Cod_cita);
                cmd.Parameters.Add("@pfecha", oCitas.Fecha);
                cmd.Parameters.Add("@phora", oCitas.Hora);
                cmd.Parameters.Add("@pId_paciente", oCitas.Id_paciente1);
                cmd.Parameters.Add("@pid_medico", oCitas.Id_medico);
                cmd.Parameters.Add("@pvalor", oCitas.Valor);
                cmd.Parameters.Add("@pdiagnostico", oCitas.Diagnostico);
                cmd.Parameters.Add("@pNom_acompanante", oCitas.Nom_acompanante);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
                return false;
            }
        }
    }
}
