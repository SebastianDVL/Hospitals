using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
namespace CapaReglas
{
    public class ClsRegCitas
    {

        ClsDatCitas oDatCitas = new ClsDatCitas();

        [Obsolete]
        public DataSet ConsultarCita(ClsEntCitas oCitas) => oDatCitas.consultarCita(oCitas);

        [Obsolete]
        public bool GuardarCita(ClsEntCitas oCitas) => oDatCitas.guardarCita(oCitas);
    }
}
