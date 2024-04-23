using Microsoft.AspNetCore.Mvc;
using Projeto_Triade.Abstraction.Interfaces.Service;
using Projeto_Triade.Model.Model;

namespace Projeto_Triade.WebApi.Controllers
{
    [ApiController]
    [Route("Relatorio")]
    public class RelatorioController : ControllerBase
    {
        private readonly IRelatorioService _relatorioService;
        public RelatorioController(IRelatorioService relatorioService)
        {
            _relatorioService = relatorioService;
        }

        [HttpGet("GetRelatorioAquisicao")]
        public async Task<RelatorioAquisicao> GetRelatorioAquisicao(DateTime dataInicio, DateTime dataFim)
        {
            return await _relatorioService.GetRelatorioAquisicaoByDateAsync(dataInicio, dataFim);
        }

        [HttpGet("GetRelatorioSaidaEstoque")]
        public async Task<RelatorioSaidaDeEstoque> GetRelatorioSaidaEstoque(DateTime dataInicio, DateTime dataFim, bool exibirProdutoComposto)
        {
            return await _relatorioService.GetRelatorioSaidaEstoqueByDateAsync(dataInicio, dataFim, exibirProdutoComposto);
        }
    }
}
