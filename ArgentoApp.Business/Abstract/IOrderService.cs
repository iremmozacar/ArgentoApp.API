using System;
using ArgentoApp.Shared.ComplexTypes;
using ArgentoApp.Shared.DTOs.OrderDTOs;
using ArgentoApp.Shared.DTOs.ResponseDTOs;

namespace ArgentoApp.Business.Abstract;

public interface IOrderService
{
Task<ResponseDto<NoContent>> CreateAsync (OrderDto orderDto);
Task<ResponseDto<List<OrderDto>>> GetOrdersAsync();

Task<ResponseDto<List<OrderDto>>> GetOrdersAsync(int productId);
    Task<ResponseDto<List<OrderDto>>> GetOrdersAsync(string userId);
    Task<ResponseDto<OrderDto>> GetOrderAsync (int Id);
    Task<ResponseDto<NoContent>> ChangeOrderStatusAsync (int id, OrderState orderState);
    Task<ResponseDto<NoContent>> CancelOrder (int id);

}
