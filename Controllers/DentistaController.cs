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

        public List<string> ObterEstados()
        {
            try
            {
                return _dentistaService.ObterEstados();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter estados: {ex.Message}");
                throw;
            }
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
    }
}
