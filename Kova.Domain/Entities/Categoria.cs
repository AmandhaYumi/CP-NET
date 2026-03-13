namespace Kova.Domain.Entities;

public class Categoria
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Nome { get; private set; }

    public string Descricao { get; private set; }

    public List<Produto> Produtos { get; private set; }

    public Categoria(string nome, string descricao)
    {
         if (nome == null || nome.Length < 2)
            throw new Exception("Nome inválido");
         Nome = nome;
         if (descricao == null || descricao.Length < 10)
            throw new Exception("Descrição inválida"); 
         Descricao = descricao;
    }
}