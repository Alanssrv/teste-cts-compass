using Common.Entity;

namespace Common.Database.Transaction.Interfaces
{
    public interface IProdutoTransaction
    {
        IEnumerable<Produto> GetProdutos();
    }
}
