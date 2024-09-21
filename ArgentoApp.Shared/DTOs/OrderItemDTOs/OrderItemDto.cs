using System;

namespace ArgentoApp.Shared.DTOs.OrderItemDTOs;

public class OrderItemDto
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}
