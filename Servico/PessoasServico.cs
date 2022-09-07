using Devedores.Data;
using Devedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devedores.Servico
{
    public class PessoasServico
    {
        private readonly DevedoresContext _context;

        public PessoasServico(DevedoresContext context)
        {
            _context = context;
        }

        public List<Pessoa> BuscarTodas()
        {
            return _context.Pessoa.ToList();
        }

        public void Inserir(Pessoa pessoa)
        {
            _context.Pessoa.Add(pessoa);
            _context.SaveChanges();
        }
    }
}
