using System.ComponentModel;

namespace SerTerraQueijaria.Models
{
    public class Produto
    {

        public Guid ProdutoId { get; set; }

        [DisplayName("Produto")]
        public string NomeProduto { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Preço")]
        public decimal PrecoUnitario { get; set; }

        [DisplayName("Estoque")]
        public int QtdEstoque { get; set; }

        [DisplayName("Categoria")]

        public Guid TipoProdutoId { get; set; }

        public TiposProdutos TipoProd {  get; set; }
    }
}

