namespace Kova.Domain.Entities;

public class Produto
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Nome { get; private set; }

    public string Descricao { get; private set; }

    public decimal Preco { get; private set; }

    public int CategoriaId { get; private set; }

    public List<Pedido> Pedidos { get; private set; }

    public Produto(string nome, string descricao, decimal preco, int categoriaId)
    {
        if (nome == null || nome.Length < 2)
            throw new Exception("Nome inválido");
        Nome = nome;
        if (descricao == null || descricao.Length < 10)
            throw new Exception("Descrição inválida");
        Descricao = descricao;
        Preco = preco;
        CategoriaId = categoriaId;
    }
    }
