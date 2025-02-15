using Domain.Abstracts;
using Domain.Models;

namespace Application.Processors;

public class InternationalOrderProcessor : OrderProcessor
{
    protected override bool RequiresCustomProcessing()
    {
        return true;
    }

    protected override void CustomProcessing(Order order)
    {
        Console.WriteLine("🛃 Processing customs clearance.");
    }

    protected override void ShipOrder(Order order)
    {
        Console.WriteLine($"✈️ Shipping international order {order.OrderId} via air freight.");
    }

    protected override void NotifyCustomer(Order order)
    {
        Console.WriteLine($"📧 Sending international shipping confirmation to {order.CustomerName}");
    }
}
