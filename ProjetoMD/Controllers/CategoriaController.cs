using AutoMapper;
using ProjetoMD.Dominio.Entidades;
using ProjetoMD.MVC.Models;
using ProjetoMD.Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoMD.MVC.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly CategoriaRepositorio _categoriaRep = new CategoriaRepositorio();
        // GET: Clientes
        public ActionResult Index()
        {
            var categoriaViewModel = Mapper.Map<IEnumerable<Categoria>,
                IEnumerable<CategoriaViewModel>>(_categoriaRep.ConsultarTodos());

            return View(categoriaViewModel);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(CategoriaViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                var cli = Mapper.Map<CategoriaViewModel, Categoria>(categoria);
                _categoriaRep.Adicionar(cli);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public ActionResult Alterar(int Id)
        {
            var categoria = _categoriaRep.ConsultaporId(Id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

            return View(categoriaViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alterar(CategoriaViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                var cat = Mapper.Map<CategoriaViewModel, Categoria>(categoria);
                _categoriaRep.Alterar(cat);

                return RedirectToAction("Index");
            }

            return View(categoria);
        }

        public ActionResult Remover(int Id)
        {
            var categoria = _categoriaRep.ConsultaporId(Id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);

            return View(categoriaViewModel);
        }

        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmacaoRemover(int Id)
        {
            var cat = _categoriaRep.ConsultaporId(Id);
            _categoriaRep.Remover(cat);

            return RedirectToAction("Index");
        }
    }
}