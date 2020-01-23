using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysCondominio.DAL.Models
{
    public class Pagamentos
    {
        public int Id { get; set; }
        public int Apartamento { get; set; }
        public decimal TaxaCondominio { get; set; }
        public string FormaPagamento { get; set; }
        public DateTime Data { get; set; }
        public string Mes { get; set; }
        public string Observacoes { get; set; }
    }
}
