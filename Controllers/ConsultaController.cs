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
    public class ConsultaController
    {
        private readonly ConsultaService _consultaService;

        public ConsultaController()
        {
            _consultaService = new ConsultaService();
        }

        public DataTable ObterTodasConsultas()
        {
            try
            {
                return _consultaService.ObterTodasConsultas();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter lista de consultas: {ex.Message}");
                throw;
            }
        }

        public string InserirConsulta(Consulta consulta)
        {
            var resultado = _consultaService.InserirConsulta(consulta);

            return resultado.Mensagem;
        }
    }
}
