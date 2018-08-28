using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Web.MVC.Controllers
{
    public class AnimalController : Controller
    {
        private PetshopContext _context = new PetshopContext();

        [HttpGet]
        public ActionResult Listar()
        {
            var animais = _context.Animais.ToList();

            return View(animais);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Animal animal)
        {
            _context.Animais.Add(animal);

            _context.SaveChanges();

            TempData["msg"] = "Cadastrado com sucesso";

            return RedirectToAction("Cadastrar");
        }


        [HttpGet]
        public ActionResult Alterar(int id)
        {
            var animal = _context.Animais.Find(id);

            return View(animal);
        }

        [HttpPost]
        public ActionResult Alterar(Animal animal)
        {
            _context.Entry(animal).State = System.Data.Entity.EntityState.Modified;

            _context.SaveChanges();

            TempData["msg"] = "Animal atualizado";

            return RedirectToAction("Alterar");
        }
    }
}