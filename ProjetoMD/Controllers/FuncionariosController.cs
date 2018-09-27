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
    public class FuncionariosController : Controller
    {
        private readonly FuncionariosRepositorio _funcionariosRep = new FuncionariosRepositorio();
        // GET: Clientes
        public ActionResult Index()
        {
            var funcionariosViewModel = Mapper.Map<IEnumerable<Funcionarios>,
                IEnumerable<FuncionariosViewModel>>(_funcionariosRep.ConsultarTodos());

            return View(funcionariosViewModel);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(FuncionariosViewModel funcionarios)
        {
            if (ModelState.IsValid)
            {
                var forn = Mapper.Map<FuncionariosViewModel, Funcionarios>(funcionarios);
                _funcionariosRep.Adicionar(forn);

                return RedirectToAction("Index");
            }

            return View(funcionarios);
        }

        public ActionResult Alterar(int Id)
        {
            var funcionarios = _funcionariosRep.ConsultaporId(Id);
            var funcionariosViewModel = Mapper.Map<Funcionarios, FuncionariosViewModel>(funcionarios);

            return View(funcionariosViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alterar(FuncionariosViewModel funcionarios)
        {
            if (ModelState.IsValid)
            {
                var forn = Mapper.Map<FuncionariosViewModel, Funcionarios>(funcionarios);
                _funcionariosRep.Alterar(forn);

                return RedirectToAction("Index");
            }

            return View(funcionarios);
        }

        public ActionResult Remover(int Id)
        {
            var funcionarios = _funcionariosRep.ConsultaporId(Id);
            var funcionariosViewModel = Mapper.Map<Funcionarios, FuncionariosViewModel>(funcionarios);

            return View(funcionariosViewModel);
        }

        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmacaoRemover(int Id)
        {
            var forn = _funcionariosRep.ConsultaporId(Id);
            _funcionariosRep.Remover(forn);

            return RedirectToAction("Index");
        }
    }
}