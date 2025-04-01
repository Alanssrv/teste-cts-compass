using Common.Database.Transaction.Interfaces;
using Common.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Produtos.API.Controllers
{
    /// <summary>
    /// Controller responsável pelas operações relacionadas aos produtos
    /// </summary>
    [Route("api")]
    public class ProdutoController(IProdutoTransaction transaction) : Controller
    {
        private readonly IProdutoTransaction _transaction = transaction;

        /// <summary>
        /// Obtém a lista de todos os produtos (GET)
        /// </summary>
        /// <returns>Lista de produtos</returns>
        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            try
            {
                var produtos = _transaction.GetProdutos();

                return Ok(produtos);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
