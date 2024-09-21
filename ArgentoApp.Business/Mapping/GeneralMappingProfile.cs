using ArgentoApp.Entity.Concrete;
using ArgentoApp.Entity.Concrete.Abstact;
using ArgentoApp.Shared.DTOs;
using ArgentoApp.Shared.DTOs.CartDTOs;
using ArgentoApp.Shared.DTOs.CartItemDTOs;
using ArgentoApp.Shared.DTOs.Categories;
using ArgentoApp.Shared.DTOs.CategoryDto;
using ArgentoApp.Shared.DTOs.CategoryDTOs;
using ArgentoApp.Shared.DTOs.OrderDTOs;
using ArgentoApp.Shared.DTOs.OrderItemDTOs;
using ArgentoApp.Shared.DTOs.ProductDTOs;
using AutoMapper;

namespace ArgentoApp.Business.Mapping;

public class GeneralMappingProfile : Profile
{
    public GeneralMappingProfile()
    {
        //Category>>>
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CategoryCreateDto>().ReverseMap();
        CreateMap<Category, CategoryUpdateDto>().ReverseMap();
        //Product>>>
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Product, ProductUpdateDto>().ReverseMap();
        CreateMap<Product, ProductCreateDto>().ReverseMap();
        //Cart>>>
        CreateMap<Cart, CartDto>().ReverseMap();
        CreateMap<Cart, CartCreateDto>().ReverseMap();
        CreateMap<Cart, CartUpdateDto>().ReverseMap();
        //CartItem>>>
        CreateMap<CartItem, CartItemDto>().ReverseMap();
        CreateMap<CartItem, CartItemCreateDto>().ReverseMap();
        CreateMap<CartItem, CartItemUpdateDto>().ReverseMap();
        //Order>>>
        CreateMap<Order, OrderDto>().ReverseMap();
        CreateMap<Order, OrderCreateDto>().ReverseMap();
        CreateMap<Order, OrderUpdateDto>().ReverseMap();
        //OrderItem>>>
        CreateMap<OrderItem, OrderItemDto>().ReverseMap();
        CreateMap<OrderItem, OrderItemCreateDto>().ReverseMap();
        CreateMap<OrderItem, OrderItemUpdateDto>().ReverseMap();






      
    }


}
