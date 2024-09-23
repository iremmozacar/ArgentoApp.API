using System;

namespace ArgentoApp.Entity.Concrete;

public class CancelledOrder
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Adress { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public List<CancelledOrderItem> OrderItems { get; set; } 
}
