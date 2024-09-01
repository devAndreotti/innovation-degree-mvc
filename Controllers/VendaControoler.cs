using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Atividade_2.Models;
using System.Threading;

namespace Projeto_Integrador_MVC.Controllers {

    public class VendaController : Controller {
        
        public IActionResult Conceito() {

            return View();

        }
        
        [HttpPost]
        
        public IActionResult Conceito(venda v) {

            VendaRepository vr = new VendaRepository();
            vr.Inserir(v);
            return RedirectToAction("Index", "Home");

        } // INSERIR NO BANCO

    }

} // OK