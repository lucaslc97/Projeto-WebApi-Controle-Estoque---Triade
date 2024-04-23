using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Triade.Model.Model
{
    public class RequisicoesDeProduto
    {
        public string NomeFuncionario { get; set; }
        public int QuantidadesRetiradas { get; set; }
        public IEnumerable<Produto> Produtos { get; set;}
    }
}
