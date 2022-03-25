using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Carro.Context;
using Carro.Models;

namespace Carro.Controllers
{
    public class CarroController : Controller
    {
        private readonly Contexto _contexto = new Contexto();
        // GET: Carro
        public ActionResult Index()
        {
            var carro = _contexto.Carro.ToList();
            return View(carro);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarroModel carro)
        {
            if (ModelState.IsValid)
            {
                _contexto.Carro.Add(carro);
                _contexto.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        
    }
}