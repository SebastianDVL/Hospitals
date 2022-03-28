using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using CapaDatos;
namespace CapaReglas
{
   public  class ClsRegPacientes
    {
        ClsDatPaciente oDatPacientes = new ClsDatPaciente();

        [Obsolete]
        public DataSet ConsultarPaciente(clsEntPaciente oPacientes) => oDatPacientes.consultarPaciente(oPacientes);
    }
}
