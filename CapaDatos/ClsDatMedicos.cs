using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;

namespace CapaDatos
{
    public class ClsDatMedicos
    {
        ClsConexion oConexcion = new ClsConexion();
        SqlCommand cmd = new SqlCommand();

        [Obsolete]
        public DataSet consultarMedico(ClsEntMedicos oMedicos)
        {
            try
            {
                cmd.Connection = oConexcion.conectar("Hospital");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_consultar_medico";
                cmd.Parameters.Add("@pid_medico", oMedicos.Id_medico);
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
        public bool guardarMedico(ClsEntMedicos oMedicos)
        {
            try
            {
                cmd.Connection = oConexcion.conectar("Hospital");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_guardar_medico";
                cmd.Parameters.Add("@pid_medico", oMedicos.Id_medico);
                cmd.Parameters.Add("@pnom_medico", oMedicos.Nom_medico);
                cmd.Parameters.Add("@pespecialidad", oMedicos.Especialidad);
                cmd.Parameters.Add("@ptel_medico", oMedicos.Tel_medico);
                cmd.ExecuteNonQuery();

                return true;
            }catch(Exception err)
            {   
                throw new Exception(err.Message);
              
            }
        }
    }
}
