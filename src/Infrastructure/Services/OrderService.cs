using Application.Processors;
using Domain.Abstracts;
using Domain.Models;

namespace Infrastructure.Services;

public class OrderService
{
    public void ProcessOrder(Order order)
    {
        OrderProcessor processor = order.OrderType.ToLower() switch
        {
            "gift" => new GiftOrderProcessor(),
            "international" => new InternationalOrderProcessor(),
            _ => new StandardOrderProcessor(),
        };
        processor.ProcessOrder(order);
    }
}
