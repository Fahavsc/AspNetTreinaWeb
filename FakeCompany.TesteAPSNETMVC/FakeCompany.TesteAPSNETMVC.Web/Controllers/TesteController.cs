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
        public IActionResult Index(Pessoa pessoa)
        {
            if (ModelState.IsValid)
                return View("Saudacao", pessoa);
            else
                return View(pessoa);
        }
    }
}