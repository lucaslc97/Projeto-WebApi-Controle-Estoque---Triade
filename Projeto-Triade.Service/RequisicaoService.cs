using Projeto_Triade.Abstraction.Interfaces.Repository;
using Projeto_Triade.Abstraction.Interfaces.Service;
using Projeto_Triade.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Triade.Service
{
    public class RequisicaoService : IRequisicaoService
    {
        private readonly IRequisicaoRepository _requisicaoRepository;
        public RequisicaoService(IRequisicaoRepository requisicaoRepository)
        {
            _requisicaoRepository = requisicaoRepository;
        }

        public Task<RequisicoesDeProduto> GetRequisicaoProdutosAsync(string nome, string[] produtosRetirados)
        {
            throw new NotImplementedException();
        }
    }
}
