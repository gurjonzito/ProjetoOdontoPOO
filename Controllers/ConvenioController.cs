using ProjetoOdontoPOO.Models;
using ProjetoOdontoPOO.Services;

namespace ProjetoOdontoPOO.Controllers
{
    public class ConvenioController
    {
        private readonly ConvenioService _convenioService;

        public ConvenioController()
        {
            _convenioService = new ConvenioService();
        }

        public void InserirConvenio(Convenio convenio)
        {
            _convenioService.InserirConvenio(convenio);
        }
    }
}
