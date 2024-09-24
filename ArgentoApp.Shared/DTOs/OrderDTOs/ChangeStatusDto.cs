using System;
using ArgentoApp.Shared.ComplexTypes;

namespace ArgentoApp.Shared.DTOs.OrderDTOs;

public class ChangeStatusDto
{
public int Id { get; set; }
public OrderState OrderState { get; set; }  
}
