using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOdontoPOO.Controllers
{
    public class DentistaController
    {
        private readonly DentistaService _dentistaService;

        public DentistaController()
        {
            _dentistaService = new DentistaService();
        }

        public Dentista ObterDentistaPorId(int dentistaId)
        {
            try
            {
                return _dentistaService.ObterDadosDentistaPorId(dentistaId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter dentista: {ex.Message}");
                throw;
            }
        }

        public DataTable ObterTodosDentistas()
        {
            try
            {
                return _dentistaService.ObterTodosDentistas();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter lista de dentistas: {ex.Message}");
                throw;
            }
        }

        public string InserirDentista(Dentista dentista)
        {
            var resultado = _dentistaService.InserirDentista(dentista);

            return resultado.Mensagem;
        }

        public bool AtualizarDentista(int dentistaId, Dentista dentista)
        {
            try
            {
                return _dentistaService.AtualizarDentista(dentistaId, dentista);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar dentista: {ex.Message}");
                throw;
            }
        }
    }
}
