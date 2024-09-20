using System;
using ArgentoApp.Entity.Concrete;
using ArgentoApp.Entity.Concrete.Abstact;
using ArgentoApp.Shared.DTOs;
using ArgentoApp.Shared.DTOs.Categories;
using ArgentoApp.Shared.DTOs.CategoryDto;
using ArgentoApp.Shared.DTOs.CategoryDTOs;
using ArgentoApp.Shared.DTOs.ProductDTOs;
using AutoMapper;

namespace ArgentoApp.Business.Mapping;

public class GeneralMappingProfile:Profile
{
public GeneralMappingProfile()
{
    CreateMap<Category,CategoryDto>().ReverseMap();
    CreateMap<Category,CategoryCreateDto>().ReverseMap();
    CreateMap<Category, CategoryUpdateDto>().ReverseMap();

    CreateMap<Product,ProductDto>().ReverseMap();
    CreateMap<Product,ProductUpdateDto>().ReverseMap();
    CreateMap<Product,ProductCreateDto>().ReverseMap();
    
    }


}
