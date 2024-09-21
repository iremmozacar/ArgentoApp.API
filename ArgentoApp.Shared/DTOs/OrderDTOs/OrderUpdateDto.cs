using System;
using ArgentoApp.Shared.DTOs.OrderItemDTOs;

namespace ArgentoApp.Shared.DTOs.OrderDTOs;

public class OrderUpdateDto
{
    public int OrderId { get; set; }
    public List<OrderItemUpdateDto> OrderItems { get; set; } = new List<OrderItemUpdateDto>();
    public string Status { get; set; }
}
