using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlanilla.BL
{
    public class EmpleadoBL
    {
        Contexto _contexto;
        public EmpleadoBL()
        {
            _contexto = new Contexto();
        }

        public List<Empleado> Obtener()
        {

            return _contexto.Empleados.ToList();
        }
    }
}
