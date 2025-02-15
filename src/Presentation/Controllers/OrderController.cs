using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Infrastructure.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly OrderService _orderService;

    public OrderController()
    {
        _orderService = new OrderService();
    }

    [HttpPost("process")]
    public IActionResult ProcessOrder(int orderId, string customer, decimal amount, string type)
    {
        var order = new Order(orderId, customer, amount, type);
        _orderService.ProcessOrder(order);
        return Ok("Order processed successfully.");
    }
}
