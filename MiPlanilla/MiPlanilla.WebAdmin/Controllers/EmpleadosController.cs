using MiPlanilla.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPlanilla.WebAdmin.Controllers
{
    public class EmpleadosController : Controller
    {

        EmpleadoBL _empleadosBL;
        CargosBL _cargoBL;


        public EmpleadosController()
        {
            _empleadosBL = new EmpleadoBL();
            _cargoBL = new CargosBL();
        }
        // GET: Empleados
      
        public ActionResult Index()
        {
            var ListadeEmpleados = _empleadosBL.Obtener();
            return View(ListadeEmpleados);
        }


        public ActionResult Crear()
        {
            var NuevoEmpleado = new Empleado();
            var cargos = _cargoBL.Obtener();

            ViewBag.ListaCargos = new SelectList(cargos, "Id", "Descripcion");

            return View(NuevoEmpleado);
        }

        [HttpPost]
        public  ActionResult Crear(Empleado empleado)
        {
            _empleadosBL.GuardarEmpleado(empleado);

            return RedirectToAction("Index");
        }


        public ActionResult Editar(int Id, int Num)
        {
            var empleado = _empleadosBL.ObtenerEmpleado(Id);
            

            return View(empleado);
        }

        [HttpPost]
        public ActionResult Editar (Empleado empleado)
        {

            _empleadosBL.GuardarEmpleado(empleado);
            return RedirectToAction("Index");
        }

        public ActionResult Detalle (int Id)
        {
            var empleado = _empleadosBL.ObtenerEmpleado(Id);

            return View(empleado);
        }


        public ActionResult Eliminar(int Id)
        {
            var empleado = _empleadosBL.ObtenerEmpleado(Id);

            return View(empleado);
        }

        [HttpPost]
        public  ActionResult Eliminar(Empleado empleado)
        {
            

            _empleadosBL.EliminarEmpleado(empleado.Id);
            return RedirectToAction("Index");

        }

    }
}