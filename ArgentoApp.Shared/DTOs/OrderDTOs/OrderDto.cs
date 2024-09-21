using System;
using ArgentoApp.Shared.DTOs.OrderItemDTOs;

namespace ArgentoApp.Shared.DTOs.OrderDTOs;

public class OrderDto
{
    public int OrderId { get; set; }
    public string UserId { get; set; }
    public List<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string Status { get; set; }
    public string ShippingAddress { get; set; }
}

