using Microsoft.AspNetCore.Mvc;
using Projeto_Triade.Abstraction.Interfaces.Service;
using Projeto_Triade.Model.Model;

namespace Projeto_Triade.WebApi.Controllers
{
    [ApiController]
    [Route("Relatorio")]
    public class RequisicoesController : ControllerBase
    {
        private readonly IRequisicaoService _requisicaoService;
        public RequisicoesController(IRequisicaoService requisicaoService)
        {
            _requisicaoService = requisicaoService;
        }

        [HttpPut("RequisicacaoDeProduto")]
        public  async Task<RequisicoesDeProduto> RequisicacaoDeProduto(string nome, string[] produtosRetirados)
        {
            return await _requisicaoService.GetRequisicaoProdutosAsync(nome, produtosRetirados);
        }
    }
}
