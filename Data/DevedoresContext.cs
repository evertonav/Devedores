using Devedores.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devedores.Data
{
    public class DevedoresContext : DbContext 
    {
        public DevedoresContext(DbContextOptions<DevedoresContext> options) : base(options)
        {          
        }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Devedor> Devedor { get; set; }
    }
}
