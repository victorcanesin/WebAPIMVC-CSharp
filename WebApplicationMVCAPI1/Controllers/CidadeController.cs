using Microsoft.AspNetCore.Mvc;
using WebApplicationMVCAPI1.Models;
using WebApplicationMVCAPI1.Repositories;

namespace WebApplicationMVCAPI1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class CidadeController : ControllerBase
    {        
        private readonly CidadeRepository _cidadeRepository;

        public CidadeController(CidadeRepository cidadeRepository)
        {
            _cidadeRepository = cidadeRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cidade>> Obter()
        {
            return Ok(_cidadeRepository.obterCidades());
        }

        [HttpPost]
        public ActionResult<Cidade> incluir(Cidade cidade)
        {
           _cidadeRepository.incluir(cidade);
            return Ok(cidade);
        }

        [HttpPut]
        public ActionResult<Cidade> alterar(Cidade cidade)
        {
            _cidadeRepository.alterar(cidade);
            return Ok(cidade);
        }

        [HttpDelete("{cidadeCodigo}")]
        public  ActionResult<Cidade> excluir(short cidadeCodigo)
        {
            var city = _cidadeRepository.obterCidade(cidadeCodigo);

            if (city == null)
            {
                return NotFound();
            }
            else
            {
                _cidadeRepository.excluir(city);                
                return Ok();
            }
        }
    }
}
