using System;
using ArgentoApp.Business.Abstract;
using ArgentoApp.Data;
using ArgentoApp.Entity.Concrete;
using ArgentoApp.Shared.DTOs;
using ArgentoApp.Shared.DTOs.CategoryDto;
using ArgentoApp.Shared.DTOs.ResponseDTOs;
using ArgentoApp.Shared.Helpers;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace ArgentoApp.Business.Concrete;

public class CategoryService : ICategoryService
{


    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<ResponseDto<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto)
    {
           string url = CustomUrlHelper.GetUrl(categoryCreateDto.Name);
           Category category=_mapper.Map<Category>(categoryCreateDto);
         var createdCategory= await _categoryRepository.CreateAsync(category);
         if(createdCategory==null){
            return ResponseDto<CategoryDto>.Fail("Bir hata oluştu", StatusCodes.Status400BadRequest);
         }
         CategoryDto categoryDto=_mapper.Map<CategoryDto>(createdCategory);
         return ResponseDto<CategoryDto>.Success(categoryDto, StatusCodes.Status201Created);
         
    }

    public async Task<ResponseDto<NoContent>> DeleteAsync(int id)
    {
        var category = await _categoryRepository.GetbyIdAsync(x=>x.Id==id);
        if (category==null){
            return ResponseDto<NoContent>.Fail($"{id} id'li kategori bulunamadı!",404);
        }
        await _categoryRepository.DeleteAsync(category);
        return ResponseDto<NoContent>.Success(200);
    }

    public async Task<ResponseDto<CategoryDto>> GetActivesAsync(bool IsActive = true)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<int>> GetActivesCountAsync(bool IsActive = true)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<List<CategoryDto>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<CategoryDto>> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<int>> GetCountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto)
    {
        throw new NotImplementedException();
    }
}
