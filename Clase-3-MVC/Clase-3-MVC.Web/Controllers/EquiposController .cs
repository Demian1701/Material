using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clase_3_MVC.Entidades;
using Clase_3_MVC.Servicios;
using Clase_3_MVC.Servicios.Implementaciones;


namespace Clase_3_MVC.Web.Controllers
{
    public class EquiposController : Controller
    {
        
        public EquiposController(IEquipoService equipoService)
        {
            _equipoService = equipoService;
        }

        IEquipoService _equipoService;
        
        private static List<Equipo> _equipos = new List<Equipo>()
        {
            new Equipo() { Id =1,  Nombre = "River", Pais = "Arg" },
            new Equipo() { Id =2,  Nombre = "Boke", Pais = "Arg" },
        };

        // GET: EquiposController
        public ActionResult Listar()
        {
            //return View(_equipos);
            return View(_equipoService.Listar());
        }

        // GET: EquiposController/Details/5
        public ActionResult Crear(int id)
        {
            return View();
        }

        // GET: EquiposController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EquiposController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Equipo equipo)
        {
            try
            {
                equipo.Id = _equipos.Max(o => o.Id) + 1;
                _equipos.Add(equipo);
                return RedirectToAction(nameof(Listar));
            }
            catch
            {
                return View();
            }
        }

        // GET: EquiposController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EquiposController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EquiposController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EquiposController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
