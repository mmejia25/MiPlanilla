using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlanilla.BL
{
    public  class Empleado
    {
        public int Id { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public double Salario { get; set; }
        public String Estatus { get; set; }
        public String Cargo { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
