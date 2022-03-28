using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
namespace CapaDatos
{
    public class ClsDatPaciente
    {
        ClsConexion oConexcion = new ClsConexion();
        SqlCommand cmd = new SqlCommand();

        [Obsolete]
        public DataSet consultarPaciente(clsEntPaciente oPaciente)
        {
            try
            {
                cmd.Connection = oConexcion.conectar("Hospital");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_consultar_paciente";
                cmd.Parameters.Add("@pId_paciente", oPaciente.Id_paciente1);
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
    }
}
