using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        public IActionResult Index(string nome, int idade)
        {

            ViewBag.Mensagem = nome;
            ViewBag.Idade = idade;
            ViewBag.MaiorIdade = idade >= 21 ? "Você é maior de idade" : "Você é menor de idade";
            return View("Saudacao");
        }
    }
}