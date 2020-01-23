using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCondominio.DAL.Models
{
   public  class Proprietarios
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string NomeCompleto { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int Apartamento { get; set; }
    }
}
