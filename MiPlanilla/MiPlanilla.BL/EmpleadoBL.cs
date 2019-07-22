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


       public void GuardarEmpleado(Empleado producto)
        {

            if (producto.Id == 0)
            {
                _contexto.Empleados.Add(producto);
            }else
            {
                var empleadoexistente = _contexto.Empleados.Find(producto.Id);
                empleadoexistente.Nombres = producto.Nombres;
                empleadoexistente.Apellidos = producto.Apellidos;
                empleadoexistente.Cargo = producto.Cargo;
                empleadoexistente.Estatus = producto.Estatus;
                empleadoexistente.Salario = producto.Salario;
            }
            
            _contexto.SaveChanges();
        }

        public Empleado ObtenerEmpleado(int Id)
        {

            var empleado = _contexto.Empleados.Find(Id);
             
            return empleado;
        }

       

    }


}
