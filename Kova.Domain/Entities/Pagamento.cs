using Kova.Domain.Enums;

namespace Kova.Domain.Entities;

public class Pagamento
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public StatusPagamento Status { get; private set; }

    public TipoPagamento Tipo { get; private set; }

    public Pagamento(StatusPagamento status, TipoPagamento tipo)
    {
        Status = status;
        Tipo = tipo;
    }
}
