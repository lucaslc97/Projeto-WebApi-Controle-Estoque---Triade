using Projeto_Triade.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Triade.Abstraction.Interfaces.Service
{
    public interface IRequisicaoService
    {
        Task<RequisicoesDeProduto> GetRequisicaoProdutosAsync(string nome, string[] produtosRetirados);
    }
}
