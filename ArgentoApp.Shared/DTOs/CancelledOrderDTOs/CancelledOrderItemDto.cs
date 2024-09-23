using System;

namespace ArgentoApp.Shared.DTOs.OrderDTOs;

public class CancelledOrderItemDto
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
