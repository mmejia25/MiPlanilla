using MiPlanilla.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPlanilla.WebAdmin.Controllers
{
    public class CargosController : Controller
    {

        CargosBL _cargosBL;


        public CargosController()
        {
            _cargosBL = new CargosBL();
        }
        // GET: Cargo
        public ActionResult Index()
        {
            var ListadeCargos = _cargosBL.Obtener();
            return View(ListadeCargos);
        }


        public ActionResult Crear()
        {
            var NuevoCargo = new Cargo();


            return View(NuevoCargo);
        }

        [HttpPost]
        public ActionResult Crear(Cargo cargo)
        {
            _cargosBL.GuardarCargo(cargo);

            return RedirectToAction("Index");
        }


        public ActionResult Editar(int Id)
        {
            var cargo = _cargosBL.ObtenerCargo(Id);

            return View(cargo);
        }

        [HttpPost]
        public ActionResult Editar(Cargo cargo)
        {

            _cargosBL.GuardarCargo(cargo);
            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int Id)
        {
            var cargo = _cargosBL.ObtenerCargo(Id);

            return View(cargo);
        }


        public ActionResult Eliminar(int Id)
        {
            var cargo = _cargosBL.ObtenerCargo(Id);

            return View(cargo);
        }

        [HttpPost]
        public ActionResult Eliminar(Cargo cargo)
        {

            _cargosBL.EliminarCargo(cargo.Id);
            return RedirectToAction("Index");
        }

    }
}