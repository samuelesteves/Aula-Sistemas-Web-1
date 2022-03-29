using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           CarroModel carro = _contexto.Carro.Where(a => a.cod == id).FirstOrDefault();

            if (carro == null)
            {
                return HttpNotFound();
            }

            return View(carro);
        }

        [HttpGet]
        public ActionResult Edit (int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CarroModel carro = _contexto.Carro.Where(a => a.cod == id).FirstOrDefault();

            if (carro == null)
            {
                return HttpNotFound();
            }
            return View(carro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CarroModel carro)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _contexto.Entry(carro).State = System.Data.Entity.EntityState.Modified;
                    _contexto.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(carro);
                }
            }
                return View(carro);
            

        }

            [HttpGet]
            public ActionResult Delete(int? id)
            {
               if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                CarroModel carro = _contexto.Carro.Where(a => a.cod == id).FirstOrDefault();
                
                if (carro == null)
                {
                    return HttpNotFound();
                }
                return View(carro); 
            }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete (CarroModel carro)
        {
            try
            {
                _contexto.Entry(carro).State = System.Data.Entity.EntityState.Deleted;
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
        }
        }
        
    }
