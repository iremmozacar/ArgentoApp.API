using System;
using ArgentoApp.Shared.DTOs.ImageDTOs;
using ArgentoApp.Shared.DTOs.ResponseDTOs;
using Microsoft.AspNetCore.Http;

namespace ArgentoApp.Shared.Helpers.Abstract;

public interface IImageHelper
{
Task<ResponseDto<ImageDto>> UploadImageAsync (ImageCreateDto imageCreateDto);
ResponseDto<NoContent> DeleteImage(ImageDeleteDto ımageDeleteDto);
}
