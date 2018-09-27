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
    public class SaidasController : Controller
    {
        private readonly SaidasRepositorio _saidasRep = new SaidasRepositorio();
        // GET: Clientes
        public ActionResult Index()
        {
            var saidasViewModel = Mapper.Map<IEnumerable<Saidas>,
                IEnumerable<SaidasViewModel>>(_saidasRep.ConsultarTodos());

            return View(saidasViewModel);
        }

        public ActionResult Adicionar()
        {
            Produtos produtos = new Produtos();
            ViewBag.Saidas = new SelectList
                (
                new Saidas().Produtos.ToString()
                );



            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(SaidasViewModel saidas)
        {
            if (ModelState.IsValid)
            {
                var sai = Mapper.Map<SaidasViewModel, Saidas>(saidas);
                _saidasRep.Adicionar(sai);

                return RedirectToAction("Index");
            }

            return View(saidas);
        }

        public ActionResult Alterar(int Id)
        {
            var saidas = _saidasRep.ConsultaporId(Id);
            var saidasViewModel = Mapper.Map<Saidas, SaidasViewModel>(saidas);

            return View(saidasViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alterar(SaidasViewModel saidas)
        {
            if (ModelState.IsValid)
            {
                var sai = Mapper.Map<SaidasViewModel, Saidas>(saidas);
                _saidasRep.Alterar(sai);

                return RedirectToAction("Index");
            }

            return View(saidas);
        }

        public ActionResult Remover(int Id)
        {
            var saidas = _saidasRep.ConsultaporId(Id);
            var saidasViewModel = Mapper.Map<Saidas, SaidasViewModel>(saidas);

            return View(saidasViewModel);
        }

        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmacaoRemover(int Id)
        {
            var sai = _saidasRep.ConsultaporId(Id);
            _saidasRep.Remover(sai);

            return RedirectToAction("Index");
        }
    }
}