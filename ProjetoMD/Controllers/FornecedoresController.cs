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
    public class FornecedoresController : Controller
    {
        private readonly FornecedoresRepositorios _fornecedoresRep = new FornecedoresRepositorios();
        // GET: Clientes
        public ActionResult Index()
        {
            var fornecedoresViewModel = Mapper.Map<IEnumerable<Fornecedores>,
                IEnumerable<FornecedoresViewModel>>(_fornecedoresRep.ConsultarTodos());

            return View(fornecedoresViewModel);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(FornecedoresViewModel fornecedores)
        {
            if (ModelState.IsValid)
            {
                var forn = Mapper.Map<FornecedoresViewModel, Fornecedores>(fornecedores);
                _fornecedoresRep.Adicionar(forn);

                return RedirectToAction("Index");
            }

            return View(fornecedores);
        }

        public ActionResult Alterar(int Id)
        {
            var fornecedores = _fornecedoresRep.ConsultaporId(Id);
            var fornecedoresViewModel = Mapper.Map<Fornecedores, FornecedoresViewModel>(fornecedores);

            return View(fornecedoresViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alterar(FornecedoresViewModel fornecedores)
        {
            if (ModelState.IsValid)
            {
                var forn = Mapper.Map<FornecedoresViewModel, Fornecedores>(fornecedores);
                _fornecedoresRep.Alterar(forn);

                return RedirectToAction("Index");
            }

            return View(fornecedores);
        }

        public ActionResult Remover(int Id)
        {
            var fornecedores = _fornecedoresRep.ConsultaporId(Id);
            var fornecedoresViewModel = Mapper.Map<Fornecedores, FornecedoresViewModel>(fornecedores);

            return View(fornecedoresViewModel);
        }

        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmacaoRemover(int Id)
        {
            var forn = _fornecedoresRep.ConsultaporId(Id);
            _fornecedoresRep.Remover(forn);

            return RedirectToAction("Index");
        }
    }
}