using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProjetoOdontoPOO.Controllers
{
    public class ResponsavelController
    {
        private readonly ResponsavelService _responsavelService;

        public ResponsavelController()
        {
            _responsavelService = new ResponsavelService();
        }

        public Responsavel ObterResponsavelPorId(int responsavelId)
        {
            try
            {
                return _responsavelService.ObterDadosResponsavelPorId(responsavelId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter responsável: {ex.Message}");
                throw;
            }
        }

        public DataTable ObterTodosResponsaveis()
        {
            try
            {
                return _responsavelService.ObterTodosResponsaveis();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter lista de responsáveis: {ex.Message}");
                throw;
            }
        }

        public string InserirResponsavel(Responsavel responsavel)
        {
            var resultado = _responsavelService.InserirResponsavel(responsavel);

            return resultado.Mensagem;
        }

        public bool AtualizarResponsavel(int responsavelId, Responsavel responsavel)
        {
            try
            {
                return _responsavelService.AtualizarResponsavel(responsavelId, responsavel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao atualizar responsável: {ex.Message}");
                throw;
            }
        }
    }
}
