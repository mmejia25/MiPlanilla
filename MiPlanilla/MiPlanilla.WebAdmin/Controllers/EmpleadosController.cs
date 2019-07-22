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


        public EmpleadosController()
        {
            _empleadosBL = new EmpleadoBL();
        }
        // GET: Empleados
        public ActionResult Index()
        {
            var ListadeProductos = _empleadosBL.Obtener();
            return View(ListadeProductos);
        }


        public ActionResult Crear()
        {
            var NuevoEmpleado = new Empleado();


            return View(NuevoEmpleado);
        }

        [HttpPost]
        public  ActionResult Crear(Empleado empleado)
        {
            _empleadosBL.GuardarEmpleado(empleado);

            return RedirectToAction("Index");
        }
    }
}