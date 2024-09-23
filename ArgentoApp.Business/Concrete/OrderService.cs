using System;
using ArgentoApp.Business.Abstract;
using ArgentoApp.Data.Abstract;
using ArgentoApp.Entity.Concrete;
using ArgentoApp.Shared.ComplexTypes;
using ArgentoApp.Shared.DTOs.OrderDTOs;
using ArgentoApp.Shared.DTOs.ResponseDTOs;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;

namespace ArgentoApp.Business.Concrete;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository; 
    private readonly IMapper _mapper;

    public OrderService(IOrderRepository orderRepository, IMapper mapper)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
    }

    public Task<ResponseDto<NoContent>> ChangeOrderStatusAsync(int id, OrderState orderState)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseDto<NoContent>> CreateAsync(OrderCreateDto orderCreateDto)
    {
        if (orderCreateDto == null){
            return ResponseDto<NoContent>.Fail("Bir hata oluştu", 400);
        }
        var order = _mapper.Map<Order>(orderCreateDto);
        var orderResult = await _orderRepository.CreateAsync(order);
         if (orderResult == null){
            return ResponseDto<NoContent>.Fail("Bir hata oluştu!", 500);
         }
        if (order.OrderItems == null || !order.OrderItems.Any())
        {
            return ResponseDto<NoContent>.Fail("Order items kayıp", 400);
        }
        return ResponseDto<NoContent>.Success(201);
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

    public Task<ResponseDto<NoContent>> CancelOrder(int id)
    {
        throw new NotImplementedException();
    }
}
