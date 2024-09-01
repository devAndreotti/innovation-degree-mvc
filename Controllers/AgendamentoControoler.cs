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

namespace Atividade_2.Controllers {

    public class AgendamentoController : Controller {
        
        public IActionResult Entrevista() {

            return View();

        }
        
        [HttpPost]
        
        public IActionResult Entrevista(agendamento a) {

            AgendamentoRepository ar = new AgendamentoRepository();
            ar.Insert(a);
            return RedirectToAction("Index", "Home");

        } // INSERIR NO BANCO

    }

} // OK