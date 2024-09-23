using System;
using ArgentoApp.Shared.DTOs.OrderDTOs;
using ArgentoApp.Shared.DTOs.ResponseDTOs;

namespace ArgentoApp.Business.Abstract;

public interface ICancelledOrderService
{
    Task<ResponseDto<List<CancelledOrderDto>>> GetAllCancelledOrdersAsync();
    Task<ResponseDto<CancelledOrderDto>> GetCancelledOrderByIdAsync(int id);
    Task<ResponseDto<NoContent>> DeleteCancelledOrderAsync(int id);
}
