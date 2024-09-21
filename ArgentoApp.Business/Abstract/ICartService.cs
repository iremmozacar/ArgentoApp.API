using System;
using ArgentoApp.Entity.Concrete;
using ArgentoApp.Shared.DTOs.CartDTOs;
using ArgentoApp.Shared.DTOs.ResponseDTOs;

namespace ArgentoApp.Business.Abstract;

public interface ICartService
{
Task<ResponseDto<NoContent>> InitilaizeCartAsync(string userId);
Task<ResponseDto<CartDto>> GetCartByUserIdAsync (string userId);
Task<ResponseDto<NoContent>> AddToCartAsync (string userId, int productId, int quantity);

}
