using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOdontoPOO.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal ValorPago { get; set; }
        public string PagamentoStatus { get; set; }
        public  string MetodoPagamento {  get; set; }

    }
}
