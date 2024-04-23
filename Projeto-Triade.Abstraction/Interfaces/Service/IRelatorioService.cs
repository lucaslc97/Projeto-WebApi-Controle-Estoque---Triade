using Projeto_Triade.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Triade.Abstraction.Interfaces.Service
{
    public interface IRelatorioService
    {
        Task<RelatorioAquisicao> GetRelatorioAquisicaoByDateAsync(DateTime dataInicio, DateTime dataFim);
        Task<RelatorioSaidaDeEstoque> GetRelatorioSaidaEstoqueByDateAsync(DateTime dataInicio, DateTime dataFim, bool requisitarProdutoComposto);
    }
}
