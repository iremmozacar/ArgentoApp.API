using System;
using ArgentoApp.Business.Abstract;
using ArgentoApp.Shared.ComplexTypes;
using ArgentoApp.Shared.DTOs.OrderDTOs;
using ArgentoApp.Shared.DTOs.ResponseDTOs;

namespace ArgentoApp.Business.Concrete;

public class OrderService : IOrderService
{
    public Task<ResponseDto<NoContent>> CancelOrder(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<NoContent>> ChangeOrderStatusAsync(int id, OrderState orderState)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<NoContent>> CreateAsync(OrderDto orderDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<OrderDto>> GetOrderAsync(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<List<OrderDto>>> GetOrdersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<List<OrderDto>>> GetOrdersAsync(int productId)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<List<OrderDto>>> GetOrdersAsync(string userId)
    {
        throw new NotImplementedException();
    }
}
