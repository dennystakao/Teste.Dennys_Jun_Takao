using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Teste.Dennys_Jun_Takao.Service.Services;
using Teste.Dennys_Jun_Takao.WebSiteTeste.Models;

namespace Teste.Dennys_Jun_Takao.WebSiteTeste.Controllers
{
    public class HomeController : Controller
    {
        ConsoleResolution _cr = new ConsoleResolution();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Sobre()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Resultado()
        {
            return View(new ResultadoVm());
        }

        [HttpPost]
        public ActionResult Resultado(ResultadoVm vm)
        {
            if (!string.IsNullOrEmpty(vm.PalavraTriangulo))
                vm.Resultado = _cr.AvaliacaoTecnica6(vm.PalavraTriangulo);

            return View(vm);
        }
    }
}