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


       public void GuardarEmpleado(Empleado empleado)
        {

            if (empleado.Id == 0)
            {
                _contexto.Empleados.Add(empleado);
            }else
            {
                var empleadoexistente = _contexto.Empleados.Find(empleado.Id);
                empleadoexistente.Nombres = empleado.Nombres;
                empleadoexistente.Apellidos = empleado.Apellidos;
                empleadoexistente.Cargo = empleado.Cargo;
                empleadoexistente.Estatus = empleado.Estatus;
                empleadoexistente.Salario = empleado.Salario;
            }
            
            _contexto.SaveChanges();
        }

        public Empleado ObtenerEmpleado(int Id)
        {

            var empleado = _contexto.Empleados.Find(Id);
                       
             
            return empleado;
        }

        public void EliminarEmpleado (int Id)
        {
            var empleado = _contexto.Empleados.Find(Id);
            _contexto.Empleados.Remove(empleado);
            _contexto.SaveChanges();
        }
       

    }


}
