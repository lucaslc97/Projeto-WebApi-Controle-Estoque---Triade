using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Triade.Model.Model
{
    public class Produto : BaseModel
    {
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public int Quantidade { get; set; }
    }
}
