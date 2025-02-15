namespace Domain.Models;

public class Order(int orderId, string customerName, decimal amount, string orderType)
{
    public int OrderId { get; } = orderId;
    public string CustomerName { get; } = customerName;
    public decimal Amount { get; } = amount;
    public string OrderType { get; } = orderType;
}
