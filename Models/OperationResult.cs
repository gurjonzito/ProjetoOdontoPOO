using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOdontoPOO.Models
{
    public class OperationResult
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }

        public OperationResult(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }
    }
}
