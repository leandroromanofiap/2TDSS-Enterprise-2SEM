using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class JogadorController : Controller
    {
        private BrasfootContext _context = new BrasfootContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var times = _context.Times.ToList();

            ViewBag.Times = new SelectList(times, "Times","Nome");

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);

            _context.SaveChanges();

            TempData["msg"] = "Jogador cadastrado com sucesso.";

            return RedirectToAction("Cadastrar");
        }
    }
}