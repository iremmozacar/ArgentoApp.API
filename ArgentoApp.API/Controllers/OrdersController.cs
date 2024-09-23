using ArgentoApp.Business.Abstract;
using ArgentoApp.Shared.DTOs.OrderDTOs;
using ArgentoApp.Shared.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArgentoApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrdersController : CustomControllerBase

    {
        private readonly IOrderService _orderservice;

        public OrdersController(IOrderService orderservice)
        {
            _orderservice = orderservice;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(OrderCreateDto orderCreateDto)
        {
            var response = await _orderservice.CreateAsync(orderCreateDto);
            return CreateActionResult(response);
        }
    }
}
