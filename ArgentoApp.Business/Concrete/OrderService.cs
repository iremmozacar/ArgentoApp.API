using System;
using ArgentoApp.Business.Abstract;
using ArgentoApp.Data.Abstact;
using ArgentoApp.Data.Abstract;
using ArgentoApp.Entity.Concrete;
using ArgentoApp.Shared.ComplexTypes;
using ArgentoApp.Shared.DTOs.OrderDTOs;
using ArgentoApp.Shared.DTOs.ResponseDTOs;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;

namespace ArgentoApp.Business.Concrete;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;
    private readonly IMapper _mapper;
    private readonly ICancelledOrderRepository _cancelledOrderRepository;
    private readonly IProductRepository _productRepository;
    public OrderService(IOrderRepository orderRepository, IMapper mapper, ICancelledOrderRepository cancelledOrderRepository)
    {
        _orderRepository = orderRepository;
        _mapper = mapper;
        _cancelledOrderRepository = cancelledOrderRepository;
    }

    public Task<ResponseDto<NoContent>> ChangeOrderStatusAsync(int id, OrderState orderState)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseDto<NoContent>> CreateAsync(OrderCreateDto orderCreateDto)
    {
        if (orderCreateDto == null)
        {
            return ResponseDto<NoContent>.Fail("Bir hata oluştu", 400);
        }
        var order = _mapper.Map<Order>(orderCreateDto);
        var orderResult = await _orderRepository.CreateAsync(order);
        if (orderResult == null)
        {
            return ResponseDto<NoContent>.Fail("Bir hata oluştu!", 500);
        }
        if (order.OrderItems == null || !order.OrderItems.Any())
        {
            return ResponseDto<NoContent>.Fail("Order items kayıp", 400);
        }
        return ResponseDto<NoContent>.Success(201);
    }

    public async Task<ResponseDto<OrderDto>> GetOrderAsync(int Id)
    {
        var order = await _orderRepository.GetAsync(x => x.Id == Id, source => source.Include(x => x.OrderItems).ThenInclude(y => y.Product));
        if (order == null)
        {
            return ResponseDto<OrderDto>.Fail("Böyle bir sipariş bulunamadı!", 404);
        }
        var orderDto = _mapper.Map<OrderDto>(order);
        return ResponseDto<OrderDto>.Success(orderDto, 200);
    }

    public async Task<ResponseDto<List<OrderDto>>> GetOrdersAsync()
    {
        var orders = await _orderRepository.GetAllAsync(x => !x.IsCancel, source => source.Include(x => x.OrderItems).ThenInclude(y => y.Product));
        if (orders.Count == 0)
        {
            return ResponseDto<List<OrderDto>>.Fail("Hiç sipariş bulunamadı!", 404);
        }
        var orderDtoList = _mapper.Map<List<OrderDto>>(orders);
        return ResponseDto<List<OrderDto>>.Success(orderDtoList, 200);

    }

    public async Task<ResponseDto<List<OrderDto>>> GetOrdersAsync(int productId)
    {
        var orders = await _orderRepository.GetAllAsync(
        x => x.OrderItems.Any(y => y.ProductId == productId && !x.IsCancel),
        source => source.Include(x => x.OrderItems).ThenInclude(y => y.Product));
        if (orders.Count == 0)
        {
            return ResponseDto<List<OrderDto>>.Fail("Hiç sipariş bulunamadı!", 404);
        }
        var orderDtoList = _mapper.Map<List<OrderDto>>(orders);
        return ResponseDto<List<OrderDto>>.Success(orderDtoList, 200);
    }

    public async Task<ResponseDto<List<OrderDto>>> GetOrdersAsync(string userId)
    {
        var orders = await _orderRepository.GetAllAsync(
        x => x.UserId == userId && !x.IsCancel,
        source => source.Include(x => x.OrderItems).ThenInclude(y => y.Product));

        if (orders.Count == 0)
        {
            return ResponseDto<List<OrderDto>>.Fail("Hiç sipariş bulunamadı!", 404);
        }
        var orderDtoList = _mapper.Map<List<OrderDto>>(orders);
        return ResponseDto<List<OrderDto>>.Success(orderDtoList, 200);

    }
    public async Task<ResponseDto<List<OrderDto>>> GetCancelledOrdersAsync()
    {
        var orders = await _orderRepository.GetAllAsync(x => x.IsCancel,
            source => source.Include(x => x.OrderItems).ThenInclude(y => y.Product));

        if (orders.Count == 0)
        {
            return ResponseDto<List<OrderDto>>.Fail("Hiç iptal edilmiş sipariş bulunamadı!", 404);
        }

        var orderDtoList = _mapper.Map<List<OrderDto>>(orders);
        return ResponseDto<List<OrderDto>>.Success(orderDtoList, 200);
    }

    public async Task<ResponseDto<NoContent>> CancelOrder(int id)
    {
        var order = await _orderRepository.GetAsync(x => x.Id == id,o => o.Include(o => o.OrderItems));
        if (order == null)
        {
            return ResponseDto<NoContent>.Fail("Böyle bir sipariş bulunamadı!", 404);
        }
        if (order.OrderItems == null || !order.OrderItems.Any())
        {
            return ResponseDto<NoContent>.Fail("Bu siparişin ürünleri bulunamadı!", 400);
        }

        var cancelledOrder = new CancelledOrder
        {
            Id = order.Id,
            UserId = order.UserId,
            FirstName = order.FirstName,
            LastName = order.LastName,
            Adress = order.Adress,
            City = order.City,
            PhoneNumber = order.PhoneNumber,
            Email = order.Email,
            OrderItems = order.OrderItems.Select(item => new CancelledOrderItem
            {
                ProductId = item.ProductId,
                Price = item.Price,
                Quantity = item.Quantity
            }).ToList()
        };
        order.IsCancel = true;
        await _cancelledOrderRepository.CreateAsync(cancelledOrder);
        await _orderRepository.DeleteAsync(order);
        return ResponseDto<NoContent>.Success(200);
    }

}
