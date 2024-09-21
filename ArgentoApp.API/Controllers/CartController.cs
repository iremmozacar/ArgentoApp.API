using System.Diagnostics.Contracts;
using ArgentoApp.Business.Abstract;
using ArgentoApp.Shared.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArgentoApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : CustomControllerBase
    {
        private readonly ICartService _cartService;
        private readonly ICartItemService _cartItemService;

        public CartController(ICartService cartService, ICartItemService cartItemService)
        {
            _cartService = cartService;
            _cartItemService = cartItemService;
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateCart (string userId)
        {
            var response = await _cartService.InitilaizeCartAsync(userId);
            return CreateActionResult(response);
         }
         [HttpGet("{userId}")]
         public async Task<IActionResult> GetCartByUserIdAsync (string userId){
            var response = await _cartService.GetCartByUserIdAsync(userId);
            return CreateActionResult(response);
         }

         [HttpPost]
         public async Task<IActionResult> AddToCartAsync (string userId, int productId, int quantity){
            var response = await _cartService.AddToCartAsync(userId, productId, quantity);
            return CreateActionResult(response);
         }
        

    }
}
