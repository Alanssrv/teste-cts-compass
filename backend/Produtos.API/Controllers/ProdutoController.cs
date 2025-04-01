using Common.Database.Transaction.Interfaces;
using Common.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Produtos.API.Controllers
{
    [Route("api")]
    public class ProdutoController(IProdutoTransaction transaction) : Controller
    {
        private readonly IProdutoTransaction _transaction = transaction;

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
