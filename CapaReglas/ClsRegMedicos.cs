using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using CapaEntidad;
namespace CapaReglas
{
    public class ClsRegMedicos
    {
        ClsDatMedicos oDatMedicos = new ClsDatMedicos();

        [Obsolete]
        public DataSet ConsultarMedico(ClsEntMedicos oMedicos) => oDatMedicos.consultarMedico(oMedicos);
        [Obsolete]
        public bool guardarMedico(ClsEntMedicos oMedicos) => oDatMedicos.guardarMedico(oMedicos);
    }
}
