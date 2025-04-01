using Common.Entity;

namespace Common.Database.Transaction.Interfaces
{
    /// <summary>
    /// Interface de configuração de transações relacionadas à entidade Produto
    /// </summary>
    public interface IProdutoTransaction
    {

        /// <summary>
        /// Obtém a lista de todos os produtos do banco de dados
        /// </summary>
        /// <returns>Lista de produtos</returns>
        IEnumerable<Produto> GetProdutos();
    }
}
