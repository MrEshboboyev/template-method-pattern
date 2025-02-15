using Domain.Abstracts;
using Domain.Models;

namespace Application.Processors;

public class StandardOrderProcessor : OrderProcessor
{
    protected override void NotifyCustomer(Order order)
    {
        Console.WriteLine($"📧 Sending standard order confirmation email to {order.CustomerName}");
    }
}
