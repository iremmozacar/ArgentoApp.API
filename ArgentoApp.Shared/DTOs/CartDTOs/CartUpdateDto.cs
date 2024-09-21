using System;
using ArgentoApp.Shared.DTOs.CartItemDTOs;

namespace ArgentoApp.Shared.DTOs.CartDTOs;

public class CartUpdateDto
{
    public int CartId { get; set; }   
    public List<CartItemDto> Items { get; set; } = new List<CartItemDto>(); 

}
