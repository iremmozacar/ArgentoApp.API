using System;

namespace ArgentoApp.Shared.DTOs.OrderItemDTOs;

public class OrderItemCreateDto
{
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

