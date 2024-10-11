namespace SerTerraQueijaria.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        public string Produtos { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int QtdEstoque { get; set; }
        public Guid TipoProdutoId { get; set; }
    }
}

