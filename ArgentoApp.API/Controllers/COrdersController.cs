using ArgentoApp.Business.Abstract;
using ArgentoApp.Shared.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArgentoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class COrdersController : CustomControllerBase
    {
        private readonly ICancelledOrderService _cancelledOrderService;

        public COrdersController(ICancelledOrderService cancelledOrderService)
        {
            _cancelledOrderService = cancelledOrderService;
        }


        [HttpGet]
        public async Task<IActionResult> GetCancelledOrders()
        {
            var response = await _cancelledOrderService.GetAllCancelledOrdersAsync();
            return CreateActionResult(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCancelledOrders(int id)
        {
            var response = await _cancelledOrderService.DeleteCancelledOrderAsync(id);
            return CreateActionResult(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCancelledOrder(int id)
        {
            var response = await _cancelledOrderService.DeleteCancelledOrderAsync(id);
            return CreateActionResult(response);
        }
    }


    }

