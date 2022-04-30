using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P2_2019VM607.Models;

namespace P2_2019VM607.Controllers
{
    public class CovidController : Controller
    {

        private readonly dbContext _contexto;

        public CovidController(dbContext miContexto)
        {
            this._contexto = miContexto;
        }

        public IActionResult Index()
        {
            IEnumerable<caso> casos = from c in _contexto.caso select c;

            return View(casos);
        }

        [HttpPost]
        public ActionResult NewPost(caso nuevoCaso)
        {
            var nuevo = new caso()
            {
                departamento = nuevoCaso.departamento,
                genero = nuevoCaso.genero,
                confirmados = nuevoCaso.confirmados,
                recuperados = nuevoCaso.recuperados,
                fallecidos = nuevoCaso.fallecidos
            };

            _contexto.caso.Add(nuevo);
            _contexto.SaveChanges();

            IEnumerable<caso> casos = from c in _contexto.caso select c;

            return RedirectToAction("Index", casos);
        }
    }
}
