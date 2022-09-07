using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Devedores.Models
{
    public class Devedor
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }

        [Range(1.0, 50000.0, ErrorMessage = "{0} deve ser entre {1} e {2}")]        
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Valor { get; set; }
        public Boolean Pago { get; set; }
    }
}
