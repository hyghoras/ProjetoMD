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
    public class ProdutosController : Controller
    {
        private readonly ProdutosRepositorio _produtosRep = new ProdutosRepositorio();
        // GET: Clientes
        public ActionResult Index()
        {
            var produtosViewModel = Mapper.Map<IEnumerable<Produtos>,
                IEnumerable<ProdutosViewModel>>(_produtosRep.ConsultarTodos());

            return View(produtosViewModel);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(ProdutosViewModel produtos)
        {
            if (ModelState.IsValid)
            {
                var pro = Mapper.Map<ProdutosViewModel, Produtos>(produtos);
                _produtosRep.Adicionar(pro);

                return RedirectToAction("Index");
            }

            return View(produtos);
        }

        public ActionResult Alterar(int Id)
        {
            var produtos = _produtosRep.ConsultaporId(Id);
            var produtosViewModel = Mapper.Map<Produtos, ProdutosViewModel>(produtos);

            return View(produtosViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alterar(ProdutosViewModel produtos)
        {
            if (ModelState.IsValid)
            {
                var pro = Mapper.Map<ProdutosViewModel, Produtos>(produtos);
                _produtosRep.Alterar(pro);

                return RedirectToAction("Index");
            }

            return View(produtos);
        }

        public ActionResult Remover(int Id)
        {
            var produtos = _produtosRep.ConsultaporId(Id);
            var produtosViewModel = Mapper.Map<Produtos, ProdutosViewModel>(produtos);

            return View(produtosViewModel);
        }

        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmacaoRemover(int Id)
        {
            var pro = _produtosRep.ConsultaporId(Id);
            _produtosRep.Remover(pro);

            return RedirectToAction("Index");
        }
    }
}