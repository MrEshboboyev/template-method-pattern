using Domain.Abstracts;
using Domain.Models;

namespace Application.Processors;

public class GiftOrderProcessor : OrderProcessor
{
    protected override bool RequiresCustomProcessing()
    {
        return true;
    }

    protected override void CustomProcessing(Order order)
    {
        Console.WriteLine("🎁 Wrapping order as a gift.");
    }

    protected override void NotifyCustomer(Order order)
    {
        Console.WriteLine($"📧 Sending gift order confirmation email to {order.CustomerName}");
    }
}
