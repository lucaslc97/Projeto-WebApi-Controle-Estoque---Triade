namespace Projeto_Triade.Model.Model
{
    public class ProdutoComposto:BaseModel
    {

        public IEnumerable<Produto> ProdutosSimples { get; set; }
    }
}
