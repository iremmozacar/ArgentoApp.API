using System;
using ArgentoApp.Shared.DTOs.OrderDTOs;
using ArgentoApp.Shared.DTOs.ProductDTOs;

namespace ArgentoApp.Shared.DTOs.OrderDTOs;

public class OrderItemDto
{
 
    public int ProductId { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public ProductDto Product { get; set; }
}
