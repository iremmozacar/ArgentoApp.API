using System;

namespace ArgentoApp.Shared.DTOs.CategoryDto;

public class CategoryCreateDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; } = true;
    public string Description { get; set; }
}
