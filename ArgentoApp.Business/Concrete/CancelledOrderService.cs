using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using ArgentoApp.Business.Abstract;
using ArgentoApp.Data.Abstract;
using ArgentoApp.Entity.Concrete;
using ArgentoApp.Shared.DTOs.OrderDTOs;
using ArgentoApp.Shared.DTOs.ResponseDTOs;
using AutoMapper;

namespace ArgentoApp.Business.Concrete;

public class CancelledOrderService : ICancelledOrderService
{
    private readonly ICancelledOrderRepository _cancelledOrderRepository;
    private readonly IMapper _mapper;

    public CancelledOrderService(ICancelledOrderRepository cancelledOrderRepository, IMapper mapper)
    {
        _cancelledOrderRepository = cancelledOrderRepository;
        _mapper = mapper;
    }

    public async Task<ResponseDto<NoContent>> DeleteCancelledOrderAsync(int id)
    {
        var cancelledOrder = await _cancelledOrderRepository.GetAsync(x=>x.Id==id);
        if (cancelledOrder == null){
            return ResponseDto<NoContent>.Fail("İlgili sipariş bulunamadı!", 404);
        }
        await _cancelledOrderRepository.DeleteAsync(cancelledOrder);
        return ResponseDto<NoContent>.Success(200);
    }

    public async Task<ResponseDto<List<CancelledOrderDto>>> GetAllCancelledOrdersAsync()
    {
        var cancelledOrders= await _cancelledOrderRepository.GetAllAsync();
        if (cancelledOrders.Count == 0){
            return ResponseDto<List<CancelledOrderDto>>.Fail("İlgili sipariş bulunamadı!", 404);
        }
        var cancelledOrderDto=  _mapper.Map<List<CancelledOrderDto>>(cancelledOrders);
        return ResponseDto<List<CancelledOrderDto>>.Success(cancelledOrderDto,200);
    }

    public async Task<ResponseDto<CancelledOrderDto>> GetCancelledOrderByIdAsync(int id)
    {
        CancelledOrder cancelledOrder = await _cancelledOrderRepository.GetAsync(x => x.Id == id);
        if (cancelledOrder == null)
        {
            return ResponseDto<CancelledOrderDto>.Fail("Böyle bir sipariş bulunamadı!", 404);
            
        }
        CancelledOrderDto cancelledOrderDto = _mapper.Map<CancelledOrderDto>(cancelledOrder);
        return ResponseDto<CancelledOrderDto>.Success(cancelledOrderDto,200);
    }
}
