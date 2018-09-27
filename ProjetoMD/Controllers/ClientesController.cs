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
    public class ClientesController : Controller
    {
        private readonly ClientesRepositorio _clientesRep = new ClientesRepositorio();
        // GET: Clientes
        public ActionResult Index()
        {
            var clientesViewModel = Mapper.Map<IEnumerable<Clientes>,
                IEnumerable<ClientesViewModel>>(_clientesRep.ConsultarTodos());

            return View(clientesViewModel);
        }

        public ActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(ClientesViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var cli = Mapper.Map<ClientesViewModel, Clientes>(cliente);
                _clientesRep.Adicionar(cli);

                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Alterar(int Id)
        {
            var clientes = _clientesRep.ConsultaporId(Id);
            var clientesViewModel = Mapper.Map<Clientes, ClientesViewModel>(clientes);

            return View(clientesViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alterar(ClientesViewModel clientes)
        {
            if (ModelState.IsValid)
            {
                var cli = Mapper.Map<ClientesViewModel, Clientes>(clientes);
                _clientesRep.Alterar(cli);

                return RedirectToAction("Index");
            }

            return View(clientes);
        }

        public ActionResult Remover(int Id)
        {
            var clientes = _clientesRep.ConsultaporId(Id);
            var clientesViewModel = Mapper.Map<Clientes, ClientesViewModel>(clientes);

            return View(clientesViewModel);
        }

        [HttpPost, ActionName("Remover")]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmacaoRemover(int Id)
        {
            var cli = _clientesRep.ConsultaporId(Id);
            _clientesRep.Remover(cli);

            return RedirectToAction("Index");
        }
    }
}