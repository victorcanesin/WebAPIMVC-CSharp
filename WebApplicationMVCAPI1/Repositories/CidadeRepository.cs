using Microsoft.EntityFrameworkCore;
using WebApplicationMVCAPI1.Context;
using WebApplicationMVCAPI1.Models;

namespace WebApplicationMVCAPI1.Repositories
{
    public class CidadeRepository
    {
        private readonly InformixContext _informixContext;

        public CidadeRepository(InformixContext informixContext)
        {
            _informixContext = informixContext;
        }

        public IEnumerable<Cidade> obterCidades()
        {
            return _informixContext.Cidades
                                   .ToList();
        }

        public Cidade obterCidade(short cidadeCodigo)
        {
            return _informixContext.Cidades
                  .Where(c => c.cidadeCodigo == cidadeCodigo)
                  .FirstOrDefault();
        }

        public void incluir(Cidade cidade)
        {
            _informixContext.Cidades.Add(cidade);
            _informixContext.SaveChanges();
        }

        public void alterar(Cidade cidade)
        {
            _informixContext.Cidades.Update(cidade);
            _informixContext.SaveChanges();
        }

        public void excluir(Cidade cidade)
        {
            _informixContext.Cidades.Remove(cidade);
            _informixContext.SaveChanges();
        }

    }
}
