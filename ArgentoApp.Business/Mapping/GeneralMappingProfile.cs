using System;
using ArgentoApp.Entity.Concrete;
using ArgentoApp.Shared.DTOs;
using ArgentoApp.Shared.DTOs.CategoryDto;
using AutoMapper;

namespace ArgentoApp.Business.Mapping;

public class GeneralMappingProfile:Profile
{
public GeneralMappingProfile()
{
    CreateMap<Category,CategoryDto>().ReverseMap();
    CreateMap<Category,CategoryCreateDto>().ReverseMap();
    CreateMap<Category, CategoryUpdateDto>().ReverseMap();
    }
}
