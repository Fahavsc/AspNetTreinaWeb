using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeCompany.TesteAPSNETMVC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FakeCompany.TesteAPSNETMVC.Web.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//Garantir que sera validado o token de autencação da aplicação toda vez que for chamado o controller
        public IActionResult Index([Bind("Nome", "Idade", "Endereco","Email")]Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                pessoa.IsAtivo = true;
                return View("Saudacao", pessoa);
            }
            else
                return View(pessoa);
        }
    }
}