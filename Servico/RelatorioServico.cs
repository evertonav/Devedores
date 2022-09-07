using Devedores.Data;
using Devedores.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devedores.Servico
{
    public class RelatorioServico
    {
        private readonly DevedoresContext _context;

        public RelatorioServico(DevedoresContext context)
        {
            _context = context;
        }

        public List<Devedor> RelatorioAnalitico(Boolean pago)
        {
            return new DevedoresServico(_context).BuscarTodos().Where(x => x.Pago == pago).ToList();
        }

        public List<Devedor> RelatorioSintetico(Boolean pago)
        {
            var devedorAgrupadoPorNome = new DevedoresServico(_context)
                                            .BuscarTodos()
                                            .Where(x => x.Pago == pago)
                                            .GroupBy(x => x.Pessoa.Nome);

            List<Devedor> devedoresTotalizadoPorNome = new List<Devedor>();

            foreach (var devedorItem in devedorAgrupadoPorNome)
            {
                Devedor devedor = new Devedor();
                devedor.Pessoa = new Pessoa() { Nome = devedorItem.Key };
                devedor.Valor = double.Parse(devedorItem.Sum(e => e.Valor).ToString("F2"));
                devedor.Pago = devedorItem.FirstOrDefault(x => x.Pago == x.Pago).Pago;

                devedoresTotalizadoPorNome.Add(devedor);
            }

            return devedoresTotalizadoPorNome;
        }

    }
}
