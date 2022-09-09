using Devedores.Controllers.Enums;
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

        public IActionResult Inserir(PaginaRetorno? paginaRetorno, int? id)
        {
            ViewData["retornarPagina"] = paginaRetorno;

            if (id.HasValue)
            {
                ViewData["idRotaPagina"] = id.Value;
            }
            else
            {
                ViewData["idRotaPagina"] = 0;
            }

            return View(new Pessoa());
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Previnir ataque CSRF
        public IActionResult Inserir(Pessoa pessoa)
        {
            _pessoasServico.Inserir(pessoa);
            return RedirectToAction(nameof(Inserir), "Devedores");
        }

        public IActionResult DevedorInserir()
        {
            return RedirectToAction(nameof(Inserir), "Devedores");
        }

        public IActionResult DevedorEditar(int? id)
        {
            return RedirectToAction("Editar", "Devedores", new { id = id.Value });
        }        
    }
}
