namespace Kova.Domain.Entities;

public class Cliente
{
    public int IdCliente { get; set; }

    public string NomeCliente { get; set; }

    public string EmailCliente { get; set; }

    public string TelefoneCliente { get; set; }
    
    public List<Pedido> Pedidos { get; set; }
} 