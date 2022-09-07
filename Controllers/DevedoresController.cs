using Devedores.Data;
using Devedores.Models;
using Devedores.Models.ViewModel;
using Devedores.Servico;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devedores.Controllers
{
    public class DevedoresController : Controller
    {
        private readonly DevedoresServico _devedoresServico;
        private readonly PessoasServico _pessoasServico;

        public DevedoresController(DevedoresServico devedoresServico, PessoasServico pessoasServico)
        {
            _devedoresServico = devedoresServico;
            _pessoasServico = pessoasServico;
        }

        public IActionResult Index()
        {
            return View(_devedoresServico.BuscarTodos());
        }

        public IActionResult Inserir()
        {
            DevedorFormViewModel devedorFormViewModel = new DevedorFormViewModel();
            devedorFormViewModel.Pessoas = _pessoasServico.BuscarTodas();
            return View(devedorFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Previnir ataque CSRF
        public IActionResult Inserir(Devedor devedor)
        {
            _devedoresServico.Inserir(devedor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult InserirPessoas()
        {
            return RedirectToAction(nameof(Inserir), "Pessoas");
        }

        public IActionResult Editar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Devedor devedor = _devedoresServico.BuscarPeloId(id.Value);

            if (devedor == null)
            {
                return NotFound();
            }

            DevedorFormViewModel devedorFormViewModel = new DevedorFormViewModel();
            devedorFormViewModel.Pessoas = _pessoasServico.BuscarTodas();
            devedorFormViewModel.Devedor = devedor;
            
            return View(devedorFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Previnir ataque CSRF
        public IActionResult Editar(Devedor devedor)
        {
            _devedoresServico.Atualizar(devedor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Deletar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Devedor devedor = _devedoresServico.BuscarPeloId(id.Value);

            if (devedor == null)
            {
                return NotFound();
            }

            return View(devedor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //Previnir ataque CSRF
        public IActionResult Deletar(Devedor devedor)
        {
            _devedoresServico.Deletar(devedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
