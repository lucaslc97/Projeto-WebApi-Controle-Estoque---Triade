using Microsoft.AspNetCore.Mvc;
using Projeto_Triade.Abstraction.Interfaces.Service;
using Projeto_Triade.Model.Model;

namespace Projeto_Triade.WebApi.Controllers
{
    [ApiController]
    [Route("Relatorio")]
    public class RequisicoesController : ControllerBase
    {
        public RequisicoesController()
        {
        }

        [HttpPut("RequisicacaoDeProduto")]
        public  Task<RequisicoesDeProduto> RequisicacaoDeProduto(string nome, string[] produtosRetirados)
        {
            throw new NotImplementedException();
        }
    }
}
