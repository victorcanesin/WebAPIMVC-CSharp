using WebApplicationMVCAPI1.Context;
using WebApplicationMVCAPI1.Models;

namespace WebApplicationMVCAPI1.Repositories
{
    public class EstadoRepository
    {
        private readonly InformixContext _informixContext;

        public EstadoRepository(InformixContext informixContext)
        {
            _informixContext = informixContext;
        }

        public IEnumerable<Estado> obterEstados()
        {
            return _informixContext.Estados.ToList();
        }
    }
}
