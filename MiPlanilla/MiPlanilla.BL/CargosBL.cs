using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlanilla.BL
{
    public class CargosBL
    {
        Contexto _contexto;
        public List<Cargo> listadeCargos { get; set; }

        public CargosBL()
        {
            _contexto = new Contexto();
            listadeCargos = new List<Cargo>();
        }

        public List<Cargo> Obtener()
        {

            listadeCargos = _contexto.Cargos.ToList();
            return listadeCargos;
        }


        public void GuardarCargo(Cargo cargo)
        {

            if (cargo.Id == 0)
            {
                _contexto.Cargos.Add(cargo);
            }
            else
            {
                var cargoexistente = _contexto.Cargos.Find(cargo.Id);
                cargoexistente.Id = cargo.Id;
                cargoexistente.Descripcion = cargo.Descripcion;
                cargoexistente.Pais = cargo.Pais;
            }

            _contexto.SaveChanges();
        }

        public Cargo ObtenerCargo(int Id)
        {

            var cargo = _contexto.Cargos.Find(Id);

            return cargo;
        }

        public void EliminarCargo(int Id)
        {
            var cargo = _contexto.Cargos.Find(Id);
            _contexto.Cargos.Remove(cargo);
            _contexto.SaveChanges();
        }


    }

}
