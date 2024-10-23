using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOdontoPOO.Services
{
    public class ResponsavelService
    {
        private readonly ResponsavelRepository _responsavelRepository;

        public ResponsavelService()
        {
            _responsavelRepository = new ResponsavelRepository();
        }

        public Responsavel ObterDadosResponsavelPorId(int responsavelId)
        {
            if (responsavelId <= 0)
                throw new ArgumentException("ID do responsável inválido.");

            return _responsavelRepository.ObterDadosResponsavelPorId(responsavelId);
        }

        public DataTable ObterTodosResponsaveis()
        {
            return _responsavelRepository.ObterDadosResponsaveis();
        }

        public OperationResult InserirResponsavel(Responsavel responsavel)
        {
            try
            {
                var resultadoValidacao = ValidarCadastroResponsavel(responsavel);
                if (!resultadoValidacao.Sucesso)
                    return resultadoValidacao;

                _responsavelRepository.InserirResponsavel(responsavel);
                return new OperationResult(true, "Responsável cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return new OperationResult(false, $"Erro ao cadastrar responsável: {ex.Message}");
            }
        }

        public bool AtualizarResponsavel(int responsavelId, Responsavel responsavel)
        {
            var resultadoValidacao = ValidarCadastroResponsavel(responsavel);
            if (!resultadoValidacao.Sucesso)
                throw new ArgumentException(resultadoValidacao.Mensagem);

            return _responsavelRepository.AtualizarResponsavel(responsavelId, responsavel);
        }

        private OperationResult ValidarCadastroResponsavel(Responsavel responsavel)
        {
            return ValidarResponsavel(responsavel);
        }

        private OperationResult ValidarResponsavel(Responsavel responsavel)
        {
            string cpfLimpo = responsavel.CPF.Replace(".", "").Replace("-", "").Replace(" ", "").Replace(",", "");
            Console.WriteLine($"CPF Limpo: {cpfLimpo}");

            string telefoneLimpo = responsavel.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            Console.WriteLine($"Telefone Limpo: {telefoneLimpo}");

            if (string.IsNullOrWhiteSpace(responsavel.Nome))
                return new OperationResult(false, "O nome do responsável é obrigatório.");

            if (responsavel.DataNascimento == DateTime.MinValue)
                return new OperationResult(false, "Data de nascimento inválida.");

            if (responsavel.Idade < 18)
                return new OperationResult(false, "Idade inválida.");

            if (string.IsNullOrWhiteSpace(cpfLimpo))
                return new OperationResult(false, "O CPF do responsável é obrigatório.");

            if (cpfLimpo.Length != 11)
                return new OperationResult(false, "O CPF do responsável deve conter 11 dígitos.");

            if (string.IsNullOrWhiteSpace(responsavel.Sexo))
                return new OperationResult(false, "O sexo do responsável é obrigatório.");

            if (string.IsNullOrWhiteSpace(telefoneLimpo))
                return new OperationResult(false, "O telefone do responsável é obrigatório.");

            if (string.IsNullOrWhiteSpace(responsavel.Parentesco))
                return new OperationResult(false, "O parentesco do responsável é obrigatório.");

            return new OperationResult(true, "Validação bem-sucedida!");
        }
    }
}
