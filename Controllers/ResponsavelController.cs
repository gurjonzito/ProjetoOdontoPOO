using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System.Collections.Generic;

namespace ProjetoOdontoPOO.Controllers
{
    public class ResponsavelController
    {
        private readonly ResponsavelService _responsavelService;

        public ResponsavelController()
        {
            _responsavelService = new ResponsavelService();
        }

        public List<Responsavel> ObterResponsaveis()
        {
            return _responsavelService.ObterResponsaveis();
        }

        //public void InserirResponsavel(Responsavel responsavel)
        //{
        //    _responsavelService.InserirResponsavel(responsavel);
        //}
    }
}
