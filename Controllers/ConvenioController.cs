using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Collections.Generic;
using System.Data;

namespace ProjetoOdontoPOO.Controllers
{
    public class ConvenioController
    {
        private readonly ConvenioService _convenioService;

        public ConvenioController()
        {
            _convenioService = new ConvenioService();
        }

        public Convenio ObterConvenioPorId(int convenioId)
        {
            try
            {
                return _convenioService.ObterDadosConvenioPorId(convenioId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter convênio: {ex.Message}");
                throw;
            }
        }

        public DataTable ObterTodosConvenios()
        {
            try
            {
                return _convenioService.ObterTodosConvenios();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter lista de convênios: {ex.Message}");
                throw;
            }
        }

        public string InserirConvenio(Convenio convenio)
        {
            var resultado = _convenioService.InserirConvenio(convenio);

            return resultado.Mensagem;
        }
    }
}
