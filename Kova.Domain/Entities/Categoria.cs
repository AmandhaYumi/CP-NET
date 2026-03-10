namespace Kova.Domain.Entities;

public class Categoria
{
    public int IdCategoria { get; set; }

    public string NomeCategoria { get; set; }

    public string DescricaoCategoria { get; set; }

    public List<Produto> Produtos { get; set; }
}