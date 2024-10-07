using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;
using System.Collections.Generic;

namespace ProjetoOdontoPOO.Controllers
{
    public class ConvenioController
    {
        private readonly ConvenioService _convenioService;

        public ConvenioController()
        {
            _convenioService = new ConvenioService();
        }

        public List<Convenio> ObterConvenios()
        {
            return _convenioService.ObterConvenios();
        }

        public void InserirConvenio(Convenio convenio)
        {
            _convenioService.InserirConvenio(convenio);
        }
    }
}
