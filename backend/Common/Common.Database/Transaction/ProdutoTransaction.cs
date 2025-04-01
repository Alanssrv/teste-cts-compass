using Common.Database.Transaction.Interfaces;
using Common.Entity;

namespace Common.Database.Transaction
{
    /// <summary>
    /// Classe responsável pelas transações relacionadas à entidade Produto
    /// </summary>
    public class ProdutoTransaction : IProdutoTransaction
    {
        private readonly AppDbContext _context;

        /// <summary>
        /// Construtor da classe ProdutoTransaction com a criação de instância com banco de dados
        /// </summary>
        public ProdutoTransaction()
        {
            _context = new AppDbContext();
        }

        /// <summary>
        /// Obtém a lista de todos os produtos do banco de dados
        /// </summary>
        /// <returns>Lista de produtos</returns>
        public IEnumerable<Produto> GetProdutos()
        {
            return _context.Produtos.ToList();
        }
    }
}
