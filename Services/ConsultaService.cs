using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Repositories;
using System;
using System.Data;

namespace ProjetoOdontoPOO.Services
{
    public class ConsultaService
    {
        private readonly ConsultaRepository _consultaRepository;

        public ConsultaService()
        {
            _consultaRepository = new ConsultaRepository();
        }

        public Consulta ObterDadosConsultaPorId(int consultaId)
        {
            if (consultaId <= 0)
                throw new ArgumentException("ID da consulta inválido.");

            return _consultaRepository.ObterDadosConsultaPorId(consultaId);
        }

        public DataTable ObterTodasConsultas()
        {
            return _consultaRepository.ObterDadosConsultas();
        }

        public bool AtualizarConsulta(int consultaId, Consulta consulta)
        {
            var resultadoValidacao = ValidarCadastroConsulta(consulta);
            if (!resultadoValidacao.Sucesso)
                throw new ArgumentException(resultadoValidacao.Mensagem);

            return _consultaRepository.AtualizarConsulta(consultaId, consulta);
        }

        public OperationResult InserirConsulta(Consulta consulta)
        {
            try
            {
                var resultadoValidacao = ValidarCadastroConsulta(consulta);
                if (!resultadoValidacao.Sucesso)
                    return resultadoValidacao;

                _consultaRepository.InserirConsulta(consulta);
                return new OperationResult(true, "Consulta agendada com sucesso!");
            }
            catch (Exception ex)
            {
                return new OperationResult(false, $"Erro ao agendar consulta: {ex.Message}");
            }
        }

        private OperationResult ValidarCadastroConsulta(Consulta consulta)
        {
            return ValidarConsulta(consulta);
        }

        private OperationResult ValidarConsulta(Consulta consulta)
        {

            if (consulta.DataConsulta < DateTime.Now)
                return new OperationResult(false, "A data da consulta não pode ser no passado.");

            if (consulta.Paciente == null)
                return new OperationResult(false, "A consulta deve estar associada a um paciente.");

            if (consulta.Dentista == null)
                return new OperationResult(false, "A consulta deve estar associada a um dentista.");

            return new OperationResult(true, "Validação bem-sucedida!");
        }
    }
}
