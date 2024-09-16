using System;
using ArgentoApp.Shared.DTOs.ResponseDTOs;
using Microsoft.AspNetCore.Mvc;

namespace ArgentoApp.Shared.Helpers;

public class CustomControllerBase: ControllerBase
{
public static IActionResult CreateActionResult<T>(ResponseDto<T> responseDto){
    return new ObjectResult(responseDto)
    {
        StatusCode=responseDto.StatusCode
    };
}
}
