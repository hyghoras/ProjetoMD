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
    public class EnderecosController : Controller
    {
        private readonly EnderecosRepositorio _enderecosRep = new EnderecosRepositorio();
        // GET: Clientes
        public ActionResult Index()
        {
            var enderecosViewModel = Mapper.Map<IEnumerable<Enderecos>,
                IEnumerable<EnderecosViewModel>>(_enderecosRep.ConsultarTodos());

            return View(enderecosViewModel);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(EnderecosViewModel enderecos)
        {
            if (ModelState.IsValid)
            {
                var end = Mapper.Map<EnderecosViewModel, Enderecos>(enderecos);
                _enderecosRep.Adicionar(end);

                return RedirectToAction("Index");
            }

            return View(enderecos);
        }

        public ActionResult Alterar(int Id)
        {
            var enderecos = _enderecosRep.ConsultaporId(Id);
            var enderecosViewModel = Mapper.Map<Enderecos, EnderecosViewModel>(enderecos);

            return View(enderecosViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alterar(EnderecosViewModel enderecos)
        {
            if (ModelState.IsValid)
            {
                var end = Mapper.Map<EnderecosViewModel, Enderecos>(enderecos);
                _enderecosRep.Alterar(end);

                return RedirectToAction("Index");
            }

            return View(enderecos);
        }

        public ActionResult Remover(int Id)
        {
            var enderecos = _enderecosRep.ConsultaporId(Id);
            var enderecosViewModel = Mapper.Map<Enderecos, EnderecosViewModel>(enderecos);

            return View(enderecosViewModel);
        }

        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmacaoRemover(int Id)
        {
            var end = _enderecosRep.ConsultaporId(Id);
            _enderecosRep.Remover(end);

            return RedirectToAction("Index");
        }
    }
}