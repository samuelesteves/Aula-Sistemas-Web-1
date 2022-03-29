using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aluno.Context;
using Aluno.Models;

namespace Aluno.Controllers
{
    public class AlunoController : Controller
    {
        private readonly Contexto _contexto = new Contexto();
        // GET: Aluno
        public ActionResult Index()
        {
            var alunos = _contexto.Alunos.ToList();
            return View(alunos);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AlunoModel aluno)
        {
            if (ModelState.IsValid)
            {
                _contexto.Alunos.Add(aluno);
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
                
            AlunoModel aluno = _contexto.Alunos.Where(a => a.Id == id).FirstOrDefault();

            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);
        }
        [HttpGet]
        public ActionResult Edit (int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            AlunoModel aluno = _contexto.Alunos.Where(a => a.Id == id).FirstOrDefault();

            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AlunoModel aluno)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _contexto.Entry(aluno).State = System.Data.Entity.EntityState.Modified;
                    _contexto.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(aluno);
                }
            }
            return View(aluno);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            AlunoModel aluno = _contexto.Alunos.Where(a => a.Id == id).FirstOrDefault();

            if (aluno == null)
            {
                return HttpNotFound();
            }

            return View(aluno);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete (AlunoModel aluno)
        {

            try
            {
                _contexto.Entry(aluno).State = System.Data.Entity.EntityState.Deleted;
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(aluno);
            }
        }
    }
}