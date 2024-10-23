using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Repositories;
using System;
using System.Data;

namespace ProjetoOdontoPOO.Services
{
    public class ConvenioService
    {
        private readonly ConvenioRepository _convenioRepository;

        public ConvenioService()
        {
            _convenioRepository = new ConvenioRepository();
        }

        public Convenio ObterDadosConvenioPorId(int convenioId)
        {
            if (convenioId <= 0)
                throw new ArgumentException("ID do convênio inválido.");

            return _convenioRepository.ObterDadosConvenioPorId(convenioId);
        }

        public DataTable ObterTodosConvenios()
        {
            return _convenioRepository.ObterDadosConvenios();
        }

        public bool AtualizarConvenio(int convenioId, Convenio convenio)
        {
            var resultadoValidacao = ValidarCadastroConvenio(convenio);
            if (!resultadoValidacao.Sucesso)
                throw new ArgumentException(resultadoValidacao.Mensagem);

            return _convenioRepository.AtualizarConvenio(convenioId, convenio);
        }

        public OperationResult InserirConvenio(Convenio convenio)
        {
            try
            {
                var resultadoValidacao = ValidarCadastroConvenio(convenio);
                if (!resultadoValidacao.Sucesso)
                    return resultadoValidacao;

                _convenioRepository.InserirConvenio(convenio);
                return new OperationResult(true, "Convênio cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return new OperationResult(false, $"Erro ao cadastrar convênio: {ex.Message}");
            }
        }

        private OperationResult ValidarCadastroConvenio(Convenio convenio)
        {
            return ValidarConvenio(convenio);
        }

        private OperationResult ValidarConvenio(Convenio convenio)
        {
            string cnpjLimpo = convenio.CNPJ.Replace(".", "").Replace("-", "").Replace(" ", "").Replace(",", "");
            Console.WriteLine($"CNPJ Limpo: {cnpjLimpo}");

            string telefoneLimpo = convenio.Telefone.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            Console.WriteLine($"Telefone Limpo: {telefoneLimpo}");

            if (string.IsNullOrWhiteSpace(convenio.Nome))
                return new OperationResult(false, "O nome do convênio é obrigatório.");

            if (string.IsNullOrWhiteSpace(cnpjLimpo))
                return new OperationResult(false, "O CNPJ do convênio é obrigatório.");

            if (cnpjLimpo.Length != 14)
                return new OperationResult(false, "O CNPJ do convênio deve conter 14 dígitos.");

            if (string.IsNullOrWhiteSpace(telefoneLimpo))
                return new OperationResult(false, "O telefone do convênio é obrigatório.");

            if (string.IsNullOrWhiteSpace(convenio.Endereco))
                return new OperationResult(false, "O endereço do convênio é obrigatório.");

            if (string.IsNullOrWhiteSpace(convenio.Email) && (convenio.Email.Contains(" ") || !convenio.Email.Contains("@")))
                return new OperationResult(false, "E-mail inválido.");

            if (convenio.DataCriacao == DateTime.MinValue)
                return new OperationResult(false, "Data de criação inválida.");

            return new OperationResult(true, "Validação bem-sucedida!");
        }
    }
}
