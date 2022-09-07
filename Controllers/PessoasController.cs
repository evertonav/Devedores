using Devedores.Models;
using Devedores.Servico;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devedores.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoasServico _pessoasServico;

        public PessoasController(PessoasServico pessoasServico)
        {
            _pessoasServico = pessoasServico;
        }

        public IActionResult Inserir()
        {
            return View(new Pessoa());
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Previnir ataque CSRF
        public IActionResult Inserir(Pessoa pessoa)
        {
            _pessoasServico.Inserir(pessoa);
            return RedirectToAction(nameof(Inserir), "Devedores");
        }
    }
}
