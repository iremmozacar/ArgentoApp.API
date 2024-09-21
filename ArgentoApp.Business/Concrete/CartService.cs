using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using ArgentoApp.Business.Abstract;
using ArgentoApp.Data.Abstract;
using ArgentoApp.Entity.Concrete;
using ArgentoApp.Shared.DTOs.CartDTOs;
using ArgentoApp.Shared.DTOs.CartItemDTOs;
using ArgentoApp.Shared.DTOs.ResponseDTOs;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ArgentoApp.Business.Concrete;

public class CartService:ICartService
{
private readonly ICartRepository _cartRepository;
    private readonly IMapper _mapper;

    public CartService(ICartRepository cartRepository,IMapper mapper)
    {
        _cartRepository = cartRepository;
        _mapper = mapper;
    }
    public async  Task<ResponseDto<NoContent>> AddToCartAsync(string userId, int productId, int quantity)
    {
        var cart = await _cartRepository.GetAsync(x => x.UserId == userId, source=>source.Include(x=>x.CartItems));
        if (cart == null)
        {
            return ResponseDto<NoContent>.Fail("Kullanıcıya ait bir sepet bulunamadı!", 404);
        }
        var index = cart.CartItems.FindIndex(x => x.ProductId == productId);
        if (index < 0)
        {

            var CartItem = new CartItem
            {
                ProductId = productId,
                Quentity = quantity,
                CartId = cart.Id
            };

            cart.CartItems.Add(CartItem);
        }
        else
        {
            cart.CartItems[index].Quentity = quantity;
        }
        await _cartRepository.UpdateAsync(cart);
        return ResponseDto<NoContent>.Success(200);
    }
    public async Task<ResponseDto<CartDto>> GetCartByUserIdAsync(string userId)
    {
        var cart = await _cartRepository.GetAsync(x=>x.UserId==userId);
        if (cart ==null){
            return ResponseDto<CartDto>.Fail("Kullanıcıya ait bi sepet bulunamadı!", 404);
        }
        var cartDto = _mapper.Map<CartDto>(cart);
        return ResponseDto<CartDto>.Success(cartDto,200);
    }
    public async Task<ResponseDto<NoContent>> InitilaizeCartAsync(string userId)
    {
        {
            var cart = new Cart
            {
                UserId = userId,
                CreatedDate = DateTime.Now,
                CartItems = new List<CartItem>()
            };

            await _cartRepository.CreateAsync(cart);
            return ResponseDto<NoContent>.Success(201);
        }
    }
}
