using Kova.Domain.Enums;

namespace Kova.Domain.Entities;

public class Pedido
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public DateTime Data { get; private set; } = DateTime.Now;

    public decimal ValorTotal { get; private set; }

    public StatusPedido Status { get; private set; }

    public int ClienteId { get; private set; }
    
    public int PagamentoId { get; private set; }
    
    public List<Produto> Produtos { get; private set; }

    public Pedido(decimal valorTotal,  StatusPedido status, int clienteId, int pagamentoId)
    {
        if (valorTotal < 1)
            throw new Exception("Valor Total inválido");
        ValorTotal = valorTotal;
        Status = status;
        ClienteId = clienteId;
        PagamentoId = pagamentoId;
        
    }
}

