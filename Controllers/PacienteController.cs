using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOdontoPOO.Controllers
{
    public class PacienteController
    {
        private readonly PacienteService _pacienteService;

        public PacienteController()
        {
            _pacienteService = new PacienteService();
        }

        public void InserirPacienteComEndereco(Paciente paciente, Endereco endereco)
        {
            _pacienteService.InserirPacienteComEndereco(paciente, endereco);
        }
    }
}
