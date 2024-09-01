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

namespace Atividade92.Controllers {

    public class UsuariosController : Controller {

        public IActionResult Cadastro() {
            // if (HttpContext.Session.GetInt32("id") == null)  ISSO FARIA COM QUE FOSSE IMPOSSÍVEL CADASTRAR SEM ESTAR LOGADO
            // return RedirectToAction("AvisoLogin");
            return View();

        }
        
        [HttpPost]
        
        public IActionResult Cadastro(usuarios u) {

            UsuariosRepository ur = new UsuariosRepository();
            ur.Insert(u);
            return RedirectToAction("Index", "Home");

        } // CADASTRO REFERENTE AO USUÁRIO

        public IActionResult Login() {

            return View();

        }

        [HttpPost]

        public IActionResult Login(usuarios u) {

            UsuariosRepository ur = new UsuariosRepository();
            usuarios usu = ur.QueryLogin(u);

            if (usu != null) {

                HttpContext.Session.SetInt32("id", u.id);
                HttpContext.Session.SetString("login", u.login);
                ViewBag.Mensagem ="Deu CERTO! Você está logado!";
                return RedirectToAction("Index", "Home");

            }

            else {

                ViewBag.Mensagem ="Deu ERRADO! Você não está logado!";
                return View();
            
            }

        } // MENSAGEM DADA CASO O USUÁRIO CONSIGA LOGAR OU NÃO

        public IActionResult Logout() {

            HttpContext.Session.Clear();
            return View();

        } // LIMPAR A SESSÃO

        public IActionResult AvisoLogin() {

            return View();

        }
    
    }

} // OK