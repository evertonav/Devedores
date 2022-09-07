using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Devedores.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do {0} deve ser entre {2} e {1} caracteres")]
        public string Nome { get; set; }
    }
}
