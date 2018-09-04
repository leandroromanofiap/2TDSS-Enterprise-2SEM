using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class TecnicoController : Controller
    {
        private BrasfootContext _context = new BrasfootContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Cadastrar(Tecnico tecnico)
        {
            _context.Tecnicos.Add(tecnico);

            _context.SaveChanges();

            TempData["msg"] = "Técnico cadastrado com sucesso.";

            return RedirectToAction("Cadastrar");
        }
    }
}