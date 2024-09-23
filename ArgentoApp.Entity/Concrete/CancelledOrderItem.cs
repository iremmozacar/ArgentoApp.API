using System;
using ArgentoApp.Entity.Concrete.Abstact;

namespace ArgentoApp.Entity.Concrete;

public class CancelledOrderItem
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int CancelledOrderId { get; set; } 
    public CancelledOrder CancelledOrder { get; set; }
}
