using Kova.Domain.Enums;

namespace Kova.Domain.Entities;

public class Pagamento
{
    public int IdPagamento { get; set; }

    public string StatusPagamento { get; set; } = string.Empty;

    public TipoPagamento TipoPagamento { get; set; }

    public int PedidoId { get; set; }

    public Pedido Pedido { get; set; }
}