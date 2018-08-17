﻿using _04.Fiap.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _04.Fiap.Web.MVC.Controllers
{
    public class MedicoController : Controller
    {
        // Simulação de banco de dados.
        private static List<Medico> _banco = new List<Medico>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_banco);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Medico medico)
        {
            _banco.Add(medico);

            TempData["mensagem"] = "Médico cadastrado com sucesso.";

            return RedirectToAction("Cadastrar");
        }
    }
}