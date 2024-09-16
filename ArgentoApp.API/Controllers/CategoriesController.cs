using System;
using ArgentoApp.Business.Abstract;
using ArgentoApp.Shared.DTOs.CategoryDto;
using ArgentoApp.Shared.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ArgentoApp.API;
[ApiController]
[Route("api/[controller]/[action]")]
public class CategoriesController:CustomControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

 [HttpPost]
    public async Task<IActionResult> Create(CategoryCreateDto categoryCreateDto)
  {
    var response = await _categoryService.CreateAsync(categoryCreateDto);
    return CreateActionResult(response);
  }
}
