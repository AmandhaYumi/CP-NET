namespace Kova.Domain.Entities;

public class Produto
{
    public int IdProduto { get; set; }

    public string NomeProduto { get; set; }

    public string DescricaoProduto { get; set; }

    public decimal PrecoProduto { get; set; }

    public int CategoriaId { get; set; }

    public Categoria Categoria { get; set; }

    public List<Pedido> Pedidos { get; set; }
}