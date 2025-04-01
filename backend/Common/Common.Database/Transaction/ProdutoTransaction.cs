using Common.Database.Transaction.Interfaces;
using Common.Entity;

namespace Common.Database.Transaction
{
    public class ProdutoTransaction : IProdutoTransaction
    {
        private readonly AppDbContext _context;

        public ProdutoTransaction() {
            _context = new AppDbContext();
        }

        public IEnumerable<Produto> GetProdutos() {
            return _context.Produtos.ToList();
        }
    }
}
