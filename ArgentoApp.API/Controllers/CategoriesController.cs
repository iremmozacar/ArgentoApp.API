using System;
using System.Reflection.Metadata.Ecma335;
using ArgentoApp.Business.Abstract;
using ArgentoApp.Shared.DTOs;
using ArgentoApp.Shared.DTOs.CategoryDto;
using ArgentoApp.Shared.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ArgentoApp.API;
[ApiController]
[Route("api/[controller]/[action]")]
public class CategoriesController : CustomControllerBase
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

  [HttpPut]
  public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
  {
    var response = await _categoryService.UpdateAsync(categoryUpdateDto);
    return CreateActionResult(response);
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(int id)
  {
    var response = await _categoryService.DeleteAsync(id);
    return CreateActionResult(response);
  }

  [HttpGet("{isActive}")]
  public async Task<IActionResult> GetActives()
  {
    var response = await _categoryService.GetActivesAsync();
    return CreateActionResult(response);
  }

  [HttpGet]
  public async Task<IActionResult> GetCount()
  {
    var response = await _categoryService.GetCountAsync();
    return CreateActionResult(response);
  }

  [HttpGet]
  public async Task<IActionResult> GetActivesCount()
  {
    var response = await _categoryService.GetActivesCountAsync();
    return CreateActionResult(response);
  }

  [HttpGet]
  public async Task<IActionResult> GetAll()
  {
    var response = await _categoryService.GetAllAsync();
    return CreateActionResult(response);
  }
 

}
