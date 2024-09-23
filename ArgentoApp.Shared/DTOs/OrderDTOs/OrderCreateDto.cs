using System;
using ArgentoApp.Shared.DTOs.OrderItemDTOs;

namespace ArgentoApp.Shared.DTOs.OrderDTOs;

public class OrderCreateDto
{
    public string UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; } 
    public string Email { get; set; }
    public string PaymentType { get; set; }
    public List<OrderItemDto> OrderItems { get; set; }
   
}
