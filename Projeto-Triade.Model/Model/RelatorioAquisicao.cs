﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Triade.Model.Model
{
    public class RelatorioAquisicao
    {
        public IEnumerable<Produto> ProdutosSimples { get; set; }
        public IEnumerable<ProdutoComposto> ProdutosComposto { get; set; }
    }
}
