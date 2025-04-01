namespace Common.Entity
{
    /// <summary>
    /// Representação da entidade Produto
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// Campo de identificador do produto
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Campo nome do produto
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Campo preco do produto
        /// </summary>
        public decimal Preco { get; set; }

        /// <summary>
        /// Campo quantidade do produto
        /// </summary>
        public int Quantidade { get; set; }
    }
}
