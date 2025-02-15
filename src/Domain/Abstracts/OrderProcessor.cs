using Domain.Models;

namespace Domain.Abstracts;

public abstract class OrderProcessor
{
    public void ProcessOrder(Order order)
    {
        ValidateOrder(order);
        ProcessPayment(order);
        if (RequiresCustomProcessing())
        {
            CustomProcessing(order);
        }
        ShipOrder(order);
        NotifyCustomer(order);
    }

    protected virtual void ValidateOrder(Order order)
    {
        Console.WriteLine($"✅ Validating order {order.OrderId} for {order.CustomerName}");
    }

    protected virtual void ProcessPayment(Order order)
    {
        Console.WriteLine($"💳 Processing payment of ${order.Amount} for {order.CustomerName}");
    }

    protected virtual void ShipOrder(Order order)
    {
        Console.WriteLine($"🚚 Shipping order {order.OrderId} to customer.");
    }

    protected virtual void NotifyCustomer(Order order)
    {
        Console.WriteLine($"📧 Sending order confirmation to {order.CustomerName}");
    }

    protected virtual bool RequiresCustomProcessing()
    {
        return false;
    }

    protected virtual void CustomProcessing(Order order)
    {
    }
}
