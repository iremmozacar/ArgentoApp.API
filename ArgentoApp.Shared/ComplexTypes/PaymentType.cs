using System.ComponentModel.DataAnnotations;

namespace ArgentoApp.Shared.ComplexTypes;

public enum PaymentType
{
    [Display(Name ="Kredi Kartı")]
 CreditCard=0,
 [Display(Name = "EFT/Havale")]
 EFT=1
}
