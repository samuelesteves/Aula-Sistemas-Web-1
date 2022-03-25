using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}