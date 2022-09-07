using Devedores.Data;
using Devedores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Devedores.Servico
{
    public class DevedoresServico
    {
        private readonly DevedoresContext _context;

        public DevedoresServico(DevedoresContext context)
        {
            _context = context;
        }

        public List<Devedor> BuscarTodos()
        {
            return _context.Devedor.Include(x => x.Pessoa).ToList();
        }

        public Devedor BuscarPeloId(int Id)
        {
            return _context.Devedor.Where(x => x.Id == Id).Include(x => x.Pessoa).FirstOrDefault(x => x.Id == Id);
        }

        public void Inserir(Devedor devedor) 
        {
            _context.Devedor.Add(devedor);
            _context.SaveChanges();
        }

        public void Atualizar(Devedor devedor)
        {
            _context.Devedor.Update(devedor);
            _context.SaveChanges();
        }

        public void Deletar(Devedor devedor)
        {
            try
            {
                _context.Devedor.Remove(devedor);
                _context.SaveChanges();
            }
            catch (DbUpdateException excecao)
            {
                throw new ApplicationException(excecao.Message);
            }
        }
    }
}
