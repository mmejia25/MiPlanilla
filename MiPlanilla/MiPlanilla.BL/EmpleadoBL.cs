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
        public List<Empleado> listadeEmpleados { get; set; }

        public EmpleadoBL()
        {
            _contexto = new Contexto();
            listadeEmpleados = new List<Empleado>();
        }

        public List<Empleado> Obtener()
        {

            listadeEmpleados = _contexto.Empleados.ToList();
            return listadeEmpleados; 
        }
    }
}
