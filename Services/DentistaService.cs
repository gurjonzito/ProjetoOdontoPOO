using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOdontoPOO.Services
{
    public class DentistaService
    {
        private readonly DentistaRepository _dentistaRepository;

        public DentistaService()
        {
            _dentistaRepository = new DentistaRepository();
        }

        public List<string> ObterEstados()
        {
            return _dentistaRepository.ObterEstados();
        }

        public Dentista ObterDadosDentistaPorId(int dentistaId)
        {
            if (dentistaId <= 0)
                throw new ArgumentException("ID do dentista inválido.");

            return _dentistaRepository.ObterDadosDentistaPorId(dentistaId);
        }

        public DataTable ObterTodosDentistas()
        {
            return _dentistaRepository.ObterDadosDentistas();
        }

        public OperationResult InserirDentista(Dentista dentista)
        {
            try
            {
                var resultadoValidacao = ValidarCadastroDentista(dentista);
                if (!resultadoValidacao.Sucesso)
                    return resultadoValidacao;

                _dentistaRepository.InserirDentista(dentista);
                return new OperationResult(true, "Dentista cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return new OperationResult(false, $"Erro ao cadastrar dentista: {ex.Message}");
            }
        }

        private OperationResult ValidarCadastroDentista(Dentista dentista)
        {
            return ValidarDentista(dentista);
        }

        private OperationResult ValidarDentista(Dentista dentista)
        {
            string telefoneLimpo = dentista.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            Console.WriteLine($"Telefone Limpo: {telefoneLimpo}");

            if (string.IsNullOrWhiteSpace(dentista.Nome))
                return new OperationResult(false, "O nome do dentista é obrigatório.");

            if (string.IsNullOrWhiteSpace(dentista.CRM))
                return new OperationResult(false, "O CRM do dentista é obrigatório.");

            if (dentista.CRM.Length != 6)
                return new OperationResult(false, "O CRM do dentista deve conter 6 dígitos.");

            if (string.IsNullOrWhiteSpace(dentista.Estado) || dentista.Estado.Length != 2)
                return new OperationResult(false, "O Estado do CRM do dentista é obrigatório.");

            if (string.IsNullOrWhiteSpace(dentista.Especialidade))
                return new OperationResult(false, "A especialidade do dentista é obrigatório.");

            if (string.IsNullOrWhiteSpace(telefoneLimpo))
                return new OperationResult(false, "O telefone do dentista é obrigatório.");

            return new OperationResult(true, "Validação bem-sucedida!");
        }
    }
}
