using Projeto_Triade.Abstraction.Interfaces.Repository;
using Projeto_Triade.Abstraction.Interfaces.Service;
using Projeto_Triade.Model.Model;

namespace Projeto_Triade.Service
{
    public class RelaorioService : IRelatorioService
    {
        private readonly IRelatorioRepository _relatorioRepository;
        public RelaorioService(IRelatorioRepository relatorioRepository)
        {
            _relatorioRepository = relatorioRepository;
        }
        public Task<RelatorioAquisicao> GetRelatorioAquisicaoByDateAsync(DateTime dataInicio, DateTime dataFim)
        {
            throw new NotImplementedException();
        }

        public Task<RelatorioSaidaDeEstoque> GetRelatorioSaidaEstoqueByDateAsync(DateTime dataInicio, DateTime dataFim, bool requisitarProdutoComposto)
        {
            throw new NotImplementedException();
        }
    }
}
