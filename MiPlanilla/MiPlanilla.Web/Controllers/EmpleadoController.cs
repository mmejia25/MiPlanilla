using MiPlanilla.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPlanilla.Web.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {

            var empleadoBL = new EmpleadoBL();
            var ListadeEmpleados = empleadoBL.Obtener();
            
            return View(ListadeEmpleados);
        }
    }
}