using Kova.Domain.Enums;

namespace Kova.Domain.Entities;

public class Pedido
{
    public int IdPedido { get; set; }

    public DateTime DataPedido { get; set; }

    public decimal ValorTotalPedido { get; set; }

    public StatusPedido StatusPedido { get; set; }

    public int ClienteId { get; set; }

    public Cliente Cliente { get; set; }
}

