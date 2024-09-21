using System;
using ArgentoApp.Shared.DTOs.OrderItemDTOs;

namespace ArgentoApp.Shared.DTOs.OrderDTOs;

public class OrderCreateDto
{
    public string UserId { get; set; }
    public List<OrderItemCreateDto> OrderItems { get; set; } = new List<OrderItemCreateDto>();
    public string ShippingAddress { get; set; }
}
