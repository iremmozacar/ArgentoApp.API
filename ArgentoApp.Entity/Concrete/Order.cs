using System;
using ArgentoApp.Shared.ComplexTypes;

namespace ArgentoApp.Entity.Concrete;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public string UserId { get; set; }
    public string FirstName { get; set; }   
    public string LastName { get; set; }    
    public string Adress { get; set; }  
    public string City { get; set; }    
    public int PhoneNumber { get; set; }    
    public string Email { get; set; }   
    public PaymentType PaymentType { get; set; }
    public OrderState OrderState { get; set; } 

}
