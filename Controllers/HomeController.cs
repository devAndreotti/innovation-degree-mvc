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

    public class HomeController : Controller {
        
        public IActionResult Index() {

            // pacotesRepository aR = pacotesRepository();
            // aR.testeConexao();
            return View();

        } // TESTE ANTIGO

        public IActionResult Party() {

            return View();

        }

    }

} // OK