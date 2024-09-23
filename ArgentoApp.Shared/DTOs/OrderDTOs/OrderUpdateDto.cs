using System;
using ArgentoApp.Shared.DTOs.OrderDTOs;

namespace ArgentoApp.Shared.DTOs.OrderDTOs;

public class OrderUpdateDto
{
    public int OrderId { get; set; }
    public List<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>();
    public string Status { get; set; }
}
