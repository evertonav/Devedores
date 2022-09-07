using Devedores.Servico;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devedores.Controllers
{
    public class RelatoriosController : Controller
    {
        private readonly RelatorioServico _relatorioServico;

        public RelatoriosController(RelatorioServico relatorioServico)
        {
            _relatorioServico = relatorioServico;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RelatorioAnalitico(int? pago)
        {
            return View(_relatorioServico.RelatorioAnalitico(pago == 1));
        }

        public IActionResult RelatorioSintetico(int? pago)
        {
            return View(_relatorioServico.RelatorioSintetico(pago == 1));
        }
    }
}
